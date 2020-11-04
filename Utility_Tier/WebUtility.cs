using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Suite.Utility_Tier
{
    class  WebUtility : ReportsGeneration
    {

        public static IWebDriver webDriver;

        public WebUtility(IWebDriver webDriver)
        {
            ReportsGeneration._driver = webDriver;
        }
        public static bool checkElementsByName(ArrayList arrElements)
        {
            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!checkElementByName(strName)) returnValue = false;

            }
            return returnValue;
        }




        public static bool checkElementByName(string strName)
        {
            bool returnValue = false;
            try
            {
                if (webDriver.FindElement(By.Name(strName)).Displayed)
                {
                    ////ReporterUtil.Pass("[Element Exist] : " + strName);
                    returnValue = true;
                }
                else
                {
                    //ReporterUtil.Fail("[Element Does Not Exist] : " + strName);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Element Does Not Exist] : " + strName);
                returnValue = false;
            }
            return returnValue;
        }

        public static bool clickElementByXpath(string strName)
        {
            bool returnValue = false;
            try
            {
                if (webDriver.FindElement(By.XPath(strName)).Displayed)
                {
                    webDriver.FindElement(By.XPath(strName)).Click();
                    ReporterUtil.ReportEvent("Pass", "Control Click", "Control Xpath exist and Clicked");

                    returnValue = true;
                }
                else
                {
                    ReporterUtil.ReportEvent("Fail", "Control Click", "Control Xpath  does not exist");

                    returnValue = false;
                }
            }

            catch (Exception excep)
            {
                //ReporterUtil.Fail("Element cannot be found or clicked" + strName);
            }
            return returnValue;
        }


        public static bool clickElementByXpath(ObjectRepositoryUtil.objPropertyValue ObjectRepo)
        {
            bool returnValue = false;
            try
            {
                if (webDriver.FindElement(By.XPath(ObjectRepo.Property)).Displayed)
                {
                    webDriver.FindElement(By.XPath(ObjectRepo.Property)).Click();
                    ReporterUtil.ReportEvent("Pass", ObjectRepo.REFName + " Click", "Control Xpath exist and Clicked");

                    returnValue = true;
                }
                else
                {
                    ReporterUtil.ReportEvent("Fail", ObjectRepo.REFName + " Clicked", "Control Xpath  does not exist");

                    returnValue = false;
                }
            }

            catch (Exception excep)
            {
                //ReporterUtil.Fail("Element cannot be found or clicked" + strName);
            }
            return returnValue;
        }

        public static bool clickElementByName(string strName)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.Name(strName)).Displayed)
                {
                    webDriver.FindElement(By.Name(strName)).Click();
                    //ReporterUtil.Pass("[Element Exist And Clicked] : " + strName);
                    returnValue = true;
                }
                else
                {
                    //ReporterUtil.Fail("[Element Does Not Exist Cannot Be Clicked] : " + strName);
                    returnValue = false;
                }
            }

            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Element Does Not Exist Cannot Be Clicked] : " + strName);
                returnValue = false;
            }
            return returnValue;
        }


        public static bool clickElementByLinkText(string strName)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.LinkText(strName)).Displayed)
                {
                    webDriver.FindElement(By.LinkText(strName)).Click();
                    //ReporterUtil.Pass("[Link Exist And Clicked] : " + strName);
                    returnValue = true;
                }
                else
                {
                    //ReporterUtil.Fail("[Link Does Not Exist Cannot Be Clicked] : " + strName);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Link Does Not Exist Cannot Be Clicked] : " + strName);
                returnValue = false;
            }

            return returnValue;
        }

        public static bool clickElementByID(string strName)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.Id(strName)).Displayed)
                {
                    webDriver.FindElement(By.Id(strName)).Click();
                    //ReporterUtil.Pass("[Element By ID Exist And Clicked] : " + strName);
                    returnValue = true;
                }
                else
                {
                    //ReporterUtil.Fail("[Element by ID Does Not Exist Cannot Be Clicked] : " + strName);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Element by ID Does Not Exist Cannot Be Clicked] : " + strName);
                returnValue = false;
            }
            return returnValue;
        }

        public static bool inputTextByXpath(string Locator, string InputString)
        {
            bool returnValue = false;
            try
            {
                if (true)
                {
                    webDriver.FindElement(By.XPath(Locator)).SendKeys(InputString);
                    ReporterUtil.ReportEvent("Pass", "Text Input", Locator + "By Xpath exist and entered" + InputString);
                    returnValue = true;
                }
                else
                {
                    //ReporterUtil.Fail("[ " + Locator + "By Xpath Does Not Exist And Cannot Typed] : " + InputString);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail(Locator + excep.Message);
                Console.WriteLine("Exception:" + ex.Message);
            }
            return returnValue;
        }


        public static bool inputTextByXpath(ObjectRepositoryUtil.objPropertyValue objectRef, string InputString)
        {

            bool returnValue = false;
            try
            {
                if (webDriver.FindElement(By.XPath(objectRef.Property)).Displayed)
                {
                    webDriver.FindElement(By.XPath(objectRef.Property)).Clear();
                    webDriver.FindElement(By.XPath(objectRef.Property)).SendKeys(InputString);
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                    Console.WriteLine("Text Input", objectRef.REFName + "By Xpath exist and entered" + InputString);

                    ReporterUtil.ReportEvent("Pass", "Text Input", objectRef.REFName + "By Xpath exist and entered" + InputString);
                    returnValue = true;
                }
                else
                {
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                    //ReporterUtil.Fail("[ " + Locator + "By Xpath Does Not Exist And Cannot Typed] : " + InputString);
                    returnValue = false;
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
                //ReporterUtil.Fail(Locator + excep.Message);
            }
            return returnValue;
        }


        public static bool inputTextByID(string idElementName, string InputString)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.Id(idElementName)).Displayed)
                {
                    webDriver.FindElement(By.Id(idElementName)).SendKeys(InputString);
                    //ReporterUtil.Pass("[ " + idElementName + " By ID Exist And Typed] : " + InputString);
                    returnValue = true;
                }
                else
                {
                    //ReporterUtil.Fail("[ " + idElementName + "By ID Does Not Exist And Cannot Typed] : " + InputString);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail(idElementName + " " + ex.Message);
            }
            return returnValue;
        }

        public static bool naviGateToUrl(string url, string pageTitle)
        {
            bool returnValue = false;
            try
            {
                webDriver.Navigate().GoToUrl(url);
                if (webDriver.Title.Contains(pageTitle))
                {
                    ReporterUtil.ReportEvent("Pass", "[Navigation Done to URL] - " + url, " [and has Title ]" + pageTitle);
                    webDriver.Manage().Window.Maximize();
                   
                    returnValue = true;
                }
                else
                {
                    ReporterUtil.ReportEvent("Fail", "Application Launch", "[Navigation To URL failed] - " + url);
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReporterUtil.ReportEvent("Fail", "Application Launch", "[Navigation To URL failed] - " + url + ex.Message);

            }
            return returnValue;
        }


        public static bool PartialLinkText(String linkName)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.PartialLinkText(linkName)).Displayed)
                {
                    //ReporterUtil.Pass("[Link Exist] : " + linkName);
                    returnValue = true;
                }
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Link Does not Exist] : " + linkName);
                returnValue = false;
            }
            return returnValue;
        }



        public static bool PartialLinksText(ArrayList arrElements)
        {

            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!PartialLinkText(strName)) returnValue = false;

            }
            return returnValue;
        }


        public static bool FindElementByTag(String tagName, string seachElement)
        {
            bool returnValue = false;
            try
            {

                if (webDriver.FindElement(By.XPath("//" + tagName + "[contains(text(),'" + seachElement + "')]")).Displayed)
                {
                    //ReporterUtil.Pass("[Element by tag(" + tagName + ") Exist] : " + seachElement);
                    returnValue = true;

                }
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Element by tag(" + tagName + ") Does not Exist] : " + seachElement);
                returnValue = false;
            }
            return returnValue;
        }



        public static bool FindElementsByTag(ArrayList arrElements, string strTagname)
        {

            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!FindElementByTag(strTagname, strName)) returnValue = false;

            }
            return returnValue;
        }

        public static bool checkElementByID(string strName)
        {
            bool returnValue = false;
            try
            {
                IWebElement WE = webDriver.FindElement(By.Id(strName));

                if (WE.Displayed)
                {
                    //ReporterUtil.Pass("[Element By ID =" + strName + " Exist] with text : " + WE.Text);
                    returnValue = true;
                }
                WE = null;
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Element by ID Does Not Exist] : " + strName);
                returnValue = false;
            }
            return returnValue;
        }


        public static bool checkElementsByID(ArrayList arrElements)
        {

            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!checkElementByID(strName)) returnValue = false;

            }
            return returnValue;
        }

        public static bool checkElementByClass(string strName)
        {
            bool returnValue = false;
            try
            {
                IWebElement WE = webDriver.FindElement(By.ClassName(strName));

                if (WE.Displayed)
                {
                    //ReporterUtil.Pass("[Element By Class =" + strName + " Exist] with text : " + WE.Text);
                    returnValue = true;
                }
                WE = null;
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Element by Class Does Not Exist] : " + strName);
                returnValue = false;
            }
            return returnValue;
        }


        public static bool checkElementsByClass(ArrayList arrElements)
        {

            bool returnValue = true;
            foreach (string strName in arrElements)
            {
                if (!checkElementByClass(strName)) returnValue = false;

            }
            return returnValue;
        }



        public static bool checkTextExistInElementByID(string elementByID, string text)
        {
            bool returnValue = false;

            try
            {
                IWebElement WE = webDriver.FindElement(By.Id(elementByID));


                if (WE.Displayed)
                {
                    if (WE.Text.Contains(text))
                    {
                        //ReporterUtil.Pass("[Element By ID =" + elementByID + " Exist] with text : " + text);
                        returnValue = true;
                    }
                    else
                    {
                        //ReporterUtil.Fail("[Element By ID =" + elementByID + " Exist] without text : " + text);
                        returnValue = true;
                    }
                }
                WE = null;
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Element by ID Does Not Exist] : " + elementByID);
                returnValue = false;
            }
            return returnValue;
        }



        public static bool checkTextExistInElementsByID(ArrayList arrElements)
        {

            bool returnValue = true;
            string elementName = "";
            if (arrElements.Count > 1)
            {
                elementName = arrElements[0].ToString();
                arrElements.RemoveAt(0);
                foreach (string strName in arrElements)
                {
                    if (!checkTextExistInElementByID(elementName, strName)) returnValue = false;

                }
            }
            else
            {
                returnValue = false;
            }

            return returnValue;
        }

        public static bool checkTextExistInElementByClass(string elementByClass, string text)
        {
            bool returnValue = false;

            try
            {
                IWebElement WE = webDriver.FindElement(By.ClassName(elementByClass));


                if (WE.Displayed)
                {
                    if (WE.Text.Contains(text))
                    {
                        //ReporterUtil.Pass("[Element By Class =" + elementByClass + " Exist] with text : " + text);
                        returnValue = true;
                    }
                    else
                    {
                        //ReporterUtil.Fail("[Element By Class =" + elementByClass + " Exist] without text : " + text);
                        returnValue = true;
                    }
                }
                WE = null;
            }
            catch (Exception ex)
            {
                //ReporterUtil.Fail("[Element by Class Does Not Exist] : " + elementByClass);
                returnValue = false;
            }
            return returnValue;
        }

        public static bool checkTextExistInElementsByClass(ArrayList arrElements)
        {

            bool returnValue = true;
            string elementName = "";
            if (arrElements.Count > 1)
            {
                elementName = arrElements[0].ToString();
                arrElements.RemoveAt(0);
                foreach (string strName in arrElements)
                {
                    if (!checkTextExistInElementByClass(elementName, strName)) returnValue = false;

                }
            }
            else
            {
                returnValue = false;
            }

            return returnValue;
        }

        public static string getTextFromTableByXpath(ObjectRepositoryUtil.objPropertyValue objectRef)
        {

            //bool returnValue = false;
            string returnValue = null;
            try
            {
                if (webDriver.FindElement(By.XPath(objectRef.Property)).Displayed)
                {
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                    Console.WriteLine("Text Object", objectRef.REFName + "By Xpath object exist and entered");

                    ReporterUtil.ReportEvent("Pass", "Text Input", objectRef.REFName + "By Xpath object exist");
                    returnValue = webDriver.FindElement(By.XPath(objectRef.Property)).Text.ToString();
                }
                else
                {
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                    //ReporterUtil.Fail("[ " + Locator + "By Xpath Does Not Exist And Cannot Typed] : " + InputString);
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
                //ReporterUtil.Fail(Locator + excep.Message);
            }
            return returnValue;
        }

        public static bool checkTextExistInElementByXPath(ObjectRepositoryUtil.objPropertyValue objectRef, string text)
        {
            bool returnValue = false;

            try
            {
                IWebElement WE = webDriver.FindElement(By.XPath(objectRef.Property));


                if (WE.Displayed)
                {
                    if (WE.Text.Contains(text))
                    {
                        ReporterUtil.ReportEvent("Pass", "Text Verify", "[Element By XPath =" + objectRef.REFName + " Exist] with text : " + text);
                        returnValue = true;
                    }
                    else
                    {
                        ReporterUtil.ReportEvent("Fail", "Text Verify", "[Element By XPath =" + objectRef.REFName + " Exist] with text : " + text);
                        returnValue = true;
                    }
                }
                WE = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
                //ReporterUtil.Fail("[Element by ID Does Not Exist] : " + elementByID);
                returnValue = false;
            }
            return returnValue;
        }
    }

}