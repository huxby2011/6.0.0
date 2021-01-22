using Abp.Web.Mvc.Controllers;

namespace Wlays.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class WlaysControllerBase : AbpController
    {
        protected WlaysControllerBase()
        {
            LocalizationSourceName = WlaysConsts.LocalizationSourceName;
        }
    }
}