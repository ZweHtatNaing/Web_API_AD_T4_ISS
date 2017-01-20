using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using DI.Core;


namespace DI.Data
{
   public class IDbContext:DbContext
    {
        public IDbContext(): base("name=LogicUniversity")
       {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = false;
           
        }
        //public class ApplicationUser : IdentityUser
        //{
        //    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        //    {
        //        // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        //        var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        //        // Add custom user claims here
        //        return userIdentity;
        //    }
        //}


        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
       {
           return base.Set<TEntity>();
       }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !String.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                               && type.BaseType.GetGenericTypeDefinition() == typeof (EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
