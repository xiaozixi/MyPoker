using Xunit;

namespace MyPoker.EntityFrameworkCore;

[CollectionDefinition(MyPokerTestConsts.CollectionDefinitionName)]
public class MyPokerEntityFrameworkCoreCollection : ICollectionFixture<MyPokerEntityFrameworkCoreFixture>
{

}
