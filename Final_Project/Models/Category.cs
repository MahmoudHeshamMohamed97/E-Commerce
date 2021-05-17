using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Project.Controllers.ProductsController;

namespace Final_Project.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //Navigation properties
        public List<Product> Products { set; get; }
    }
}
