using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

        IWebElement field1 = driver.FindElement(By.class("btn btn-primary dropdown-toggle"));
        btn btn-primary dropdown-toggle.SendKeys("value1");

        IWebElement field2 = driver.FindElement(By.class("btn btn-primary"));
        btn btn-primary.SendKeys("value2");

        IWebElement field3 = driver.FindElement(By.class("form-group col-xs-6"));
        form-group col-xs-6.SendKeys("value3");

        IWebElement submitButton = driver.FindElement(By.Id("submit"));
        submitButton.Click();

        IWebElement successMessage = driver.FindElement(By.Id("success"));
        Assert.IsTrue(successMessage.Displayed, "Submission failed.");

        Console.WriteLine("Test passed.");

        driver.Quit();
    }
}
