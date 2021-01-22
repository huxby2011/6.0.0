using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Wlays.EntityFramework;

namespace Wlays
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(WlaysCoreModule))]
    public class WlaysDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<WlaysDbContext>(null);
        }
    }
}
