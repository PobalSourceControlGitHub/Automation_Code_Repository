using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;
using OpenQA.Selenium.IE;
using Automation_Suite._02_Utility_Tier;
using WDSE;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;
using System.Threading;
using Microsoft.Edge.SeleniumTools;

namespace Automation_Suite.Utility_Tier
{
    [SetUpFixture]
    public class ReportsGeneration
    {
        public static ExtentReports _extent;
        public static ExtentTest _test;
        public static IWebDriver _driver;

        public string browser;
        private static readonly object ReportsUtil;

        public static string getTimeStamp()
        {

            return DateTime.Now.ToString("dd-MMM-yyyy_hh-mm-ss_tt");

        }


        [OneTimeSetUp]
        public static void ExtentReportStart()
        {
            ReporterUtil.GetEnvConfigDetails();
            _extent = new ExtentReports();

            string browser = Env.strCurrentBrowser;

            string Root = Directory.GetCurrentDirectory();
            var path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = path.Substring(0, path.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(projectPath.ToString() + "Result_Tier");
            var repoName = "Pobal_Report_" + getTimeStamp() + "_" + Env.strCurrentBrowser + ".html";


            var reportPath = projectPath + @"Result_Tier\Reports\" + repoName;
            ExtentV3HtmlReporter htmlReporter = new ExtentV3HtmlReporter(reportPath);

            // ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);

            // htmlReporter.LoadConfig(@"C:\PobalFramework-master\PobalFramework-master\Pobal_Test_Project\Automation_Suite\ReportConfig.xml");

            _extent.AttachReporter(htmlReporter);
            _extent.AddSystemInfo("Host Name", browser);
            _extent.AddSystemInfo("Environment", "Test");
            _extent.AddSystemInfo("UserName", "Ankita");
            





        }


        [OneTimeTearDown]
        public void ReportClose()
        {
            _extent.Flush();
        }

        [SetUp]
        public static void BeforeTest()
        {

            try
            {
                
                string browser = Env.strCurrentBrowser;  //Get browser name from the config
                switch (browser)
                {
                    case "Chrome":

                        Helper.KILL_ALL("Chrome");
                        ChromeDriverService service = ChromeDriverService.CreateDefaultService("webdriver.chrome.driver", @"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\chromedriver_win32\chromedriver_win32\chromedriver.exe");

                        //hide driver service command prompt window

                        service.HideCommandPromptWindow = true;
                        service.SuppressInitialDiagnosticInformation = true;

                        ChromeOptions options = new ChromeOptions();

                        //options.AddArgument("disable-infobars");
                        options.AddArgument("--start-maximized");
                        options.AddExcludedArgument("enable-automation");
                        options.AddAdditionalCapability("useAutomationExtension", false);

                        _driver = new ChromeDriver(service, options);

                        _driver.Manage().Cookies.DeleteAllCookies();
                        _driver.Manage().Window.Maximize();

                        break;


                    case "Firefox":

                        Helper.KILL_ALL("geckodriver");
                        FirefoxDriverService FFservice = FirefoxDriverService.CreateDefaultService(@"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite", "geckodriver.exe");

                        //Give the path of the Firefox Browser        
                        FFservice.FirefoxBinaryPath = @"C:\Users\asrivastava\AppData\Local\Mozilla Firefox\firefox.exe";

                        FirefoxOptions FFoptions = new FirefoxOptions();
                        FFoptions.AddAdditionalCapability("acceptInsecureCerts", true, true);
                        FFoptions.AddAdditionalCapability("acceptUntrustedCerts", true, true);

                        _driver = new FirefoxDriver(FFservice, FFoptions);

                        _driver.Manage().Cookies.DeleteAllCookies();
                        
                        _driver.Manage().Window.Maximize();

                        break;

                    case "Internet Explorer":

                        Helper.KILL_ALL("IEDriverServer");
                        InternetExplorerOptions IEoptions = new InternetExplorerOptions();
                        IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                        IEoptions.IgnoreZoomLevel = true;
                        _driver = new
                        InternetExplorerDriver(@"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\IEDriverServer_Win32_2.39.0\", IEoptions);


                        _driver.Manage().Cookies.DeleteAllCookies();
                        _driver.Manage().Window.Maximize();

                        break;

                    case "MicrosoftEdge Chromium":

                        Helper.KILL_ALL("msedgedriver");
                        var optionsEdge = new EdgeOptions();
                        optionsEdge.UseChromium = true;

                        _driver = new EdgeDriver(@"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\edgedriver_win64\", optionsEdge);
                        _driver.Manage().Cookies.DeleteAllCookies();
                        _driver.Manage().Window.Maximize();

                        break;


                    default:
                        Helper.KILL_ALL("Chrome");
                        service = ChromeDriverService.CreateDefaultService("webdriver.chrome.driver", @"C:\PobalFramework-master\PobalFramework-master\Pobal_Test_Project\Automation_Suite\chromedriver_win32\chromedriver.exe");

                        //hide driver service command prompt window

                        service.HideCommandPromptWindow = true;
                        service.SuppressInitialDiagnosticInformation = true;

                        ChromeOptions optionsCh = new ChromeOptions();

                        //options.AddArgument("disable-infobars");
                        optionsCh.AddArgument("--start-maximized");
                        optionsCh.AddExcludedArgument("enable-automation");
                        optionsCh.AddAdditionalCapability("useAutomationExtension", false);

                        _driver = new ChromeDriver(service, optionsCh);

                        _driver.Manage().Cookies.DeleteAllCookies();
                        _driver.Manage().Window.Maximize();

                        break;


                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Browser invoke Fail " + Ex.Message);
            }

            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);



        }


        [TearDown]
        public static void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
            ? ""
            : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;
            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    DateTime time = DateTime.Now;
                    string fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
                    string screenShotLocation_1 = Capture(GetDriver(), fileName, false);
                  //  FullWebPageScreenShotCapture("newChrome.png");

                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath(screenShotLocation_1 + "\\Result_Tier\\Screenshots\\" + fileName));
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default: //after test pass , here it is failing
                    logstatus = Status.Pass;

                    time = DateTime.Now;
                    fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";

                    //ReporterUtil.CaptureScreenShot(fileName);

                    string screenShotLocation = Capture(GetDriver(), fileName, true);

                   
                    Thread.Sleep(500);
                  

                    _test.Log(Status.Pass, "Snapshot below: " + _test.AddScreenCaptureFromPath(screenShotLocation + "\\Result_Tier\\Screenshots\\" + fileName));
                    break;
            }

            _test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            _extent.Flush();
            _driver.Quit();
        }
        public static IWebDriver GetDriver()
        {
            return _driver;
        }
        public static string Capture(IWebDriver driver,string screenShotName, bool flag)
        {
            if (flag)
            {
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                Screenshot screenshot = ts.GetScreenshot();
                var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                var actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
                var reportPath = new Uri(actualPath).LocalPath;


                var DirLocation = Directory.CreateDirectory(reportPath + "\\Result_Tier\\" + "Screenshots");
                if (!DirLocation.Exists)
                {
                    DirLocation = Directory.CreateDirectory(reportPath + "\\Result_Tier\\" + "Screenshots");


                    var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "\\Result_Tier\\Screenshots\\" + screenShotName;
                    var localpath = new Uri(finalpth).LocalPath;

                    screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
                }

                else
                {

                    var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "\\Result_Tier\\Screenshots\\" + screenShotName;
                    var localpath = new Uri(finalpth).LocalPath;
                    screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
                }


                return reportPath;

            }
            return CaptureFullImage(driver, screenShotName);


        
    }

        public static string CaptureFullImage(IWebDriver driver, string screenShotName)
        {

            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            var reportPath = new Uri(actualPath).LocalPath;


            var DirLocation = Directory.CreateDirectory(reportPath + "\\Result_Tier\\" + "Screenshots");
            VerticalCombineDecorator vcd = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            if (!DirLocation.Exists)
            {
                DirLocation = Directory.CreateDirectory(reportPath + "\\Result_Tier\\" + "Screenshots");


                var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "\\Result_Tier\\Screenshots\\" + screenShotName;
                var localpath = new Uri(finalpth).LocalPath;

                _driver.TakeScreenshot(vcd).ToMagickImage().ToBitmap().Save(localpath);

            }

            else
            {

                var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "\\Result_Tier\\Screenshots\\" + screenShotName;
                var localpath = new Uri(finalpth).LocalPath;
                _driver.TakeScreenshot(vcd).ToMagickImage().ToBitmap().Save(localpath);

            }


            return reportPath;
        }
        public static void FullWebPageScreenShotCapture(string screenShotFullSize)
        {
            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            var reportPath = new Uri(actualPath).LocalPath;
            var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "\\Result_Tier\\Screenshots\\" + screenShotFullSize;
            var localpath = new Uri(finalpth).LocalPath;

            VerticalCombineDecorator vcd = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            _driver.TakeScreenshot(vcd).ToMagickImage().ToBitmap().Save("newChrome.png");

            _driver.Quit();
        }

    }
}

