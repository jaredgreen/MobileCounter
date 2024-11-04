using Core.Services;

namespace UnitTests.Services;

[TestFixture]
public class FizzBuzzCalculatorTests
{
    private FizzBuzzCalculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new FizzBuzzCalculator();
    }

    [Test]
    public void WhenCalculateWithOne_ReturnsOne()
    {
        var result = _calculator.Calculate(1);
        
        result.Should().Be("1");
    }

    [Test]
    public void WhenCalculateWithThree_ReturnsFizz()
    {
        var result = _calculator.Calculate(3);
        
        result.Should().Be("Fizz");
    }

    [Test]
    public void WhenCalculateWithFive_ReturnsBuzz()
    {
        var result = _calculator.Calculate(5);
        
        result.Should().Be("Buzz");
    }

    [Test]
    public void WhenCalculateWithFifteen_ReturnsFizzBuzz()
    {
        var result = _calculator.Calculate(15);
        
        result.Should().Be("FizzBuzz");
    }
}