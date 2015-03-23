using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class DocWriterConfiguration : DbConfiguration
    {
        public DocWriterConfiguration()
        {
            DbInterception.Add(new DocWriterEFInterceptor());
        }
    }
}