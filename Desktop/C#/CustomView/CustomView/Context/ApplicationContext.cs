using Entity.Auth;
using System;
using System.Data.Entity;
using System.Linq;

namespace Context
{
    public class ApplicationContext : DbContext
    {
        #region Auth

        public DbSet<Audit> Audits { get; set; }
        public DbSet<Dependency> Dependencies { get; set; }
        public DbSet<DependencyLevel> DependencyLevels { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FormEntity> FormEntities { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }

        #endregion

        public ApplicationContext()
            : this("DefaultCS")
        {

        }

        public ApplicationContext(String ConnectionStringName)
            : base("name=" + ConnectionStringName)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationContext, ApplicationConfiguration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention>();
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
                Util.Logger.Log(ex, Util.Logger.WARNING);
            }
            return DateTime.Now;
        }
    }
}
