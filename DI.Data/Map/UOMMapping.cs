using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class UOMMapping:EntityTypeConfiguration<UOM>
    {
        public UOMMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.uom).IsRequired();
            ToTable("UOM");
        }
    }
}
