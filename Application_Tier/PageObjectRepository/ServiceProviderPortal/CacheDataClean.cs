using Automation_Suite.Utility_Tier;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal
{
    class CacheDataClean
    {
        private IWebDriver driver;
        private object thread;

        [FindsBy(How = How.CssSelector, Using = "#clearBrowsingDataConfirm")]
        private IWebElement cleanDataBtn { get; set; }

        public CacheDataClean(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [TestMethod]
        public void cacheData()
        {
            driver.Navigate().GoToUrl("chrome://settings/clearBrowserData");

            
            
            IWebElement root1 = driver.FindElement(By.CssSelector("settings-ui"));
            IWebElement shadowRoot1 = expandRootElement(root1, driver);
            IWebElement root2 = shadowRoot1.FindElement(By.CssSelector("settings-main"));
            IWebElement shadowRoot2 = expandRootElement(root2, driver);
            IWebElement root3 = shadowRoot2.FindElement(By.CssSelector("settings-basic-page"));
            IWebElement shadowRoot3 = expandRootElement(root3, driver);
            IWebElement root4 = shadowRoot3.FindElement(By.CssSelector("settings-section > settings-privacy-page"));
            IWebElement shadowRoot4 = expandRootElement(root4, driver);
            IWebElement root5 = shadowRoot4.FindElement(By.CssSelector("settings-clear-browsing-data-dialog"));
            IWebElement shadowRoot5 = expandRootElement(root5, driver);
            IWebElement root6 = shadowRoot5.FindElement(By.CssSelector("#clearBrowsingDataDialog"));
            IWebElement root7 = root6.FindElement(By.CssSelector("cr-tabs[role='tablist']"));

            root7.Click();

            IWebElement clearDataButton = root6.FindElement(By.CssSelector("#clearBrowsingDataConfirm"));

            clearDataButton.Click();
        }

        private static IWebElement expandRootElement(IWebElement element, IWebDriver driver)
        {
            return (IWebElement)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].shadowRoot", element);
        }
    }

}
    
