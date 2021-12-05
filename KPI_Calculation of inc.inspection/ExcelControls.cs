using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xl = Microsoft.Office.Interop.Excel;

namespace KPI_Calculation_of_inc.inspection
{
    static class ExcelControls
    {
        public static DataTable Get_ExcelData( string linkToExcel, string sheetName)
        {
            DataTable _results = new DataTable();

            bool _isExcelFileOpen = IsExcelFileOpen(linkToExcel);

            if (_isExcelFileOpen)
            {
                _results = ExcelControls.Get_ExcelData_JET_when_OPENED(linkToExcel, sheetName);
            }
            else
            {
                try {
                    _results = ExcelControls.Get_ExcelData_ACE_when_CLOSED(linkToExcel, sheetName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message.ToString() + "\n Варіанти вирішення: \n1. Встановіть необхідні елементи; \n2. Повторіть спробу, але перед цим відкрийте excel-файл.");
                }
            }

            return _results;
        }

        private static DataTable Get_ExcelData_ACE_when_CLOSED(string linkToExcel, string sheetName)
        {
            DataTable _results = new DataTable();

            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + linkToExcel + ";Extended Properties='Excel 8.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("SELECT * FROM [" + sheetName + "$] WHERE Material NOT LIKE '' ", con);
            con.Open();

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(oconn);

            con.Close();

            dataAdapter.Fill(_results);

            return _results;
        }
        private static DataTable Get_ExcelData_JET_when_OPENED(string linkToExcel, string sheetName)
        {
            DataTable _results = new DataTable();
            string PathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + linkToExcel + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PathConn);
            OleDbDataAdapter myDataAdapder = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$] WHERE Material NOT LIKE '' ", conn);
            //DataTable dt = new DataTable();
            myDataAdapder.Fill(_results);
            //dataGridView1.DataSource = dt;
            return _results;
        }
        

        public static string[] Get_AllWorkSheetsFromExcel(string LinkToFile)
        {
            string[] _results = new string[] { };
            bool _isExcelFileOpen = IsExcelFileOpen(LinkToFile);

            if (_isExcelFileOpen)
            {
                _results = GetAllWorkSheets_whenOpened(LinkToFile);
            }
            else
            {
                _results = GetAllWorkSheets_whenClosed(LinkToFile);
            }

            return _results;
        }

        private static string[] GetAllWorkSheets_whenClosed(string LinkToFile)
        {
            Sheets theSheets = null;

            using (SpreadsheetDocument document = SpreadsheetDocument.Open(LinkToFile, false))
            {
                WorkbookPart wbPart = document.WorkbookPart;
                theSheets = wbPart.Workbook.Sheets;
            }

            int _quantityOfSheets = theSheets.Count();
            string[] _results = new string[_quantityOfSheets];

            foreach (Sheet item in theSheets)
            {
                _results[item.SheetId - 1] = item.Name.ToString();
            }

            return _results;
        }
        private static string[] GetAllWorkSheets_whenOpened(string LinkToFile)
        {
            xl.Workbook xlWorkBook;
            xl.Application xlApp = new xl.Application();
            xlApp = (xl.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");

            int _quantityOfSheets = xlApp.Sheets.Count;
            string[] _results = new string[_quantityOfSheets];

            foreach (xl.Workbook item in xlApp.Workbooks)
            {
                if (LinkToFile.Contains(item.Name))
                {
                    xlWorkBook = item;

                    for (int i = 1; i <= xlWorkBook.Sheets.Count; i++)
                    {
                        _results[i - 1] = xlWorkBook.Sheets[i].Name;
                    }
                    break;
                }
            }

            return _results;
        }
        private static bool IsExcelFileOpen(string xlFileName)
        {
            xl.Application xlApp = null;
            xl.Workbook xlWb = null;
            try
            {
                if (!File.Exists(xlFileName))
                {
                    MessageBox.Show("Excel File does not exists!");
                    return false;
                }

                try
                {
                    xlApp = (xl.Application)Marshal.GetActiveObject("Excel.Application");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return false;
                }

                foreach (xl.Workbook wb in xlApp.Workbooks)
                {
                    if (wb.FullName == xlFileName)
                    {
                        xlWb = wb;
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
