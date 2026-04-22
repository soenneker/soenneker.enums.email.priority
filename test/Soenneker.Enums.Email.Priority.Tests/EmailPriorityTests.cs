using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.Email.Priority.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EmailPriorityTests : HostedUnitTest
{
    public EmailPriorityTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
