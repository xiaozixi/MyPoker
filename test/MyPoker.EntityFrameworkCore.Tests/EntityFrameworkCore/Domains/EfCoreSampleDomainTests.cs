using MyPoker.Samples;
using Xunit;

namespace MyPoker.EntityFrameworkCore.Domains;

[Collection(MyPokerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MyPokerEntityFrameworkCoreTestModule>
{

}
