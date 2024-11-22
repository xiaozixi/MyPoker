using Volo.Abp.Modularity;

namespace MyPoker;

[DependsOn(
    typeof(MyPokerApplicationModule),
    typeof(MyPokerDomainTestModule)
)]
public class MyPokerApplicationTestModule : AbpModule
{

}
