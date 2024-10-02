using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThoiTrang.Models;

namespace ThoiTrang.ViewModel
{
    public class ShopVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
    public class category
    {
        public List<category> Categories{ get; set; }
        public List<Product> products { get; set; } 
    }
    public class CartItemViewModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}