using System;
using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class ReferencedDocument
    {
        [Key]
        public int Id { get; set; }

        public string SourceSystem { get; set; }

        [Required]
        public bool Auto { get; set; }

        [Required]
        public string Revision { get; set; }

        [Required]
        public string Title { get; set; }

        public string Note { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public virtual Document Document { get; set; }
    }
}