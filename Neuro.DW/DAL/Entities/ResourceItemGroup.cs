using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class ResourceItemGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string GroupName { get; set; }

        public virtual List<ResourceItem> ResourceItems { get; set; }
    }
}