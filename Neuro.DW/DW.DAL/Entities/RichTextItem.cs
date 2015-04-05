using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class RichTextItem
    {
        [Key]
        public int Id { get; set; }

        public string TextBoxValue { get; set; }

        public virtual List<Image> Images { get; set; }

        public int AuthorId { get; set; }
        [Required]
        public virtual User Author { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}