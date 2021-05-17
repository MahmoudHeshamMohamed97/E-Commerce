using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Project.Controllers.ProductsController;

namespace Final_Project.Models
{
    public class ProductColor
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
       public List<Product> Products { get; set; }
    }
}
