using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Document
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string SourceSystem { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual List<Attachment> Attachments { get; set; }

        public virtual List<ReferencedDocument> ReferencedDocuments { get; set; }
    }
}