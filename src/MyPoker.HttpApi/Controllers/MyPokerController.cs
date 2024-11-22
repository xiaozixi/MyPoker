using MyPoker.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyPoker.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyPokerController : AbpControllerBase
{
    protected MyPokerController()
    {
        LocalizationResource = typeof(MyPokerResource);
    }
}
