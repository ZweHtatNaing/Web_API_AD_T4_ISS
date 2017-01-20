using System.Data.Entity.ModelConfiguration;
using DI.Core.Data;

namespace DI.Data.Map
{
    class EmployeeMapping: EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.EmployeeNumber).IsRequired();
            Property(t => t.EmployeeName).IsRequired();   
            Property(t => t.EmplpyeeEmail).IsOptional();
            Property(t => t.Password).IsRequired();
            Property(t => t.IsDelegateAuthority).IsOptional();
            Property(t => t.FromDate).IsOptional();
            Property(t => t.ToDate).IsOptional();
            this.HasRequired(t => t.UserRoles).WithMany().HasForeignKey(t=>t.UserRoleId);
            this.HasRequired(t => t.Departments).WithMany().HasForeignKey(t => t.DepartmentId);

            ToTable("Employee");
        }
    }
}
