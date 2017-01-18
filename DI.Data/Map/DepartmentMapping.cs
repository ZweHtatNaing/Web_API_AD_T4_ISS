using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class DepartmentMapping:EntityTypeConfiguration<Department>
    {
        public DepartmentMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.ContactName).IsRequired();
            Property(t => t.DepartmentCode).IsRequired();
            Property(t => t.DepartmentName).IsRequired();
            Property(t => t.FaxNumber).IsOptional();
            Property(t => t.PhoneNo).IsOptional();
         
            ToTable("Department");
        }
    }
}
