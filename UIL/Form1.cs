using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SoilType
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public int SelectedMethod=0;

        public Form1()
        {
            InitializeComponent();
          
        }
  
        
        /// <summary>
        /// 批处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      private void BatchProcBtn_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count>0)
            {
                dt.Reset();
            }
            ReadFile.ExceltoDt(ReadFile.FileSurf(), dt);
            ShowTable st = null;
            if(SelectedMethod==0)
              {
                 st = new ShowTable(MultiType.Typedt(dt, USANamePic, USAGrayPic, SelectedMethod));
            }
            else if(SelectedMethod ==1)
            {
                 st = new ShowTable(MultiType.Typedt(dt, ISSSNamePic, ISSSGrayPic, SelectedMethod));
            }
            else
            {
                 st = new ShowTable(MultiType.Typedt(dt, UKNamePic, UKGrayPic, SelectedMethod));
            }
            st.Show();
        }
        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 清空输入值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CleanBtn_Click_1(object sender, EventArgs e)
        {
            this.Sand.Text = "";
            this.Clay.Text = "";
            this.Silt.Text = "";
            this.ResultTxt.Text = "";
        }
 
        /// <summary>
        /// 土壤质地查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoilTextureSearchBtn_Click(object sender, EventArgs e)
        {
            double sand = double.Parse(this.Sand.Text);
            double clay = double.Parse(this.Clay.Text);
            double silt = double.Parse(this.Silt.Text);

            if ((sand + clay + silt) >= 101)
            {
                this.ResultTxt.Text = "请确保输入值的总和不超过100%";
            }
            else
            {

                
                Gray_Scale judgeSoilType = new Gray_Scale();
                if (SelectedMethod == 0)
                {                    
                    this.ResultTxt.Text = judgeSoilType.MainProcess(sand, clay, silt, USANamePic, USAGrayPic,0);
                }
                else if (SelectedMethod == 1)
                {                  
                    this.ResultTxt.Text = judgeSoilType.MainProcess(sand, clay, silt, ISSSNamePic, ISSSGrayPic,1);
                }
                else
                {                    
                    this.ResultTxt.Text = judgeSoilType.MainProcess(sand, clay, silt, UKNamePic, UKGrayPic,2);
                }

            }
        }
        /// <summary>
        /// 图版选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MethodSelectTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMethod = MethodSelectTab.SelectedIndex;
        }

    }
}
