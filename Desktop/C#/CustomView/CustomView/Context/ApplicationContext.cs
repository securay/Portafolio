using Entity.Auth;
using Entity.Coolers;
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
        public DbSet<SystemMenu> SystemMenus { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<SystemUserMenuPermission> SystemUserMenuPermissions { get; set; }

        #endregion

        #region Coolers

        public DbSet<Cooler> Coolers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MeasureUnit> MeasureUnits { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        public DbSet<ServiceOrderDetail> ServiceOrderDetails { get; set; }

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
                return Database.SqlQuery(typeof(DateTime), "SELECT NOW()", new object[] { }).Cast<DateTime>().First();
            }
            catch (System.Data.Entity.Migrations.Infrastructure.AutomaticMigrationsDisabledException ex)
            {
                Util.Logger.Log(ex, Util.Logger.WARNING);
            }
            return DateTime.Now;
        }
    }
}
