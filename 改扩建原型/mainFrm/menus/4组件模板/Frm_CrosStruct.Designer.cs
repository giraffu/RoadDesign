using System;

namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_CrosStruct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CrosStruct));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_show = new System.Windows.Forms.Panel();
            this.chb_BingRoad = new System.Windows.Forms.CheckBox();
            this.cb_MaterialID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chb_Grading = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_place = new System.Windows.Forms.ComboBox();
            this.lb_place = new System.Windows.Forms.Label();
            this.nud_step = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_component = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.参数名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb_component = new System.Windows.Forms.PictureBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.pn_show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_component)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_component)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_Name);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cb_type);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pn_show);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_place);
            this.groupBox3.Controls.Add(this.lb_place);
            this.groupBox3.Controls.Add(this.nud_step);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dgv_component);
            this.groupBox3.Location = new System.Drawing.Point(11, 255);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(586, 307);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(220, 27);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(135, 21);
            this.tb_Name.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "名称：";
            // 
            // cb_type
            // 
            this.cb_type.BackColor = System.Drawing.SystemColors.Window;
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "中央分隔带",
            "台阶",
            "路面边部构造",
            "铣刨线"});
            this.cb_type.Location = new System.Drawing.Point(81, 27);
            this.cb_type.Margin = new System.Windows.Forms.Padding(2);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(92, 20);
            this.cb_type.TabIndex = 16;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "构件类别：";
            // 
            // pn_show
            // 
            this.pn_show.Controls.Add(this.chb_BingRoad);
            this.pn_show.Controls.Add(this.cb_MaterialID);
            this.pn_show.Controls.Add(this.label7);
            this.pn_show.Controls.Add(this.chb_Grading);
            this.pn_show.Location = new System.Drawing.Point(359, 17);
            this.pn_show.Margin = new System.Windows.Forms.Padding(2);
            this.pn_show.Name = "pn_show";
            this.pn_show.Size = new System.Drawing.Size(216, 63);
            this.pn_show.TabIndex = 14;
            // 
            // chb_BingRoad
            // 
            this.chb_BingRoad.AutoSize = true;
            this.chb_BingRoad.Location = new System.Drawing.Point(6, 10);
            this.chb_BingRoad.Margin = new System.Windows.Forms.Padding(2);
            this.chb_BingRoad.Name = "chb_BingRoad";
            this.chb_BingRoad.Size = new System.Drawing.Size(96, 16);
            this.chb_BingRoad.TabIndex = 16;
            this.chb_BingRoad.Text = "是否绑定路面";
            this.chb_BingRoad.UseVisualStyleBackColor = true;
            this.chb_BingRoad.CheckStateChanged += new System.EventHandler(this.chb_BingRoad_CheckStateChanged);
            // 
            // cb_MaterialID
            // 
            this.cb_MaterialID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MaterialID.FormattingEnabled = true;
            this.cb_MaterialID.Items.AddRange(new object[] {
            "水泥混凝土",
            "级配碎石",
            "碾压混凝土",
            "C30现浇砼"});
            this.cb_MaterialID.Location = new System.Drawing.Point(121, 36);
            this.cb_MaterialID.Margin = new System.Windows.Forms.Padding(2);
            this.cb_MaterialID.Name = "cb_MaterialID";
            this.cb_MaterialID.Size = new System.Drawing.Size(92, 20);
            this.cb_MaterialID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "材料信息：";
            // 
            // chb_Grading
            // 
            this.chb_Grading.AutoSize = true;
            this.chb_Grading.Location = new System.Drawing.Point(129, 10);
            this.chb_Grading.Margin = new System.Windows.Forms.Padding(2);
            this.chb_Grading.Name = "chb_Grading";
            this.chb_Grading.Size = new System.Drawing.Size(72, 16);
            this.chb_Grading.TabIndex = 13;
            this.chb_Grading.Text = "是否放坡";
            this.chb_Grading.UseVisualStyleBackColor = true;
            this.chb_Grading.CheckStateChanged += new System.EventHandler(this.chb_Grading_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "*图中为右幅样式，系统会根据左幅自动镜像";
            this.label5.Visible = false;
            // 
            // cb_place
            // 
            this.cb_place.BackColor = System.Drawing.SystemColors.Window;
            this.cb_place.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_place.FormattingEnabled = true;
            this.cb_place.Items.AddRange(new object[] {
            "朝内",
            "朝外"});
            this.cb_place.Location = new System.Drawing.Point(81, 57);
            this.cb_place.Margin = new System.Windows.Forms.Padding(2);
            this.cb_place.Name = "cb_place";
            this.cb_place.Size = new System.Drawing.Size(92, 20);
            this.cb_place.TabIndex = 8;
            // 
            // lb_place
            // 
            this.lb_place.AutoSize = true;
            this.lb_place.Location = new System.Drawing.Point(14, 61);
            this.lb_place.Name = "lb_place";
            this.lb_place.Size = new System.Drawing.Size(65, 12);
            this.lb_place.TabIndex = 7;
            this.lb_place.Text = "参照位置：";
            // 
            // nud_step
            // 
            this.nud_step.Location = new System.Drawing.Point(235, 55);
            this.nud_step.Margin = new System.Windows.Forms.Padding(2);
            this.nud_step.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nud_step.Name = "nud_step";
            this.nud_step.Size = new System.Drawing.Size(50, 21);
            this.nud_step.TabIndex = 6;
            this.nud_step.ValueChanged += new System.EventHandler(this.nud_step_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "台阶数：";
            // 
            // dgv_component
            // 
            this.dgv_component.AllowUserToOrderColumns = true;
            this.dgv_component.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_component.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.参数名称,
            this.Column1,
            this.Column2});
            this.dgv_component.Location = new System.Drawing.Point(4, 80);
            this.dgv_component.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_component.Name = "dgv_component";
            this.dgv_component.RowHeadersWidth = 51;
            this.dgv_component.RowTemplate.Height = 27;
            this.dgv_component.Size = new System.Drawing.Size(571, 182);
            this.dgv_component.TabIndex = 0;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "orderID";
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 6;
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Width = 80;
            // 
            // 参数名称
            // 
            this.参数名称.DataPropertyName = "parameterName";
            this.参数名称.HeaderText = "高度";
            this.参数名称.MinimumWidth = 6;
            this.参数名称.Name = "参数名称";
            this.参数名称.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "宽度";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "坡度";
            this.Column2.Name = "Column2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb_component);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(586, 240);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "构件图";
            // 
            // pb_component
            // 
            this.pb_component.Image = ((System.Drawing.Image)(resources.GetObject("pb_component.Image")));
            this.pb_component.Location = new System.Drawing.Point(4, 19);
            this.pb_component.Margin = new System.Windows.Forms.Padding(2);
            this.pb_component.Name = "pb_component";
            this.pb_component.Size = new System.Drawing.Size(578, 211);
            this.pb_component.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_component.TabIndex = 0;
            this.pb_component.TabStop = false;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Location = new System.Drawing.Point(425, 573);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(71, 26);
            this.btn_OK.TabIndex = 20;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(527, 573);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 26);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // Frm_CrosStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 608);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "Frm_CrosStruct";
            this.Text = "Frm_StandandCrossMember";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pn_show.ResumeLayout(false);
            this.pn_show.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_component)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_component)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_show;
        private System.Windows.Forms.ComboBox cb_MaterialID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chb_Grading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_place;
        private System.Windows.Forms.Label lb_place;
        private System.Windows.Forms.NumericUpDown nud_step;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_component;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb_component;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckBox chb_BingRoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参数名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}