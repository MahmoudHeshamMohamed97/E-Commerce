using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Project.Controllers.ProductsController;

namespace Final_Project.Models
{
    public class Store
    {
        public int ID { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int quantity { get; set; }
        [ForeignKey("Product")]
        public Nullable<int> ProductId { get; set; }
        //Navigation Property

        public virtual Product Product { get; set; }
    }
}
