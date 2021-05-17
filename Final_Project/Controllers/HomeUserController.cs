using Final_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using static Project.Controllers.ProductsController;

namespace Final_Project.Controllers
{
    public class HomeUserController : Controller
    {
        HttpClient client = new HttpClient();
        public IActionResult Index(int id,string brand,string material,int minprice,int maxprice)
        {
            if (brand == "null")
                brand = null;
            if (material == "null")
                material = null;
            // var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.allMaterials = new List<string>() { "Cotton", "Silk", "Leather", "Fiber" };
            ViewBag.allBrands = new List<string>() { "PullAndBeer", "Tomato", "Lust", "Lacoste" };
            HttpResponseMessage response = client.GetAsync("https://localhost:44329/api/Category").Result;
            List<Category> allCategories = JsonConvert.DeserializeObject<IList<Category>>(response.Content.ReadAsStringAsync().Result).ToList();
            ViewBag.Categories = allCategories;
            ViewBag.brand = brand;
            ViewBag.material = material;
            HttpResponseMessage res = client.GetAsync("https://localhost:44329/api/product").Result;
            List<Product> allProducts = JsonConvert.DeserializeObject<IList<Product>>(res.Content.ReadAsStringAsync().Result).ToList();
            if (id == 0)
            {
                if (brand != null && material == null)
                {
                    if(maxprice==0)
                        return View(allProducts.Where(p => p.brand.ToLower() == brand.ToLower()).ToList());
                    else
                        return View(allProducts.Where(p => p.brand.ToLower() == brand.ToLower()&&p.Price>minprice&&p.Price<=maxprice).ToList());

                }
                else if (brand == null && material != null)
                {
                    if (maxprice == 0)
                        return View(allProducts.Where(p => p.Material.ToLower() == material.ToLower()).ToList());
                    else
                        return View(allProducts.Where(p => p.Material.ToLower() == material.ToLower() && p.Price > minprice && p.Price <= maxprice).ToList());
                }
                else if (brand != null && material != null)
                {
                    if (maxprice == 0)
                        return View(allProducts.Where(p => p.brand.ToLower() == brand.ToLower() && p.Material.ToLower() == material.ToLower()).ToList());
                    else
                        return View(allProducts.Where(p => p.brand.ToLower() == brand.ToLower() && p.Material.ToLower() == material.ToLower() && p.Price > minprice && p.Price <= maxprice).ToList());
                }
                else
                {
                    if (maxprice == 0)
                        return View(allProducts);
                    else
                        return View(allProducts.Where(p=> p.Price > minprice && p.Price <= maxprice).ToList());
                }
                   
            }
            else
            {
                if (brand != null && material == null)
                {
                    if (maxprice == 0)
                        return View(allProducts.Where(p => p.Category_Id == id && p.brand.ToLower() == brand.ToLower()).ToList());
                    else
                        return View(allProducts.Where(p => p.Category_Id == id && p.brand.ToLower() == brand.ToLower() && p.Price > minprice && p.Price <= maxprice).ToList());
                }    
                else if (brand != null && material != null)
                {
                    if (maxprice == 0)
                        return View(allProducts.Where(p => p.Category_Id == id && p.brand.ToLower() == brand.ToLower() && p.Material.ToLower() == material.ToLower()).ToList());
                    else
                        return View(allProducts.Where(p => p.Category_Id == id && p.brand.ToLower() == brand.ToLower() && p.Material.ToLower() == material.ToLower() && p.Price > minprice && p.Price <= maxprice).ToList());
                }
                else if (brand == null && material != null)
                {
                    if (maxprice == 0)
                        return View(allProducts.Where(p => p.Category_Id == id && p.Material.ToLower() == material.ToLower()).ToList());
                    else
                        return View(allProducts.Where(p => p.Category_Id == id && p.Material.ToLower() == material.ToLower() && p.Price > minprice && p.Price <= maxprice).ToList());
                }
                else
                {
                    if (maxprice == 0)
                        return View(allProducts.Where(p => p.Category_Id == id).ToList());
                    else
                        return View(allProducts.Where(p => p.Category_Id == id && p.Price > minprice && p.Price <= maxprice).ToList());
                }
                    
            }
               

        }
        //public IActionResult Filter(int id)
        //{
        //    HttpResponseMessage res = client.GetAsync("https://localhost:44329/api/product").Result;
        //    List<Product> allProducts = JsonConvert.DeserializeObject<IList<Product>>(res.Content.ReadAsStringAsync().Result).ToList();
        //    return RedirectToAction("Index");
        //}

        public IActionResult Details(int id)
        {
            HttpResponseMessage res = client.GetAsync("https://localhost:44329/api/product/" + id).Result;
            Product Product = JsonConvert.DeserializeObject<Product>(res.Content.ReadAsStringAsync().Result);
            return View(Product);
        }
      
        public IActionResult Search(string search)
        {
            ViewBag.allMaterials = new List<string>() { "Cotton", "Silk", "Leather", "Fiber" };
            ViewBag.allBrands = new List<string>() { "PullAndBeer", "Tomato", "Lust", "Lacoste" };
            HttpResponseMessage res = client.GetAsync("https://localhost:44329/api/product").Result;
            List<Product> allProducts = JsonConvert.DeserializeObject<IList<Product>>(res.Content.ReadAsStringAsync().Result).ToList();
            HttpResponseMessage response = client.GetAsync("https://localhost:44329/api/Category").Result;
            List<Category> allCategories = JsonConvert.DeserializeObject<IList<Category>>(response.Content.ReadAsStringAsync().Result).ToList();
            ViewBag.Categories = allCategories;
            return View("Index", allProducts.Where(p => p.Description.ToLower().Contains(search.ToLower())||p.Name.ToLower().Contains(search.ToLower())).ToList());
        }
       





    }
}
