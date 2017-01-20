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
        public Guid SuppliersId { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
