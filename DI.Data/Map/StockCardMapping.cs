using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class StockCardMapping:EntityTypeConfiguration<StockCard>
    {
        public StockCardMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.SerialNumber).IsOptional();
            Property(t => t.Description).IsRequired();
            Property(t => t.BalanceQty).IsRequired();
            Property(t => t.Qty).IsRequired();
            Property(t => t.TransDate).IsOptional();
            this.HasRequired(t => t.Stocks).WithMany().HasForeignKey(t => t.StockId);
            ToTable("StockCard");
        }
    }
}
