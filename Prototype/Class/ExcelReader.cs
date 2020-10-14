using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Prototype.Class
{
    class ExcelReader
    {

        public DataTable GetAttendanceRecord(string path)
        {

            FileInfo info = new FileInfo(path);

            string conString = string.Empty;

            //check file extension
            switch (info.Extension)
            {
                case ".xls": //Excel 97-03.
                    conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Excel03ConString;Extended Properties='Excel 8.0;HDR=YES'";
                    break;
                case ".xlsx": //Excel 07 and above.
                    conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";
                    break;
            }

            //create datatable object
            DataTable dt = new DataTable();
            conString = string.Format(conString, path);

            //Use OldDb to read excel
            using (OleDbConnection connExcel = new OleDbConnection(conString))
            {
                using (OleDbCommand cmdExcel = new OleDbCommand())
                {
                    using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                    {
                        cmdExcel.Connection = connExcel;

                        //Get the name of First Sheet.
                        connExcel.Open();
                        DataTable dtExcelSchema;

                        //excelApp.Visible = true;
                     
                        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        //string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        string sheetName = "Original Records$";
                        connExcel.Close();

                        //Read Data from First Sheet.
                        connExcel.Open();
                        cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                        odaExcel.SelectCommand = cmdExcel;
                        odaExcel.Fill(dt);
                        connExcel.Close();
                    }
                }
            }

            return dt;
        }

    }
}
