using Abp.Web.Mvc.Views;

namespace Wlays.Web.Views
{
    public abstract class WlaysWebViewPageBase : WlaysWebViewPageBase<dynamic>
    {

    }

    public abstract class WlaysWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WlaysWebViewPageBase()
        {
            LocalizationSourceName = WlaysConsts.LocalizationSourceName;
        }
    }
}