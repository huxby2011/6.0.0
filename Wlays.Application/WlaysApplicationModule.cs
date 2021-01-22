using System.Reflection;
using Abp.Modules;

namespace Wlays
{
    [DependsOn(typeof(WlaysCoreModule))]
    public class WlaysApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
