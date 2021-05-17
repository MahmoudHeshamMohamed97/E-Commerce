using Final_Project.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static Project.Controllers.ProductsController;

namespace Final_Project.Controllers
{
    public class CartController : Controller
    {
        HttpClient client = new HttpClient();
        // GET: CartController
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            List<string> colors = new List<string>();
            List<string> clothessizes = new List<string>();
            List<string> shoes = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Black");
            colors.Add("White");
            clothessizes.Add("M");
            clothessizes.Add("L");
            clothessizes.Add("XL");
            clothessizes.Add("XXL");
            clothessizes.Add("XXXL");
            shoes.Add("40");
            shoes.Add("41");
            shoes.Add("42");
            shoes.Add("43");
            shoes.Add("45");
            ViewBag.Colors = colors;
            ViewBag.clothesSizes = clothessizes;
            ViewBag.shoesSizes = shoes;
            ViewBag.cart = cart;
            if (cart == null)
                ViewBag.total = 0;
            else
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }
        
        private int IsExist(string id)
        {
            List<Item> items = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Product.ID.ToString().Equals(id))
                {
                    return i;
                }
                  
            }
            return -1;
        }

        // GET: CartController/Details/5
        public IActionResult Buy(string id)
        {
            
            HttpResponseMessage res = client.GetAsync("https://localhost:44329/api/product/" + id).Result;
            Product Product = JsonConvert.DeserializeObject<Product>(res.Content.ReadAsStringAsync().Result);

            if(SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item() {ID=Product.ID,ProductId=Product.ID,Product=Product, Quantity = 1, Color="Red", Size=(Product.Category.Name == "Shoes")?"40":"M" });
                
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = IsExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item() { ID = Product.ID, ProductId = Product.ID, Product = Product, Quantity = 1, Color = "Red", Size = (Product.Category.Name == "Shoes") ? "40" : "M" });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index");
        }

        // GET: CartController/Create
        public IActionResult Remove(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = IsExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeQuantity(int ItemId, int quantity,string color,string size)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Item item=cart.Where(i=>i.ID==ItemId).First();
            item.Quantity = quantity;
            item.Color = color;
            item.Size = size;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
          
            return RedirectToAction("Index");
        }
        public IActionResult updateColor(int ItemId, string color)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Item item = cart.Where(i => i.ID == ItemId).First();
            item.Color = color;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        public IActionResult updateSize(int ItemId, string size)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Item item = cart.Where(i => i.ID == ItemId).First();
            item.Size = size;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

    }
}
