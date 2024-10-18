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
    
    #region IncrementCommandTests

    [Test]
    public void WhenIncrementToOne_ClickedTextShouldBeClickedOneTime()
    {
        _countingService.CurrentCount.Returns(1);
        
        _vm.IncrementCommand.Execute(null);
        
        _vm.ClickedText.Should().Be("Clicked 1 time");
    }

    [Test]
    public void WhenIncrementToTwo_ClickedTextShouldBeClickedTwoTimes()
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
    
    #endregion IncrementCommandTests

    #region ResetCommandTests
    
    [Test]
    public void WhenResetCommandExecuted_ClickedTextShouldBeClickMe()
    {
        _vm.ClickedText = "Clicked 1 time";
        
        _vm.ResetCommand.Execute(null);
        
        _vm.ClickedText.Should().Be("Click Me");
    }

    [Test]
    public void WhenResetCommandExecuted_ShouldResetCountingService()
    {
        _vm.ResetCommand.Execute(null);
        
        _countingService.Received().Reset();
    }
    

    #endregion ResetCommandTests
}