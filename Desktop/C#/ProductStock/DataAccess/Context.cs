using Entity;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Casino> Casinos { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoredProduct> StoredProducts { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }

        public Context()
            : base("name=MainConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Properties<decimal>().Configure(config => config.HasPrecision(12, 4));
        }

        public DateTime GetCurrentTime()
        {
            try
            {
                return Database.SqlQuery(typeof(DateTime), "SELECT GETDATE()", new object[] { }).Cast<DateTime>().First();
            }
            catch (System.Data.Entity.Migrations.Infrastructure.AutomaticMigrationsDisabledException ex)
            {
                Util.Logger.Error("Error consultando la fecha actual", ex);
            }
            return DateTime.Now;
        }
    }
}
