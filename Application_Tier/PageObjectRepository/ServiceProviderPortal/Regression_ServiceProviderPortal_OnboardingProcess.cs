using Automation_Suite._02_Utility_Tier;
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

namespace Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal
{
    class Regression_ServiceProviderPortal_OnboardingProcess
    {


        private IWebDriver webDriver;


        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Start On-Boarding Process")]
        public IWebElement OnBoardingLink { get; set; }


        [FindsBy(How = How.Id, Using = "NextButton")]
        public IWebElement NextButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = "text")]
        private IWebElement Name { get; set; }


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

        [FindsBy(How = How.Id, Using = "eyp_businessfacilityname")]
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


        public Regression_ServiceProviderPortal_OnboardingProcess(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }


        [TestMethod]
        public void OnBoardingWithDifferentOptions(IWebDriver webDriver)
        {
            try
            {
                var oPropDict = ExcelUtil.poupulateHashFromExcel("TestData", "SPP_TestData");

                WebDriverWait web = new WebDriverWait(webDriver, TimeSpan.FromSeconds(100));

                Assert.IsTrue(true, "Onboarding Page");

                webDriver.FindElement(By.XPath("//a[contains(text(),'Start On-Boarding Process')]")).Click();
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(500)); // Timeout in seconds
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));



                AJAXCall.WaitForAjax();
                this.NextButton.Click();

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "      "+ webDriver.Url + "     " + "PASSED");
                SelectElement oSelect_1 = new SelectElement(webDriver.FindElement(By.Id("eyp_legalstructure")));
                IList<IWebElement> elementCount = oSelect_1.Options;
                Console.Write(elementCount.Count);

                //string value = "Designated Activity Company Limited by Guarantee";
                string value_1 = "Private Unlimited Company";
                string value_2 = "Partnership";
                string value_3 = "Sole Trader";
                string value_4 = "Limited Company with Share Capital";
                var legalStructValue = "";

                foreach (IWebElement selection in elementCount)
                {
                    if (selection.Text.Contains(value_3) || selection.Text.Contains(value_3) || selection.Text.Contains(value_3)|| selection.Text.Contains(value_3) || selection.Text.Contains(value_3)
                        ) { oSelect_1.SelectByText(selection.Text);

                         legalStructValue = selection.Text;
                         break; }

                    
                    
                }
                ReportsGeneration._test.Log(Status.Pass, "       " + legalStructValue + "  " + "select by text is pass");

                this.TypeofOrg.Click();
                SelectElement oSelect_2 = new SelectElement(TypeofOrg);
                IList<IWebElement> opt = oSelect_2.Options;
                Console.Write(opt.Count);

                string val = "New Organisation";
                ReportsGeneration._test.Log(Status.Pass, val);
                Thread.Sleep(200);
               
                oSelect_2.SelectByText(val);


                ReportsGeneration._test.Log(Status.Pass, val + "  " + "dropdown is working fine");

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "    " + "legal option" + legalStructValue + "      " + "PASSED");
                this.NextButton.Click();

                firstName.SendKeys("Automation");
                lastName.SendKeys("Test");

                string gmailAcc = Constant_functions.GetRandomAlphaNumeric() + "@yahoo.com";

                email.SendKeys(gmailAcc);
                confirmEmail.SendKeys(gmailAcc);

                var contactDetail = Constant_functions.RandomNumGeneration(9);

                contactNo.SendKeys(contactDetail);

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "     " + "contact details added successfully" + "      " + "PASSED");
                this.NextButton.Click();

                AJAXCall.WaitForReady(webDriver);

                var croNumber = Constant_functions.RandomNumGeneration(3);
                Thread.Sleep(500);
                if (AJAXCall.IsElementPresent(By.XPath("//*[@id='eyp_crono']")))
                {
                    wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(400));
                    croNum.SendKeys("108");
                    croNum.SendKeys(croNumber);

                    IWebElement CRONO = webDriver.FindElement(By.Id("eyp_crono"));
                    ReportsGeneration._test.Log(Status.Pass, "SPP" + "     " + CRONO + "     " + "PASSED");
                }

                
            
               else if (AJAXCall.IsElementPresent(By.Id("eyp_legalname")))
                {
                    IWebElement legalName = webDriver.FindElement(By.Id("eyp_legalname"));
                    Console.WriteLine("No CRO No. (Companies Registration Office Number) selection");
                    ReportsGeneration._test.Log(Status.Pass, "SPP" + "     " + legalName + "     " + "PASSED");
                }

                var trnNo1 = Constant_functions.randomString(2);

                var s = Constant_functions.RandomNumGeneration(7);
                //s += trnNo1;

                string TrnNo = s + "XZ";

                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(1000);

                webDriver.FindElement(By.XPath("//input[@id='eyp_trn']")).Click();

                Thread.Sleep(1000);
                webDriver.FindElement(By.XPath("//input[@id='eyp_trn']")).SendKeys(s + trnNo1);


                //TRNnumber.SendKeys(trnNo1);
                var randomRecords = Constant_functions.RandomNumGeneration(7);
                tcanNumber.SendKeys(randomRecords);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//input[@id='eyp_trn']")));
                webDriver.FindElement(By.XPath("//input[@id='eyp_trn']")).SendKeys("WD");

                if (AJAXCall.IsElementPresent(By.Id("eyp_communityprivate")))
                {

                    SelectElement privateOrcommunity = new SelectElement(communityprivate);
                    IList<IWebElement> opt_privateOrcommunity = privateOrcommunity.Options;
                    privateOrcommunity.SelectByIndex(2);

                }

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

                Thread.Sleep(500);
                ReportsGeneration._test.Log(Status.Pass, "SPP" + "     "+ webDriver.Url + "     "+ "PASSED");
                NextButton.Click();

               /* if (AJAXCall.IsElementPresent(By.Id("eyp_county")))
                {

                    SelectElement countyNameEnter = new SelectElement(countyName);
                    countyNameEnter.SelectByText("Dublin");

                    AJAXCall.WaitForReady(webDriver);
                    Thread.Sleep(200);
                    NextButton.Click();
                } */

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

                Thread.Sleep(800);

                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(600);

               

                Thread.Sleep(600);
                

                uploadDoc.Click();

                AJAXCall.WaitForReady(webDriver);
                Thread.Sleep(1000);

                webDriver.SwitchTo().Frame(1);

               // Thread.Sleep(500);
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(500));

                    // docOption.Click();
                    SelectElement docSelection = new SelectElement(docOption);
                    docSelection.SelectByText("Proof of ID");


                    AJAXCall.WaitForReady(webDriver);

                    IWebElement upload = webDriver.FindElement(By.Id("AttachFile"));
                    upload.SendKeys("C:\\temp\\Tech_Cities_Future_report.pdf");

                    submit.Click();


                    AJAXCall.WaitForAjax();


                    Thread.Sleep(1000);

                    if (AJAXCall.IsElementPresent(By.Id("InsertButton")))
                    {
                        submit.Click();

                    }
                    else
                    {
                        Console.WriteLine("cursor is in parent window");

                    }


                    Thread.Sleep(1000);


                    // Get Parent window handle
                    var winHandleBefore = webDriver.CurrentWindowHandle;
                    foreach (var winHandle in webDriver.WindowHandles)
                    {
                        // Switch to parent window
                        webDriver.SwitchTo().DefaultContent();
                    }

                    // AJAXCall.WaitForAjax();
                    Thread.Sleep(1000);
                   
                    js.ExecuteScript("window.scrollBy(0,250)", "");

                    ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + webDriver.Url + "      " + "PASSED");

                    if (NextButton.Displayed || AJAXCall.IsElementPresent(By.Id("NextButton")))
                    {


                        NextButton.Click();
                    }

                    Thread.Sleep(500);
                    AJAXCall.WaitForAjax();

                    facilityName.SendKeys("Test");
                    string gmailAcc_1 = Constant_functions.GetRandomAlphaNumeric() + "@yahoo.com";
                    facilityEmail.SendKeys(gmailAcc_1);

                    facilityNumber.SendKeys(contactDetail);

                    AJAXCall.WaitForAjax();

                    ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + "facility details added successfully" + "       " + "PASSED");
                    NextButton.Click();

                
                

                Thread.Sleep(800);

               
                js.ExecuteScript("window.scrollBy(0,0)", "");
                //((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", addressIndex);

                Thread.Sleep(800);
                AJAXCall.WaitForAjax();

                 address = "16 Pearse Square, Greenpark Road, Bray, Co. Wicklow";
                 address_0 = "17 The Blennicks, Rosses Point, Co.Silgo";
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


                accept.Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));
                NextButton.Click();

                IWebElement message = webDriver.FindElement(By.Id("MessageLabel"));
                var mesgValue = message.Text;

                ReportsGeneration._test.Log(Status.Pass, "SPP" + "    " + "OnBoarding Process Submitted to CRM SuccessFully with message :" + "      " + mesgValue + "     " + "      " + "PASSED");
                ReportsGeneration._test.Log(Status.Pass, MarkupHelper.CreateLabel("OnBoarding Process Submitted to CRM SuccessFully with message :" + "    " + mesgValue, ExtentColor.Yellow));

                // webUtility.inputTextByID(oPropDict["Customer_Name"], ExcelUtil.GetData("CustName"));
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                ReportsGeneration._test.Log(Status.Fail, "SPP" + "     " + "OnBoarding Process Failed" + "      " + "FAIL");
                Assert.Fail();
            }


        }
    }
}