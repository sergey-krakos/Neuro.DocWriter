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
    /// configuration for context
    /// </summary>
    public class DocWriterConfiguration : DbConfiguration
    {
        public DocWriterConfiguration()
        {
            this.AddInterceptor(new DocWriterEFInterceptor());
            this.SetDatabaseInitializer<DocWriterContext>(null);
        }
    }
}