using System;
using System.Data.Entity.Migrations;

namespace DataAccess
{
    public class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
            : base()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Context context)
        {
        }
    }
}
