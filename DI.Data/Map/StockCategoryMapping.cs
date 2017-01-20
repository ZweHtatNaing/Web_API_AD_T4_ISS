using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;
namespace DI.Data.Map
{
    class StockCategoryMapping: EntityTypeConfiguration<Stock>
    {
        public StockCategoryMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.ItemCode).IsRequired();
            Property(t => t.CategoryId).IsRequired();
            Property(t => t.Price).IsRequired();
            Property(t => t.ItemDescription).IsRequired();
            Property(t => t.ReoderQty).IsRequired();
            Property(t => t.ReorderLevelQty).IsOptional();
            Property(t => t.AddedDate).IsOptional();
            Property(t => t.BinCode).IsRequired();
         
            this.HasRequired(t => t.Categories).WithMany().HasForeignKey(t => t.CategoryId).WillCascadeOnDelete(false);
            ToTable("Stock");
        }
    }
}
