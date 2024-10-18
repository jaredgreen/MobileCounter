using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace UITests;

public abstract class BaseTest
{
	protected AppiumDriver App => AppiumSetup.App;

	protected AppiumElement FindUIElement(string id)
	{
		return App.FindElement(MobileBy.Id(id));
	}
}