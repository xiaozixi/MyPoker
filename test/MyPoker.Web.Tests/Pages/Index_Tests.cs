using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MyPoker.Pages;

[Collection(MyPokerTestConsts.CollectionDefinitionName)]
public class Index_Tests : MyPokerWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
