using System.Data.Entity;
using System.Linq;
using Object_Library.Entity;
using Object_Library.Interfaces;

namespace Object_Library.Context
{
    public class SkazatiDb : DbContext, ISkazatiDb
    {
        public SkazatiDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<TimeReport> TimeReports { get; set; }
        public DbSet<FavoriteSite> FavoriteSites { get; set; }
        public DbSet<FavoritesLink> FavoritesLinks { get; set; }
        public DbSet<SystemConfiguration> SystemConfigurations { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<LogControl> LogControls { get; set; }

        IQueryable<T> ISkazatiDb.Query<T>()
        {
            return Set<T>();
        }

        void ISkazatiDb.Add<T>(T entity)
        {
            Set<T>().Add(entity);
        }

        void ISkazatiDb.Update<T>(T entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        void ISkazatiDb.Remove<T>(T entity)
        {
            Set<T>().Remove(entity);
        }

        void ISkazatiDb.SaveChanges()
        {
            SaveChanges();
        }
    }
}