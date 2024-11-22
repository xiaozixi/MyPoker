using MyPoker.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyPoker.Web.Pages;

public abstract class MyPokerPageModel : AbpPageModel
{
    protected MyPokerPageModel()
    {
        LocalizationResourceType = typeof(MyPokerResource);
    }
}
