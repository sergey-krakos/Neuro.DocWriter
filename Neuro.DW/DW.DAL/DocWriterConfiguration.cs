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
            AddInterceptor(new DocWriterEfInterceptor());
            SetDatabaseInitializer<DocWriterContext>(null);
        }
    }
}