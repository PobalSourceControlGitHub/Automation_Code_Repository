using Automation_Suite.Application_Tier.PageObjectRepository.CRM;
using Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal;
using Automation_Suite.Configuration_Tier;
using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Threading;

namespace Automation_Suite.Application_Tier.TestRunner
{
    [TestFixture]

    class ExistingUser_ServiceProviderPortal : ReportsGeneration
    {
        [Test, Category("BVT : Build Verification Test")]
        public void MyAccount_AllPages()
        {
            SignIn_ServiceProviderPortal ExistingUser_Navigation = new SignIn_ServiceProviderPortal(_driver);
            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            ExistingUser_Navigation.MyAccount_NavigationTest(_driver);
        }

        [Category("SPP_SignIn_Coverage")]
        [Test, Order(1)]
        public void SP_Portal_BankAccount_EndToEnd()
        {
            SignIn_ServiceProviderPortal regression_SignIN = new SignIn_ServiceProviderPortal(_driver);
            regression_SignIN.MultipleWindowHandling(URLConfig.TestURL_ServiceProviderPortal, URLConfig.UAT_CRM);
          
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");
            Thread.Sleep(1000);

            _driver.Navigate().GoToUrl(URLConfig.UAT_CRM);
        
            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            CRM_Bank_Page cp = new CRM_Bank_Page(_driver);
            cp.BankApproval();          
        }

        [Category("SPP_SignIn_Functional_Steps")]
        [Test, Order(2)]
        public void CRM_BankCode()
        {
            _driver.Navigate().GoToUrl(URLConfig.UAT_CRM);

            CRM_Bank_Page cp = new CRM_Bank_Page(_driver);
            cp.Bank_CodeActivation(_driver);

            Thread.Sleep(1000);
            SignIn_ServiceProviderPortal regression_SignIN = new SignIn_ServiceProviderPortal(_driver);
            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            //regression_SignIN.searchThroughAccountName(_driver);
        }

        [Category("SPP_SignIn_Functional_Steps")]
        [Test, Order(3)]
        public void goingBackToBankAccount()
        {
            CRM_Bank_Page regression_SignIN = new CRM_Bank_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.UAT_CRM);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");
            regression_SignIN.BankApproval();
        }


        [Category("SPP_SignIn_Coverage")]
        [Test, Order(4)]
        public void SP_Portal_TuslaCertificate_EndToEnd()
        {
            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            TuslaCertificate Tc = new TuslaCertificate(_driver);
            Tc.TuslaSubmission();

            DateTime time = DateTime.Now;
            string fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
            string screenShotLocation = Capture(GetDriver(), fileName, true);

            _test.Log(Status.Pass, "Snapshot below: " + _test.AddScreenCaptureFromPath(screenShotLocation + "\\Result_Tier\\Screenshots\\" + fileName));

            Tc.TuslaCRM_Approval();
        }



        [Category("SPP_SignIn_Coverage")]
        [Test, Order(5)]
        public void SP_Portal_FeeList_EndToEnd()
        {
            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");
            Feelist FL = new Feelist(_driver);
            FL.FeeList_Submission_SPP();


        }

        [Category("SPP_SignIn_Coverage")]
        [Test, Order(6)]
        public void SP_Portal_ServiceCalendars_EndToEnd()
        {
            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");
            ServiceCalendars Sc = new ServiceCalendars(_driver);
            Sc.ServiceCalendar_Page();
        }

        [Category("SPP_SignIn_Coverage")]
        [Test, Order(8)]
        public void SP_Portal_Registration_EndToEnd()
        {

            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            RegistartionTab progPage = new RegistartionTab(_driver);
            progPage.RegistrationPage();
        }

        [Category("SPP_SignIn_Coverage")]
        [Test, Order(9)]
        public void SP_Portal_Returns_EndToEnd()
        {
            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -Returns Section :" + "    " + _driver.Url + "           " + "PASSED");
            Returns returns = new Returns();         
        }

        
        [Category("SPP_SignIn_Coverage")]
        [Test, Order(8)]
        public void SP_Portal_Programmes_EndToEnd()
        {
            //Assert.Ignore();

            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            Programmes progPage = new Programmes(_driver);
            progPage.ProgrammePage();
        }
    }

}
