using Microsoft.AspNetCore.Builder;
using MyPoker;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<MyPokerWebTestModule>();

public partial class Program
{
}
