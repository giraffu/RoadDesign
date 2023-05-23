namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_NewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NewProject));
            this.pb_SelectPath = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_projectInfo = new System.Windows.Forms.Button();
            this.tb_ProjectPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectPath)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_SelectPath
            // 
            this.pb_SelectPath.Image = ((System.Drawing.Image)(resources.GetObject("pb_SelectPath.Image")));
            this.pb_SelectPath.Location = new System.Drawing.Point(344, 57);
            this.pb_SelectPath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pb_SelectPath.Name = "pb_SelectPath";
            this.pb_SelectPath.Size = new System.Drawing.Size(29, 31);
            this.pb_SelectPath.TabIndex = 15;
            this.pb_SelectPath.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(301, 116);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 25);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(203, 116);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(71, 25);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_projectInfo
            // 
            this.btn_projectInfo.Location = new System.Drawing.Point(25, 116);
            this.btn_projectInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_projectInfo.Name = "btn_projectInfo";
            this.btn_projectInfo.Size = new System.Drawing.Size(71, 25);
            this.btn_projectInfo.TabIndex = 12;
            this.btn_projectInfo.Text = "项目信息";
            this.btn_projectInfo.UseVisualStyleBackColor = true;
            this.btn_projectInfo.Visible = false;
            this.btn_projectInfo.Click += new System.EventHandler(this.btn_projectInfo_Click);
            // 
            // tb_ProjectPath
            // 
            this.tb_ProjectPath.Location = new System.Drawing.Point(89, 59);
            this.tb_ProjectPath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tb_ProjectPath.Name = "tb_ProjectPath";
            this.tb_ProjectPath.ReadOnly = true;
            this.tb_ProjectPath.Size = new System.Drawing.Size(241, 21);
            this.tb_ProjectPath.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "工程路径：";
            // 
            // tb_ProjectName
            // 
            this.tb_ProjectName.Location = new System.Drawing.Point(89, 19);
            this.tb_ProjectName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tb_ProjectName.Name = "tb_ProjectName";
            this.tb_ProjectName.Size = new System.Drawing.Size(284, 21);
            this.tb_ProjectName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "工程名称：";
            // 
            // Frm_NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 161);
            this.Controls.Add(this.pb_SelectPath);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_projectInfo);
            this.Controls.Add(this.tb_ProjectPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ProjectName);
            this.Controls.Add(this.label1);
            this.Name = "Frm_NewProject";
            this.Text = "Frm_NewProject";
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_SelectPath;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_projectInfo;
        private System.Windows.Forms.TextBox tb_ProjectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ProjectName;
        private System.Windows.Forms.Label label1;
    }
}