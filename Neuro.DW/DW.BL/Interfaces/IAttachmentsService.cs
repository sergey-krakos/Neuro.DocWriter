using System.Collections.Generic;

using DW.DAL.Entities;

namespace DW.BL.Interfaces
{
    /// <summary>
    /// Interface, that contains functionality for managing Document Attachments
    /// </summary>
    public interface IAttachmentsService
    {
        IList<Attachment> GetAllByDocumentId(int documentId);

        void Add(Attachment attachment);

        void Update(Attachment attachment);

        void Remove(Attachment attachment);
    }
}
