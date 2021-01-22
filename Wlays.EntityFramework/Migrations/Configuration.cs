using System.Data.Entity.Migrations;

namespace Wlays.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Wlays.EntityFramework.WlaysDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Wlays";
        }

        protected override void Seed(Wlays.EntityFramework.WlaysDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
