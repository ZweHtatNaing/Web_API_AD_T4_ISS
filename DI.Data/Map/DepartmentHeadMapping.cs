using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class DepartmentHeadMapping:EntityTypeConfiguration<DepartmentHead>
    {
        public DepartmentHeadMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.Name).IsRequired();
            Property(t => t.Address).IsRequired();
            Property(t => t.PhoneNo).IsOptional();
            ToTable("DepartmentHead");

        }
    }
}
