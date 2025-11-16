using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoilType
{
    public partial class ShowTable : Form
    {
        DataTable dt;
        public ShowTable(DataTable Typedt)
        {
            InitializeComponent();
            dt = Typedt.Copy();
            dataGridView1.DataSource = dt;
        }

        private void ShowTable_Load(object sender, EventArgs e)
        {

        }

        private void 关闭_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFile.ExportExcel("", dt);
        }
    }
}
