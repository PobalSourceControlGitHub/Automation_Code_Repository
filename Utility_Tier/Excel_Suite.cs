using Automation_Suite._01_Configuration_Tier.EnvironmentFiles;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using xl = Microsoft.Office.Interop.Excel;

namespace Automation_Suite.Utility_Tier
{
    class Excel_Suite
    {
        xl.Application xlApp = null;
        xl.Workbooks workbooks = null;
        xl.Workbook workbook = null;
        Hashtable sheets;
        public string xlFilePath;


        public Excel_Suite(string xlFilePath)
        {
            this.xlFilePath = xlFilePath;
        }



        public void OpenExcel()
        {
            xlApp = new xl.Application();
            workbooks = xlApp.Workbooks;
            workbook = workbooks.Open(xlFilePath);
            sheets = new Hashtable();
            int count = 1;
            // Storing worksheet names in Hashtable.
            foreach (xl.Worksheet sheet in workbook.Sheets)
            {
                sheets[count] = sheet.Name;
                count++;
            }
        }

        public void CloseExcel()
        {
            workbook.Close(false, xlFilePath, null); // Close the connection to workbook
            Marshal.FinalReleaseComObject(workbook); // Release unmanaged object references.
            workbook = null;

            workbooks.Close();
            Marshal.FinalReleaseComObject(workbooks);
            workbooks = null;

            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);
            xlApp = null;
        }


        public bool SetCellData(string sheetName, string colName, string value, string value_1)
        {
            OpenExcel();

            int sheetValue = 0;
            int ColumnNumber = 1;

            try
            {
                if (sheets.ContainsValue(sheetName))
                {
                    foreach (DictionaryEntry sheet in sheets)
                    {
                        if (sheet.Value.Equals(sheetName))
                        {
                            sheetValue = (int)sheet.Key;
                        }
                    }


                    xl.Worksheet worksheet = workbook.Worksheets[sheetValue] as xl.Worksheet;
                    xl.Range range = worksheet.UsedRange;
                    int rowRange = range.Rows.Count + 1;

                    //TODO


                    /* for (int i = 1; i <= range.Columns.Count; i++)
                     {
                         string colNameValue = Convert.ToString((range.Cells[1, i] as xl.Range).Value2);
                         if (colNameValue.ToLower() == colName.ToLower())
                         {
                             colNumber = i;
                             break;
                         }
                     } */

                    range.Cells[rowRange, ColumnNumber] = value;
                    range.Cells[rowRange, ++ColumnNumber] = value_1;

                    workbook.Save();
                    Marshal.FinalReleaseComObject(worksheet);
                    worksheet = null;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {

                CloseExcel();
            }

            return true;
        }




        public void getCellData(string sheetName, Boolean flag)
        {


            OpenExcel();

            int sheetValue = 0;
            int ColumnNumber = 1;

            try
            {
                if (sheets.ContainsValue(sheetName))
                {
                    foreach (DictionaryEntry sheet in sheets)
                    {
                        if (sheet.Value.Equals(sheetName))
                        {
                            sheetValue = (int)sheet.Key;
                        }
                    }

                    xl.Worksheet worksheet = workbook.Worksheets[sheetValue] as xl.Worksheet;
                    xl.Range range = worksheet.UsedRange;
                    int rowRange = range.Rows.Count;
                    int colRange = range.Columns.Count;

                    var excelData = range.Cells[rowRange, 1].Value2.ToString();
                   
                    if (colRange>1)
                    {
                        var excelData_EmailID = range.Cells[rowRange, colRange].Value2.ToString();
                        Env.Email_Id = excelData_EmailID;
                    }
                    Env.Data_Retrieve = excelData;
                    
                    Console.Write(excelData + "\t");


                    CloseExcel();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public ExcelData getBankData(string sheetName)
        {

            OpenExcel();
            int sheetValue = 0;
            ExcelData bankData = null;

            try
            {
                if (sheets.ContainsValue(sheetName))
                {
                    foreach (DictionaryEntry sheet in sheets)
                    {
                        if (sheet.Value.Equals(sheetName))
                        {
                            sheetValue = (int)sheet.Key;
                        }
                    }

                    xl.Worksheet worksheet = workbook.Worksheets[sheetValue] as xl.Worksheet;
                    xl.Range range = worksheet.UsedRange;
                    int rowRange = range.Rows.Count;

                    Random rnd = new Random();
                    //int row = rnd.Next(15, 62);
                    int row = rnd.Next(2, 16);
                    int col = 1;
                    //Reading data from excel and setting to model object
                    bankData = new ExcelData();
                    bankData.AccountName = range.Cells[row, col].Value2;
                    bankData.BankName = range.Cells[row, ++col].Value2;
                    bankData.IBAN1 = range.Cells[row, ++col].Value2;
                    bankData.AccountNumber = range.Cells[row, 11].Value2;
                    bankData.BankBranch = range.Cells[row, 12].Value2;
                    bankData.BIC = range.Cells[row, 13].Value2;
                    bankData.SortCode = range.Cells[row, 14].Value2;

                    Excel_Suite ex = new Excel_Suite(Env.BANK_NAME);
                    ex.StoreBankName("BankName", "BankAccount_Name", bankData.AccountName);
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            finally
            {
                CloseExcel();

            }

            return bankData;
        }

        public bool SetBankCellData(string sheetName, string colName, string value)
        {
            OpenExcel();

            int sheetValue = 0;
            int ColumnNumber = 1;

            try
            {
                if (sheets.ContainsValue(sheetName))
                {
                    foreach (DictionaryEntry sheet in sheets)
                    {
                        if (sheet.Value.Equals(sheetName))
                        {
                            sheetValue = (int)sheet.Key;
                        }
                    }
                    xl.Worksheet worksheet = workbook.Worksheets[sheetValue] as xl.Worksheet;
                    xl.Range range = worksheet.UsedRange;
                    int rowRange = range.Rows.Count + 1;

                    range.Cells[rowRange, ColumnNumber] = value;

                    workbook.Save();
                    Marshal.FinalReleaseComObject(worksheet);
                    worksheet = null;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {

                CloseExcel();
            }

            return true;
        }

        public bool StoreBankName(string sheetName, string colName, string value)
        {
            OpenExcel();

            int sheetValue = 0;
            int ColumnNumber = 1;

            try
            {
                if (sheets.ContainsValue(sheetName))
                {
                    foreach (DictionaryEntry sheet in sheets)
                    {
                        if (sheet.Value.Equals(sheetName))
                        {
                            sheetValue = (int)sheet.Key;
                        }
                    }
                    xl.Worksheet worksheet = workbook.Worksheets[sheetValue] as xl.Worksheet;
                    xl.Range range = worksheet.UsedRange;
                    int rowRange = range.Rows.Count + 1;

                    range.Cells[rowRange, ColumnNumber] = value;

                    workbook.Save();
                    Marshal.FinalReleaseComObject(worksheet);
                    worksheet = null;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                CloseExcel();
            }

            return true;
        }

        public bool getBankAccount(string sheetName)
        {
            OpenExcel();
            int sheetValue = 0;
            int ColumnNumber = 1;

            try
            {
                if (sheets.ContainsValue(sheetName))
                {
                    foreach (DictionaryEntry sheet in sheets)
                    {
                        if (sheet.Value.Equals(sheetName))
                        {
                            sheetValue = (int)sheet.Key;
                        }
                    }

                    xl.Worksheet worksheet = workbook.Worksheets[sheetValue] as xl.Worksheet;
                    xl.Range range = worksheet.UsedRange;
                    int rowRange = range.Rows.Count;

                    var excelData = range.Cells[rowRange, 1].Value2.ToString();
                    Env.BankName = excelData;
                    Console.Write(excelData + "\t");
                }
                CloseExcel();
            }

            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
           }

        public bool setChildDetails(string sheetName, string colName, string value, string value1, string value2)
        {
            OpenExcel();

            int sheetValue = 0;
            int ColumnNumber = 1;

            try
            {
                if (sheets.ContainsValue(sheetName))
                {
                    foreach (DictionaryEntry sheet in sheets)
                    {
                        if (sheet.Value.Equals(sheetName))
                        {
                            sheetValue = (int)sheet.Key;
                        }
                    }
                    xl.Worksheet worksheet = workbook.Worksheets[sheetValue] as xl.Worksheet;
                    xl.Range range = worksheet.UsedRange;
                    int rowRange = range.Rows.Count + 1;

                    range.Cells[rowRange, ColumnNumber] = value;
                    range.Cells[rowRange, ColumnNumber] = value1;
                    range.Cells[rowRange, ColumnNumber] = value2;

                    workbook.Save();
                    Marshal.FinalReleaseComObject(worksheet);
                    worksheet = null;
         
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {

                CloseExcel();
            }

            return true;
        }
    }
}



   



