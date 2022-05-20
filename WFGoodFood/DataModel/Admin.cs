using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGoodFood.DataModel
{
    public class Admin
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Login { get; set; }
        [StringLength(255)]
        public string Password { get; set; }
      
    }
}
