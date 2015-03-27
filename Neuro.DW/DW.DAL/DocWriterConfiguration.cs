using System.Data.Entity;

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