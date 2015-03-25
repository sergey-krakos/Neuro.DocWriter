using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DW.DAL.Entities;

namespace DW.BL.Interfaces
{
    /// <summary>
    /// Interface, that contains functionality for managing Referenced Documents
    /// </summary>
    public interface IReferencedDocumentsService
    {
        IList<ReferencedDocument> GetAllByDocumentId(int documentId);

        void Add(ReferencedDocument referencedDocument);

        void Update(ReferencedDocument referencedDocument);

        void Remove(ReferencedDocument referencedDocument);
    }
}
