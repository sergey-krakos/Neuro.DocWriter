using System.Data.Entity.Migrations;

namespace DW.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DocWriterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(DocWriterContext context)
        {
        }
    }
}