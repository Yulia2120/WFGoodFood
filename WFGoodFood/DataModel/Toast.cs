using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGoodFood.DataModel
{
    public class Toast
    {
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
