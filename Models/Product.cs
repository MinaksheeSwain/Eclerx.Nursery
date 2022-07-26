using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eclerx.Nursery.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string TreeName { get; set; }    
        public int SKU_No { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}