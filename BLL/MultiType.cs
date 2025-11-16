using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace SoilType
{
    class MultiType
    {
        /// <summary>
        /// 批量处理函数
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="NamePic"></param>
        /// <param name="GrayPic"></param>
        /// <returns></returns>

        public static DataTable Typedt(DataTable dt, PictureBox NamePic, PictureBox GrayPic,int Method)
        {
            DataTable Type = dt.Copy();
            DataColumn dc = new DataColumn("土壤质地类型");
            Type.Columns.Add(dc);
            for (int i = 0; i < Type.Rows.Count; i++)
            {
                Gray_Scale Judgetype = new Gray_Scale();
                double value1 = Type.Rows[i][0] != DBNull.Value ? Convert.ToInt32(Type.Rows[i][0]) : 0;
                double value2 = Type.Rows[i][1] != DBNull.Value ? Convert.ToInt32(Type.Rows[i][1]) : 0;
                double value3 = Type.Rows[i][2] != DBNull.Value ? Convert.ToInt32(Type.Rows[i][2]) : 0;


                Type.Rows[i][3] = Judgetype.MainProcess(value1,value2, value3, NamePic, GrayPic, Method);
     
        }
            return Type;
        }
        
    }
}
