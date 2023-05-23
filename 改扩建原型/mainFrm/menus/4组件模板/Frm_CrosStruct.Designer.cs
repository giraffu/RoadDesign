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
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Step = new System.Windows.Forms.Button();
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
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.说明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.参数名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.参数值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.父编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_signalPicture = new System.Windows.Forms.Button();
            this.pb_component = new System.Windows.Forms.PictureBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tv_componentMng = new System.Windows.Forms.TreeView();
            this.groupBox3.SuspendLayout();
            this.pn_show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_component)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_component)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Copy
            // 
            this.btn_Copy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Copy.Location = new System.Drawing.Point(67, 593);
            this.btn_Copy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(47, 26);
            this.btn_Copy.TabIndex = 23;
            this.btn_Copy.Text = "复制";
            this.btn_Copy.UseVisualStyleBackColor = false;
            // 
            // btn_Rename
            // 
            this.btn_Rename.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Rename.Location = new System.Drawing.Point(121, 593);
            this.btn_Rename.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(50, 26);
            this.btn_Rename.TabIndex = 18;
            this.btn_Rename.Text = "重命名";
            this.btn_Rename.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Step);
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
            this.groupBox3.Location = new System.Drawing.Point(256, 275);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(586, 307);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置";
            // 
            // Btn_Step
            // 
            this.Btn_Step.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Step.Location = new System.Drawing.Point(284, 53);
            this.Btn_Step.Name = "Btn_Step";
            this.Btn_Step.Size = new System.Drawing.Size(80, 23);
            this.Btn_Step.TabIndex = 15;
            this.Btn_Step.Text = "修改台阶数";
            this.Btn_Step.UseVisualStyleBackColor = false;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(229, 27);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(135, 21);
            this.tb_Name.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 31);
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
            this.pn_show.Location = new System.Drawing.Point(369, 17);
            this.pn_show.Margin = new System.Windows.Forms.Padding(2);
            this.pn_show.Name = "pn_show";
            this.pn_show.Size = new System.Drawing.Size(206, 63);
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
            this.cb_MaterialID.Location = new System.Drawing.Point(94, 36);
            this.cb_MaterialID.Margin = new System.Windows.Forms.Padding(2);
            this.cb_MaterialID.Name = "cb_MaterialID";
            this.cb_MaterialID.Size = new System.Drawing.Size(92, 20);
            this.cb_MaterialID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "材料信息：";
            // 
            // chb_Grading
            // 
            this.chb_Grading.AutoSize = true;
            this.chb_Grading.Location = new System.Drawing.Point(106, 10);
            this.chb_Grading.Margin = new System.Windows.Forms.Padding(2);
            this.chb_Grading.Name = "chb_Grading";
            this.chb_Grading.Size = new System.Drawing.Size(84, 16);
            this.chb_Grading.TabIndex = 13;
            this.chb_Grading.Text = "含放坡构造";
            this.chb_Grading.UseVisualStyleBackColor = true;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 61);
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
            this.名称,
            this.说明,
            this.参数名称,
            this.参数值,
            this.编号,
            this.父编号});
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
            this.序号.Visible = false;
            this.序号.Width = 80;
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "text";
            this.名称.HeaderText = "参数";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.Visible = false;
            this.名称.Width = 80;
            // 
            // 说明
            // 
            this.说明.DataPropertyName = "Explain";
            this.说明.HeaderText = "铣刨厚度（cm）";
            this.说明.MinimumWidth = 6;
            this.说明.Name = "说明";
            this.说明.Visible = false;
            this.说明.Width = 125;
            // 
            // 参数名称
            // 
            this.参数名称.DataPropertyName = "parameterName";
            this.参数名称.HeaderText = "参数 ";
            this.参数名称.MinimumWidth = 6;
            this.参数名称.Name = "参数名称";
            this.参数名称.ReadOnly = true;
            // 
            // 参数值
            // 
            this.参数值.DataPropertyName = "parameterValue";
            this.参数值.HeaderText = "参数值(cm)";
            this.参数值.MinimumWidth = 6;
            this.参数值.Name = "参数值";
            this.参数值.Width = 150;
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "GUID";
            this.编号.HeaderText = "编号";
            this.编号.MinimumWidth = 6;
            this.编号.Name = "编号";
            this.编号.Visible = false;
            this.编号.Width = 125;
            // 
            // 父编号
            // 
            this.父编号.DataPropertyName = "PGUID";
            this.父编号.HeaderText = "父编号";
            this.父编号.MinimumWidth = 6;
            this.父编号.Name = "父编号";
            this.父编号.Visible = false;
            this.父编号.Width = 125;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_del.Location = new System.Drawing.Point(180, 593);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(53, 26);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_state);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_signalPicture);
            this.groupBox2.Controls.Add(this.pb_component);
            this.groupBox2.Location = new System.Drawing.Point(256, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(586, 261);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "构件图";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.ForeColor = System.Drawing.Color.Red;
            this.lbl_state.Location = new System.Drawing.Point(71, 238);
            this.lbl_state.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(29, 12);
            this.lbl_state.TabIndex = 17;
            this.lbl_state.Text = "编辑";
            this.lbl_state.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "编辑状态：";
            this.label6.Visible = false;
            // 
            // btn_signalPicture
            // 
            this.btn_signalPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_signalPicture.Location = new System.Drawing.Point(488, 231);
            this.btn_signalPicture.Margin = new System.Windows.Forms.Padding(2);
            this.btn_signalPicture.Name = "btn_signalPicture";
            this.btn_signalPicture.Size = new System.Drawing.Size(94, 26);
            this.btn_signalPicture.TabIndex = 15;
            this.btn_signalPicture.Text = "更换示意图";
            this.btn_signalPicture.UseVisualStyleBackColor = false;
            this.btn_signalPicture.Visible = false;
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
            this.btn_OK.Location = new System.Drawing.Point(670, 593);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(71, 26);
            this.btn_OK.TabIndex = 20;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_New.Location = new System.Drawing.Point(9, 593);
            this.btn_New.Margin = new System.Windows.Forms.Padding(2);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(52, 26);
            this.btn_New.TabIndex = 15;
            this.btn_New.Text = "新增";
            this.btn_New.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(772, 593);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 26);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_componentMng);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(243, 573);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "横向构件列表";
            // 
            // tv_componentMng
            // 
            this.tv_componentMng.Location = new System.Drawing.Point(4, 19);
            this.tv_componentMng.Margin = new System.Windows.Forms.Padding(2);
            this.tv_componentMng.Name = "tv_componentMng";
            this.tv_componentMng.Size = new System.Drawing.Size(233, 547);
            this.tv_componentMng.TabIndex = 0;
            // 
            // Frm_CrosStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 629);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_Rename);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_CrosStruct";
            this.Text = "Frm_StandandCrossMember";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pn_show.ResumeLayout(false);
            this.pn_show.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_component)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_component)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Step;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 说明;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参数名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参数值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 父编号;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_signalPicture;
        private System.Windows.Forms.PictureBox pb_component;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tv_componentMng;
        private System.Windows.Forms.CheckBox chb_BingRoad;
    }
}