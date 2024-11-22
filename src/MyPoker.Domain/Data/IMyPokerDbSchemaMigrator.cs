using System.Threading.Tasks;

namespace MyPoker.Data;

public interface IMyPokerDbSchemaMigrator
{
    Task MigrateAsync();
}
