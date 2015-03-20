using System;

namespace DAL.Entities
{
    public class Attachment
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public int DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}