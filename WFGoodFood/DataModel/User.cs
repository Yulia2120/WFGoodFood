using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGoodFood.DataModel
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string UserName { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Password { get; set; }
    }
}
