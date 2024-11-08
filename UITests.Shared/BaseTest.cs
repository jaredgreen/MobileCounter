using OpenQA.Selenium.Appium;

namespace UITests;

public abstract class BaseTest
{
	protected static AppiumDriver App => AppiumSetup.App;

	protected static AppiumElement FindUIElement(string id)
	{
		return App.FindElement(MobileBy.Id(id));
	}

	protected static void NavigateToCounterPage()
	{
		var goToFizzBuzz = App.FindElement(MobileBy.AccessibilityId("Counter"));
		goToFizzBuzz.Click();
		Wait();
	}
	
	protected static void NavigateToFizzBuzzPage()
	{
		var goToFizzBuzz = App.FindElement(MobileBy.AccessibilityId("FizzBuzz"));
		goToFizzBuzz.Click();
		Wait();
	}

	protected static void OpenApp()
	{
		App.ActivateApp("com.uplift.mobilecounter");
	}

	protected static void CloseApp()
	{
		App.TerminateApp("com.uplift.mobilecounter");
	}
	
}