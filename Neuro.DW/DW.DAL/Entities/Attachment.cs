using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime CreatedOn { get; set; }

        [Required]
        public virtual Document Document { get; set; }
    }
}