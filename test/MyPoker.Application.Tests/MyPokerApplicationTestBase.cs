using Volo.Abp.Modularity;

namespace MyPoker;

public abstract class MyPokerApplicationTestBase<TStartupModule> : MyPokerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
