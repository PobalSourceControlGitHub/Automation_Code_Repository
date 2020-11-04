using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Data;
using System.IO;
using ExcelDataReader;
using LinqToExcel;
using Automation_Suite.Utility_Tier;

namespace Automation_Suite._02_Utility_Tier
{
    public class ExcelUtil
    {
        public static DataRow oCurrentDataRow;


        public static System.Data.DataTable ExcelToTable(string strDataFile, string strDataSheet)
        {
            try
            {
                FileStream oFileStream = File.Open(strDataFile, FileMode.Open, FileAccess.Read);

                IExcelDataReader oExlReader = ExcelReaderFactory.CreateOpenXmlReader(oFileStream);

                //oExlReader.IsFirstRowAsColumnNames = true;

                //DataSet oDataSet = oExlReader.AsDataSet();
                var oDataSet = oExlReader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

                DataTableCollection oDataCollTable = oDataSet.Tables;

                System.Data.DataTable oResultTable = oDataCollTable[strDataSheet];

                oExlReader.Close();

                return oResultTable;
            }
            catch (Exception Ex)
            {
                ReporterUtil.ReportEvent("Fail", "Data Load Failed from Excel to table", Ex.Message);
                throw Ex;
            }
        }


        public static string GetData(string strColumnName)
        {
            try
            {
                return ExcelUtil.oCurrentDataRow[strColumnName].ToString();
            }
            catch (DataException e)
            {
                Console.WriteLine(e.StackTrace);
                ReporterUtil.ReportEvent("Fail", "Unable to get the data from the Excel", e.Message);
                return "";
            }
        }


        public static Hashtable poupulateHashFromExcel(string xlsFileName, string xlsSheetName)
        {
            try
            {
                string xlsPathGenration = @"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\TestData_Repository\TestData" + ".xlsx";
                var excelFile = new ExcelQueryFactory(xlsPathGenration);
                var artistAlbums = from a in excelFile.Worksheet(xlsSheetName) select a;
                Hashtable hashtable = new Hashtable();

                foreach (var a in artistAlbums)
                {
                    hashtable.Add(a["RealName"].ToString(), a["objectName"].ToString());
                }
                return hashtable;
            }
            catch (Exception Ex)
            {
                ReporterUtil.ReportEvent("Fail", "Data Load Failed for Excel " + xlsFileName + " Sheet " + xlsSheetName, Ex.Message);
                return null;
            }
        }


        public Dictionary<string, string> populatDictionaryFromExcel(string xlsFileName, string xlsSheetName)
        {

            try
            {
                string xlsPathGenration = @"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\TestData_Repository\TestData.xlsx ";
                var excelFile = new ExcelQueryFactory(xlsPathGenration);
                var propertyValues = from a in excelFile.Worksheet(xlsSheetName) select a;
                Dictionary<string, string> oDictionary = new Dictionary<string, string>();

                foreach (var a in propertyValues)
                {
                    if (!((oDictionary.ContainsKey(a["RealName"].ToString())) || (oDictionary.ContainsKey(a["objectName"].ToString()))))
                    {
                        oDictionary.Add(a["RealName"].ToString(), a["objectName"].ToString());
                    }

                }
                return oDictionary;
            }
            catch (Exception Ex)
            {
                ReporterUtil.ReportEvent("Fail", "Data Load Failed for Excel " + xlsFileName + " Sheet " + xlsSheetName, Ex.Message);
                return null;
            }
        }
    }
}
