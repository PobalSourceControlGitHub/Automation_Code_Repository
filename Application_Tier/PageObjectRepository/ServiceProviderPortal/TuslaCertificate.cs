using Automation_Suite.Application_Tier.CRM;
using Automation_Suite.Configuration_Tier;
using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Automation_Suite.Constant;
using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal
{
    class TuslaCertificate
    {
      
        private IWebDriver webDriver;
        
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

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Tusla Certificate')]")]
        public IWebElement TuslaCertificateLink { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Add Tusla Registration")]
        public IWebElement AddTusla_Button { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_tuslanumber")]
        public IWebElement TuslaText { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".entity-action-button")]
        public IWebElement actionButton { get; set; }


        [FindsBy(How = How.Id, Using = "NextButton")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Upload Certificate")]
        public IWebElement UploadtuslaCert { get; set; }
        //driver.SwitchTo().Frame(1)

        [FindsBy(How = How.Id, Using = "eyp_documenttypeid")]
        public IWebElement eyp_documenttypeid_dropdown { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_description")]
        public IWebElement eyp_descriptiontextBox { get; set; }

        [FindsBy(How = How.Id, Using = "InsertButton")]
        public IWebElement submitButton { get; set; }

        [FindsBy(How = How.Id, Using = "TabstmProvider")]
        private IWebElement tabCRM { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id='TabstmProvider']/a/span/span")]
        private IWebElement CRM_TabOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='detailActionGroupControl']/ul/li[4]/span/span/span/span/li[2]/a")]
        private IWebElement tuslaTab { get; set; }

        
        [FindsBy(How = How.Id, Using = "crmGrid_findCriteria")]
        private IWebElement crmGrid_FindCriteria { get; set; }


        [FindsBy(How = How.XPath, Using = "//table[@id='gridBodyTable']/tbody/tr/td[2]/nobr/a")]
        private IWebElement crmGrid_Click { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_onboardingstage_lookupValue")]
        private IWebElement active_click { get; set; }

        [FindsBy(How = How.Id, Using = "crmQuickFindTD")]
        private IWebElement crmSearchGrid { get; set; }

        [FindsBy(How = How.Id, Using = "FormSecNavigationControl-Icon")]
        public IWebElement NavigationFlyOut_Button { get; set; }

        //#flyoutFormSection_ReviewApprovalProcess #flyoutFormSection_Anchor
        [FindsBy(How = How.CssSelector, Using = "#flyoutFormSection_ReviewApprovalProcess > #flyoutFormSection_Cell")]
        public IWebElement Review_Click { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_onboardingstage_lookupValue")]
        public IWebElement Oboarding_Stage { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_name_i")]
        public IWebElement eyp_name { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[2]/span/a/span")]
        public IWebElement SaveAndClose { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_markasapproved_i")]
        public IWebElement approve_chkBox { get; set; }

        [FindsBy(How = How.Id, Using = "userNameInput")]
        private IWebElement userName { get; set; }

        [FindsBy(How = How.Id, Using = "passwordInput")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "submitButton")]
        private IWebElement signIN { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#viewSelectorContainer div")]
        private IWebElement ViewSelectorContainer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ccc-reject-settings']")]
        public IWebElement CookiesSession_popup { get; set; }

        public TuslaCertificate(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [TestMethod]
        public void TuslaSubmission()
        {
            AJAXCall.WaitForAjax();
            Thread.Sleep(900);

            CommonUtils CookiesAction = new CommonUtils(webDriver);
            CookiesAction.RejectAll_Cookies();
            Thread.Sleep(900);

            SignIn_Page.Click();


            Excel_Suite userEmail = new Excel_Suite(Env.EXCEL_TEST_URL);
            userEmail.getCellData("SPP_TestData", true);
            UserEmail.SendKeys(Env.Email_Id);
            Password.SendKeys("Test@123");

            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(800));
            Thread.Sleep(800);
            SubmitButton.Click();

            MyAccount_Toggle.Click();

            TuslaCertificateLink.Click();


            AddTusla_Button.Click();

            var tuslaNum = Constant_functions.randomString(2);
            Constant_functions.tuslaNumber = tuslaNum + "1380";
            TuslaText.SendKeys(Constant_functions.tuslaNumber);
            actionButton.Click();
            NextButton.Click();

            Thread.Sleep(1000);

            UploadtuslaCert.Click();
            Thread.Sleep(1000);

            webDriver.SwitchTo().Frame(1);

            Thread.Sleep(1000);
            AJAXCall.WaitForReady(webDriver);

            // docOption.Click();
            SelectElement docSelection = new SelectElement(eyp_documenttypeid_dropdown);
            docSelection.SelectByText("TUSLA Certificate");
            

            IWebElement upload = webDriver.FindElement(By.Id("AttachFile"));
            upload.SendKeys("C:\\temp\\Tech_Cities_Future_report.pdf");

            webDriver.FindElement(By.Id("InsertButton")).Click();
           
            Thread.Sleep(1000);
            AJAXCall.WaitForReady(webDriver);
            webDriver.SwitchTo().DefaultContent();

            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.scrollBy(0,500)", "");

            js.ExecuteScript("arguments[0].scrollIntoView();", NextButton);
            Thread.Sleep(500);
            ReportsGeneration._test.Log(Status.Pass, "SPP TUSLA CERT" + "      " + webDriver.Url + "      " + "PASSED");

            if(AJAXCall.IsElementPresent(By.Id("NextButton")))
            {
                NextButton.Click();
            }
            else
            {
                js = (IJavaScriptExecutor)webDriver;
                js.ExecuteScript("arguments[0].scrollIntoView();", NextButton);
                NextButton.Click();
            }
            Thread.Sleep(900);

            //Get Parent window handle
            var winHandleBefore = webDriver.CurrentWindowHandle;
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void TuslaCRM_Approval()
        {
            webDriver.Navigate().GoToUrl(URLConfig.CRM_SPP_Frame);

            Thread.Sleep(800);
            if (AJAXCall.IsElementPresent(By.CssSelector(".idp:nth-child(4) .largeTextNoWrap")))
            {
                pobalOption_Select.Click();
            }
            userName.SendKeys(Credentials_Data.UserName);
            password.SendKeys(Credentials_Data.Password);

            signIN.Click();
            AJAXCall.WaitForReady(webDriver);

            Thread.Sleep(1000);

            CRM_TabOptions.Click();
            Thread.Sleep(1500);

            tuslaTab.Click();

            Thread.Sleep(500);
            webDriver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);

            //webDriver.SwitchTo().Frame("contentIFrame1");
            webDriver.SwitchTo().Frame(0);
            Thread.Sleep(500);

            ViewSelectorContainer.Click();
            webDriver.FindElement(By.Id("crmGrid_findCriteria")).Click();
            Thread.Sleep(500);

            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(800));
            Thread.Sleep(1000);



            if (AJAXCall.IsElementPresent(By.Id("crmGrid_findCriteria")) || crmGrid_FindCriteria.Displayed)
            {
                //crmSearchGrid.Click();

                IWebElement clickwebforms = webDriver.FindElement(By.Id("crmGrid_findCriteria"));
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(800));


                IWebElement wb = webDriver.FindElement(By.Id("crmGrid_findHintText"));
                var value = wb.GetAttribute("style");

                AJAXCall.WaitForAjax();

                if (value.Contains("display: none;"))
                {

                    AJAXCall.WaitForAjax();

                    clickwebforms.Click();
                    if (value.Contains("display: none;"))
                    {
                        Thread.Sleep(1000);
                        clickwebforms.Click();                      

                        Thread.Sleep(900);
                        clickwebforms.SendKeys(Constant_functions.tuslaNumber);
                        AJAXCall.WaitForAjax();
                        clickwebforms.SendKeys(Keys.Enter);
                        Thread.Sleep(1000);
                    }
                }
                else
                {

                    Thread.Sleep(1000);
                    clickwebforms.Click();
                    if (value.Contains("display: inline;"))
                    {
                        Thread.Sleep(1000);
                        clickwebforms.Click();

                        Thread.Sleep(900);
                        clickwebforms.SendKeys(Constant_functions.tuslaNumber);
                      
                        AJAXCall.WaitForAjax();
                        Thread.Sleep(1000);
                        clickwebforms.SendKeys(Keys.Enter);
                        Thread.Sleep(1000);
                    }
                }
            }
            Thread.Sleep(1000);

            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(800));

            CRM_UAT_ServiceProviderPortal_Page tuslaCRMPage = new CRM_UAT_ServiceProviderPortal_Page(webDriver);
            tuslaCRMPage.OnBoardingAdmin();

            webDriver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);
            webDriver.SwitchTo().Frame(0);

            webDriver.SwitchTo().ParentFrame();
            Thread.Sleep(2000);

            webDriver.SwitchTo().Frame(1);
            Thread.Sleep(2000);


            Thread.Sleep(2000);
            if (AJAXCall.IsElementPresent(By.XPath("//*[@id='FormSecNavigationControl - Icon']")))
            {

                NavigationFlyOut_Button.Click();
                Review_Click.Click();
            }

            else
            {
                Actions action = new Actions(webDriver);
                action.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();
            }
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.scrollBy(0,250)", "");

            Thread.Sleep(1000);
            
            IWebElement chkBox_td = webDriver.FindElement(By.Id("eyp_markasapproved_d"));
            var td = chkBox_td.GetAttribute("class");
            Thread.Sleep(2000);

            approve_chkBox.Click();
            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);

            webDriver.SwitchTo().DefaultContent();

            AJAXCall.WaitForAjax();
            Thread.Sleep(800);

            SaveAndClose.Click();
            webDriver.SwitchTo().Frame(1);

            Thread.Sleep(1000);
           // webDriver.SwitchTo().DefaultContent();
            AJAXCall.WaitForAjax();

            
        }

    }
}
