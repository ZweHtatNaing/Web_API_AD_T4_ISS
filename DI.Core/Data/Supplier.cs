using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class Supplier:BaseEntity
    {
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public int PhoneNo { get; set; }
        public int FaxNo { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string GstRegNo { get; set; }
        public bool IsSelected { get; set; }
       


    }
}
