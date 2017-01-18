using System;
using System.ComponentModel.DataAnnotations;
using DI.Core.Data;

namespace DI.Core
{
    public abstract class BaseEntity
    {
        [Microsoft.Build.Framework.Required]
        [Key]
        public Guid ID { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        
    }
}
