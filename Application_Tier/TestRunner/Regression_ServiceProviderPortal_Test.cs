using Automation_Suite.Application_Tier.PageObjectRepository.ServiceProviderPortal;
using Automation_Suite.Configuration_Tier;
using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace Automation_Suite.Application_Tier.TestRunner
{
    [TestFixture]
    [Category("Regression")]
    class Regression_ServiceProviderPortal_Test : ReportsGeneration
    {  
        [Test]
        public void RegTest()
        {
            Regression_ServiceProviderPortal_OnboardingProcess Op_reg = new Regression_ServiceProviderPortal_OnboardingProcess(GetDriver());
            _driver.Navigate().GoToUrl(URLConfig.TestURL_ServiceProviderPortal);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Service Provider Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");
            AJAXCall.CheckPageIsLoaded(_driver);
            Op_reg.OnBoardingWithDifferentOptions(_driver);
            //ReporterUtil.ReportEvent("pass", "SPP", "NO Exception");

        }

        }



}

