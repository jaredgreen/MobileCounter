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

    #region ClickedText
    
    [Test]
    public void WhenCreated_ClickedTextShouldBeClickMe()
    {
        _vm.ClickedCount.Should().Be("Click Me");
    }
    
    [Test]
    public void GivenCurrentCountIsOne_ClickedTextShouldBeClickedOneTime()
    {
        _countingService.CurrentCount.Returns(1);
        
        _vm.ClickedCount.Should().Be("Clicked 1 time");
    }
    
    [Test]
    public void GivenCurrentCountIsTwo_ClickedTextShouldBeClickedTwoTimes()
    {
        _countingService.CurrentCount.Returns(2);
        
        _vm.ClickedCount.Should().Be("Clicked 2 times");
    }
    
    #endregion ClickedText
    
    #region IncrementCommandTests


    [Test]
    public void WhenIncrementCommandExecuted_ShouldIncrementCountingService()
    {
        _vm.IncrementCommand.Execute(null);
        
        _countingService.Received().Increment();
    }

    [Test]
    public void WhenIncrementCommandIsExecuted_ShouldNotifyPropertyChangedForClickedText()
    {
        var isFired = false;
        _vm.PropertyChanged += (_, e) =>
        {
            if (e.PropertyName == nameof(_vm.ClickedCount))
            {
                isFired = true;
            }
        };
        
        _vm.IncrementCommand.Execute(null);

        isFired.Should().BeTrue();
    }
    
    #endregion IncrementCommandTests

    #region ResetCommandTests

    [Test]
    public void WhenResetCommandExecuted_ShouldResetCountingService()
    {
        _vm.ResetCommand.Execute(null);
        
        _countingService.Received().Reset();
    }

    [Test]
    public void WhenResetCommandIsExecuted_ShouldNotifyPropertyChangedForClickedText()
    {
        var isFired = false;
        _vm.PropertyChanged += (_, e) =>
        {
            if (e.PropertyName == nameof(_vm.ClickedCount))
            {
                isFired = true;
            }
        };
        
        _vm.ResetCommand.Execute(null);

        isFired.Should().BeTrue();
    }
    

    #endregion ResetCommandTests
}