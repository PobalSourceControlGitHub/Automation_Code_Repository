using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;
using Automation_Suite.Constant;
using Automation_Suite.Utility_Tier;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal
{
    class ServiceCalendars
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.PartialLinkText, Using = "Sign In")]
        public IWebElement SignIn_Page { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement UserEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "submit-signin-local")]
        public IWebElement SubmitButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".dropdown:nth-child(3) .caret")]
        public IWebElement MyAccount_Toggle { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Service Calendar")]
        public IWebElement ServiceCalendar_Tab { get; set; }


        [FindsBy(How = How.PartialLinkText, Using = "Create Calendar")]
        public IWebElement CreateCalendar { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_programmecall")]
        public IWebElement Eyp_programmecall { get; set; }


        [FindsBy(How = How.CssSelector, Using = "option:nth-child(5)")]
        public IWebElement child5OptionClick { get; set; }


        [FindsBy(How = How.Id, Using = "NextButton")]
        public IWebElement NextButton { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_monopeningtime")]
        public IWebElement Eyp_monopeningtime { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_monclosingtime")]
        public IWebElement Eyp_monclosingtime { get; set; }


        [FindsBy(How = How.CssSelector, Using = "tr:nth-child(3) > .text:nth-child(2)")]
        public IWebElement child3OptClick { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_tueopeningtime")]
        public IWebElement Eyp_tueopeningtime { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_tueclosingtime")]
        public IWebElement Eyp_tueclosingtime { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_wedopeningtime")]
        public IWebElement Eyp_wedopeningtime { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_wedclosingtime")]
        public IWebElement Eyp_wedclosingtime { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_thuopeningtime")]
        public IWebElement Eyp_thuopeningtime { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_thuclosingtime")]
        public IWebElement Eyp_thuclosingtime { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_friopeningtime")]
        public IWebElement Eyp_friopeningtime { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_friclosingtime")]
        public IWebElement Eyp_friclosingtime { get; set; }



        public ServiceCalendars(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [TestMethod]
        public void ServiceCalendar_Page()
        {
            CommonUtils cookieIgnore = new CommonUtils(webDriver);
            cookieIgnore.RejectAll_Cookies();



            SignIn_Page.Click();


            Excel_Suite userEmail = new Excel_Suite(Env.EXCEL_TEST_URL);
            userEmail.getCellData("SPP_TestData", true);
            UserEmail.SendKeys(Env.Email_Id);
            Password.SendKeys("Test@123");

            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(800));
            System.Threading.Thread.Sleep(800);
            SubmitButton.Click();

            Thread.Sleep(1000);

            MyAccount_Toggle.Click();

            AJAXCall.WaitForAjax();
            ServiceCalendar_Tab.Click();


            CreateCalendar.Click();

            SelectElement ProgCell = new SelectElement(Eyp_programmecall);
            var ECCE2021 = "ECCE 2021";
            var ECCE2022 = "ECCE 2022";
           
            var NCS2020 = "NCS 2020";
            var NCS2021 = "NCS 2021";
            var NCS2022 = "NCS 2022";

            ProgCell.SelectByText(NCS2020);

            Thread.Sleep(800);
            NextButton.Click();

            var startDate = "09:00";
            var closeDate = "12:00";

            Eyp_monopeningtime.SendKeys(startDate);
            Eyp_monclosingtime.SendKeys(closeDate);

            Eyp_tueopeningtime.SendKeys(startDate);
            Eyp_tueclosingtime.SendKeys(closeDate);

            Eyp_wedopeningtime.SendKeys(startDate);
            Eyp_wedclosingtime.SendKeys(closeDate);

            Eyp_thuopeningtime.SendKeys(startDate);
            Eyp_thuclosingtime.SendKeys(closeDate);

            Eyp_friopeningtime.SendKeys(startDate);
            Eyp_friclosingtime.SendKeys(closeDate);

            Thread.Sleep(800);

            NextButton.Click();



        }
    }
}
