using Automation_Suite.Application_Tier.CRM;
using Automation_Suite.Configuration_Tier;
using Automation_Suite.Utility_Tier;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;

namespace Automation_Suite.Application_Tier.TestRunner
{
    [TestFixture]
  

    [Category("BVT : Build Verification Test")]
    class CRM_UAT_ServiceProviderPortal_TestRunner : ReportsGeneration
    {   

        [Test]
        //[Parallelizable]
        
        public void SPP_CRM_validation()
        {
            try
            {


                CRM_UAT_ServiceProviderPortal_Page spp_crm = new CRM_UAT_ServiceProviderPortal_Page(GetDriver());

                _driver.Navigate().GoToUrl(URLConfig.UAT_CRM);
                spp_crm.CRM_SPP_TRN_SearchAndApproval(_driver);

                _test.Log(Status.Pass, "CRM_UAT_Validation" + " " + "PASSED");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        [Test]
        public void Email_Test_SPP()
        {
            try
            {

                CRM_UAT_ServiceProviderPortal_Page spp_crm = new CRM_UAT_ServiceProviderPortal_Page(GetDriver());

                _driver.Navigate().GoToUrl(URLConfig.UAT_CRM);
                spp_crm.Email_LinkActivation(_driver);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
