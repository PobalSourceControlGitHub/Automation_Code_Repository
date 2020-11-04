using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;
using Automation_Suite.Application_Tier.CRM;
using Automation_Suite.Configuration_Tier;
using Automation_Suite.Constant;
using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Automation_Suite.Application_Tier.PageObjectRepository.CRM
{
    class CRM_Bank_Page
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.XPath, Using = "//span[@id='TabstmProvider']/a/span/span")]
        private IWebElement CRM_TabOptions { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#NewSubArea_cd3e4525 > .nav-rowLabel")]
        private IWebElement Email_Link { get; set; }


        [FindsBy(How = How.XPath, Using = "//table[@id='gridBodyTable']/tbody/tr/td[2]/nobr/a")]
        private IWebElement Email_section { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Complete your Registration in the Early Years Hive")]
        private IWebElement Complete_Reg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='bySelection']/div[3]/div/span")]
        private IWebElement pobalOption_Select { get; set; }

        [FindsBy(How = How.Id, Using = "userNameInput")]
        private IWebElement userName { get; set; }

        [FindsBy(How = How.Id, Using = "passwordInput")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "submitButton")]
        private IWebElement signIN { get; set; }

        [FindsBy(How = How.XPath, Using = "xpath=//div[@id='bySelection']/div[3]/div/span")]
        private IWebElement crm_Frame_SSP { get; set; }
        //css=

        [FindsBy(How = How.CssSelector, Using = "#onboardingarea > .nav-rowLabel")]
        private IWebElement onboardingTab { get; set; }

        [FindsBy(How = How.Id, Using = "TabstmProvider")]
        private IWebElement tabCRM { get; set; }


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

        [FindsBy(How = How.Id, Using = "submit-redeem-invitation")]
        public IWebElement submit_RedeemActivateButtn { get; set; }


        [FindsBy(How = How.Id, Using = "InvitationCode")]
        public IWebElement InvitationCode_Textfield { get; set; }

        [FindsBy(How = How.Id, Using = "ContentContainer_MainContent_MainContent_PasswordTextBox")]
        public IWebElement Newuser_Password { get; set; }

        [FindsBy(How = How.Id, Using = "ContentContainer_MainContent_MainContent_ConfirmPasswordTextBox")]
        public IWebElement ConfirmNewuser_Password { get; set; }

        [FindsBy(How = How.Id, Using = "ContentContainer_MainContent_MainContent_SubmitButton")]
        public IWebElement Register_New_user { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_dataprotectionacceptance_label")]
        public IWebElement accept_rule { get; set; }


        [FindsBy(How = How.Id, Using = "UpdateButton")]
        public IWebElement Update_Submitbtn { get; set; }
        //div[@id='detailActionGroupControl']/ul/li[3]/span/span/span/span/li[2]/a

        [FindsBy(How = How.XPath, Using = " //div[@id='detailActionGroupControl']/ul/li[3]/span/span/span/span/li[2]/a")]
        public IWebElement BankAccount_Link { get; set; }

        

        [FindsBy(How = How.XPath, Using = "//*[@id='crmGrid_gridBar']/tbody/tr/th[2]/table/tbody/tr/td[1]/a")]
        public IWebElement arrowDown { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_markasapproved_i")]
        public IWebElement approve_chkBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='FormSecNavigationControl - Icon']")]
        public IWebElement navigationImageLink { get; set; }

       
        [FindsBy(How = How.CssSelector, Using = ".ms-crm-inlineheader-content")]
        public IWebElement crmContentLink { get; set; }



        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Validation / Approval Process')]")]
        public IWebElement ValidationApprovalLink { get; set; }

        public CRM_Bank_Page(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [TestMethod]
        public string getBankCodeString(string HtmlString)
        {

            string[] arr = HtmlString.Split(new[] { "<br>" }, StringSplitOptions.None);
            foreach (string value in arr)
                if (value.Contains("code"))
                {

                    Console.WriteLine(value);


                    Constant_functions.emailActivateURL += value;

                    string[] banktextCode = value.Split(new[] { ":" }, StringSplitOptions.None);
                    Constant_functions.bankCode += banktextCode[1].TrimStart();
                    return value;



                }

            Console.WriteLine();


            return "";
        }


        [TestMethod]
        public void Bank_CodeActivation(IWebDriver driver)
        {

            try
            {

                Thread.Sleep(4000);
                pobalOption_Select.Click();

                userName.SendKeys("asrivastava@pobal.ie");
                userName.Clear();

                userName.SendKeys("asrivastava@pobal.ie");
                password.SendKeys(Credentials_Data.Password);

                signIN.Click();

                webDriver.Navigate().GoToUrl(URLConfig.CRM_SPP_Frame);


                Thread.Sleep(800);

                CRM_TabOptions.Click();

                AJAXCall.WaitForAjax();
                Thread.Sleep(900);
                Email_Link.Click();


                AJAXCall.WaitForReady(driver);
                Thread.Sleep(1000);

                webDriver.SwitchTo().Frame(0);

                var Email_Sequence = "//table[@id='gridBodyTable']/tbody/tr/td";
                Thread.Sleep(2000);
                for (int i = 1; i < 100; i++)
                {

                    var mesg = Email_Sequence + "[" + i + "]/nobr/a";


                    IWebElement wb = webDriver.FindElement(By.XPath("//table[@id='gridBodyTable']/tbody/tr" + "[" + i + "]" + "/td[2]/nobr/a"));
                    var EmailText = wb.Text;


                    AJAXCall.WaitForAjax();
                    Thread.Sleep(1000);

                    if (EmailText.Contains("Bank Account Validation Code"))
                    {


                        //webDriver.FindElement(By.XPath("//table[@id='gridBodyTable']/tbody/tr" + "[" + i + "]" + "/td[2]/nobr/a")).Click();
                        webDriver.FindElement(By.XPath("//table[@id='gridBodyTable']/tbody/tr/td[2]/nobr/a")).Click();
                        break;
                    }


                    else if (EmailText.Contains("Bank"))
                    {

                        Console.WriteLine(EmailText);
                    }



                }
                Thread.Sleep(1000);

                webDriver.SwitchTo().DefaultContent();



                IList<IWebElement> frames;
                frames = webDriver.FindElements(By.TagName("iframe"));

                int totalFrames = frames.Count;
                Dictionary<int, string> frameNamesIDs = new Dictionary<int, string>();
                for (int i = 0; i < frames.Count; i++)
                {
                    frameNamesIDs.Add(i, frames[i].GetAttribute("id").ToString());

                }

                webDriver.SwitchTo().Frame("contentIFrame1");

                Thread.Sleep(1000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                webDriver.SwitchTo().Frame("descriptionEditIFrame");

                Thread.Sleep(1000);

                IWebElement message = webDriver.FindElement(By.XPath("/html/body/div/p/span[2]"));
                //var text_link = message.GetAttribute("textContent");

                var bankCode = message.GetAttribute("innerHTML");


                getBankCodeString(bankCode);
                ReportsGeneration._test.Log(Status.Pass, "         " + bankCode + "         " + "PASSED");
                Thread.Sleep(1000);

                var newVal = Constant_functions.bankCode;

                Excel_Suite Ex = new Excel_Suite(@"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\TestData_Repository\BankCode.xlsx");
                Ex.SetBankCellData("Bank_Sheet", "BankActivationCode", newVal);


                // Adds resources to the resource writer.


                Thread.Sleep(500);
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            }





            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail("Failed");

            }
        }

        [TestMethod]
        public void BankApproval()
        {
            try
            {
               
                AJAXCall.WaitForAjax();

                Thread.Sleep(2000);
                tabCRM.Click();
                Thread.Sleep(1500);

                BankAccount_Link.Click();

                Thread.Sleep(2000);
                webDriver.SwitchTo().ParentFrame();

                Thread.Sleep(2000);
                webDriver.SwitchTo().Frame(0);




                //webDriver.FindElement(By.Id("crmGrid_findHintText")).Click();
                Thread.Sleep(500);
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

                            Excel_Suite ex = new Excel_Suite(Env.BANK_NAME);
                            ex.getBankAccount("BankName");
                              
                            Thread.Sleep(900);
                            clickwebforms.SendKeys(Env.BankName);

                            Thread.Sleep(1000);
                            clickwebforms.SendKeys(Keys.Enter);

                            AJAXCall.WaitForAjax();

                            arrowDown.Click();

                            Thread.Sleep(1000);
                            arrowDown.Click();
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

                            Excel_Suite ex = new Excel_Suite(Env.BANK_NAME);
                            ex.getBankAccount("BankName");

                            Thread.Sleep(900);
                            clickwebforms.SendKeys(Env.BankName);

                            Thread.Sleep(1000);
                            clickwebforms.SendKeys(Keys.Enter);

                            Thread.Sleep(1000);
                            arrowDown.Click();

                            Thread.Sleep(1000);
                            arrowDown.Click();

                        }
                    }
                }

                Thread.Sleep(1000);

                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(800));
                CRM_UAT_ServiceProviderPortal_Page bankAccSearch = new CRM_UAT_ServiceProviderPortal_Page(webDriver);
                bankAccSearch.OnBoardingAdmin();

                webDriver.SwitchTo().DefaultContent();

                Thread.Sleep(2000);
                webDriver.SwitchTo().Frame("contentIFrame1");


                Thread.Sleep(5000);
                /* if (AJAXCall.IsElementPresent(By.XPath("//*[@id='FormSecNavigationControl - Icon']")))
                 {

                     NavigationFlyOut_Button.Click();
                     Review_Click.Click();
                 }

                 else
                 {
                     Actions action = new Actions(webDriver);
                     action.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();
                 } */


                crmContentLink.Click();

                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                js.ExecuteScript("window.scrollBy(0, 380)", "");

             
                Thread.Sleep(3000);

                           
                Thread.Sleep(1000);
                IWebElement chkBox_td = webDriver.FindElement(By.Id("eyp_markasapproved_d"));
                var td = chkBox_td.GetAttribute("class");

                Thread.Sleep(2000);
                approve_chkBox.Click();


                /*if(value_box.Contains("display: inline-block;"))
                {
                     approve_chkbox.Click();

                } */


                AJAXCall.WaitForAjax();
                Thread.Sleep(1000);

                webDriver.SwitchTo().ParentFrame();

                AJAXCall.WaitForAjax();
                Thread.Sleep(800);

                SaveAndClose.Click();
                webDriver.SwitchTo().Frame(1);

                AJAXCall.WaitForAjax();

                js.ExecuteScript("window.scrollBy(0,250)", "");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
        }
    }
}
