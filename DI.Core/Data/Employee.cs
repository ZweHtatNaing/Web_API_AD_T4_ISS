using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class Employee:BaseEntity
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmplpyeeEmail { get; set; }
        public bool IsDelegateAuthority { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Guid AccountId { get; set; }
        public Boolean IsDepartment { get; set; }

        public Boolean IsDepartmentHead { get; set; }

        public Guid DepId { get; set; }

        public Guid DepHeadId { get; set; }
        public virtual Department Departments{get; set; }
        public virtual DepartmentHead DepartmentHeads { get; set; }
        public virtual Account Accounts { get; set; }


    }
}
