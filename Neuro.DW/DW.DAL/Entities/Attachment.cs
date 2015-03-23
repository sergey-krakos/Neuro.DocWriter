using System;
using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class Attachment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public int DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}