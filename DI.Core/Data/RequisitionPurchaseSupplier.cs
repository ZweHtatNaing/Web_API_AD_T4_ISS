using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class RequisitionPurchaseSupplier:BaseEntity
    {
      
        public int reqQty { get; set; }
        public Guid StockId { get; set; }

        public Guid SupplierId { get; set; }

        public virtual Supplier Suppliers { get; set; }
        public virtual Stock Stocks { get; set; }
    }
}
