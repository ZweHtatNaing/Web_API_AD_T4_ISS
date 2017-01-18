using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
   public class RequisitionMapping:EntityTypeConfiguration<Requitition>
    {
       public RequisitionMapping()
       {
           HasKey(t => t.ID);
           Property(t => t.Qty).IsRequired();
           Property(t => t.RequestionCode).IsRequired();
           Property(t => t.Status).IsOptional();
           this.HasRequired(t => t.Employees).WithMany().HasForeignKey(t => t.EmployeeID);        
           this.HasRequired(t => t.Items).WithMany().HasForeignKey(u => u.ItemId);
           ToTable("Requisition");
       }
    }
}
