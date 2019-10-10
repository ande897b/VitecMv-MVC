using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitecMv_MVC.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
    }
}
