using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;

namespace Automation_Suite._02_Utility_Tier
{
    public class Helper
    {

        public static void getTestDataDetails(string TestScriptID, out string xlsName, out string xlsSheetName, out string RunFlag)
        {
            System.Data.DataTable oTableEnv = ExcelUtil.ExcelToTable(Env.strRelativePath + Env.strConfigurationXl, "Scenarios");
            System.Data.DataRow[] oDataRowsEnv = oTableEnv.Select("TestScriptId =" + TestScriptID);
            xlsName = null;
            RunFlag = null;
            xlsSheetName = null;
            if (oDataRowsEnv.Length != 0)
            {
                ExcelUtil.oCurrentDataRow = oDataRowsEnv[0];
                xlsName = ExcelUtil.GetData("TestData");
                xlsSheetName = ExcelUtil.GetData("TestSheet");
                RunFlag = ExcelUtil.GetData("Run");
            }
            oTableEnv = null;
            oDataRowsEnv = null;
        }


        public static void setRelativePath()
        {
            string strProjectName = Assembly.GetExecutingAssembly().GetName().Name;
            string startupPath = Environment.CurrentDirectory;
            string[] strRootPath = Regex.Split(startupPath, "bin");

            // DirectoryInfo oDirInfo = Directory.GetParent(Directory.GetCurrentDirectory());
            //GlbVar.strRelativePath = oDirInfo.Parent.Parent.FullName + GlbVar.sysFileSeperator + strProjectName + GlbVar.sysFileSeperator;
            Env.strRelativePath = strRootPath[0];
            Console.WriteLine(Env.strRelativePath);
        }

        public static string getTimeStamp()
        {
            string strDateTime;

            strDateTime = DateTime.Now.ToString();
            strDateTime = strDateTime.Replace("-", "_");
            strDateTime = strDateTime.Replace(":", "_");
            strDateTime = strDateTime.Replace(" ", "_");
            strDateTime = strDateTime.Replace("/", "_");
            return strDateTime;
        }

       


        
        public static void KILL_ALL(string strProcess)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName(strProcess))
                {
                    proc.Kill();
                    Console.WriteLine("Killed " + strProcess);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
