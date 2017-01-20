using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Core.Data;

namespace DI.Data.Map
{
    class SupplierMapping:EntityTypeConfiguration<Supplier>
    {
        public SupplierMapping()
        {
            HasKey(t => t.ID);
            Property(t => t.SupplierCode).IsRequired();
            Property(t => t.SupplierName).IsRequired();
            Property(t => t.ContactName).IsRequired();
            Property(t => t.PhoneNo).IsRequired();
            Property(t => t.FaxNo).IsRequired();
            Property(t => t.Address).IsRequired();
            Property(t => t.PostalCode).IsRequired();
            Property(t => t.GstRegNo).IsRequired();
            Property(t => t.IsSelected).IsRequired();
            ToTable("Supplier");
        }
    }
}
