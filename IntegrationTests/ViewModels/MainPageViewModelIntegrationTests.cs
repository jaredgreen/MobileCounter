using Core.Services;
using Core.ViewModels;

namespace IntegrationTests.ViewModels;

[TestFixture]
public class MainPageViewModelIntegrationTests
{
    private MainPageViewModel _vm;
    
    [SetUp]
    public void Setup()
    {
        var countingService = new CountingService();
        _vm = new MainPageViewModel(countingService);
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
        _vm.IncrementCommand.Execute(null);
        
        _vm.ClickedText.Should().Be("Clicked 1 time");
    }

    [Test]
    public void WhenIncrementToTwo_ClickedTextShouldBeClickedOneTime()
    {
        _vm.IncrementCommand.Execute(null);
        _vm.IncrementCommand.Execute(null);
        
        _vm.ClickedText.Should().Be("Clicked 2 times");
    }
    
    #endregion IncrementCommandTests

    #region ResetCommandTests

    [Test]
    public void GivenIncremented_WhenReset_ClickedTextShouldBeClickMe()
    {
        _vm.IncrementCommand.Execute(null);
        _vm.IncrementCommand.Execute(null);
        
        _vm.ResetCommand.Execute(null);
        
        _vm.ClickedText.Should().Be("Click Me");
    }
    
    #endregion ResetCommandTests
}