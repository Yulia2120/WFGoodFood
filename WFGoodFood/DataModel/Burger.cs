using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGoodFood.DataModel
{
    public class Burger
    {
        //public Burger(string productName, decimal price, string imageUrl)
        //{
        //    ProductName = productName;
        //    Price = price;
        //    ImageUrl = imageUrl;
        //}

        public int Id { get; set; }
        [StringLength(255)]
        public string ProductName { get; set; }
        [StringLength(255)]
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [StringLength(2555)]
        public string Description { get; set; }
       
        public Category Category { get; set; }

    }
}
