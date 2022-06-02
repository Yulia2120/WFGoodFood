using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGoodFood.DataModel
{
    public class Order
    {
        public int OrderId { get; set; }
        [StringLength(255)]
        public string CustomerId { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Burger> Burgers { get; set; }
        public Order()
        {
            Burgers = new List<Burger>();
        }

    }
}
