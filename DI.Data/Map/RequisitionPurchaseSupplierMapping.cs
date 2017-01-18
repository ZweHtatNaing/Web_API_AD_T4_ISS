using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class RequisitionPurchaseSupplierMapping:EntityTypeConfiguration<RequisitionPurchaseSupplier>
    {
        public RequisitionPurchaseSupplierMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.reqQty).IsRequired();
            this.HasRequired(t => t.Stocks).WithMany().HasForeignKey(u => u.StockId);
            this.HasRequired(t => t.Suppliers).WithMany().HasForeignKey(u => u.SupplierId);
            ToTable("RequisitionPurchaseSupplier");
        }
    }
}
