using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumBase
{
    public class Tests
    {
        String uhuUrl = "http://www.uhu.es/index.php";

        IWebDriver driver;

        [SetUp]
        public void Start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TC_001()
        {
            driver.Url = uhuUrl;

            System.Threading.Thread.Sleep(2000);
            /*
            IWebElement acceptButton = driver.FindElement(By.XPath("//span[contains(text(), 'Acepto')]"));
            acceptButton.Click();

            
            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

            searchText.SendKeys("LambdaTest");

            IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));

            searchButton.Click();
            */
            System.Threading.Thread.Sleep(6000);

            Console.WriteLine("Test Passed");
        }

        [Test]
        public void TC_002()
        {
            driver.Url = uhuUrl;

            System.Threading.Thread.Sleep(6000);

            IWebElement campusButton = driver.FindElement(By.XPath("//a[contains(text(), 'Campus Virtual')]"));
            campusButton.Click();

            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void Close_Browser()
        {
            driver.Quit();
        }
    }
}