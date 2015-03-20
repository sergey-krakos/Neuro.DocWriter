using System;

namespace DAL.Entities
{
    public class ReferencedDocument
    {
        public int Id { get; set; }

        public string SourceSystem { get; set; }

        public bool Auto { get; set; }

        public string Revision { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public int DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}