using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;
using Automation_Suite.Utility_Tier;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal
{
    class RegistartionTab
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email_Text { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password_Text { get; set; }

        [FindsBy(How = How.LinkText, Using = "Sign In")]
        public IWebElement SignIn_Page { get; set; }

        [FindsBy(How = How.Id, Using = "submit-signin-local")]
        public IWebElement Submit { get; set; }      

        [FindsBy(How = How.CssSelector, Using = ".dropdown:nth-child(3) .caret")]
        public IWebElement dropdownCaret { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".dropdown:nth-child(7) > .dropdown-toggle")]
        public IWebElement dropdown_NCS { get; set; }


        [FindsBy(How = How.PartialLinkText, Using = "NCS Registrations")]
        public IWebElement NCS_Tab { get; set; }


        [FindsBy(How = How.PartialLinkText, Using = "Retrieve a CHICK")]
        public IWebElement RetrieveCHICK { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_firstname")]
        public IWebElement Eyp_firstname { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_lastname")]
        public IWebElement Eyp_lastname { get; set; }


        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[3]/td[1]/div[2]/div/input")]
        public IWebElement DateOfBirth { get; set; }
        
        [FindsBy(How = How.Id, Using = "eyp_chic")]
        public IWebElement Eyp_chic { get; set; }

        [FindsBy(How = How.Id, Using = "NextButton")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".fa-chevron-circle-down")]
        public IWebElement circleDown { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".btn-xs")]
        public IWebElement btnXs { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Edit")]
        public IWebElement EditLink { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_claimedhours")]
        public IWebElement Claimedhours { get; set; }


        [FindsBy(How = How.Id, Using = "UpdateButton")]
        public IWebElement updateButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".dropdown:nth-child(3) .caret")]
        public IWebElement caretDropDown { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Service Provider")]
        public IWebElement ServiceProvider { get; set; }
        

        [FindsBy(How = How.PartialLinkText, Using = "Create Calendar")]
        public IWebElement CreateCalendar { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_programmecall")]
        public IWebElement Eyp_programmecall { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_monopeningtime")]
        public IWebElement Monopeningtime { get; set; }

        [FindsBy(How = How.Id, Using = "//input[@type='text'])[8]")]
        public IWebElement StartDate { get; set; }

        [FindsBy(How = How.Id, Using = "//input[@type='text'])[10]")]
        public IWebElement EndDate { get; set; }


       
        public RegistartionTab(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }
        /* driver.FindElement(By.CssSelector(".datepicker-days .next > .glyphicon")).Click();
         {
             var element = driver.FindElement(By.CssSelector(".datepicker-days .next > .glyphicon"));
             Actions builder = new Actions(driver);
         builder.DoubleClick(element).Perform();
         } */

      
        

        public void RegistrationPage()
        {

            CommonUtils cookieIgnore = new CommonUtils(driver);
            cookieIgnore.RejectAll_Cookies();

            SignIn_Page.Click();


            Excel_Suite userEmail = new Excel_Suite(Env.EXCEL_TEST_URL);
            userEmail.getCellData("SPP_TestData", true);
            Email_Text.SendKeys(Env.Email_Id);
            Password_Text.SendKeys("Test@123");

            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(800));
            Thread.Sleep(800);
            Submit.Click();


            dropdown_NCS.Click();
            NCS_Tab.Click();

            RetrieveCHICK.Click();

            Excel_Suite childDataExcel = new Excel_Suite(Env.EXCEL_TEST_CHILD_DATA);
            ChildAward_Data ChildData = childDataExcel.GetChildDetails(Env.EXCEL_TEST_CHILD_DATA);
            

            Eyp_firstname.SendKeys(ChildData.ChildFirstName);
            Eyp_lastname.SendKeys(ChildData.ChildLastName);

            DateOfBirth.SendKeys(ChildData.DateOfBirth);
            Eyp_chic.SendKeys(ChildData.ChildIdentifierCode);
            
            NextButton.Click();

            StartDate.SendKeys("");

            EndDate.SendKeys("");

            NextButton.Click();

            Claimedhours.SendKeys("4");

            
        }

    }
}
