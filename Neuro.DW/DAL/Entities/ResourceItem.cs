using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
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
        public int GroupId { get; set; }
        public virtual ResourceItemGroup Group { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public virtual User Author { get; set; }
    }
}