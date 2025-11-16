using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace SoilType 
{
    class saveFile
    {
        /// <summary>
        /// 导出结果excel文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="dt1"></param>
        public static void ExportExcel(string fileName, DataTable dt1)
        {
            if (dt1.Rows.Count > 0)
            {
                string saveFileName = "";
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = "xls";
                saveDialog.Filter = "Excel文件|*.xls";
                saveDialog.FileName = fileName;
                saveDialog.ShowDialog();
                saveFileName = saveDialog.FileName;
                if (saveFileName.IndexOf(":") < 0) return; //被点了取消   
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建Excel对象，可能您的设备未安装Excel");
                    return;
                }
                xlApp.SheetsInNewWorkbook = 2;
                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add();
                writeSheet(dt1, (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1]);
                workbook.Worksheets[1].Name = "距离矩阵";

                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);
                        //fileSaved = true;  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                    }
                }
                xlApp.Quit();
                GC.Collect();//强行销毁   
                MessageBox.Show(fileName + "的结果保存成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("结果为空,无结果需要导出", "提示", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// 写入数值
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="worksheet"></param>
    private static void writeSheet(DataTable dt, Microsoft.Office.Interop.Excel.Worksheet worksheet)
    {
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
        }
 
        for (int r = 0; r < dt.Rows.Count; r++)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cells[r + 2, i + 1] = dt.Rows[r][i].ToString();
            }
            System.Windows.Forms.Application.DoEvents();
        }
        worksheet.Columns.EntireColumn.AutoFit();//列宽自适应 
    }
}
        
    
}
