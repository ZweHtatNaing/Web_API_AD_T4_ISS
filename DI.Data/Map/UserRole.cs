using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class UserRole:EntityTypeConfiguration<UserRoles>
    {
        public UserRole()
        {
            HasKey(t => t.ID);
            Property(t => t.Name).IsRequired();
            ToTable("UserRoles");
        }
    }
}
