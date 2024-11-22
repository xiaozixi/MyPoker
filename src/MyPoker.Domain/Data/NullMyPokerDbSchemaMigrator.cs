using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyPoker.Data;

/* This is used if database provider does't define
 * IMyPokerDbSchemaMigrator implementation.
 */
public class NullMyPokerDbSchemaMigrator : IMyPokerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
