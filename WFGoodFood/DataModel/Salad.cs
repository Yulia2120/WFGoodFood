

using System.ComponentModel.DataAnnotations;

namespace WFGoodFood.DataModel
{
    public class Salad
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
