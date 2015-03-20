using System;
using System.Data.Entity;
using System.Linq;
using DAL.Entities;

namespace DAL
{
    /// <summary>
    /// Class, representing database context for an DocWriter database
    /// </summary>
    public class DocWriterContext : DbContext
    {
        public DocWriterContext()
            : base("name=DocWriter")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Attachment> Attachments { get; set; }

        public virtual DbSet<ReferencedDocument> ReferencedDocuments { get; set; }

        public virtual DbSet<Document> Documents { get; set; }
        
    }
}