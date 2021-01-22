using Abp.Application.Services;

namespace Wlays
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class WlaysAppServiceBase : ApplicationService
    {
        protected WlaysAppServiceBase()
        {
            LocalizationSourceName = WlaysConsts.LocalizationSourceName;
        }
    }
}