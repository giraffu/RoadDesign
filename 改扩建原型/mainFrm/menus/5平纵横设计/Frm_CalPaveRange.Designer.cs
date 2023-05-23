namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_CalPaveRange
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tb_end = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Start = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_newRoadLine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_oldRoadLine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Compute = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 66;
            this.label8.Text = "起讫桩号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 64;
            this.label5.Text = "起讫桩号：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 188);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(292, 10);
            this.progressBar1.TabIndex = 63;
            this.progressBar1.Visible = false;
            // 
            // tb_end
            // 
            this.tb_end.Location = new System.Drawing.Point(219, 120);
            this.tb_end.Margin = new System.Windows.Forms.Padding(2);
            this.tb_end.Name = "tb_end";
            this.tb_end.Size = new System.Drawing.Size(67, 21);
            this.tb_end.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 61;
            this.label6.Text = "终点桩号：";
            // 
            // tb_Start
            // 
            this.tb_Start.Location = new System.Drawing.Point(83, 120);
            this.tb_Start.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Start.Name = "tb_Start";
            this.tb_Start.Size = new System.Drawing.Size(61, 21);
            this.tb_Start.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 59;
            this.label7.Text = "起点桩号：";
            // 
            // cb_newRoadLine
            // 
            this.cb_newRoadLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_newRoadLine.FormattingEnabled = true;
            this.cb_newRoadLine.Items.AddRange(new object[] {
            "KY",
            "KZ",
            "Y",
            "Z",
            "1KY",
            "1KZ"});
            this.cb_newRoadLine.Location = new System.Drawing.Point(120, 66);
            this.cb_newRoadLine.Margin = new System.Windows.Forms.Padding(2);
            this.cb_newRoadLine.Name = "cb_newRoadLine";
            this.cb_newRoadLine.Size = new System.Drawing.Size(164, 20);
            this.cb_newRoadLine.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 57;
            this.label4.Text = "新路设计线位：";
            // 
            // cb_oldRoadLine
            // 
            this.cb_oldRoadLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_oldRoadLine.FormattingEnabled = true;
            this.cb_oldRoadLine.Items.AddRange(new object[] {
            "K3",
            "K2"});
            this.cb_oldRoadLine.Location = new System.Drawing.Point(120, 14);
            this.cb_oldRoadLine.Margin = new System.Windows.Forms.Padding(2);
            this.cb_oldRoadLine.Name = "cb_oldRoadLine";
            this.cb_oldRoadLine.Size = new System.Drawing.Size(164, 20);
            this.cb_oldRoadLine.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 55;
            this.label3.Text = "老路拟合线位：";
            // 
            // btn_Compute
            // 
            this.btn_Compute.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Compute.Location = new System.Drawing.Point(120, 156);
            this.btn_Compute.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(71, 26);
            this.btn_Compute.TabIndex = 54;
            this.btn_Compute.Text = "计算";
            this.btn_Compute.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.Location = new System.Drawing.Point(215, 156);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(71, 26);
            this.btn_close.TabIndex = 53;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // Frm_CalPaveRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 201);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tb_end);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Start);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_newRoadLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_oldRoadLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Compute);
            this.Controls.Add(this.btn_close);
            this.Name = "Frm_CalPaveRange";
            this.Text = "Frm_ComputeOverlay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tb_end;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_newRoadLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_oldRoadLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Compute;
        private System.Windows.Forms.Button btn_close;
    }
}