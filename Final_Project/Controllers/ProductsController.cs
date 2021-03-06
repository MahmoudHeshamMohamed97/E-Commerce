using Final_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{

    [Authorize]
    public class ProductsController : Controller
    {
    
        public class Product
        {
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public int Price { get; set; }
            public int Weight { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
            public DateTime Create_Date { get; set; }
            public Nullable<int> Discount { get; set; }
            [Required]
            public int Stock { get; set; }
            public string Material { get; set; }
            public string brand { get; set; }
            [ForeignKey("Category")]
            public Nullable<int> Category_Id { get; set; }
            //navigation properties
            public Category Category { get; set; }
            public virtual Order Order { get; set; }

            // 08/04/2021
            public string ChangeDateFormat(DateTime date)
            {
                string newDate = date.ToShortDateString();
                string day = newDate.Substring(0, 2);
                string month = newDate.Substring(3, 2);
                string year = newDate.Substring(6);
                return year+"-"+month+"-"+day;
            }
        }

        HttpClient client = new HttpClient();
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            //IEnumerable<Order> OrderList;
            string ProductList;
            HttpResponseMessage response = client.GetAsync("https://localhost:44329/api/product").Result;
            ProductList = response.Content.ReadAsStringAsync().Result;
            List<Product> allProducts =  JsonConvert.DeserializeObject<IList<Product>>(ProductList).ToList();
            return View(allProducts);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult EachProduct(int id)
        {
            string Product;
            HttpResponseMessage response = client.GetAsync("https://localhost:44329/api/product/" + id).Result;
            Product = response.Content.ReadAsStringAsync().Result;
            ViewBag.currentProduct = JsonConvert.DeserializeObject<Product>(Product);
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            HttpResponseMessage response = client.GetAsync("https://localhost:44329/api/Category").Result;
            List<Category> allCategories = JsonConvert.DeserializeObject<IList<Category>>(response.Content.ReadAsStringAsync().Result).ToList();
            ViewBag.Categories = allCategories;
            //HttpResponseMessage res = client.GetAsync("https://localhost:44329/api/ProductColor").Result;
            //List<ProductColor> Colors= JsonConvert.DeserializeObject<IList<ProductColor>>(res.Content.ReadAsStringAsync().Result).ToList();
            //ViewBag.Colors = Colors;
            return View(new Product() );
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Product product)
        {
            //string fileName = product.Name + product.Price + product.Weight;
            //System.IO.File.Create("wwwroot/Images/" + fileName + ".png").Dispose();

            //using (WebClient client = new WebClient())
            //{
            //    client.DownloadFile(new Uri(product.Image), "wwwroot/Images/" + fileName + ".png");
            //}

            

            //product.Create_Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                string ProudctInString = JsonConvert.SerializeObject(product);
                StringContent requestBody = new StringContent(ProudctInString, Encoding.UTF8, "application/json");
                HttpResponseMessage respMessage = client.PostAsync("https://localhost:44329/api/product", requestBody).Result;
                
                TempData["Added"] = "Added";
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            HttpResponseMessage res = client.GetAsync("https://localhost:44329/api/Category").Result;
            List<Category> allCategories = JsonConvert.DeserializeObject<IList<Category>>(res.Content.ReadAsStringAsync().Result).ToList();
            ViewBag.Categories = allCategories;
            HttpResponseMessage Response = client.GetAsync("https://localhost:44329/api/product/" + id.ToString()).Result;
            string ProductEdit = Response.Content.ReadAsStringAsync().Result;
            Product myProductToEdit = JsonConvert.DeserializeObject<Product>(ProductEdit);
            return View(myProductToEdit);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(Product product)
        {
            //string fileName = product.Name + product.Price + product.Weight;
            //System.IO.File.Create("wwwroot/Images/" + fileName + ".png").Dispose();

            //using (WebClient client = new WebClient())
            //{
            //    client.DownloadFile(new Uri(product.Image), "wwwroot/Images/" + fileName + ".png");
            //}
            string SerializedObject = JsonConvert.SerializeObject(product);
            StringContent requestBody = new StringContent(SerializedObject, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = client.PutAsync("https://localhost:44329/api/product/" + product.ID , requestBody).Result;
            //HttpResponseMessage response = client.PutAsJsonAsync("Product/" + product.ID, product).Result;
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            HttpResponseMessage response = client.DeleteAsync("https://localhost:44329/api/product/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                StringContent requestBody = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                HttpResponseMessage respMessage = client.PostAsync("https://localhost:44329/api/Category", requestBody).Result;
                TempData["Added"] = "Added";
            }
            return RedirectToAction("Create");
        }




    }
    
}
