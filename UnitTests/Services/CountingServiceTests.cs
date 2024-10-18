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
    public void WhenCreated_CurrentCountIsZero()
    {
        _countingService.CurrentCount.Should().Be(0);
    }

    [Test]
    public void WhenIncrement_ThenCurrentCountIsOne()
    {
        _countingService.Increment();
        
        _countingService.CurrentCount.Should().Be(1);
    }

    [Test]
    public void GivenIncrementedOnce_WhenIncrement_ThenCurrentCountIsTwo()
    {
        _countingService.Increment();
        
        _countingService.Increment();
        
        _countingService.CurrentCount.Should().Be(2);
    }

    [Test]
    public void GivenIncremented_WhenReset_ThenCurrentCountIsZero()
    {
        _countingService.Increment();
        _countingService.Increment();
        
        _countingService.Reset();
        
        _countingService.CurrentCount.Should().Be(0);
    }
}