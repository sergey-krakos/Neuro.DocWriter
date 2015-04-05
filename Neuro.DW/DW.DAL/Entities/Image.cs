using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ImageTitle { get; set; }

        [Required]
        public string RelativeImageUrl { get; set; }

        public int? Index { get; set; }

        public int RichTextItemId { get; set; }
        [Required]
        public virtual RichTextItem RichTextItem { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}