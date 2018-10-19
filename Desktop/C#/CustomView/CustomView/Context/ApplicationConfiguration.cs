using System.Data.Entity.Migrations;

namespace Context
{
    public class ApplicationConfiguration : DbMigrationsConfiguration<ApplicationContext>
    {
        public ApplicationConfiguration()
            : base()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ApplicationContext context)
        {
        }
    }
}
