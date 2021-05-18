using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubApp.Models
{
    public class Product : Entity
    {
        public string Product_Name { get; set; }
        public string Product_Price { get; set; }
        public string Product_Quantity { get; set; }
        public string ImagePath { get; set; }
        public string Details { get; set; }

    }
}
