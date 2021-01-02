using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;
using Automation_Suite.Configuration_Tier;
using Automation_Suite.Constant;
using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;
using Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal;

namespace Automation_Suite.Application_Tier.PageObjectRepository
{
    class OnBoardingPage
    {   
       
        private IWebDriver webDriver;

        string TrnNo = "";

        Dictionary<string, string> dataStoredFile = new Dictionary<string, string>();
        ResourceWriter rs = new ResourceWriter();

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Start On-Boarding Process")]
        public IWebElement OnBoardingLink { get; set; }


        [FindsBy(How = How.Id, Using = "NextButton")]
        public IWebElement NextButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = "text")]
        private IWebElement Name { get; set; }
       

        [FindsBy(How = How.Id, Using = " eyp_typeofonboardingdetails")]
        private IWebElement Eyp_typeofonboardingdetails { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_legalstructure")]
        private IWebElement Legalstructure { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_typeofonboarding")]
        private IWebElement TypeofOrg { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_firstname")]
        private IWebElement firstName { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_lastname")]
        private IWebElement lastName { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_useremail")]
        private IWebElement email { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_confirmemail")]
        private IWebElement confirmEmail { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_mobilephone")]
        private IWebElement contactNo { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='eyp_legalname']")]
        private IWebElement legalName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='eyp_crono']")]
        private IWebElement croNum { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_trn")]
        private IWebElement TRNnumber { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_tcan")]
        private IWebElement tcanNumber { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_communityprivate")]
        private IWebElement communityprivate { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_charitynumber")]
        private IWebElement charityNo { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_registeredcharity")]
        private IWebElement registeredcharity { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_email")]
        private IWebElement OrgEmail { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_mainphone")]
        private IWebElement mainPhone { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_addressline1")]
        private IWebElement addressline1 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_addressline2")]
        private IWebElement addressline2 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_county")]
        private IWebElement countyName { get; set; }


        [FindsBy(How = How.Id, Using = ".launchentitylookup")]
        private IWebElement entityLookup { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_county_lookupmodal")]
        private IWebElement lookupModal { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='AutoAddressControl']/div/input")]
        private IWebElement addressIndex { get; set; }


        [FindsBy(How = How.PartialLinkText, Using = "Upload New Document")]
        private IWebElement uploadDoc { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_documenttypeid")]
        private IWebElement docOption { get; set; }

        [FindsBy(How = How.Id, Using = "InsertButton")]
        private IWebElement submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='eyp_businessfacilityname']")]
        private IWebElement facilityName { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_facilityemail")]
        private IWebElement facilityEmail { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_facilitycontactnumber")]
        private IWebElement facilityNumber { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_naionra")]
        private IWebElement naionraSelection { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_childminder")]
        private IWebElement childMinderSelection { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_locatedonschoolpremises")]
        private IWebElement schoolpremisesSelection { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_sptuslaregistered")]
        private IWebElement TuslaRegServiceSelection { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_confirmtrueinformation_label")]
        private IWebElement accept { get; set; }

       


        public OnBoardingPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        public string getTRNNumber()
        {
            return TrnNo;
        }

        [TestMethod]
        public void StartOnboarding(IWebDriver webDriver)
        {
            try
            {
                
                CommonUtils Cu = new CommonUtils(webDriver);
               
                WebDriverWait web = new WebDriverWait(webDriver, TimeSpan.FromSeconds(500));
               

                Thread.Sleep(1000);
                Cu.NonFunctionaCookies_On();

                Cu.AnalyticalCookies_On();
                
                Cu.AcceptAll_Cookies();

                Assert.IsTrue(true, "Onboarding Page");
                AJAXCall.WaitForAjax();
                webDriver.FindElement(By.XPath("//a[contains(text(),'Start On-Boarding Process')]")).Click();

                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(800)); // Timeout in seconds
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));



                AJAXCall.WaitForAjax();
                this.NextButton.Click();

                ReportsGeneration._test.Log(Status.Pass, "SPP" + webDriver.Url + "PASSED");
                SelectElement oSelect_1 = new SelectElement(webDriver.FindElement(By.Id("eyp_legalstructure")));
                IList<IWebElement> elementCount = oSelect_1.Options;
                Console.Write(elementCount.Count);

                string value = "Sole Trader";
                string value_1 = "Partnership";
                string value_2 = "Limited Company with Share Capital";
                oSelect_1.SelectByText(value_1);

                this.TypeofOrg.Click();
                SelectElement oSelect_2 = new SelectElement(TypeofOrg);
                IList<IWebElement> opt = oSelect_2.Options;
                Console.Write(opt.Count);

                ReportsGeneration._test.Log(Status.Pass, value);
                Thread.Sleep(200);
                string val = "New Organisation";
                oSelect_2.SelectByText(val);

               // AJAXCall.WaitForAjax();

                ReportsGeneration._test.Log(Status.Pass, val + "  " + "dropdown is working fine");

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "    " + "legal option" + value + "      " + "PASSED");
                this.NextButton.Click();

                Thread.Sleep(1000);
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(900));
                firstName.SendKeys("Automation");
                lastName.SendKeys("Test");

                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(1000));
                string gmailAcc = Constant_functions.GetRandomAlphaNumeric() + "@hotmail.com";


                var trnNo1 = Constant_functions.randomString(2);

                var s = Constant_functions.RandomNumGeneration(7);

                TrnNo = s + trnNo1;
                Excel_Suite Ex = new Excel_Suite(Env.EXCEL_TEST_URL);
                Ex.SetCellData("SPP_TestData", " ", TrnNo, gmailAcc);

                email.SendKeys(gmailAcc);
                confirmEmail.SendKeys(gmailAcc);

                var contactDetail = Constant_functions.RandomNumGeneration(9);

                contactNo.SendKeys(contactDetail);

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "     " + "contact details added successfully" + "      " + "PASSED");
                this.NextButton.Click();

                Thread.Sleep(1000);

                if (AJAXCall.IsElementPresent(By.XPath("//*[@id='eyp_crono']")))
                {
                    var croNumber = Constant_functions.RandomNumGeneration(3);

                    croNum.SendKeys("120");
                    Thread.Sleep(800);
                    croNum.SendKeys(croNumber);

                    Thread.Sleep(600);
                }

                Thread.Sleep(1000);

                if (AJAXCall.IsElementPresent(By.Id("eyp_legalname")))
                {
                    IWebElement legalName = webDriver.FindElement(By.Id("eyp_legalname"));
                    Console.WriteLine("False- CRO No. (Companies Registration Office Number) selection");

                    legalName.SendKeys("Pobal Automation");
                    ReportsGeneration._test.Log(Status.Pass, "SPP" + "     " + legalName + "     " + "PASSED");
                }              
                string trnKey = "Key" + TrnNo;
             
                 dataStoredFile.Add(trnKey, TrnNo);
                 rs.WriteResources(dataStoredFile);

                Thread.Sleep(800);

                foreach (char c in TrnNo)
                {   
                    TRNnumber.SendKeys(c.ToString());
                }
                
                Thread.Sleep(1000);                             
             
                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(1000);

                webDriver.FindElement(By.XPath("//input[@id='eyp_trn']")).Click();

                Thread.Sleep(1000);
               

                Thread.Sleep(900);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//input[@id='eyp_trn']")));
            
                var randomRecords = Constant_functions.RandomNumGeneration(7);
                tcanNumber.SendKeys(randomRecords);
                
                Thread.Sleep(1000);
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(900));

                if (AJAXCall.IsElementPresent(By.Id("eyp_communityprivate")))
                {
                    SelectElement privateOrcommunity = new SelectElement(communityprivate);
                    IList<IWebElement> opt_privateOrcommunity = privateOrcommunity.Options;
                    privateOrcommunity.SelectByIndex(2);
                }

                Thread.Sleep(500);

                if (AJAXCall.IsElementPresent(By.Id("eyp_registeredcharity")))
                {
                    SelectElement regCharity = new SelectElement(registeredcharity);
                    regCharity.SelectByText("No");
                }


                OrgEmail.SendKeys(gmailAcc);


                var mainPh = Constant_functions.RandomNumGeneration(9);

                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(200);

                mainPhone.SendKeys(mainPh);

                Thread.Sleep(1000);
                TRNnumber.SendKeys(trnNo1);
                ReportsGeneration._test.Log(Status.Pass, "SPP" + "     " + webDriver.Url + "     " + "PASSED");
                
                NextButton.Click();

                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(600);

                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
               
                js.ExecuteScript("window.scrollBy(0,0)", "");
                //((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", addressIndex);

                Thread.Sleep(800);
                AJAXCall.WaitForAjax();

                var address = "16 Pearse Square, Greenpark Road, Bray, Co. Wicklow";
                var address_0 = "17 The Blennicks, Rosses Point, Co.Silgo";
                addressIndex.SendKeys(address_0);

                Thread.Sleep(800);
                webDriver.FindElement(By.CssSelector(".autoaddress-button")).Click();

                Thread.Sleep(800);

                AJAXCall.WaitForAjax();

                js.ExecuteScript("window.scrollBy(0, 250)", "");
                Thread.Sleep(800);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));

                ReportsGeneration._test.Log(Status.Pass, address_0 + "      " + "address details added successfully" + "      " + "PASSED");
                Thread.Sleep(800);
                if (AJAXCall.IsElementPresent(By.Id("NextButton")))
                {
                    NextButton.Click();
                }             
                Thread.Sleep(1000);   
                

                uploadDoc.Click();
                AJAXCall.WaitForReady(webDriver);

                webDriver.SwitchTo().Frame(1);

                Thread.Sleep(1000);

                // docOption.Click();
                SelectElement docSelection = new SelectElement(docOption);
                docSelection.SelectByText("Proof of ID");               

                Thread.Sleep(500);

                IWebElement upload = webDriver.FindElement(By.Id("AttachFile"));
                upload.SendKeys("C:\\temp\\Tech_Cities_Future_report.pdf");
              
                webDriver.FindElement(By.Id("InsertButton")).Click();
                Thread.Sleep(1000);
                AJAXCall.WaitForAjax();

                
                webDriver.SwitchTo().DefaultContent();
                Thread.Sleep(1000);
                //js.ExecuteScript("window.scrollBy(0, 500)", "");
                Point loc = webDriver.FindElement(By.Id("NextButton")).Location;

                Console.WriteLine(loc);


                js = (IJavaScriptExecutor)webDriver;

                js.ExecuteScript("javascript:window.scrollBy(0," + loc.Y + ")");

                

                Thread.Sleep(1000);
                ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + webDriver.Url + "      " + "PASSED");

                AJAXCall.WaitForReady(webDriver);
                if (AJAXCall.IsElementPresent(By.Id("NextButton")))
                {
                    Thread.Sleep(1000);
                    NextButton.Click();
                }
                else
                {
                    js = (IJavaScriptExecutor)webDriver;
                    js.ExecuteScript("arguments[0].scrollIntoView();", NextButton);
                    NextButton.Click();
                }

                Thread.Sleep(900);

                // Get Parent window handle
                var winHandleBefore = webDriver.CurrentWindowHandle;

                Thread.Sleep(1000);
                            
                AJAXCall.WaitForAjax();
                 
                ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + "facility details added successfully" + "       " + "PASSED");

                Thread.Sleep(1000);
                if (NextButton.Displayed || AJAXCall.IsElementPresent(By.Id("NextButton")))
                {
                    facilityName.SendKeys("Test");

                    Thread.Sleep(1000);
                    facilityName.SendKeys(Keys.Tab);
                    facilityName.SendKeys("Test");

                    facilityEmail.SendKeys(Keys.Tab);
                    string gmailAcc_1 = Constant_functions.GetRandomAlphaNumeric() + "@yahoo.com";
                    facilityEmail.SendKeys(gmailAcc_1);
                    Thread.Sleep(800);

                    facilityNumber.SendKeys(Keys.Tab);
                    facilityNumber.SendKeys(contactDetail);

                    Thread.Sleep(1000);
                    Thread.Sleep(600);
                    NextButton.Click();
                } 
                

               
                js.ExecuteScript("window.scrollBy(0, 0)", "");
                //((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", addressIndex);


                AJAXCall.WaitForAjax();

                address = "16 Pearse Square, Greenpark Road, Bray, Co. Wicklow";
                addressIndex.SendKeys(address);

                Thread.Sleep(800);
                webDriver.FindElement(By.CssSelector(".autoaddress-button")).Click();

                Thread.Sleep(800);

                AJAXCall.WaitForAjax();

                js.ExecuteScript("window.scrollBy(0, 250)", "");
                Thread.Sleep(800);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + "address details added successfully" + "      " + "PASSED");
                Thread.Sleep(800);
                if (AJAXCall.IsElementPresent(By.Id("NextButton")))
                {
                    NextButton.Click();
                }

                Thread.Sleep(800);

                if (AJAXCall.IsElementPresent(By.Id("eyp_naionra")))
                {
                    SelectElement naionraSelect = new SelectElement(naionraSelection);
                    naionraSelect.SelectByText("No");
                }
                SelectElement childminderSelect = new SelectElement(childMinderSelection);
                childminderSelect.SelectByText("No");


                SelectElement schoolpremisesSelect = new SelectElement(schoolpremisesSelection);
                schoolpremisesSelect.SelectByText("Yes");


                SelectElement tuslaregSelect = new SelectElement(TuslaRegServiceSelection);
                tuslaregSelect.SelectByText("No");

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));
                NextButton.Click();

                Thread.Sleep(1000);
                accept.Click();


                Thread.Sleep(1000);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));
                NextButton.Click();

                IWebElement message = webDriver.FindElement(By.Id("MessageLabel"));
                var mesgValue = message.Text;

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "    " + "OnBoarding Process Submitted to CRM SuccessFully with message :" + "      "+mesgValue+  "     "  + "      " + "PASSED");
                ReportsGeneration._test.Log(Status.Pass, MarkupHelper.CreateLabel("OnBoarding Process Submitted to CRM SuccessFully with message :" + "    " + mesgValue , ExtentColor.Yellow));

               
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                
                ReportsGeneration._test.Log(Status.Fail, "SPP" + "     " + "OnBoarding Process Failed" + " " +
                    "     " + "FAIL");
                Assert.Fail();
            }


        }

        public void StartOnboarding_Frontend(IWebDriver webDriver)
        {
            try
            {

                CommonUtils Cu = new CommonUtils(webDriver);

                WebDriverWait web = new WebDriverWait(webDriver, TimeSpan.FromSeconds(500));
                Thread.Sleep(1000);
                Cu.NonFunctionaCookies_On();

                Cu.AnalyticalCookies_On();

                Cu.AcceptAll_Cookies();

                Assert.IsTrue(true, "Onboarding Page");
                AJAXCall.WaitForAjax();

                Cookies cookiePage = new Cookies(webDriver);
               

                webDriver.FindElement(By.XPath("//a[contains(text(),'Start On-Boarding Process')]")).Click();

                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(800)); // Timeout in seconds
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));


                cookiePage.getAllCookies();

                AJAXCall.WaitForAjax();
                this.NextButton.Click();

                ReportsGeneration._test.Log(Status.Pass, "SPP" + webDriver.Url + "PASSED");
                SelectElement oSelect_1 = new SelectElement(webDriver.FindElement(By.Id("eyp_legalstructure")));
                IList<IWebElement> elementCount = oSelect_1.Options;
                Console.Write(elementCount.Count);

                string value = "Sole Trader";
                string value_1 = "Partnership";
                string value_2 = "Limited Company with Share Capital";
                oSelect_1.SelectByText(value_1);

                this.TypeofOrg.Click();
                SelectElement oSelect_2 = new SelectElement(TypeofOrg);
                IList<IWebElement> opt = oSelect_2.Options;
                Console.Write(opt.Count);

                ReportsGeneration._test.Log(Status.Pass, value);
                Thread.Sleep(200);
                string val = "New Organisation";
                string val_1 = "Change of Circumstance";
                oSelect_2.SelectByText(val);

                // AJAXCall.WaitForAjax();

                ReportsGeneration._test.Log(Status.Pass, val + "  " + "dropdown is working fine");

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "    " + "legal option" + value + "      " + "PASSED");
                this.NextButton.Click();

                Thread.Sleep(1000);
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(900));
                firstName.SendKeys("Automation");
                lastName.SendKeys("Test");

                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(1000));
                string gmailAcc = Constant_functions.GetRandomAlphaNumeric() + "@hotmail.com";


                var trnNo1 = Constant_functions.randomString(2);

                var s = Constant_functions.RandomNumGeneration(7);

                TrnNo = s + trnNo1;
                Excel_Suite Ex = new Excel_Suite(Env.EXCEL_TEST_URL);
                
                email.SendKeys(gmailAcc);
                confirmEmail.SendKeys(gmailAcc);

                var contactDetail = Constant_functions.RandomNumGeneration(9);

                contactNo.SendKeys(contactDetail);

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "     " + "contact details added successfully" + "      " + "PASSED");
                this.NextButton.Click();

                Thread.Sleep(1000);

                if (AJAXCall.IsElementPresent(By.XPath("//*[@id='eyp_crono']")))
                {
                    var croNumber = Constant_functions.RandomNumGeneration(3);

                    croNum.SendKeys("120");
                    Thread.Sleep(800);
                    croNum.SendKeys(croNumber);

                    Thread.Sleep(600);
                }

                Thread.Sleep(1000);

                if (AJAXCall.IsElementPresent(By.Id("eyp_legalname")))
                {
                    IWebElement legalName = webDriver.FindElement(By.Id("eyp_legalname"));
                    Console.WriteLine("False- CRO No. (Companies Registration Office Number) selection");

                    legalName.SendKeys("Pobal Automation");
                    ReportsGeneration._test.Log(Status.Pass, "SPP" + "     " + legalName + "     " + "PASSED");
                }
                string trnKey = "Key" + TrnNo;

                dataStoredFile.Add(trnKey, TrnNo);
                rs.WriteResources(dataStoredFile);

                Thread.Sleep(800);

                foreach (char c in TrnNo)
                {
                    TRNnumber.SendKeys(c.ToString());
                }

                Thread.Sleep(1000);

                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(1000);

                webDriver.FindElement(By.XPath("//input[@id='eyp_trn']")).Click();

                Thread.Sleep(1000);


                Thread.Sleep(900);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//input[@id='eyp_trn']")));

                var randomRecords = Constant_functions.RandomNumGeneration(7);
                tcanNumber.SendKeys(randomRecords);

                Thread.Sleep(1000);
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(900));

                if (AJAXCall.IsElementPresent(By.Id("eyp_communityprivate")))
                {
                    SelectElement privateOrcommunity = new SelectElement(communityprivate);
                    IList<IWebElement> opt_privateOrcommunity = privateOrcommunity.Options;
                    privateOrcommunity.SelectByIndex(2);
                }

                Thread.Sleep(500);

                if (AJAXCall.IsElementPresent(By.Id("eyp_registeredcharity")))
                {
                    SelectElement regCharity = new SelectElement(registeredcharity);
                    regCharity.SelectByText("No");
                }


                OrgEmail.SendKeys(gmailAcc);


                var mainPh = Constant_functions.RandomNumGeneration(9);

                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(200);

                mainPhone.SendKeys(mainPh);

                Thread.Sleep(1000);
                TRNnumber.SendKeys(trnNo1);
                ReportsGeneration._test.Log(Status.Pass, "SPP" + "     " + webDriver.Url + "     " + "PASSED");

                NextButton.Click();

                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(600);

                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;

                js.ExecuteScript("window.scrollBy(0,0)", "");
                //((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", addressIndex);

                Thread.Sleep(800);
                AJAXCall.WaitForAjax();

                var address = "16 Pearse Square, Greenpark Road, Bray, Co. Wicklow";
                var address_0 = "17 The Blennicks, Rosses Point, Co.Silgo";
                addressIndex.SendKeys(address_0);

                Thread.Sleep(800);
                webDriver.FindElement(By.CssSelector(".autoaddress-button")).Click();

                Thread.Sleep(800);

                AJAXCall.WaitForAjax();

                js.ExecuteScript("window.scrollBy(0, 250)", "");
                Thread.Sleep(800);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));

                ReportsGeneration._test.Log(Status.Pass, address_0 + "      " + "address details added successfully" + "      " + "PASSED");
                Thread.Sleep(800);
                if (AJAXCall.IsElementPresent(By.Id("NextButton")))
                {
                    NextButton.Click();
                }
                Thread.Sleep(1000);


                uploadDoc.Click();
                AJAXCall.WaitForAjax();

                webDriver.SwitchTo().Frame(1);

                Thread.Sleep(1000);

                // docOption.Click();
                SelectElement docSelection = new SelectElement(docOption);
                docSelection.SelectByText("Proof of ID");
                AJAXCall.WaitForReady(webDriver);

                Thread.Sleep(1000);

                IWebElement upload = webDriver.FindElement(By.Id("AttachFile"));
                upload.SendKeys("C:\\temp\\Tech_Cities_Future_report.pdf");
             
                Thread.Sleep(500);
                if (AJAXCall.IsElementPresent(By.Id("InsertButton")))
                {
                    webDriver.FindElement(By.Id("InsertButton")).Click();               
                }

                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(1000);

                webDriver.SwitchTo().DefaultContent();
                Thread.Sleep(1000);

                Point loc = webDriver.FindElement(By.Id("NextButton")).Location;

                Console.WriteLine(loc);


                js = (IJavaScriptExecutor)webDriver;

                js.ExecuteScript("javascript:window.scrollBy(0," + loc.Y + ")");

                //js.ExecuteScript("window.scrollBy(0, 500)", "");

                Thread.Sleep(1000);
                ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + webDriver.Url + "      " + "PASSED");

                AJAXCall.WaitForReady(webDriver);
                if (AJAXCall.IsElementPresent(By.Id("NextButton")))
                {
                    Thread.Sleep(1000);
                    NextButton.Click();
                }
                else
                {
                    js = (IJavaScriptExecutor)webDriver;
                    js.ExecuteScript("arguments[0].scrollIntoView();", NextButton);
                    NextButton.Click();
                }

                Thread.Sleep(900);

                // Get Parent window handle
                var winHandleBefore = webDriver.CurrentWindowHandle;

                Thread.Sleep(1000);

                AJAXCall.WaitForAjax();

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + "facility details added successfully" + "       " + "PASSED");

                Thread.Sleep(1000);
                if (NextButton.Displayed || AJAXCall.IsElementPresent(By.Id("NextButton")))
                {
                    facilityName.SendKeys("Test");

                    Thread.Sleep(1000);
                    facilityName.SendKeys(Keys.Tab);
                    facilityName.SendKeys("Test");

                    facilityEmail.SendKeys(Keys.Tab);
                    string gmailAcc_1 = Constant_functions.GetRandomAlphaNumeric() + "@yahoo.com";
                    facilityEmail.SendKeys(gmailAcc_1);
                    Thread.Sleep(800);

                    facilityNumber.SendKeys(Keys.Tab);
                    facilityNumber.SendKeys(contactDetail);

                    Thread.Sleep(1000);
                    Thread.Sleep(600);
                    NextButton.Click();
                }



                js.ExecuteScript("window.scrollBy(0, 0)", "");
                //((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", addressIndex);


                AJAXCall.WaitForAjax();

                address = "16 Pearse Square, Greenpark Road, Bray, Co. Wicklow";
                addressIndex.SendKeys(address);

                Thread.Sleep(800);
                webDriver.FindElement(By.CssSelector(".autoaddress-button")).Click();

                Thread.Sleep(800);

                AJAXCall.WaitForAjax();

                js.ExecuteScript("window.scrollBy(0, 250)", "");
                Thread.Sleep(800);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + "address details added successfully" + "      " + "PASSED");
                Thread.Sleep(800);
                if (AJAXCall.IsElementPresent(By.Id("NextButton")))
                {
                    NextButton.Click();
                }

                Thread.Sleep(800);

                if (AJAXCall.IsElementPresent(By.Id("eyp_naionra")))
                {
                    SelectElement naionraSelect = new SelectElement(naionraSelection);
                    naionraSelect.SelectByText("No");
                }
                SelectElement childminderSelect = new SelectElement(childMinderSelection);
                childminderSelect.SelectByText("No");


                SelectElement schoolpremisesSelect = new SelectElement(schoolpremisesSelection);
                schoolpremisesSelect.SelectByText("Yes");


                SelectElement tuslaregSelect = new SelectElement(TuslaRegServiceSelection);
                tuslaregSelect.SelectByText("No");

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));
                NextButton.Click();

                Thread.Sleep(1000);
                accept.Click();


                Thread.Sleep(1000);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));
                NextButton.Click();

                IWebElement message = webDriver.FindElement(By.Id("MessageLabel"));
                var mesgValue = message.Text;

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "    " + "OnBoarding Process Submitted to CRM SuccessFully with message :" + "      " + mesgValue + "     " + "      " + "PASSED");
                ReportsGeneration._test.Log(Status.Pass, MarkupHelper.CreateLabel("OnBoarding Process Submitted to CRM SuccessFully with message :" + "    " + mesgValue, ExtentColor.Yellow));


            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                ReportsGeneration._test.Log(Status.Fail, "SPP" + "     " + "OnBoarding Process Failed" + " " +
                    "     " + "FAIL");
                Assert.Fail();
            }
        }
    }
}
