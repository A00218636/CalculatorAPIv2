using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CalculatorIntegrationTest
{
 

    [TestClass]
    public class CalculatorWebTests
    {
        IWebDriver _driver;

        [TestInitialize]
        public void StartUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [TestMethod]
        public void TestThatTheWebsiteAdds()
        {
            _driver.Navigate().GoToUrl("http://localhost:5000/");
            var left = _driver.FindElement(By.CssSelector("input[name=OperandFirst]"));
            var right = _driver.FindElement(By.CssSelector("input[name=OperandSecond]"));
            var form = _driver.FindElement(By.CssSelector("form"));
            var rb = _driver.FindElement(By.CssSelector("input[value=Addition]"));


            rb.Click();
            left.SendKeys("1");
            right.SendKeys("1");
            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual(2.ToString(), output.Text);
        }
        [TestMethod]
        public void TestThatTheWebsiteSubtracts()
        {
            _driver.Navigate().GoToUrl("http://localhost:5000/");
            var left = _driver.FindElement(By.CssSelector("input[name=OperandFirst]"));
            var right = _driver.FindElement(By.CssSelector("input[name=OperandSecond]"));
            var form = _driver.FindElement(By.CssSelector("form"));
            var rb = _driver.FindElement(By.CssSelector("input[value=Subtraction]"));


            rb.Click();

            left.SendKeys("2");
            right.SendKeys("1");
            rb.Click();
            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual(1.ToString(), output.Text);
        }
        [TestMethod]
        public void TestThatTheWebsiteMultiplies()
        {
            _driver.Navigate().GoToUrl("http://localhost:5000/");
            var left = _driver.FindElement(By.CssSelector("input[name=OperandFirst]"));
            var right = _driver.FindElement(By.CssSelector("input[name=OperandSecond]"));
            var form = _driver.FindElement(By.CssSelector("form"));
            var rb = _driver.FindElement(By.CssSelector("input[value=Multiplication]"));


            rb.Click();

            left.SendKeys("2");
            right.SendKeys("2");
            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual(4.ToString(), output.Text);
        }
        [TestMethod]
        public void TestThatTheWebsiteDivides()
        {
            _driver.Navigate().GoToUrl("http://localhost:5000/");
            var left = _driver.FindElement(By.CssSelector("input[name=OperandFirst]"));
            var right = _driver.FindElement(By.CssSelector("input[name=OperandSecond]"));
            var form = _driver.FindElement(By.CssSelector("form"));
            var rb = _driver.FindElement(By.CssSelector("input[value=Division]"));


            rb.Click();

            left.SendKeys("4");
            right.SendKeys("2");
            form.Submit();

            var output = _driver.FindElement(By.CssSelector("output"));
            Assert.AreEqual(2.ToString(), output.Text);
        }


    }
    }

