using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace Context
{
    public class ApplicationConfiguration : DbMigrationsConfiguration<ApplicationContext>
    {
        public ApplicationConfiguration()
            : base()
        {
            #if DEBUG
            //System.Windows.Forms.MessageBox.Show("DEBUG");
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            #endif
        }

        protected override void Seed(ApplicationContext context)
        {
        }
    }
}
