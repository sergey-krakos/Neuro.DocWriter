using System;
using System.ComponentModel.DataAnnotations;

namespace DW.DAL.Entities
{
    public class Attachment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; }

        public string Description { get; set; }

        public string Revision { get; set; }

        public bool IsUploadedToSharepoint { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public int DocumentId { get; set; }
        [Required]
        public virtual Document Document { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}