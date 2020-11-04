using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;
using Automation_Suite.Configuration_Tier;
using System.Collections.Generic;
using Automation_Suite.Application_Tier.PageObjectRepository.CRM;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal
{
    class SignIn_ServiceProviderPortal
    {
        private IWebDriver driver;


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

        [FindsBy(How = How.PartialLinkText, Using = "Organisation")]
        public IWebElement Organisation { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Service Provider")]
        public IWebElement ServiceProvider_Page { get; set; }


        [FindsBy(How = How.PartialLinkText, Using = "User Roles")]
        public IWebElement userRoles_Page { get; set; }



        [FindsBy(How = How.PartialLinkText, Using = "Bank Account")]
        public IWebElement BankAccount_Page { get; set; }



        [FindsBy(How = How.PartialLinkText, Using = "Tusla Certificate")]
        public IWebElement TuslaCertificate_Page { get; set; }


        [FindsBy(How = How.PartialLinkText, Using = "Fees List")]
        public IWebElement FeesList_Page { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Service Calendar")]
        public IWebElement ServiceCalendar_Page { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "ECCE Pre-Contracting")]
        public IWebElement ECCEPreContracting_Page { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Capital Works and Equipment")]
        public IWebElement CapitalWorksEquipment_Page { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Add Bank Account")]
        public IWebElement BankAccountLink_Button { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_accountname")]
        public IWebElement accountName { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_bank")]
        public IWebElement Bank_detail { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_bank")]
        public IWebElement DropDown_Bank { get; set; }

        [FindsBy(How = How.CssSelector, Using = "option:nth-child")]
        public IWebElement DropDown_Squence { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_iban")]
        public IWebElement iban_text { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_bankbranch")]
        public IWebElement Bank_branch { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_accountnumber")]
        public IWebElement Accountnumber { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_bic")]
        public IWebElement BIC_Num { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_sortcode")]
        public IWebElement sortCode { get; set; }

        [FindsBy(How = How.Id, Using = "NextButton")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".tab-column > div > .color-section:nth-child(2)")]
        public IWebElement attachFile { get; set; }

        [FindsBy(How = How.LinkText, Using = "Upload Document")]
        public IWebElement Upload_Document { get; set; }

        [FindsBy(How = How.Id, Using = "AttachFile")]
        public IWebElement file_Attach { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_documenttypeid")]
        public IWebElement dropdown_documenttypeid { get; set; }

        [FindsBy(How = How.Id, Using = "InsertButton")]
        public IWebElement upload_Btn { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_validationcode")]
        public IWebElement Bank_validationcode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tr:nth-child(1) .dropdown .fa")]
        public IWebElement downArrow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tr:nth-child(2) .fa")]
        public IWebElement LinkCss { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Edit")]
        public IWebElement EditLink { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_validationcode")]
        public IWebElement textField_validationCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ccc-reject-settings']")]
        public IWebElement CookiesSession_popup { get; set; }


        public SignIn_ServiceProviderPortal(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }


        [TestMthod]
        public void MyAccount_NavigationTest(IWebDriver driver)
        {
            try
            {                
                Thread.Sleep(900);

                CommonUtils CookiesAction = new CommonUtils(driver);
                CookiesAction.RejectAll_Cookies();
                Thread.Sleep(900);

                SignIn_Page.Click();


                Excel_Suite userEmail = new Excel_Suite(Env.EXCEL_TEST_URL);
                userEmail.getCellData("SPP_TestData", true);
                UserEmail.SendKeys(Env.Email_Id);
                Password.SendKeys("Test@123");

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(800));
                Thread.Sleep(800);


                SubmitButton.Click();

                MyAccount_Toggle.Click();

                Organisation.Click();
                ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "dropdown is working fine");

                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(800));
                AJAXCall.WaitForAjax();

                MyAccount_Toggle.Click();
                ServiceProvider_Page.Click();
                ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "dropdown is working fine");

                Thread.Sleep(1000);
                MyAccount_Toggle.Click();

                userRoles_Page.Click();
                ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "pageload is working fine");

                MyAccount_Toggle.Click();
                BankAccount_Page.Click();
                ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "pageload is working fine");


                MyAccount_Toggle.Click();
                TuslaCertificate_Page.Click();
                ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "pageload is working fine");



                Thread.Sleep(500);
                MyAccount_Toggle.Click();
                FeesList_Page.Click();
                ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "pageload is working fine");


                MyAccount_Toggle.Click();
                ServiceCalendar_Page.Click();
                ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "pageload is working fine");


                MyAccount_Toggle.Click();

                ECCEPreContracting_Page.Click();
                ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "pageload is working fine");

                MyAccount_Toggle.Click();

                CapitalWorksEquipment_Page.Click();

                ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "dropdown is working fine");
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        [TestMethod]
        public void SP_Portal_SignIN_Submit(IWebDriver driver)
        {
            CommonUtils Cu = new CommonUtils(driver);
            Cu.AcceptAll_Cookies();

            SignIn_Page.Click();
            Thread.Sleep(900);

            Excel_Suite userEmail = new Excel_Suite(Env.EXCEL_TEST_URL);
            userEmail.getCellData("SPP_TestData", true);
            UserEmail.SendKeys(Env.Email_Id);

           // UserEmail.SendKeys(Constant_functions.UserEmailId);
            Password.SendKeys("Test@123");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(800));
          
            SubmitButton.Click();

            MyAccount_Toggle.Click();

            BankAccount_Page.Click();
            ReportsGeneration._test.Log(Status.Pass, " " + "   " + driver.Url + "   " + "pageload is working fine");
            BankAccountLink_Button.Click();
            Thread.Sleep(1000);
            Excel_Suite Es = new Excel_Suite(Env.EXCEL_BANK_DATA);
            ExcelData bankData = Es.getBankData("Sheet1");
            SelectElement bankBranchOption = new SelectElement(DropDown_Bank);


            if (bankData != null)
            {
                accountName.SendKeys(bankData.AccountName);
                
                List<string> bankNames = new List<string>
                {
                    "AIB",
                    "An Post",
                    "Bank of Ireland",
                    "First Active",
                    "ING Bank",
                    "Aareal Bank AG",
                    "Bank of America Merrill Lynch International Ltd",
                    "Ulster Bank"
                };

                Thread.Sleep(800);

                IList<IWebElement> bankNames_1 = bankBranchOption.Options;
                DropDown_Bank.Click();


                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(900));
                string val = "";


                Thread.Sleep(1000);
                foreach (var bankNameText in bankNames)
                {

                    if (bankNameText.Contains(bankData.BankName))
                    {
                        val = bankNameText;
                        if (AJAXCall.IsElementPresent(By.Id("eyp_bank")))
                        {
                            bankBranchOption.SelectByText(val);
                        }
                    }
                    else
                    {

                        bankBranchOption.SelectByIndex(4);
                        break;
                    }
                }
                Thread.Sleep(1000);
                foreach (char c in bankData.IBAN1)
                {
                    iban_text.SendKeys(c.ToString());
                }

                Bank_branch.SendKeys(bankData.BankBranch);
                Accountnumber.SendKeys(bankData.AccountNumber);

                

                Thread.Sleep(600);
                foreach (char s in bankData.BIC)
                {
                    BIC_Num.SendKeys(s.ToString());
                }
                Thread.Sleep(600);
                sortCode.SendKeys(bankData.SortCode);
            }

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(900));
            NextButton.Click();

            AJAXCall.WaitForReady(driver);

            Thread.Sleep(1000);
            Upload_Document.Click();

            AJAXCall.WaitForAjax();

            Thread.Sleep(1000);
            driver.SwitchTo().Frame(1);
            SelectElement doc = new SelectElement(dropdown_documenttypeid);
            doc.SelectByText("Bank Account Statement");

            Thread.Sleep(500);
            AJAXCall.WaitForAjax();

            IWebElement upload = driver.FindElement(By.Id("AttachFile"));
            upload.SendKeys("C:\\temp\\Tech_Cities_Future_report.pdf");

            upload_Btn.Click();
            Thread.Sleep(1000);

            AJAXCall.WaitForReady(driver);
           
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(1000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 500)", "");

            js.ExecuteScript("arguments[0].scrollIntoView();", NextButton);

            if (AJAXCall.IsElementPresent(By.Id("NextButton")))
            {
                NextButton.Click();
            }
            else
            {
                IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
                jse = (IJavaScriptExecutor)driver;
                jse.ExecuteScript("arguments[0].scrollIntoView();", NextButton);
               
            }
            
           
            ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + driver.Url + "      " + "PASSED");
           
            Thread.Sleep(700);
            
        }


        [TestMethod]
        public void SearchThroughAccountName(IWebDriver driver)
        {
            SignIn_Page.Click();

            UserEmail.SendKeys("uoti354r@hotmail.com");
            Password.SendKeys("Test@123");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(800));
            Thread.Sleep(800);
            SubmitButton.Click();

            MyAccount_Toggle.Click();

            BankAccount_Page.Click();

            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);
            downArrow.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(900));

            Thread.Sleep(1000);
            EditLink.Click();

            Actions action = new Actions(driver);
            action.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();

            NextButton.Click();
            AJAXCall.WaitForAjax();
            Thread.Sleep(2000);

            if (AJAXCall.IsElementPresent(By.PartialLinkText("Upload Document")))
            {
                action.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();
                NextButton.Click();
            }
            else
            {
                Thread.Sleep(1000);
            }

            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);

            Thread.Sleep(2000);

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

            if (AJAXCall.IsElementPresent(By.Id("eyp_validationcode")))
            {
                Excel_Suite read_BankCode = new Excel_Suite(@"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\TestData_Repository\BankCode.xlsx");
                read_BankCode.getCellData("Bank_Sheet", false);

                IWebElement value_Code = driver.FindElement(By.XPath("//*[@id='eyp_validationcode']"));
                value_Code.Click();
                value_Code.Clear();
                Thread.Sleep(2000);

                value_Code.SendKeys(Keys.Tab);
                value_Code.SendKeys(Env.Data_Retrieve);

            }
            NextButton.Click();


        }

        [TestMethod]
        public void MultipleWindowHandling(string URL1, string URL2)
        {

            driver.Navigate().GoToUrl(URL1);
            string baseTab = driver.Url;

            string newWindow = driver.CurrentWindowHandle;
            string firstTabHandle = driver.CurrentWindowHandle;
           
            Actions action = new Actions(driver);
                                        
            Thread.Sleep(4000);            
            driver.SwitchTo().Window(firstTabHandle);

            Thread.Sleep(4000);           
            SP_Portal_SignIN_Submit(driver);

            Thread.Sleep(4000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open(arguments[0])", URL2);

            List<string> tabs = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(tabs[1]);
            driver.Navigate().GoToUrl(URLConfig.UAT_CRM);

            
            Thread.Sleep(2000);
            CRM_Bank_Page cp = new CRM_Bank_Page(driver);
            cp.Bank_CodeActivation(driver);

            Thread.Sleep(1000);
            Thread.Sleep(4000);

            driver.SwitchTo().Window(tabs[0]);

            Thread.Sleep(4000);

            if (AJAXCall.IsElementPresent(By.Id("eyp_validationcode")))
            {
                Excel_Suite read_BankCode = new Excel_Suite(@"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\TestData_Repository\BankCode.xlsx");
                read_BankCode.getCellData("Bank_Sheet", false);

                IWebElement value_Code = driver.FindElement(By.XPath("//*[@id='eyp_validationcode']"));
                value_Code.Click();
                value_Code.Clear();
                Thread.Sleep(2000);

                value_Code.SendKeys(Keys.Tab);
                string value1 = Env.Data_Retrieve;
                value_Code.SendKeys(value1);
                value_Code.Clear();
                value_Code.SendKeys(value1);


                Thread.Sleep(4000);
            }



            NextButton.Click();


        }
        [TestMethod]
        public void BankApproval()
        {




        }

    }
}



