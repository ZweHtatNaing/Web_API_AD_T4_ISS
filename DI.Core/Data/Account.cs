using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class Account:BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public Guid UserRolesId { get; set; }
       
        public virtual UserRoles UserRoles { get; set; }
    }
}
