using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SoilType
{ 
    class ReadFile
    {
        DataTable dt = new DataTable("数据");
        /// <summary>
        /// 选择文件
        /// </summary>
        /// <returns></returns>
        public static string FileSurf()
        {
            string path = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            return path;
        }
        /// <summary>
        /// 读入datatable
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool ExceltoDt(string path, DataTable dt)
        {
            if (path == "")
            {
                return false;
            }
            else
            {
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                strExcel = "select * from [sheet1$]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                myCommand.Fill(dt);
                return true;
            }
        }

    }
}