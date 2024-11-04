using Core.Interfaces;
using Core.Services;
using Core.ViewModels;

namespace IntegrationTests.ViewModels;

[TestFixture]
public class FizzBuzzPageViewModelIntegrationTests
{
    private FizzBuzzPageViewModel _vm;
    private ICountingService _countingService;

    [SetUp]
    public void SetUp()
    {
        _countingService = Substitute.For<ICountingService>();
        var calculator = new FizzBuzzCalculator();
        _vm = new FizzBuzzPageViewModel(_countingService, calculator);
    }
    
    [Test]
    public void GivenCurrentCountIsThree_ThenValueShouldBeFizz()
    {
        _countingService.CurrentCount.Returns(3);

        _vm.FizzBuzzValue.Should().Be("Fizz");
    }
    
}