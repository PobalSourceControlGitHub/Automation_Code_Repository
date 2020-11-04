using Automation_Suite.Application_Tier.PageObjectRepository;
using Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal;
using Automation_Suite.Configuration_Tier;
using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using NUnit.Framework;

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
