using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Automation_Suite.Utility_Tier
{
    class AJAXCall 
    {
        static IWebDriver driver;
               
        public static void WaitForAjax_1()
        {
            WebDriverWait wait = new WebDriverWait(ReportsGeneration._driver, TimeSpan.FromSeconds(100));
            wait.Until(driver => (bool)((IJavaScriptExecutor)driver).
            ExecuteScript("return window.jQuery != undefined && jQuery.active === 0"));
        }

        public static void WaitForAjax()
        {
            var wait = new WebDriverWait(ReportsGeneration._driver, TimeSpan.FromSeconds(900));
            wait.Until(d => (bool)(d as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0"));
        }


        public static void WaitForReady(IWebDriver webdriver)
        {
            WebDriverWait wait = new WebDriverWait(ReportsGeneration._driver, TimeSpan.FromSeconds(100));
            wait.Until(driver =>
            {
                bool isAjaxFinished = (bool)((IJavaScriptExecutor)ReportsGeneration._driver).
                    ExecuteScript("return jQuery.active == 0");
                try
                {
                    ReportsGeneration._driver.FindElement(By.ClassName("spinner"));
                    return false;
                }
                catch
                {
                    return isAjaxFinished;
                }
            });    
        }

        

        public static void CheckPageIsLoaded(IWebDriver driver)
        {
            while (true)
            {
                bool ajaxIsComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                    return;
                Thread.Sleep(100);
            }
        }

        public static bool IsElementPresent(By by)
        {
            try
            {
                ReportsGeneration._driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        public static void sendKeys(IWebElement element, string text)
        {
            element.Click();

            Thread.Sleep(800);
            Actions actions = new Actions(ReportsGeneration._driver);
            foreach (char c in text)
            {
                actions.SendKeys(c.ToString())
                    .Perform();
            }
        }

        public static string waitForElementNotVisible(int timeOutInSeconds, IWebDriver driver, IWebElement elementXPath)
        {
            if ((driver == null) || (elementXPath == null) || elementXPath.GetAttribute("value").Equals(" "))
            {

                return "Wrong usage of WaitforElementNotVisible()";
            }
            try
            {
                
               // new WebDriverWait(driver, TimeSpan.FromSeconds(900)).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(elementXPath)));
                return null;
            }
            catch (TimeoutException e)
            {
                return "Build your own errormessage...";
            }
        }

        public static void scrollToBottomPage()
        {
            Actions actions = new Actions(ReportsGeneration._driver);
            actions.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();
        }
    }


}

