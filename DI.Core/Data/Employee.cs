using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class Employee:BaseEntity
    {
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string EmplpyeeEmail { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public bool IsDelegateAuthority { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        
        public Guid UserRoleId { get; set; }
        public virtual UserRoles UserRoles { get; set; }
      
        public Guid DepartmentId { get; set; }
        public virtual Department Departments { get; set; }

  


    }
}
