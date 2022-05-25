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
        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Please enter a valid Name.")]
        public string UserName { get; set; }
        [StringLength(255)]
        [Required, EmailAddress]
        public string Email { get; set; }
        [StringLength(255)]
        [Required]
        public string Password { get; set; } 
        [StringLength (255)]
        [Required]
        public string Phone { get; set; }


    }
}
