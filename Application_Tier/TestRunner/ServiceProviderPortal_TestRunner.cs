using Automation_Suite.Application_Tier.CRM;
using Automation_Suite.Application_Tier.PageObjectRepository;
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
    public class ServiceProviderPortal_TestRunner : ReportsGeneration
    {
        [Test, Category("BVT : Build Verification Test"), Category("Regression")]
        public void OnboardingTest_Frontend()
        {   
            
           OnBoardingPage Op = new OnBoardingPage(GetDriver());
          _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

           _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    "+ _driver.Url + "           "+ "PASSED");
            AJAXCall.CheckPageIsLoaded(_driver);

           
            Op.StartOnboarding_Frontend(_driver);          
        }

        [Test, Category("BVT : Build Verification Test"), Category("Regression")]
        public void OnboardingTest_CRO_Option()
        {

            OnBoarding_CRO_Selection_And_ChangeOfCircumstances_Scenarios Op = new OnBoarding_CRO_Selection_And_ChangeOfCircumstances_Scenarios(GetDriver());
            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");
            AJAXCall.CheckPageIsLoaded(_driver);


            Op.StartOnboarding_Frontend_CRO(_driver);

            DateTime time = DateTime.Now;
            string fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
            string screenShotLocation = Capture(GetDriver(), fileName, true);


            Thread.Sleep(500);
            _test.Log(Status.Pass, "Snapshot below: " + _test.AddScreenCaptureFromPath(screenShotLocation + "\\Result_Tier\\Screenshots\\" + fileName));

            Thread.Sleep(1000);

            CRM_UAT_ServiceProviderPortal_Page spp_crm = new CRM_UAT_ServiceProviderPortal_Page(GetDriver());
            _driver.Navigate().GoToUrl(URLConfig.UAT_CRM);


            Thread.Sleep(1000);
            spp_crm.Email_LinkActivation(_driver);

            time = DateTime.Now;
            fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
            screenShotLocation = Capture(GetDriver(), fileName, true);
            Thread.Sleep(500);


            _test.Log(Status.Pass, "Snapshot below: " + _test.AddScreenCaptureFromPath(screenShotLocation + "\\Result_Tier\\Screenshots\\" + fileName));

            Thread.Sleep(1000);

            _driver.Navigate().GoToUrl(URLConfig.UAT_CRM);
            spp_crm.crm_uat_validation(_driver);
            _test.Log(Status.Pass, "CRM_UAT_Validation" + " " + "PASSED");
        }


        [Test, Category("BVT : Build Verification Test"), Category("Regression")]
        public void OnboardingTest_ChangeOfCircumstances_DropdownOption()
        {

            OnBoarding_CRO_Selection_And_ChangeOfCircumstances_Scenarios Op = new OnBoarding_CRO_Selection_And_ChangeOfCircumstances_Scenarios(GetDriver());
            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");
            AJAXCall.CheckPageIsLoaded(_driver);


            Op.StartOnboarding_ChangeOfCircumstances(_driver);




        }
    }
}
