using NUnit.Framework;

namespace UITests;

public class FizzBuzzFeature : BaseTest
{
    [SetUp]
    public void Setup()
    {
        App.ActivateApp("com.uplift.mobilecounter");
    }

    [TearDown]
    public void After()
    {
        App.TerminateApp("com.uplift.mobilecounter");
    }
	
    [Test]
    public void GivenClickedOnce_WhenNavigateToFizzBuzzPage_ThenShowsOne()
    {
        var button = FindUIElement("CounterBtn");
        button.Click();
        
        NavigateToFizzBuzzPage();
	
        var cardDescription = FindUIElement("CardDescription");
        Assert.That(cardDescription.Text, Is.EqualTo("1"));
    }
	
    [Test]
    public void GivenClickedThreeTimes_WhenNavigateToFizzBuzzPage_ThenShowsFizz()
    {
        var button = FindUIElement("CounterBtn");
        button.Click();
        button.Click();
        button.Click();
        
        NavigateToFizzBuzzPage();
	
        var cardDescription = FindUIElement("CardDescription");
        Assert.That(cardDescription.Text, Is.EqualTo("Fizz"));
    }

    [Test]
    public void GivenClickedFiveTimes_WhenNavigateToFizzBuzzPage_ThenShowsBuzz()
    {
        var button = FindUIElement("CounterBtn");
        button.Click();
        button.Click();
        button.Click();
        button.Click();
        button.Click();

        NavigateToFizzBuzzPage();

        var cardDescription = FindUIElement("CardDescription");
        Assert.That(cardDescription.Text, Is.EqualTo("Buzz"));
    }

    [Test]
    public void GivenNavigatedToAndFromFizzBuzzPage_WhenIncrementFurther_ThenFizzBuzzUpdates()
    {
        NavigateToFizzBuzzPage();
        NavigateToCounterPage();
        
        var button = FindUIElement("CounterBtn");
        button.Click();
        button.Click();
        button.Click();
        
        NavigateToFizzBuzzPage();

        var cardDescription = FindUIElement("CardDescription");
        Assert.That(cardDescription.Text, Is.EqualTo("Fizz"));
    }
}