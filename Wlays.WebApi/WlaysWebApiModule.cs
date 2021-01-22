using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Wlays
{
    [DependsOn(typeof(AbpWebApiModule), typeof(WlaysApplicationModule))]
    public class WlaysWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(WlaysApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
