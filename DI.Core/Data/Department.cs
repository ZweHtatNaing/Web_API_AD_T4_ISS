using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class Department:BaseEntity
    {
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string ContactName { get; set; }
        public int PhoneNo { get; set; }
        public int FaxNumber { get; set; }
    }
}
