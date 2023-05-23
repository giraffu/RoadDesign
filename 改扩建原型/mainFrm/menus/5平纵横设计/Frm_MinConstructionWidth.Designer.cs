namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_MinConstructionWidth
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
            this.cb_lmjg = new System.Windows.Forms.ComboBox();
            this.cb_pmpkyz = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_length = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_lmjg
            // 
            this.cb_lmjg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lmjg.FormattingEnabled = true;
            this.cb_lmjg.Items.AddRange(new object[] {
            "拼宽规则1",
            "拼宽规则2"});
            this.cb_lmjg.Location = new System.Drawing.Point(141, 108);
            this.cb_lmjg.Margin = new System.Windows.Forms.Padding(2);
            this.cb_lmjg.Name = "cb_lmjg";
            this.cb_lmjg.Size = new System.Drawing.Size(203, 20);
            this.cb_lmjg.TabIndex = 26;
            // 
            // cb_pmpkyz
            // 
            this.cb_pmpkyz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pmpkyz.FormattingEnabled = true;
            this.cb_pmpkyz.Items.AddRange(new object[] {
            "拼宽规则1",
            "拼宽规则2"});
            this.cb_pmpkyz.Location = new System.Drawing.Point(141, 67);
            this.cb_pmpkyz.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pmpkyz.Name = "cb_pmpkyz";
            this.cb_pmpkyz.Size = new System.Drawing.Size(203, 20);
            this.cb_pmpkyz.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "选择路面结构：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "选择平面拼宽原则：";
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Location = new System.Drawing.Point(87, 157);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(71, 26);
            this.btn_OK.TabIndex = 22;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(214, 157);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 26);
            this.btn_Cancel.TabIndex = 21;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "m";
            // 
            // tb_length
            // 
            this.tb_length.Location = new System.Drawing.Point(141, 24);
            this.tb_length.Margin = new System.Windows.Forms.Padding(2);
            this.tb_length.Name = "tb_length";
            this.tb_length.Size = new System.Drawing.Size(138, 21);
            this.tb_length.TabIndex = 19;
            this.tb_length.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "过渡最小施工宽度：";
            // 
            // Frm_MinConstructionWidth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 207);
            this.Controls.Add(this.cb_lmjg);
            this.Controls.Add(this.cb_pmpkyz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_length);
            this.Controls.Add(this.label2);
            this.Name = "Frm_MinConstructionWidth";
            this.Text = "Frm_MinConstructionWidth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_lmjg;
        private System.Windows.Forms.ComboBox cb_pmpkyz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_length;
        private System.Windows.Forms.Label label2;
    }
}