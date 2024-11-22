using MyPoker.Localization;
using Volo.Abp.Application.Services;

namespace MyPoker;

/* Inherit your application services from this class.
 */
public abstract class MyPokerAppService : ApplicationService
{
    protected MyPokerAppService()
    {
        LocalizationResource = typeof(MyPokerResource);
    }
}
