using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Suite.Utility_Tier
{   

     class WaitUtil
    {
        private static IWebDriver driver;
        public static void WaitForElementExplicitly(IWebDriver driver, int WaitInMilliSeconds = 3000, By Selector = null)
        {
            string frameLocator = null;
            WebDriverWait wait = new WebDriverWait(driver , TimeSpan.FromSeconds(200));
            wait.Until<IWebDriver>(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(frameLocator));
        }





    }
}
