using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class Requitition:BaseEntity
    {
       
     

        public string RequestionCode { get; set; }

        public int Qty { get; set; }
        public string Status { get; set; }
        public Guid EmployeeID { get; set; }

        public Guid ItemId { get; set; }
        public virtual Employee Employees { get; set; }
        public Stock Items { get; set; }
     
     
    }
}
