using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.Modularity;

namespace MyPoker;

[DependsOn(
     typeof(AbpAspNetCoreSignalRModule)
    )]
public class MyPokerSignalRModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {

    }
}
