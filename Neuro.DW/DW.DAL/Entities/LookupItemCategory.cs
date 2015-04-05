using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class LookupItemCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public virtual List<LookupItem> LookupItems { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}