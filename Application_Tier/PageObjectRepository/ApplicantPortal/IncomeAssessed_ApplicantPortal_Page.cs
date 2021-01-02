using Automation_Suite.Constant;
using Automation_Suite.Utility_Tier;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Automation_Suite.Application_Tier.PageObjectRepository.ApplicantPortal
{
    class IncomeAssessed_ApplicantPortal_Page
    {


   
        private IWebDriver driver;

        [FindsBy(How = How.PartialLinkText, Using = "Start Income Assessed Application")]
        public IWebElement startIncomeAssessedApplication { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_dataprivacystatement_label")]
        public IWebElement Dataprivacystatement_label { get; set; }

        [FindsBy(How = How.Id, Using = "btnNext")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_irelandresident")]
        public IWebElement Resident { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "eyp_irelandresident")]
        public IWebElement Email_Text { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[. = 'No']")]
        public IWebElement optionNo { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_eucitizen")]
        public IWebElement Eyp_eucitizen { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_eftacitizen")]
        public IWebElement Eyp_eftacitizen { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_asylumrefugee")]
        public IWebElement Eyp_asylumrefugee { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_employedinireland")]
        public IWebElement Eyp_employedinireland { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[. = 'Yes']")]
        public IWebElement optionYes { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".autoaddress-text-box")]
        public IWebElement TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='AutoAddressControl']//div//input")]
        public IWebElement TextBox_Address { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@id='AutoAddressControl']//div//button")]
        public IWebElement AddressSelected { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_livingwithpartner")]
        public IWebElement Eyp_livingwithpartner { get; set; }

        /* {
                    var dropdown = driver.FindElement(By.Id("eyp_livingwithpartner"));
            dropdown.FindElement(By.XPath("//option[. = 'Yes']")).Click();
        } */
        

        [FindsBy(How = How.Id, Using = "eyp_livingwithpartnerdeclaration_label")]
        public IWebElement Eyp_livingwithpartnerdeclaration_label { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_partnerfirstname")]
        public IWebElement Eyp_partnerfirstname { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_partnerlastname")]
        public IWebElement Eyp_partnerlastname { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnerppsn")]
        public IWebElement Eyp_partnerppsn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".input-append > .form-control")]
        public IWebElement control { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='WebFormPanel']//div//div//fieldset//table//tbody//tr//td//div//div//input")]
        public IWebElement DOB_Calendar { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".datepicker-days .next")]
        public IWebElement Datepicker { get; set; }

        /* {
                var element = driver.FindElement(By.CssSelector(".datepicker-days .next > .glyphicon"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            } */

        [FindsBy(How = How.CssSelector, Using = ".datepicker-days .next > .glyphicon")]
        public IWebElement DatepickerGlyphicon { get; set; }

        /*{
                var element = driver.FindElement(By.CssSelector(".dow:nth-child(7)"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            } */

        [FindsBy(How = How.Id, Using = "eyp_genderid")]
        public IWebElement Eyp_genderid { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partneremailaddress")]
        public IWebElement Eyp_partneremailaddress { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_firstname")]
        public IWebElement Eyp_firstname { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_lastname")]
        public IWebElement Eyp_lastname { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_ppsn")]
        public IWebElement Eyp_ppsn { get; set; }


        [FindsBy(How = How.XPath, Using = "//option[. = 'Female']")]
        public IWebElement OptionGender { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_genderid")]
        public IWebElement Genderid { get; set; }


        /*{
               var dropdown = driver.FindElement(By.Id("eyp_genderid"));
               dropdown.FindElement(By.XPath("//option[. = 'Female']")).Click();
        } */

        [FindsBy(How = How.Id, Using = "eyp_subsidyrequested")]
        public IWebElement Eyp_subsidyrequested { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_relationshipapplicantid")]
        public IWebElement Eyp_relationshipapplicantid { get; set; }


        [FindsBy(How = How.XPath, Using = "//option[. = 'Step Parent']")]
        public IWebElement StepParent { get; set; }


        /* {
             var dropdown = driver.FindElement(By.Id("eyp_relationshipapplicantid"));
             dropdown.FindElement(By.XPath("//option[. = 'Step Parent']")).Click();
         }
         */


      

        [FindsBy(How = How.Id, Using = "initialeducationstage")]
        public IWebElement initialeducationstage { get; set; }



        [FindsBy(How = How.XPath, Using = "//option[. = 'Junior/Senior Infants']")]
        public IWebElement InfantOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[. = '1st to 6th Class'")]
        public IWebElement Classoption { get; set; }

        /* var dropdown = driver.FindElement(By.Id("initialeducationstage"));
                dropdown.FindElement(By.XPath("//option[. = '1st to 6th Class']")).Click(); 
            } */

        [FindsBy(How = How.Id, Using = "eyp_movetonexteducationstage")]
        public IWebElement Eyp_movetonexteducationstage { get; set; }

        /*{
                var dropdown = driver.FindElement(By.Id("eyp_movetonexteducationstage"));
                dropdown.FindElement(By.XPath("//option[. = 'No']")).Click();
            } */

        [FindsBy(How = How.Id, Using = "btnSubmitChild")]
        public IWebElement BtnSubmitChild { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_employmentstatusid")]
        public IWebElement Eyp_employmentstatusid { get; set; }

        [FindsBy(How = How.XPath, Using = "//option[. = 'Employed']")]
        public IWebElement OptionEmployed { get; set; }


        /*
 
                var dropdown = driver.FindElement(By.Id("eyp_employmentstatusid"));
                dropdown.FindElement(By.XPath("//option[. = 'Employed']")).Click();
            
      */

        [FindsBy(How = How.Id, Using = "eyp_occupationname")]
        public IWebElement Eyp_occupationname { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_occupationphone")]
        public IWebElement Eyp_occupationphone { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_occupationemailaddress")]
        public IWebElement Eyp_occupationemailaddress { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_occupationcountryid")]
        public IWebElement Eyp_occupationcountryid { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".autoaddress-text-box")]
        public IWebElement Box { get; set; }



        [FindsBy(How = How.Id, Using = "eyp_partneremploymentstatusid")]
        public IWebElement Eyp_partneremploymentstatusid { get; set; }


        [FindsBy(How = How.XPath, Using = "//option[. = 'None of the above']")]
        public IWebElement NoneOption { get; set; }

        /*{
            var dropdown = driver.FindElement(By.I("eyp_partneremploymentstatusid"));
            dropdown.FindElement(By.XPath("//option[. = 'None of the above']")).Click();
        } */


        [FindsBy(How = How.XPath, Using = "//option[. = 'Self Employed']")]
        public IWebElement SelfEmployedd { get; set; }

        /*{
            var dropdown = driver.FindElement(By.Id("eyp_partneremploymentstatusid"));
            dropdown.FindElement(By.XPath("//option[. = 'Self Employed']")).Click();
        } */

        [FindsBy(How = How.XPath, Using = "//option[. = 'Education / Training']")]
        public IWebElement EduOption { get; set; }


        /*{
            var dropdown = driver.FindElement(By.Id("eyp_partneremploymentstatusid"));
            dropdown.FindElement(By.XPath("//option[. = 'Education / Training']")).Click();
        } */

        [FindsBy(How = How.Id, Using = "eyp_partneroccupationname")]
        public IWebElement Eyp_partneroccupationname { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_partneroccupationtitle")]
        public IWebElement Eyp_partneroccupationtitle { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnercourseleadtonfqaward")]
        public IWebElement Eyp_partnercourseleadtonfqaward { get; set; }


        [FindsBy(How = How.XPath, Using = "//option[. = 'Yes']")]
        public IWebElement YesOption { get; set; }

        /*{
        var dropdown = driver.FindElement(By.Id("eyp_partnercourseleadtonfqaward"));
        dropdown.FindElement(By.XPath("//option[. = 'Yes']")).Click();
        } */

        [FindsBy(How = How.Id, Using = "eyp_partnernfqlevelid")]
        public IWebElement Eyp_partnernfqlevelid { get; set; }


        [FindsBy(How = How.XPath, Using = "//option[. = 'Level 7']")]
        public IWebElement LevelOption { get; set; }

        /*{
        var dropdown = driver.FindElement(By.Id("eyp_partnernfqlevelid"));
        dropdown.FindElement(By.XPath("//option[. = 'Level 7']")).Click();
        } */

        [FindsBy(How = How.Id, Using = "eyp_revenuejointassessed")]
        public IWebElement Eyp_revenuejointassessed { get; set; }



        [FindsBy(How = How.Id, Using = "eyp_fasttrack")]
        public IWebElement Eyp_fasttrack { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_earnnonpayey1")]
        public IWebElement Eyp_earnnonpayey1 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_declareearnnonpayey1")]
        public IWebElement Eyp_Declare_earnnonpayey1 { get; set; }

       [FindsBy(How = How.Id, Using = "eyp_incomeearnednonpayey1")]
        public IWebElement Eyp_incomeearnednonpayey1 { get; set; }


        [FindsBy(How = How.XPath, Using = "//option[. = 'No']")]
        public IWebElement NoOption { get; set; }

        /*{
            var dropdown = driver.FindElement(By.Id("eyp_earnnonpayey1"));
            dropdown.FindElement(By.XPath("//option[. = 'No']")).Click();
        } */


        [FindsBy(How = How.Id, Using = "eyp_earnnonpayey2")]
        public IWebElement Eyp_earnnonpayey2 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_incomeearnednonpayey2")]
        public IWebElement Eyp_incomeearnednonpayey2 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_receivedmaintenance")]
        public IWebElement Eyp_receivedmaintenance { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_maintenancereceivedy1")]
        public IWebElement Eyp_maintenancereceivedy1 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_maintenancereceivedy2")]
        public IWebElement Eyp_maintenancereceivedy2 { get; set; }

        
        [FindsBy(How = How.Id, Using = "eyp_paidmaintenance")]
        public IWebElement Eyp_paidmaintenance { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_maintenancepaidy1")]
        public IWebElement Eyp_maintenancepaidy1 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_maintenancepaidy2")]
        public IWebElement Eyp_maintenancepaidy2 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_earnedincomeoutside")]
        public IWebElement Eyp_earnedincomeoutside { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_incomeoutsidey1")]
        public IWebElement Eyp_incomeoutsidey1 { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_incomeoutsidey2")]
        public IWebElement Eyp_incomeoutsidey2 { get; set; }

      
        [FindsBy(How = How.Id, Using = "eyp_privatepensioncontributed")]
        public IWebElement Eyp_privatepensioncontributed { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_privatepensioncontributiony1")]
        public IWebElement Eyp_privatepensioncontributiony1 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_privatepensioncontributiony2")]
        public IWebElement Eyp_privatepensioncontributiony2 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_partnerreceivedmaintenance")]
        public IWebElement Eyp_partnerreceivedmaintenance { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnermaintenancereceivedy1")]
        public IWebElement Eyp_partnermaintenancereceivedy1 { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnermaintenancereceivedy2")]
        public IWebElement Eyp_partnermaintenancereceivedy2 { get; set; }

        

        [FindsBy(How = How.Id, Using = "eyp_partnerpaidmaintenance")]
        public IWebElement Eyp_partnerpaidmaintenance { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnermaintenancepaidy1")]
        public IWebElement Eyp_partnermaintenancepaidy1 { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnermaintenancepaidy2")]
        public IWebElement Eyp_partnermaintenancepaidy2 { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_partnerearnedincomeoutside")]
        public IWebElement Eyp_partnerearnedincomeoutside { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnerincomeoutsidey1")]
        public IWebElement Eyp_partnerincomeoutsidey1 { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnerincomeoutsidey2")]
        public IWebElement Eyp_partnerincomeoutsidey2 { get; set; }
        
            

        [FindsBy(How = How.Id, Using = "eyp_partnerprivatepensioncontributed")]
        public IWebElement Eyp_partnerprivatepensioncontributed { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnerprivatepensioncontributiony1")]
        public IWebElement Eyp_partnerprivatepensioncontributiony1 { get; set; }

        [FindsBy(How = How.Id, Using = "eyp_partnerprivatepensioncontributiony2")]
        public IWebElement Eyp_partnerprivatepensioncontributiony2 { get; set; }
        
            

        [FindsBy(How = How.Id, Using = "eyp_custodydeclaration_label")]
        public IWebElement Eyp_custodydeclaration_label { get; set; }


        [FindsBy(How = How.Id, Using = "eyp_informationtruthfuldeclaration_label")]
        public IWebElement Eyp_informationtruthfuldeclaration_label { get; set; }


        [FindsBy(How = How.Id, Using = "btnModalSubmit")]
        public IWebElement BtnModalSubmit { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".redirect-buttons")]
        public IWebElement RedirectButton { get; set; }


        [FindsBy(How = How.PartialLinkText, Using = "View Application")]
        public IWebElement ViewApplication { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/a")]
        public IWebElement Dimisscookie_Message { get; set; }


        [FindsBy(How = How.XPath, Using = "//footer/div[2]/div/div/div[2]/ul/li[6]/a")]
        public IWebElement Admin_SignIn { get; set; }


        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "submit-signin-local")]
        public IWebElement Submit { get; set; }

        [FindsBy(How = How.XPath, Using = " //*[@id='menu-bar']/ul/li[1]/a")]
        public IWebElement MyApplicationsLink { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='menu-bar']/ul/li[1]/ul/li[1]/a")]
        public IWebElement ViewApplications { get; set; }

        [FindsBy(How = How.Id, Using = "submit-signin-local")]
        public IWebElement SignIn_Page { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "New Application")]
        public IWebElement NewApplication { get; set; }

        public IncomeAssessed_ApplicantPortal_Page(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }


        [TestMethod]
        public void Page_IncomeAssessedApplicant()
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

            startIncomeAssessedApplication.Click();

            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);


            Dataprivacystatement_label.Click();

            NextButton.Click();

            AJAXCall.WaitForAjax();


            Thread.Sleep(1000);
            SelectElement residentOption = new SelectElement(Resident);
            residentOption.SelectByText("No");

            AJAXCall.WaitForAjax();

            SelectElement EuCitizen = new SelectElement(Eyp_eucitizen);
            EuCitizen.SelectByText("No");

            AJAXCall.WaitForAjax();

            SelectElement EftaCitizen = new SelectElement(Eyp_eftacitizen);
            EftaCitizen.SelectByText("No");


            AJAXCall.WaitForAjax();

            SelectElement Asylumseeker = new SelectElement(Eyp_asylumrefugee);
            Asylumseeker.SelectByText("No");

            AJAXCall.WaitForAjax();

            SelectElement selfEmployed = new SelectElement(Eyp_employedinireland);
            selfEmployed.SelectByText("Yes");


            NextButton.Click();
            //AJAXCall.WaitForAjax();

            var address_0 = "17 The Blennicks, Rosses Point, Co.Silgo";
            TextBox_Address.SendKeys(address_0);

           
            Thread.Sleep(800);
            driver.FindElement(By.CssSelector(".autoaddress-button")).Click();

            Thread.Sleep(800);

            AJAXCall.WaitForAjax();
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 500)", "");
            Thread.Sleep(800);
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NextButton")));

            ReportsGeneration._test.Log(AventStack.ExtentReports.Status.Pass, address_0 + "      " + "address details added successfully" + "      " + "PASSED");
            AJAXCall.WaitForAjax();
            if (AJAXCall.IsElementPresent(By.Id("btnNext")))
            {
                NextButton.Click();
            }
            Thread.Sleep(1000);

            SelectElement LivingWithPartner = new SelectElement(Eyp_livingwithpartner);
            LivingWithPartner.SelectByText("Yes");


            Eyp_livingwithpartnerdeclaration_label.Click();

            Eyp_partnerfirstname.SendKeys("Test");
            Eyp_partnerlastname.SendKeys("AddPartner");


            Eyp_partnerppsn.SendKeys("8967543AS");

            DOB_Calendar.SendKeys("18/11/1979");

            Eyp_partneremailaddress.SendKeys("automation@pobal.ie");

            NextButton.Click();


          /*  Eyp_firstname.SendKeys("Test");
            Eyp_lastname.SendKeys("Automation");

            var ppsndigit = Constant_functions.RandomNumGeneration(7);

            var ppsnAlpha = Constant_functions.randomString(2);
            var ppsn = ppsndigit + ppsnAlpha;

            Eyp_ppsn.SendKeys(ppsn);

            Eyp_ppsn.SendKeys("ZX");
            var myDate = DateTime.Now;

            var newDate = myDate.AddYears(-8);

            var chickDOB = newDate.ToString("dd/MM/yyyy");
            DOB_Calendar.SendKeys(chickDOB);

            SelectElement genderVateal = new SelectElement(Genderid);
            genderVal.SelectByText("Female"); */

            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(driver);
            Ap.IncomeAccess_ApplicantPortal_ChildData();

            NextButton.Click();

            SelectElement partnerEmp = new SelectElement(Eyp_employmentstatusid);
            partnerEmp.SelectByText("Employed");

            Eyp_occupationname.SendKeys("Pobal");
            Eyp_occupationphone.SendKeys("0897654567");


            var emailId = Constant_functions.randomString(9);
            Eyp_occupationemailaddress.SendKeys(emailId + "@hotmail.com");


            Thread.Sleep(1000);
            TextBox_Address.SendKeys("16 Pearse Square, Greenpark Road, Bray, Co. Wicklow");


            

            driver.FindElement(By.XPath("//*[@id='AutoAddressControl']/div/button")).Click();

            Thread.Sleep(1000);
            
            AJAXCall.WaitForAjax();
            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0, 500)", "");

            

            NextButton.Click();

            SelectElement partnerProfession = new SelectElement(Eyp_partneremploymentstatusid);
            partnerProfession.SelectByText("Education / Training");

            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0, 500)", "");

            Thread.Sleep(1000);
            Eyp_partneroccupationname.SendKeys("Pobal CO.");


            Eyp_partneroccupationtitle.SendKeys("Masters");
            SelectElement Partnercourseleadtonfqaward = new SelectElement(Eyp_partnercourseleadtonfqaward);
            Partnercourseleadtonfqaward.SelectByText("Yes");


            SelectElement Partnernfqlevelid = new SelectElement(Eyp_partnernfqlevelid);
            Partnernfqlevelid.SelectByText("Level 8");
            
           
            NextButton.Click();

            SelectElement revenueAssist = new SelectElement(Eyp_revenuejointassessed);
            revenueAssist.SelectByText("Yes");

            SelectElement fastTrack = new SelectElement(Eyp_fasttrack);
            fastTrack.SelectByText("Yes");

            NextButton.Click();

            SelectElement Form12 = new SelectElement(Eyp_earnnonpayey1);
            Form12.SelectByText("Yes");
            SelectElement Declare_Form12 = new SelectElement(Eyp_Declare_earnnonpayey1);
            Declare_Form12.SelectByText("Yes");

            
            Eyp_incomeearnednonpayey1.SendKeys("200");

            SelectElement Partner_Form12 = new SelectElement(Eyp_earnnonpayey2);
            Partner_Form12.SelectByText("Yes");

            Eyp_incomeearnednonpayey2.SendKeys("300");

            NextButton.Click();

            SelectElement recvePaymentMaintenance = new SelectElement(Eyp_receivedmaintenance);
            recvePaymentMaintenance.SelectByText("No");


            Eyp_maintenancereceivedy1.SendKeys("400");

            Eyp_maintenancereceivedy2.SendKeys("200");

            SelectElement paidMaintenance = new SelectElement(Eyp_paidmaintenance);
            paidMaintenance.SelectByText("Yes");


            Eyp_maintenancepaidy1.SendKeys("200");
            Eyp_maintenancepaidy2.SendKeys("200");

            

           SelectElement Earnedincomeoutside = new SelectElement(Eyp_earnedincomeoutside);
           Earnedincomeoutside.SelectByText("Yes");


            Eyp_incomeoutsidey1.SendKeys("400");

            Eyp_incomeoutsidey2.SendKeys("200");

            SelectElement Privatepensioncontributed = new SelectElement(Eyp_privatepensioncontributed);
            Privatepensioncontributed.SelectByText("Yes");


            Eyp_privatepensioncontributiony1.SendKeys("300");
            Eyp_privatepensioncontributiony2.SendKeys("200");

            SelectElement Partnerreceivedmaintenance = new SelectElement(Eyp_partnerreceivedmaintenance);
            Partnerreceivedmaintenance.SelectByText("Yes");

            Eyp_partnermaintenancereceivedy1.SendKeys("200");
            Eyp_partnermaintenancereceivedy2.SendKeys("300");

            
            SelectElement Partnerpaidmaintenance = new SelectElement(Eyp_partnerpaidmaintenance);
            Partnerpaidmaintenance.SelectByText("Yes");


            Eyp_partnermaintenancepaidy1.SendKeys("300");
            Eyp_partnermaintenancepaidy2.SendKeys("200");

            SelectElement Partnerearnedincomeoutside = new SelectElement(Eyp_partnerearnedincomeoutside);
            Partnerearnedincomeoutside.SelectByText("Yes");


            Eyp_partnerincomeoutsidey1.SendKeys("300");

            Eyp_partnerincomeoutsidey2.SendKeys("300");

            SelectElement Partnerprivatepensioncontributed = new SelectElement(Eyp_partnerprivatepensioncontributed);
            Partnerprivatepensioncontributed.SelectByText("Yes");
           


            Eyp_partnerprivatepensioncontributiony1.SendKeys("200");

            Eyp_partnerprivatepensioncontributiony2.SendKeys("400");

            NextButton.Click();

            Assert.Equals(driver.Url, driver.Url);
            AJAXCall.WaitForAjax();

            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

            NextButton.Click();
            Thread.Sleep(2000);

            IWebElement label = driver.FindElement(By.XPath("//label[@for='eyp_custodydeclaration']"));
            new Actions(driver).MoveToElement(label, 1, 1).Click().Perform();

            AJAXCall.WaitForAjax();

            Eyp_informationtruthfuldeclaration_label.Click();

            NextButton.Click();
            Thread.Sleep(2000);

            AJAXCall.WaitForAjax();

            BtnModalSubmit.Click();




        }
    }

}

