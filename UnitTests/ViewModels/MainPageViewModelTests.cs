using Core.Interfaces;
using Core.ViewModels;

namespace UnitTests.ViewModels;

[TestFixture]
public class MainPageViewModelTests
{
    private MainPageViewModel _vm;
    
    private ICountingService _countingService;

    [SetUp]
    public void Setup()
    {
        _countingService = Substitute.For<ICountingService>();
        _vm = new MainPageViewModel(_countingService);
    }

    [Test]
    public void WhenCreated_ClickedTextShouldBeClickMe()
    {
        _vm.ClickedText.Should().Be("Click Me");
    }

    [Test]
    public void WhenIncrementToOne_ClickedTextShouldBeClickedOneTime()
    {
        _countingService.CurrentCount.Returns(1);
        
        _vm.IncrementCommand.Execute(null);
        
        _vm.ClickedText.Should().Be("Clicked 1 time");
    }

    [Test]
    public void WhenIncrementToTwo_ClickedTextShouldBeClickedOneTime()
    {
        _countingService.CurrentCount.Returns(2);
        
        _vm.IncrementCommand.Execute(null);
        
        _vm.ClickedText.Should().Be("Clicked 2 times");
    }

    [Test]
    public void WhenIncrementCommandExecuted_ShouldIncrementCountingService()
    {
        _vm.IncrementCommand.Execute(null);
        
        _countingService.Received().Increment();
    }
}