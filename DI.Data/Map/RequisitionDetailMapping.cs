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
            Property(t => t.FullfillQty).IsRequired();
            Property(t => t.Status).IsOptional();
          

            ToTable("RequisitionDetail");

        }
    }
}
