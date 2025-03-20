using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Enums.Email.Priority.Tests;

[Collection("Collection")]
public class EmailPriorityTests : FixturedUnitTest
{
    public EmailPriorityTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
