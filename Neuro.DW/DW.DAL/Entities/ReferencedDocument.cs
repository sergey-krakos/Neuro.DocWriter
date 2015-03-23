using System;
using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class ReferencedDocument
    {
        [Key]
        public int Id { get; set; }

        public string SourceSystem { get; set; }

        public bool Auto { get; set; }

        public string Revision { get; set; }

        [Required]
        public string Title { get; set; }

        public string Note { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public int DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}