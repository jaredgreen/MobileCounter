using NUnit.Framework;

namespace UITests;

public class MainPageTests : BaseTest
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
	public void WhenLoaded_ThenShowsClickMe()
	{
		var element = FindUIElement("CounterBtn");

		Assert.That(element.Text, Is.EqualTo("Click me"));
	}

	[Test]
	public void WhenClicked_ThenShowsClickedOneTime()
	{
		var element = FindUIElement("CounterBtn");
	
		element.Click();
	
		Assert.That(element.Text, Is.EqualTo("Clicked 1 time"));
	}
	
	[Test]
	public void GivenClickedOnce_WhenClickAgain_ThenShowsClickedTwoTimes()
	{
		var element = FindUIElement("CounterBtn");
	
		element.Click();
		element.Click();
		// Task.Delay(500).Wait();
	
		Assert.That(element.Text, Is.EqualTo("Clicked 2 times"));
	}
}