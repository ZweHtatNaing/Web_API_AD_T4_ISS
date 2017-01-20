using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class RequisitionHeaderMApping:EntityTypeConfiguration<RequititionHeader>
    {
        public RequisitionHeaderMApping()
        {
            HasKey(t => t.ID);
            Property(t => t.RequestionCode).IsRequired();
            Property(t => t.TransDate).IsRequired();
            Property(t => t.Status).IsOptional();
            Property(t => t.Remark).IsOptional();
//            this.HasRequired(t => t.Employees).WithMany().HasForeignKey(t => t.EmployeeId);
            ToTable("RequititionHeaders");
        }
    }
}
