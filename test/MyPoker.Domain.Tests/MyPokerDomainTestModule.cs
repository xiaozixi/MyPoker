using Volo.Abp.Modularity;

namespace MyPoker;

[DependsOn(
    typeof(MyPokerDomainModule),
    typeof(MyPokerTestBaseModule)
)]
public class MyPokerDomainTestModule : AbpModule
{

}
