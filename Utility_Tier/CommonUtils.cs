using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Suite.Utility_Tier
{
    class CommonUtils
    {

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='ccc-reject-settings']")]
        public IWebElement CookiesSession_RejectAll { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='ccc-recommended-settings']")]
        public IWebElement CookiesSession_AcceptAll { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//*[@id='ccc-optional-categories']/div[1]/div/label/span[3]")]
        public IWebElement AnalyticalCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ccc-optional-categories']/div[2]/div/label/span[3]")]
        public IWebElement NonFunctionaCookies { get; set; }

        [FindsBy(How = How.CssSelector, Using = "svg:nth-child(1) > path")]
        public IWebElement crossButton { get; set; }


        public CommonUtils(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }


        [TestMethod]
        public void RejectAll_Cookies()
        {
            
            Thread.Sleep(1000);
            if (AJAXCall.IsElementPresent(By.XPath("//*[@id='ccc-reject-settings']")))
            {
                CookiesSession_RejectAll.Click();

                ReportsGeneration._test.Log(Status.Pass, "Service Provider Portal Application" + "    " + "Cookies Reject ALL " + "           " + "PASSED");
            }

        }

        [TestMethod]
        public void AcceptAll_Cookies()
        {

            if (AJAXCall.IsElementPresent(By.XPath("//*[@id='ccc-recommended-settings']")))
            {

                Thread.Sleep(1000);
                CookiesSession_AcceptAll.Click();

                ReportsGeneration._test.Log(Status.Pass, "Service Provider Portal Application" + "    " + "Cookies Accept ALL " + "           " + "PASSED");
            }
        }

        [TestMethod]
        public void AnalyticalCookies_On()
        {
            Thread.Sleep(1000);
            if (AJAXCall.IsElementPresent(By.XPath("//*[@id='ccc-optional-categories']/div[1]/div/label/span[3]")))
            {
               
                AnalyticalCookies.Click();
                ReportsGeneration._test.Log(Status.Pass, "Service Provider Portal Application" + "    " + "Analytical Cookies" + "           " + "PASSED");
            }
        }

        [TestMethod]
        public void NonFunctionaCookies_On()
        {
            Thread.Sleep(1000);
            if (AJAXCall.IsElementPresent(By.XPath("//*[@id='ccc-optional-categories']/div[2]/div/label/span[3]")))
            {
                NonFunctionaCookies.Click();

                ReportsGeneration._test.Log(Status.Pass, "Service Provider Portal Application" + "    " + "Non Functional Cookies" + "           " + "PASSED");
            }
        }

        [TestMethod]
        public void CloseCookiePage_CrossButton()
        {
            
            Thread.Sleep(1000);

            crossButton.Click();

            ReportsGeneration._test.Log(Status.Pass, "Service Provider Portal Application" + "    " + "Close all Cookies -X cross button" + "           " + "PASSED");
        }
    }
}
        

    

