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
        //Testing the integration between MainPageViewModel and CountingService
        var countingService = new CountingService();
        _vm = new MainPageViewModel(countingService);
    }

    [Test]
    public void WhenCreated_ClickedCountShouldBeClickMe()
    {
        _vm.ClickedCount.Should().Be("Click Me");
    }
    
    #region IncrementCommandTests

    [Test]
    public void WhenIncrementToOne_ClickedCountShouldBeClickedOneTime()
    {
        _vm.IncrementCommand.Execute(null);
        
        _vm.ClickedCount.Should().Be("Clicked 1 time");
    }

    [Test]
    public void WhenIncrementToTwo_ClickedCountShouldBeClickedOneTime()
    {
        _vm.IncrementCommand.Execute(null);
        _vm.IncrementCommand.Execute(null);
        
        _vm.ClickedCount.Should().Be("Clicked 2 times");
    }
    
    #endregion IncrementCommandTests

    #region ResetCommandTests

    [Test]
    public void GivenIncremented_WhenReset_ClickedCountShouldBeClickMe()
    {
        _vm.IncrementCommand.Execute(null);
        _vm.IncrementCommand.Execute(null);
        
        _vm.ResetCommand.Execute(null);
        
        _vm.ClickedCount.Should().Be("Click Me");
    }
    
    #endregion ResetCommandTests
}