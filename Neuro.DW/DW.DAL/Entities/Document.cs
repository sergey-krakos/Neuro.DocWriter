using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class Document
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string SourceSystem { get; set; }

        [Required]
        public virtual User Author { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public virtual List<Attachment> Attachments { get; set; }

        public virtual List<ReferencedDocument> ReferencedDocuments { get; set; }       
    }
}