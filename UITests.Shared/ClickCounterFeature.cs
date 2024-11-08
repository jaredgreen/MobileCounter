using NUnit.Framework;

namespace UITests;

public class ClickCounterFeature : BaseTest
{
	[SetUp]
	public void Setup()
	{
		OpenApp();
	}

	[TearDown]
	public void After()
	{
		CloseApp();
	}

	[Test]
	public void WhenLoaded_ThenShowsClickMe()
	{
		var button = FindUIElement("CounterBtn");

		Assert.That(button.Text, Is.EqualTo("Click Me"));
	}

	[Test]
	public void WhenClicked_ThenShowsClickedOneTime()
	{
		var button = FindUIElement("CounterBtn");
	
		button.Click();
	
		Assert.That(button.Text, Is.EqualTo("Clicked 1 time"));
	}
	
	[Test]
	public void GivenClickedOnce_WhenClickAgain_ThenShowsClickedTwoTimes()
	{
		var button = FindUIElement("CounterBtn");
	
		button.Click();
		button.Click();
	
		Assert.That(button.Text, Is.EqualTo("Clicked 2 times"));
	}
}