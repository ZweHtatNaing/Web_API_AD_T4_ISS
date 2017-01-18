using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class AccountMapping:EntityTypeConfiguration<Account>
    {
        public AccountMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.Email).IsRequired();
            Property(t => t.Password).IsRequired();
            this.HasRequired(t => t.UserRoles).WithMany().HasForeignKey(u => u.UserRolesId);
            ToTable("Account");

        }
    }
}
