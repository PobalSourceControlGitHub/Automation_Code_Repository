using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;
using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal
{
    class Programmes
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


        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Programmes')]")]
        public IWebElement ProgrammesTab { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='ProgrammeApplicationListView']/div/div/div[1]/table/tbody/tr")]
        public IList<IWebElement> NCS_Selection { get; set; }

        [FindsBy(How = How.Id, Using = "submit-signin-local")]
        public IWebElement signEmailId { get; set; }


        [FindsBy(How = How.Id, Using = "NextButton")]
        public IWebElement NextButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//fieldset[2]")]
        public IWebElement AgreeBtn { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_paucertified_label")]
        public IWebElement Eyp_paucertified_label { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".checkbox")]
        public IWebElement CheckBoxSelection { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_organisationcertified_label")]
        public IWebElement Eyp_organisationcertified_label { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_bankaccountcertified_label")]
        public IWebElement Eyp_bankaccountcertified_label { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_bankaccount_name")]
        public IWebElement Eyp_bankaccount_name { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".launchentitylookup > .fa")]
        public IWebElement searchLookUp_Button { get; set; }


        [FindsBy(How = How.CssSelector, Using = "//button[contains(.,'Select')]")]
        public IWebElement selectBank { get; set; }  

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Select')]")]
        public IWebElement selectButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='eyp_serviceproviderusercertified_label']")]
        public IWebElement Eyp_serviceproviderusercertified_label { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_tuslaregistrationcertified_label")]
        public IWebElement Eyp_tuslaregistrationcertified_label { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_servicecalendarcertified_label")]
        public IWebElement Eyp_servicecalendarcertified_label { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_feeslistcertified_label")]
        public IWebElement Eyp_feeslistcertified_label { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".launchentitylookup > .fa")]
        public IWebElement submitButton { get; set; }
       

        [FindsBy(How = How.XPath, Using = " //*[@id='eyp_serviceprovidercertified_label']")]
        public IWebElement confirmServiceProvider { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_complywithcovid19_label")]
        public IWebElement Eyp_complywithcovid19_label { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='eyp_declarationaccepted_label']")]
        public IWebElement confirmContractActivation { get; set; }

        
        [FindsBy(How = How.ClassName, Using = "btn-group entity-action-button")]
        public IWebElement Final_SubmitButton { get; set; }

        public Programmes(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }



        [TestMthod]
        public void ProgrammePage()
        {

            CommonUtils cookieIgnore = new CommonUtils(driver);
            cookieIgnore.RejectAll_Cookies();

            SignIn_Page.Click();


            Excel_Suite userEmail = new Excel_Suite(Env.EXCEL_TEST_URL);
            userEmail.getCellData("SPP_TestData", true);
            UserEmail.SendKeys(Env.Email_Id);
            Password.SendKeys("Test@123");

            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(800));
            Thread.Sleep(800);
            signEmailId.Click();

            ProgrammesTab.Click();

            Thread.Sleep(1000);

            // value = NCS_Selection.GetAttribute("data-name");

            for(int i=1; i<=NCS_Selection.Count; i++)
            {
                IWebElement ncsVal = driver.FindElement(By.XPath("//*[@id='ProgrammeApplicationListView']/div/div/div[1]/table/tbody/tr" + "[" +i+ "]"));
                string val = ncsVal.Text;
                if (val.Contains("NCS 2020"))
                {
                    ncsVal.Click();
                    break;
                }
            }
            
            

            NextButton.Click();

            NextButton.Click();
            Eyp_paucertified_label.Click();

            NextButton.Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)", "");

            js.ExecuteScript("arguments[0].scrollIntoView();", Eyp_organisationcertified_label);
            Thread.Sleep(500);
            Eyp_organisationcertified_label.Click();

            ReportsGeneration._test.Log(Status.Pass, "SPP PROGRAMMES NCS" + "      " + driver.Url + "      " + "PASSED");

            NextButton.Click();

            searchLookUp_Button.Click();

            Thread.Sleep(500);
            selectButton.Click();

            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,500)", "");

            js.ExecuteScript("arguments[0].scrollIntoView();", Eyp_bankaccountcertified_label);
            Thread.Sleep(1000);

            Eyp_bankaccountcertified_label.Click();
            NextButton.Click();


            Eyp_serviceproviderusercertified_label.Click();
            NextButton.Click();
            confirmServiceProvider.Click();

            NextButton.Click();
            Eyp_tuslaregistrationcertified_label.Click();

            NextButton.Click();
            
            js.ExecuteScript("window.scrollBy(0,500)", "");

            js.ExecuteScript("arguments[0].scrollIntoView();", Eyp_servicecalendarcertified_label);
            Thread.Sleep(500);
            Eyp_servicecalendarcertified_label.Click();

            NextButton.Click();
            js.ExecuteScript("window.scrollBy(0,500)", "");

            js.ExecuteScript("arguments[0].scrollIntoView();", Eyp_feeslistcertified_label);
            Thread.Sleep(500);
            Eyp_feeslistcertified_label.Click();

            NextButton.Click();

            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0,500)", "");
            if (AJAXCall.IsElementPresent(By.Id("eyp_complywithcovid19_label")))
            {

                Eyp_complywithcovid19_label.Click();
                NextButton.Click();
            }

            AJAXCall.scrollToBottomPage();
            confirmContractActivation.Click();
            Thread.Sleep(500);
            
            NextButton.Click();
        }
    }
}
