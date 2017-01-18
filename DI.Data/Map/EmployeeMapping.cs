using System.Data.Entity.ModelConfiguration;
using DI.Core.Data;

namespace DI.Data.Map
{
    class EmployeeMapping: EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.EmployeeName).IsRequired();
            Property(t => t.EmployeeNumber).IsRequired();
            Property(t => t.EmplpyeeEmail).IsOptional();
            Property(t => t.FromDate).IsOptional();
            Property(t => t.ToDate).IsOptional();
            Property(t => t.IsDepartment).IsRequired();
            Property(t => t.IsDepartmentHead).IsRequired();
            Property(t => t.IsDelegateAuthority).IsRequired();
            HasRequired(t => t.Departments).WithMany().HasForeignKey(t => t.DepId);
            HasRequired(t => t.DepartmentHeads).WithMany().HasForeignKey(u => u.DepHeadId);
            HasRequired(t => t.Accounts).WithMany().HasForeignKey(u => u.AccountId);
            ToTable("Employee");
        }
    }
}
