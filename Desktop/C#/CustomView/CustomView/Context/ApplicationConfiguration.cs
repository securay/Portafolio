using System.Data.Entity.Migrations;

namespace Context
{
    public class ApplicationConfiguration : DbMigrationsConfiguration<ApplicationContext>
    {
        public ApplicationConfiguration()
            : base()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            // SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.EntityFramework.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(ApplicationContext context)
        {
        }
    }
}
