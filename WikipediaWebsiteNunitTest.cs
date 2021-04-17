using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WikipediaWebsiteNunitTest
{
    IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
    }

    [Test]
    public void CheckQaSearch()
    {
        driver.Navigate().GoToUrl("https://wikipedia.org");
        driver.FindElement(By.XPath("//input[contains(@id,'searchInput')]")).Click();
        driver.FindElement(By.XPath("//input[contains(@id,'searchInput')]")).SendKeys("QA");
        driver.FindElement(By.XPath("//input[contains(@id,'searchInput')]")).SendKeys(Keys.Enter);
        var url = driver.Url;

        Assert.AreEqual("https://en.wikipedia.org/wiki/QA", url);

    }
    [TearDown]
    public void TeatDown()
    {
       driver.Quit();
    }
}
