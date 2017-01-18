using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class RequisitionDetail:BaseEntity
    {
        public int RequisitionCode { get; set; }
        public int FullfillQty { get; set; }
        public string Status { get; set; }

       
        
    }
}
