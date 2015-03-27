using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DW.DAL.Entities;

namespace DW.BL.Interfaces
{
    /// <summary>
    /// Interface, that contains functionality for managing Resource Items
    /// </summary>
    public interface IResourceService
    {
        ResourceItem GetResourceItem(string resourceKey);

        ResourceItemGroup GetResourceGroup(string groupNameKey);

        void Add(ResourceItem resourceItem);

        void Update(ResourceItem resourceItem);

        void Remove(ResourceItem resourceItem);
    }
}
