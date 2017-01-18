using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
   public class DepartmentHead:BaseEntity
    {
        public string Name { get; set; }
        public int PhoneNo { get; set; }

        public string Address { get; set; }


    }
}
