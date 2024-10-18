using Core.Services;

namespace UnitTests.Services;

[TestFixture]
public class CountingServiceTests
{
    private CountingService _countingService;

    [SetUp]
    public void Setup()
    {
        _countingService = new CountingService();
    }

    [Test]
    public void WhenCreated_CurrentCount_ReturnsZero()
    {
        _countingService.CurrentCount.Should().Be(0);
    }
}