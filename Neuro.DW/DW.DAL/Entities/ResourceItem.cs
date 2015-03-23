using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class ResourceItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Title { get; set; }

        [Required]
        public int Label { get; set; }

        public int ToolTip { get; set; }

        [Required]
        public virtual ResourceItemGroup Group { get; set; }

        [Required]
        public virtual User Author { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}