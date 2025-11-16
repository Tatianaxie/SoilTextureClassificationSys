
namespace SoilType
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Silt = new System.Windows.Forms.TextBox();
            this.Sand = new System.Windows.Forms.TextBox();
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.BatchProcBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CleanBtn = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.GroupBox();
            this.Clay = new System.Windows.Forms.TextBox();
            this.SiltLab = new System.Windows.Forms.Label();
            this.ClayLab = new System.Windows.Forms.Label();
            this.SandLab = new System.Windows.Forms.Label();
            this.ResultLab = new System.Windows.Forms.Label();
            this.USANamePic = new System.Windows.Forms.PictureBox();
            this.USAGrayPic = new System.Windows.Forms.PictureBox();
            this.MethodSelectTab = new System.Windows.Forms.TabControl();
            this.usTP = new System.Windows.Forms.TabPage();
            this.isssTP = new System.Windows.Forms.TabPage();
            this.ISSSGrayPic = new System.Windows.Forms.PictureBox();
            this.ISSSNamePic = new System.Windows.Forms.PictureBox();
            this.ukTP = new System.Windows.Forms.TabPage();
            this.UKGrayPic = new System.Windows.Forms.PictureBox();
            this.UKNamePic = new System.Windows.Forms.PictureBox();
            this.SoilTextureSearchBtn = new System.Windows.Forms.Button();
            this.InputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USANamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USAGrayPic)).BeginInit();
            this.MethodSelectTab.SuspendLayout();
            this.usTP.SuspendLayout();
            this.isssTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISSSGrayPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISSSNamePic)).BeginInit();
            this.ukTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UKGrayPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UKNamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // Silt
            // 
            this.Silt.Location = new System.Drawing.Point(63, 152);
            this.Silt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Silt.Name = "Silt";
            this.Silt.Size = new System.Drawing.Size(100, 25);
            this.Silt.TabIndex = 5;
            // 
            // Sand
            // 
            this.Sand.Location = new System.Drawing.Point(63, 41);
            this.Sand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sand.Name = "Sand";
            this.Sand.Size = new System.Drawing.Size(100, 25);
            this.Sand.TabIndex = 3;
            // 
            // ResultTxt
            // 
            this.ResultTxt.Location = new System.Drawing.Point(45, 386);
            this.ResultTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(240, 25);
            this.ResultTxt.TabIndex = 0;
            // 
            // BatchProcBtn
            // 
            this.BatchProcBtn.Location = new System.Drawing.Point(45, 630);
            this.BatchProcBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BatchProcBtn.Name = "BatchProcBtn";
            this.BatchProcBtn.Size = new System.Drawing.Size(240, 131);
            this.BatchProcBtn.TabIndex = 5;
            this.BatchProcBtn.Text = "Batch Process";
            this.BatchProcBtn.UseVisualStyleBackColor = true;
            this.BatchProcBtn.Click += new System.EventHandler(this.BatchProcBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(205, 805);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(131, 46);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // CleanBtn
            // 
            this.CleanBtn.Location = new System.Drawing.Point(45, 805);
            this.CleanBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(129, 46);
            this.CleanBtn.TabIndex = 2;
            this.CleanBtn.Text = "Clear";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click_1);
            // 
            // InputBox
            // 
            this.InputBox.Controls.Add(this.Clay);
            this.InputBox.Controls.Add(this.SiltLab);
            this.InputBox.Controls.Add(this.ClayLab);
            this.InputBox.Controls.Add(this.SandLab);
            this.InputBox.Controls.Add(this.Silt);
            this.InputBox.Controls.Add(this.Sand);
            this.InputBox.Location = new System.Drawing.Point(45, 44);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.Name = "InputBox";
            this.InputBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.Size = new System.Drawing.Size(225, 281);
            this.InputBox.TabIndex = 10;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "Data";
            // 
            // Clay
            // 
            this.Clay.Location = new System.Drawing.Point(63, 100);
            this.Clay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clay.Name = "Clay";
            this.Clay.Size = new System.Drawing.Size(100, 25);
            this.Clay.TabIndex = 16;
            // 
            // SiltLab
            // 
            this.SiltLab.AutoSize = true;
            this.SiltLab.Location = new System.Drawing.Point(6, 162);
            this.SiltLab.Name = "SiltLab";
            this.SiltLab.Size = new System.Drawing.Size(54, 15);
            this.SiltLab.TabIndex = 14;
            this.SiltLab.Text = "Silt：";
            // 
            // ClayLab
            // 
            this.ClayLab.AutoSize = true;
            this.ClayLab.Location = new System.Drawing.Point(5, 103);
            this.ClayLab.Name = "ClayLab";
            this.ClayLab.Size = new System.Drawing.Size(54, 15);
            this.ClayLab.TabIndex = 13;
            this.ClayLab.Text = "Clay：";
            // 
            // SandLab
            // 
            this.SandLab.AutoSize = true;
            this.SandLab.Location = new System.Drawing.Point(5, 45);
            this.SandLab.Name = "SandLab";
            this.SandLab.Size = new System.Drawing.Size(54, 15);
            this.SandLab.TabIndex = 12;
            this.SandLab.Text = "Sand：";
            // 
            // ResultLab
            // 
            this.ResultLab.AutoSize = true;
            this.ResultLab.Location = new System.Drawing.Point(42, 356);
            this.ResultLab.Name = "ResultLab";
            this.ResultLab.Size = new System.Drawing.Size(71, 15);
            this.ResultLab.TabIndex = 11;
            this.ResultLab.Text = "Result :";
            // 
            // USANamePic
            // 
            this.USANamePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.USANamePic.Image = ((System.Drawing.Image)(resources.GetObject("USANamePic.Image")));
            this.USANamePic.Location = new System.Drawing.Point(32, 162);
            this.USANamePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.USANamePic.Name = "USANamePic";
            this.USANamePic.Size = new System.Drawing.Size(500, 433);
            this.USANamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.USANamePic.TabIndex = 1;
            this.USANamePic.TabStop = false;
            // 
            // USAGrayPic
            // 
            this.USAGrayPic.Image = ((System.Drawing.Image)(resources.GetObject("USAGrayPic.Image")));
            this.USAGrayPic.Location = new System.Drawing.Point(568, 162);
            this.USAGrayPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.USAGrayPic.Name = "USAGrayPic";
            this.USAGrayPic.Size = new System.Drawing.Size(500, 433);
            this.USAGrayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.USAGrayPic.TabIndex = 9;
            this.USAGrayPic.TabStop = false;
            // 
            // MethodSelectTab
            // 
            this.MethodSelectTab.Controls.Add(this.usTP);
            this.MethodSelectTab.Controls.Add(this.isssTP);
            this.MethodSelectTab.Controls.Add(this.ukTP);
            this.MethodSelectTab.Location = new System.Drawing.Point(360, 44);
            this.MethodSelectTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MethodSelectTab.Name = "MethodSelectTab";
            this.MethodSelectTab.SelectedIndex = 0;
            this.MethodSelectTab.Size = new System.Drawing.Size(1122, 807);
            this.MethodSelectTab.TabIndex = 12;
            this.MethodSelectTab.SelectedIndexChanged += new System.EventHandler(this.MethodSelectTab_SelectedIndexChanged);
            // 
            // usTP
            // 
            this.usTP.Controls.Add(this.USANamePic);
            this.usTP.Controls.Add(this.USAGrayPic);
            this.usTP.Location = new System.Drawing.Point(4, 25);
            this.usTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usTP.Name = "usTP";
            this.usTP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usTP.Size = new System.Drawing.Size(1114, 778);
            this.usTP.TabIndex = 0;
            this.usTP.Text = "USDA";
            this.usTP.UseVisualStyleBackColor = true;
            // 
            // isssTP
            // 
            this.isssTP.Controls.Add(this.ISSSGrayPic);
            this.isssTP.Controls.Add(this.ISSSNamePic);
            this.isssTP.Location = new System.Drawing.Point(4, 25);
            this.isssTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isssTP.Name = "isssTP";
            this.isssTP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isssTP.Size = new System.Drawing.Size(1114, 778);
            this.isssTP.TabIndex = 1;
            this.isssTP.Text = "ISSS";
            this.isssTP.UseVisualStyleBackColor = true;
            // 
            // ISSSGrayPic
            // 
            this.ISSSGrayPic.Image = ((System.Drawing.Image)(resources.GetObject("ISSSGrayPic.Image")));
            this.ISSSGrayPic.Location = new System.Drawing.Point(559, 162);
            this.ISSSGrayPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISSSGrayPic.Name = "ISSSGrayPic";
            this.ISSSGrayPic.Size = new System.Drawing.Size(500, 433);
            this.ISSSGrayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ISSSGrayPic.TabIndex = 1;
            this.ISSSGrayPic.TabStop = false;
            // 
            // ISSSNamePic
            // 
            this.ISSSNamePic.Image = ((System.Drawing.Image)(resources.GetObject("ISSSNamePic.Image")));
            this.ISSSNamePic.Location = new System.Drawing.Point(29, 162);
            this.ISSSNamePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISSSNamePic.Name = "ISSSNamePic";
            this.ISSSNamePic.Size = new System.Drawing.Size(500, 433);
            this.ISSSNamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ISSSNamePic.TabIndex = 0;
            this.ISSSNamePic.TabStop = false;
            // 
            // ukTP
            // 
            this.ukTP.Controls.Add(this.UKGrayPic);
            this.ukTP.Controls.Add(this.UKNamePic);
            this.ukTP.Location = new System.Drawing.Point(4, 25);
            this.ukTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ukTP.Name = "ukTP";
            this.ukTP.Size = new System.Drawing.Size(1114, 778);
            this.ukTP.TabIndex = 2;
            this.ukTP.Text = "UK";
            this.ukTP.UseVisualStyleBackColor = true;
            // 
            // UKGrayPic
            // 
            this.UKGrayPic.Image = ((System.Drawing.Image)(resources.GetObject("UKGrayPic.Image")));
            this.UKGrayPic.Location = new System.Drawing.Point(568, 162);
            this.UKGrayPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UKGrayPic.Name = "UKGrayPic";
            this.UKGrayPic.Size = new System.Drawing.Size(500, 432);
            this.UKGrayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UKGrayPic.TabIndex = 9;
            this.UKGrayPic.TabStop = false;
            // 
            // UKNamePic
            // 
            this.UKNamePic.Image = ((System.Drawing.Image)(resources.GetObject("UKNamePic.Image")));
            this.UKNamePic.Location = new System.Drawing.Point(35, 162);
            this.UKNamePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UKNamePic.Name = "UKNamePic";
            this.UKNamePic.Size = new System.Drawing.Size(500, 432);
            this.UKNamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UKNamePic.TabIndex = 8;
            this.UKNamePic.TabStop = false;
            // 
            // SoilTextureSearchBtn
            // 
            this.SoilTextureSearchBtn.Location = new System.Drawing.Point(45, 455);
            this.SoilTextureSearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SoilTextureSearchBtn.Name = "SoilTextureSearchBtn";
            this.SoilTextureSearchBtn.Size = new System.Drawing.Size(240, 129);
            this.SoilTextureSearchBtn.TabIndex = 13;
            this.SoilTextureSearchBtn.Text = "Search";
            this.SoilTextureSearchBtn.UseVisualStyleBackColor = true;
            this.SoilTextureSearchBtn.Click += new System.EventHandler(this.SoilTextureSearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 956);
            this.Controls.Add(this.SoilTextureSearchBtn);
            this.Controls.Add(this.ResultLab);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BatchProcBtn);
            this.Controls.Add(this.MethodSelectTab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Soil Texture Classification System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.InputBox.ResumeLayout(false);
            this.InputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USANamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USAGrayPic)).EndInit();
            this.MethodSelectTab.ResumeLayout(false);
            this.usTP.ResumeLayout(false);
            this.isssTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ISSSGrayPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISSSNamePic)).EndInit();
            this.ukTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UKGrayPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UKNamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Silt;
        private System.Windows.Forms.TextBox Sand;
        private System.Windows.Forms.PictureBox USANamePic;
        private System.Windows.Forms.TextBox ResultTxt;
        private System.Windows.Forms.Button BatchProcBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button CleanBtn;
        private System.Windows.Forms.PictureBox USAGrayPic;
        private System.Windows.Forms.GroupBox InputBox;
        private System.Windows.Forms.Label ResultLab;
        private System.Windows.Forms.Label SiltLab;
        private System.Windows.Forms.Label ClayLab;
        private System.Windows.Forms.Label SandLab;
        private System.Windows.Forms.TextBox Clay;
        private System.Windows.Forms.TabControl MethodSelectTab;
        private System.Windows.Forms.TabPage isssTP;
        private System.Windows.Forms.TabPage usTP;
        private System.Windows.Forms.PictureBox ISSSNamePic;
        private System.Windows.Forms.PictureBox ISSSGrayPic;
        private System.Windows.Forms.TabPage ukTP;
        private System.Windows.Forms.PictureBox UKGrayPic;
        private System.Windows.Forms.PictureBox UKNamePic;
        private System.Windows.Forms.Button SoilTextureSearchBtn;
    }
}