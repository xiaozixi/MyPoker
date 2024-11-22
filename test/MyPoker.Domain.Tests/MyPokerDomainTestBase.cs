using Volo.Abp.Modularity;

namespace MyPoker;

/* Inherit from this class for your domain layer tests. */
public abstract class MyPokerDomainTestBase<TStartupModule> : MyPokerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
