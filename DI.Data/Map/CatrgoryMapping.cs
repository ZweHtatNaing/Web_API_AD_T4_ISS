using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
   public class CatrgoriesMapping:EntityTypeConfiguration<Category>
    {
       public CatrgoriesMapping()
       {
           HasKey(t => t.ID);
           Property(t => t.CategoryCode).IsRequired();
           Property(t => t.CategoryDescription).IsRequired();
           ToTable("Catrgory");

       }
    }
}
