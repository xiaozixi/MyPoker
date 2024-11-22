using MyPoker.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyPoker.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyPokerEntityFrameworkCoreModule),
    typeof(MyPokerApplicationContractsModule)
)]
public class MyPokerDbMigratorModule : AbpModule
{
}
