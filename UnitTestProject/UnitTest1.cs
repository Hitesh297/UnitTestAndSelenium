using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Work;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Calculate _cal = new Calculate();
        [TestMethod]
        public void TestMethod1()
        {
            int userInput1 = 12;
            int userInput2 = 10;
            int result = _cal.Add(userInput1, userInput2);
            Assert.AreEqual(22, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string userInput1 = "12";
            string userInput2 = "10";
            var driver = new OpenQA.Selenium.IE.InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://localhost/demo/test");
            driver.FindElementByXPath("//*[@id='Value1']").SendKeys(userInput1);
            driver.FindElementByXPath("//*[@id='Value2']").SendKeys(userInput2);
            driver.FindElementByXPath("/html/body/div[2]/form/div/div[3]/div/input").SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);
            var result = driver.FindElementByXPath("/html/body/div[2]/h2").Text;
            Assert.AreEqual("22", result);
            driver.Dispose();
        }
    }
}
