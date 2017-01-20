using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class BinMapping:EntityTypeConfiguration<Bin>
    {
        public BinMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.BinCode).IsRequired();
            Property(t => t.BinDescription).IsRequired();
            ToTable("Bin");
        }
    }
}
