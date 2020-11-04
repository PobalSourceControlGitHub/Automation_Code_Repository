using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;
using Automation_Suite.Constant;
using Automation_Suite.Utility_Tier;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal
{
    class Feelist
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = ".idp:nth-child(4) .largeTextNoWrap")]
        private IWebElement pobalOption_Select { get; set; }

        [FindsBy(How = How.LinkText, Using = "Sign In")]
        public IWebElement SignIn_Page { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement UserEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }


        [FindsBy(How = How.Id, Using = "submit-signin-local")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".dropdown:nth-child(3) .caret")]
        public IWebElement MyAccount_Toggle { get; set; }

        [FindsBy(How = How.LinkText, Using = "Fees List")]
        public IWebElement FeesList_Link { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Create")]
        public IWebElement FeeCreate { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_programmecallid")]
        public IWebElement eyp_programmecallid_text { get; set; }

        [FindsBy(How = How.Id, Using = "NextButton")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.Id, Using = "Create")]
        public IWebElement createBtn { get; set; }
       


        [FindsBy(How = How.XPath, Using = " //*[@id='FeeOptionsList']/div/div/div[2]/div[1]/div/div/a")]
        public IWebElement createBox { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//td[6]/div/a/span")]
        public IWebElement EditLink { get; set; }
        

        [FindsBy(How = How.PartialLinkText, Using = "Edit")]
        public IWebElement EditButton { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_name")]
        public IWebElement Eyp_name { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_sessiontype")]
        public IWebElement Eyp_sessiontype { get; set; }

        [FindsBy(How = How.CssSelector, Using = "option:nth-child(2)")]
        public IWebElement Option { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_days")]
        public IWebElement Eyp_days { get; set; }


        [FindsBy(How = How.ClassName, Using = "input-append input-group datetimepicker")]
        public IWebElement Eyp_date { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_feeexcludingecce")]
        public IWebElement Eyp_feeexcludingecce { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_feeincludingecce3freehours")]
        public IWebElement Eyp_feeincludingecce3freehours { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".input-group-addon")]
        public IWebElement addonClick { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tr:nth-child(5) > .day:nth-child(4)")]
        public IWebElement childOption { get; set; }


        [FindsBy(How = How.Id, Using = "InsertButton")]
        public IWebElement InsertButton { get; set; }
       

        [FindsBy(How = How.CssSelector, Using = "#FeesExtras .view-toolbar .btn")]
        public IWebElement FeeExtraClick { get; set; }
        //switchTo().Frame(4)


        [FindsBy(How = How.Id, Using = "eyp_type")]
        public IWebElement Eyp_type { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_descriptionECCE")]
        public IWebElement eyp_descriptionECCE { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_name")]
        public IWebElement EypName_Text { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_agerange")]
        public IWebElement Eyp_agerange { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_ecceavailable")]
        public IWebElement Eyp_ecceavailable { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_fullpriceperweek")]
        public IWebElement Eyp_fullpriceperweek_Text { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_daysperweek")]
        public IWebElement Eyp_daysperweek { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_hoursperweek")]
        public IWebElement Eyp_hoursperweek { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//div/fieldset[1]/table/tbody/tr[9]/td[1]/div[2]/div/input")]
        public IWebElement Effective_Date { get; set; }

        //switchTo.ParentFrame
        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement Submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ccc-reject-settings']")]
        public IWebElement CookiesSession_popup { get; set; }


        public Feelist(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [TestMethod]

        public void FeeList_Submission_SPP()
        {
            AJAXCall.WaitForAjax();
            Thread.Sleep(900);

            CommonUtils cookiesScreen = new CommonUtils(driver);
            cookiesScreen.RejectAll_Cookies();

            Thread.Sleep(900);
            SignIn_Page.Click();


            Excel_Suite userEmail = new Excel_Suite(Env.EXCEL_TEST_URL);
            userEmail.getCellData("SPP_TestData", true);
            UserEmail.SendKeys(Env.Email_Id);
            Password.SendKeys("Test@123");

            

            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(800));
            Thread.Sleep(800);
            SubmitButton.Click();

            MyAccount_Toggle.Click();

            AJAXCall.WaitForAjax();
            FeesList_Link.Click();

            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);
            EditLink.Click();
            EditButton.Click();

            createBox.Click();
            Thread.Sleep(800);

            driver.SwitchTo().Frame(1);

            Eyp_name.SendKeys("TestAutomation");

            Eyp_agerange.SendKeys("5-10");

            SelectElement option = new SelectElement(Eyp_ecceavailable);
            option.SelectByText("Yes");

            Eyp_fullpriceperweek_Text.SendKeys("100.00");

            Thread.Sleep(800);
            Eyp_daysperweek.SendKeys("5");
            Eyp_hoursperweek.SendKeys("40");


            Effective_Date.SendKeys("01/11/2020");

            InsertButton.Click();
            AJAXCall.WaitForAjax();
            driver.SwitchTo().DefaultContent();


        }



    }
}
