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
        /// <summary>
        /// Zero Subsidy
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ZeroSubsidy()
        {
            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            Ap.Chick_UniversalApplication_NoSubsidy();
        }


        /// <summary>
        /// Applicant portal with Ireland resident option
        /// </summary>
        /// 
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ValidSubsidy()
        {
            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            Ap.Chick_UniversalApplication_Subsidy(Constant.Constant_functions.key_IrelandCitizen);

        }

        /// <summary>
        /// Applicant portal with EU option
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ValidSubsidy_EU()
        {
            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            Ap.Chick_UniversalApplication_Subsidy(Constant.Constant_functions.key_EuCitizen);

        }

        /// <summary>
        /// Applicant portal with switzerland , iceland , norway option
        /// </summary>
        
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ValidSubsidy_SW_Iceland_Nr()
        {
            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            Ap.Chick_UniversalApplication_Subsidy(Constant.Constant_functions.key_SW_IC_NR_Citizen);

        }


        /// <summary> 
        /// Applicant portal with Asylum seeker option
        /// </summary>

        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ValidSubsidy_Asylum_Seeker()
        {
            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            Ap.Chick_UniversalApplication_Subsidy(Constant.Constant_functions.Key_Asylum_Seeker_RefugeeCitizen);

        }

        /// <summary>
        /// Applicant portal with self employed option
        /// </summary>
        
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ValidSubsidy_SelfEmployed()
        {
            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            Ap.Chick_UniversalApplication_Subsidy(Constant.Constant_functions.key_EuCitizen);
        }



        /// <summary>
        /// NCS Detials
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void NCS_Awards_Detail()
        {
            CHICK_ApplicantPortal_Page Ap = new CHICK_ApplicantPortal_Page(_driver);
            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            Ap.AwardPage();

            _test.Log(Status.Pass, "Child Award Details" + "    " + _driver.Url + "           " + "PASSED");

        }

        /// <summary>
        /// 
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_IncomeAssessed()
        {

            IncomeAssessed_ApplicantPortal_Page incomeAssessPg = new IncomeAssessed_ApplicantPortal_Page(_driver);

            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            incomeAssessPg.Page_IncomeAssessedApplicant();

        }

        /// <summary>
        /// 
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_IncomeAssessed_NoPartner()
        {



        }
        /// <summary>
        /// Partner application with fast track process
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_IncomeAssessed_Partner_FastTrack()
        {



        }

        /// <summary>
        /// Couple application with fast track process each
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_IncomeAssessed_Both_FastTrack()
        {

            IncomeAssessed_ApplicantPortal_Page incomeAssessPg = new IncomeAssessed_ApplicantPortal_Page(_driver);

            _driver.Navigate().GoToUrl(URLConfig.ApplicantPortal_TestURL);
            string url = _driver.Url;

            _test.Log(Status.Pass, "Applicant Portal -URL :" + "    " + _driver.Url + "           " + "PASSED");

            AJAXCall.CheckPageIsLoaded(_driver);
            incomeAssessPg.Page_IncomeAssessedApplicant();

        }

        /// <summary>
        /// Both application with no fast track process
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_IncomeAssessed_No_FastTrack()
        {



        }

        /// <summary>
        /// Child in Pre ECE
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ValidSubsidy_PRE_ECE()
        {



        }
        /// <summary>
        /// child going to Junior infant from ECE
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ValidSubsidy_ECCE()
        {



        }

        /// <summary>
        /// 
        /// </summary>
        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ValidSubsidy_PRECCE_To_ECE()
        {



        }
        /// <summary>
        /// Child < 6 years and >15 years
        /// </summary>

        [Test, Category("Applicant_Portal_Coverage")]
        public void ApplicantPortal_Page_ValidSubsidy_MorethansixyeaAndLessthanfifteenyears()
        {



        }

       
    }
}