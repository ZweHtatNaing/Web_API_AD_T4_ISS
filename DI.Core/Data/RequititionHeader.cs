using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class RequititionHeader:BaseEntity
    {

        public string RequestionCode { get; set; }
        public DateTime TransDate { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }

        public Guid EmployeeId { get; set; }
//        public ICollection<Employee> Employees { get; set; }

        public ICollection<RequisitionDetail> RequisitionDetails { get; set; }



    }
}
