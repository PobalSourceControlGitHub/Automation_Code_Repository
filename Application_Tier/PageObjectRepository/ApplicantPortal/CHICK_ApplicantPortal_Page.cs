﻿using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ApplicantPortal
{
    public class CHICK_ApplicantPortal_Page
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "submit-signin-local")]
        public IWebElement SignIn_Page { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/a")]
        public IWebElement Dimisscookie_Message { get; set; }

        [FindsBy(How = How.XPath, Using = "//footer/div[2]/div/div/div[2]/ul/li[6]/a")]
        public IWebElement Admin_SignIn { get; set; }


        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "submit-signin-local")]
        public IWebElement Submit{ get; set; }
       
        [FindsBy(How = How.XPath, Using = " //*[@id='menu-bar']/ul/li[1]/a")]
        public IWebElement MyApplicationsLink { get; set; }

       
        [FindsBy(How = How.XPath, Using = "//*[@id='menu-bar']/ul/li[1]/ul/li[1]/a")]
        public IWebElement ViewApplications { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='AutoAddressControl']/div/button")]
        public IWebElement searchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btnModalSubmit']")]
        public IWebElement caretChild_Click { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "View Applications")]
        public IWebElement viewApp_Click { get; set; }
        

        [FindsBy(How = How.PartialLinkText, Using = "New Application")]
        public IWebElement NewApplication { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Start Universal Application")]
        public IWebElement startUniversal_Application { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_dataprivacystatement_label")]
        public IWebElement eyp_dataprivacystatement { get; set; }


        [FindsBy(How = How.Id, Using = "btnNext")]
        public IWebElement NextBtn { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_irelandresident")]
        public IWebElement eyp_irelandresident { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#eyp_irelandresident > option:nth-child(3)")]
        public IWebElement eyp_irelandresident_option { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//*[@id='AutoAddressControl']/div/input")]
        public IWebElement addressSection { get; set; }


        [FindsBy(How = How.Id, Using = ".autoaddress-text-box")]
        public IWebElement autoaddress_text { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".selected")]
        public IWebElement selectedBtn_click { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_firstname")]
        public IWebElement eyp_firstname { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_lastname")]
        public IWebElement eyp_lastname { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_ppsn")]
        public IWebElement Eyp_ppsn { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//*[@id='childdetailsModal']/div/div[2]/fieldset/table/tbody/tr[2]/td[2]/div[2]/div/input")]
        public IWebElement DateOfBirth { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tr:nth-child(2) .input-append > .form-control")]
        public IWebElement front_Control { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_genderid")]
        public IWebElement Genderid { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#eyp_genderid > option:nth-child(3)")]
        public IWebElement Eyp_genderid_Click { get; set; }

        [FindsBy(How = How.Id, Using = "loading")]
        public IWebElement Loading { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_relationshipapplicantid")]
        public IWebElement Eyp_relationshipapplicantid { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#eyp_relationshipapplicantid > option:nth-child(3")]
        public IWebElement eyp_relationshipapplicantid_Option { get; set; }

        [FindsBy(How = How.Id, Using = "initialeducationstage")]
        public IWebElement Initialeducationstage { get; set; }
       

        [FindsBy(How = How.Id, Using = "eyp_movetonexteducationstage")]
        public IWebElement EduStageDate_Option { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='nexteducationstage']")]
        public IWebElement nextEduStage { get; set; }
        


        [FindsBy(How = How.XPath, Using = "//*[@id='childdetailsModal']/div/div[2]/fieldset/table/tbody/tr[7]/td[2]/div[2]/div/input")]
        public IWebElement dateNextEduStage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#initialeducationstage > option:nth-child(2)")]
        public IWebElement Initialeducationstage_child2click { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#initialeducationstage > option:nth-child(3)")]
        public IWebElement initialeducationstage_child3click { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tr:nth-child(5) > .clearfix:nth-child(2)")]
        public IWebElement nth_Child5Click { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "I agree")]
        public IWebElement Iagree { get; set; }

        [FindsBy(How = How.Id, Using = "btnSubmitChild")]
        public IWebElement BtnSubmitChild { get; set; }

        [FindsBy(How = How.Id, Using = "btnModalSubmit")]
        public IWebElement BtnModalSubmit { get; set; }

        [FindsBy(How = How.Id, Using = "menu-bar")]
        public IWebElement Menubar { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$ContentContainer$MainContent$eyp_custodydeclaration")]
        public IWebElement Eyp_custodydeclaration_label { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_informationtruthfuldeclaration_label")]
        public IWebElement Eyp_informationtruthfuldeclaration_label { get; set; }
        

        [FindsBy(How = How.PartialLinkText, Using = "View Awards")]
        public IWebElement viewAwards { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = ".weblink:nth-child(3) > .dropdown-toggle")]
        public IWebElement dropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'My Awards')]")]
        public IWebElement MyAwards  { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "View Awards")]
        public IWebElement ViewAwards { get; set; }

        [FindsBy(How = How.CssSelector, Using = "View details")]
        public IWebElement Viewdetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class = 'detail-content']")]
        public IList<IWebElement> Child_Content { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class = 'detail-label']")]
        public IList<IWebElement> Child_Label { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div:nth-child(4) > span.detail-content")]
        public IWebElement DateOfBirthContent { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div:nth-child(5) > span.detail-content")]
        public IWebElement ChildcareIdentifierCodeKey { get; set; }

        
  




        public CHICK_ApplicantPortal_Page(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }


        [TestMethod]
        public void Chick_UniversalApplication_NoSubsidy()
        {

            string parentWindow = driver.CurrentWindowHandle;

            Thread.Sleep(700);

            CommonUtils Cu = new CommonUtils(driver);
            Cu.AcceptAll_Cookies();

            if (AJAXCall.IsElementPresent(By.XPath("/html/body/div[1]/div/a")))
            {
                Dimisscookie_Message.Click();
            }
            Admin_SignIn.Click();

            Username.SendKeys("auto@parent.ie");

            Password.SendKeys("Pobal123!");

            Thread.Sleep(1000);
            SignIn_Page.Click();

            MyApplicationsLink.Click();
            ViewApplications.Click();

            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);

            NewApplication.Click();
            startUniversal_Application.Click();
            eyp_dataprivacystatement.Click();

            Thread.Sleep(1000);
            NextBtn.Click();

            SelectElement value = new SelectElement(eyp_irelandresident);
            value.SelectByText("Yes");

            NextBtn.Click();

            var address = "17 Bleach Road, Dún Brinn, Athy, Co.Kildare";
            addressSection.SendKeys(address);

            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".autoaddress-button")).Click();

            Thread.Sleep(2000);

            AJAXCall.WaitForAjax();

            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript("window.scrollBy(0, 500)", "");
            Thread.Sleep(1000);
            

            ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + "address details added successfully" + "      " + "PASSED");
            Thread.Sleep(800);
            if (AJAXCall.IsElementPresent(By.Id("btnNext")))
            {
                NextBtn.Click();
            }

            Thread.Sleep(2000);

            eyp_firstname.SendKeys("Test");
            eyp_lastname.SendKeys("Automation");


            Eyp_ppsn.SendKeys("7865481TR");
           

            var myDate = DateTime.Now;
            var newDate = myDate.AddYears(-3);

            var chickDOB = newDate.ToString("dd/MM/yyyy");
            DateOfBirth.SendKeys(chickDOB);
            SelectElement genderVal = new SelectElement(Genderid);
            genderVal.SelectByText("Female");

            Thread.Sleep(1000);
            SelectElement relToChild = new SelectElement(Eyp_relationshipapplicantid);
            relToChild.SelectByIndex(5);

            Thread.Sleep(1000);
            AJAXCall.WaitForAjax();
            if (AJAXCall.IsElementPresent(By.Id("initialeducationstage")) || Initialeducationstage.Displayed)
            {
                SelectElement EduStage = new SelectElement(Initialeducationstage);
                EduStage.SelectByText("ECCE / ECCE Eligible");
            }
            Thread.Sleep(1000);

            AJAXCall.WaitForAjax();
            if (AJAXCall.IsElementPresent(By.Id("eyp_movetonexteducationstage")) || EduStageDate_Option.Displayed)
            {
                SelectElement eduStageDate = new SelectElement(EduStageDate_Option);
                eduStageDate.SelectByText("Yes");
            }
            Thread.Sleep(2000);

            AJAXCall.WaitForAjax();
            SelectElement NextEduStage = new SelectElement(nextEduStage);
            NextEduStage.SelectByIndex(3);

            Thread.Sleep(2000);
            myDate = DateTime.Now;

            newDate = myDate.AddYears(+1).AddDays(8);

            var nextyearDate = newDate.ToString("dd/MM/yyyy");

            dateNextEduStage.Click();

            dateNextEduStage.SendKeys(nextyearDate);


            BtnSubmitChild.Click();

            Thread.Sleep(2000);
            AJAXCall.WaitForAjax();

            if (AJAXCall.IsElementPresent(By.XPath("//*[@id='btnModalSubmit']")))
            {
                caretChild_Click.Click();
                Thread.Sleep(2000);
            }
           

           
            AJAXCall.WaitForReady(driver);

            Thread.Sleep(2000);
            NextBtn.Click();

            Thread.Sleep(1000);
            IWebElement chick_Number = driver.FindElement(By.Id("eyp_id"));
            var store_ChickNumber = chick_Number.GetAttribute("value");

            AJAXCall.WaitForAjax();

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

            NextBtn.Click();

            Thread.Sleep(1000);           
            Thread.Sleep(2000);

            IWebElement label = driver.FindElement(By.XPath("//label[@for='eyp_custodydeclaration']"));
            new Actions(driver).MoveToElement(label, 1, 1).Click().Perform();
           
            AJAXCall.WaitForAjax();

            Eyp_informationtruthfuldeclaration_label.Click();

            NextBtn.Click();
            Thread.Sleep(2000);

            AJAXCall.WaitForAjax();

            BtnModalSubmit.Click();
        }

        public void Chick_UniversalApplication_Subsidy()
        {

            string parentWindow = driver.CurrentWindowHandle;

            Thread.Sleep(700);

            CommonUtils Cu = new CommonUtils(driver);
            Cu.AcceptAll_Cookies();

            if (AJAXCall.IsElementPresent(By.XPath("/html/body/div[1]/div/a")))
            {
                Dimisscookie_Message.Click();
            }
            Admin_SignIn.Click();

            Username.SendKeys("auto@parent.ie");

            Password.SendKeys("Pobal123!");

            Thread.Sleep(1000);
            SignIn_Page.Click();

            MyApplicationsLink.Click();
            ViewApplications.Click();

            MyAwards_NCS();

            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);

            NewApplication.Click();
            startUniversal_Application.Click();
            eyp_dataprivacystatement.Click();

            Thread.Sleep(1000);
            NextBtn.Click();

            SelectElement value = new SelectElement(eyp_irelandresident);
            value.SelectByText("Yes");

            NextBtn.Click();

            var address = "17 Bleach Road, Dún Brinn, Athy, Co.Kildare";
            addressSection.SendKeys(address);

            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".autoaddress-button")).Click();

            Thread.Sleep(2000);

            AJAXCall.WaitForAjax();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 500)", "");
            Thread.Sleep(1000);


            ReportsGeneration._test.Log(Status.Pass, "SPP" + "      " + "address details added successfully" + "      " + "PASSED");
            Thread.Sleep(800);
            if (AJAXCall.IsElementPresent(By.Id("btnNext")))
            {
                NextBtn.Click();
            }

            Thread.Sleep(2000);

            eyp_firstname.SendKeys("Test");
            eyp_lastname.SendKeys("Automation");

            Eyp_ppsn.SendKeys("7865481TR");
            var myDate = DateTime.Now;
            var newDate = myDate.AddYears(-1);

            var chickDOB = newDate.ToString("dd/MM/yyyy");

            DateOfBirth.SendKeys(chickDOB);
            
            SelectElement genderVal = new SelectElement(Genderid);
            genderVal.SelectByText("Female");

            Thread.Sleep(1000);
            SelectElement relToChild = new SelectElement(Eyp_relationshipapplicantid);
            relToChild.SelectByIndex(4);

            Thread.Sleep(1000);
            AJAXCall.WaitForAjax();
            
            Thread.Sleep(2000);

            AJAXCall.WaitForAjax();

            if (AJAXCall.IsElementPresent(By.Id("//*[@id='nexteducationstage']")) && nextEduStage.Displayed)
            {
                SelectElement NextEduStage = new SelectElement(nextEduStage);

                myDate = DateTime.Now;
                newDate = myDate.AddYears(+1);
                NextEduStage.SelectByIndex(3);

                Thread.Sleep(1000);
                
            }
            BtnSubmitChild.Click();

            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
           
            AJAXCall.WaitForReady(driver);

            Thread.Sleep(2000);
            NextBtn.Click();

            Thread.Sleep(1000);
            IWebElement chick_Number = driver.FindElement(By.Id("eyp_id"));
            var store_ChickNumber = chick_Number.GetAttribute("value");

            AJAXCall.WaitForAjax();

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

            NextBtn.Click();
            Thread.Sleep(2000);

            IWebElement label = driver.FindElement(By.XPath("//label[@for='eyp_custodydeclaration']"));
            new Actions(driver).MoveToElement(label, 1, 1).Click().Perform();



            AJAXCall.WaitForAjax();

            Eyp_informationtruthfuldeclaration_label.Click();

            NextBtn.Click();
            Thread.Sleep(2000);

            AJAXCall.WaitForAjax();

            BtnModalSubmit.Click();

        }

        [TestMethod]
        public void MyAwards_NCS()
        {

            MyAwards.Click();
            viewAwards.Click();

            // Viewdetails.Click();
            foreach(var Val in Child_Label)
            {
                if(Val.Text.Contains("Child's full name:"))
                {   
                    for(int i =0; i < Child_Content.Count; i++)
                    {
                        string childName = Child_Content[i].Text;
                        Excel_Suite Ex = new Excel_Suite(Env.EXCEL_TEST_CHILD_DATA);
                        Ex.setChildDetails("Data", "ChickName", childName, "", "");
                    }                
                }
                else if (Val.Text.Contains("Date of Birth:"))
                {
                    string ChildDOB = Child_Content[1].Text;
                    Excel_Suite Ex = new Excel_Suite(Env.EXCEL_TEST_CHILD_DATA);
                    Ex.setChildDetails("Data", "DOB", "", ChildDOB, "");
                }
                else if (Val.Text.Contains("Childcare Identifier Code Key:"))
                {
                    string ChildcareIdentifierCode = Child_Content[3].Text;
                    Excel_Suite Ex = new Excel_Suite(Env.EXCEL_TEST_CHILD_DATA);
                    Ex.setChildDetails("Data", "ChildCareIdentifierCodeKey", "", "", ChildcareIdentifierCode);
                }
            }           
        }
    }
}
