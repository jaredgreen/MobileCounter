using Core.Interfaces;
using Core.ViewModels;

namespace UnitTests.ViewModels;

[TestFixture]
public class FizzBuzzPageViewModelTests
{
    private FizzBuzzPageViewModel _vm;
    
    private ICountingService _countingService;
    private IFizzBuzzCalculator _calculator;

    [SetUp]
    public void Setup()
    {
        _countingService = Substitute.For<ICountingService>();
        _calculator = Substitute.For<IFizzBuzzCalculator>();
        _vm = new FizzBuzzPageViewModel(_countingService, _calculator);
    }

    [Test]
    public void FizzBuzzValue_ShouldReturnCurrentCountFizzBuzzCalculation()
    {
        _countingService.CurrentCount.Returns(5);
        _calculator.Calculate(5).Returns("FizzBuzz");
        
        _vm.FizzBuzzValue.Should().Be("FizzBuzz");
    }
}