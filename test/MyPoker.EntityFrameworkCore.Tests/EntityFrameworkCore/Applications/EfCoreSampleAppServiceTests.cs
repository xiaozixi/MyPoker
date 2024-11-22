using MyPoker.Samples;
using Xunit;

namespace MyPoker.EntityFrameworkCore.Applications;

[Collection(MyPokerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MyPokerEntityFrameworkCoreTestModule>
{

}
