using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

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