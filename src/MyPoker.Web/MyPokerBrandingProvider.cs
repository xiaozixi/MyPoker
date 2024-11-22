using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using MyPoker.Localization;

namespace MyPoker.Web;

[Dependency(ReplaceServices = true)]
public class MyPokerBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MyPokerResource> _localizer;

    public MyPokerBrandingProvider(IStringLocalizer<MyPokerResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
