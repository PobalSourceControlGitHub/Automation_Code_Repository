using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal
{
    class Cookies
    {
        private IWebDriver Instance;
        public Cookies(IWebDriver webDriver)
        {
            this.Instance = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        public  void getAllCookies()
        {
            IList<Cookie> cookies = Instance.Manage().Cookies.AllCookies;
            Console.WriteLine(cookies);

            foreach(Cookie cc in cookies)
            {
                Console.WriteLine(cc.Name);
                ReportsGeneration._test.Log(Status.Pass,"cookie Name= "+  cc.Name + "  cookie IsHttpOnly= " + cc.IsHttpOnly + "  Domain Name =" +cc.Domain  +"  "+" Value =" +cc.Name + "Expiry=" +cc.Expiry +" "+  "Cookies KEY VALUE");          
            }
        }
    }
 }

