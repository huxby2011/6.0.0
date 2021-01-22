using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using Wlays.Channels;

namespace Wlays.EntityFramework
{
    public class WlaysDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public WlaysDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in WlaysDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of WlaysDbContext since ABP automatically handles it.
         */
        public WlaysDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public WlaysDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public WlaysDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        public virtual DbSet<Channel> Channels { get; set; }
    }
}
