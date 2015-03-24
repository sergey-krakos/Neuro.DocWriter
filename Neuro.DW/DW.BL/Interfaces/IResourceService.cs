using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DW.DAL.Entities;

namespace DW.BL.Interfaces
{
    /// <summary>
    /// Contains functionality for managing ResourceItems
    /// </summary>
    public interface IResourceService
    {
        ResourceItem GetGesourceItem(string resourceName);

        ResourceItemGroup GetResourceGroup(string resourceGroupName);

        void Add(ResourceItem resourceItem);

        void Update(ResourceItem resourceItem);

        void Remove(ResourceItem resourceItem);
    }
}
