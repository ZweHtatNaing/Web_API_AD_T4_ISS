using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class Stock:BaseEntity
    {
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public int ReorderLevelQty { get; set; }
        public int ReoderQty { get; set; }

        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }

        public virtual Category Categories { get; set; }

      
    


    }
}
