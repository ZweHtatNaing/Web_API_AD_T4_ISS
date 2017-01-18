using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class Supplier:BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int postalcode { get; set; }
        public int PhoneNo{get;set;}
        public Guid AccountId { get; set; }

        public virtual Account Accounts { get; set; }
     
     
    }
}
