using Automation_Suite.Application_Tier.PageObjectRepository.ApplicantPortal;
using Automation_Suite.Configuration_Tier;
using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace Automation_Suite.Application_Tier.TestRunner
{
    [TestFixture]
    class ApplicantPortal_CHICK : ReportsGeneration
    {
        [Test, Category("BVT : Build Verification Test")]
        public void ApplicantPortal_Page_ZeroSubsidy()
        {
            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            Ap.Chick_UniversalApplication_NoSubsidy();
        }


        [Test, Category("BVT : Build Verification Test")]
        public void ApplicantPortal_Page_ValidSubsidy()
        {
            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            Ap.Chick_UniversalApplication_Subsidy();

        }

        [Test, Category("BVT : Build Verification Test")]
        public void NCS_Awards_Detail()
        {

        }
    }

}
