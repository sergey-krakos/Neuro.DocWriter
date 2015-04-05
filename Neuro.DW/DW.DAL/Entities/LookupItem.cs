using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class LookupItem
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public int CategoryId { get; set; }
        [Required]
        public virtual LookupItemCategory Category { get; set; }

        public int AuthorId { get; set; }
        [Required]
        public virtual User Author { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}