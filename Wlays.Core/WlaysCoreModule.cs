using System.Reflection;
using Abp.Modules;

namespace Wlays
{
    public class WlaysCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
