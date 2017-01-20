using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class RequisitionDetailMapping:EntityTypeConfiguration<Core.Data.RequisitionDetail>
    {
        public RequisitionDetailMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.RequestedQty).IsRequired();
            Property(t => t.RetrieveQty).IsRequired();
            Property(t => t.OutstandingQty).IsRequired();
            Property(t => t.StockId).IsRequired();
            Property(t => t.TransactionStatus).IsOptional();
            this.HasRequired(t => t.Stocks).WithMany().HasForeignKey(t => t.StockId);
            ToTable("RequisitionDetail");

        }
    }
}
