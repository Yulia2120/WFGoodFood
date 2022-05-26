using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGoodFood.DataModel
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string ProductName { get; set; }
        [StringLength(255)]
        public string ImageUrl { get; set; }
        [StringLength(2555)]
        public string Description { get; set; }

    }
}
