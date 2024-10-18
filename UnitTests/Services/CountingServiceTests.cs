using Core.Services;

namespace UnitTests.Services;

[TestFixture]
public class CountingServiceTests
{
    [SetUp]
    public void Setup()
    {
        var countingService = new CountingService();
    }
}