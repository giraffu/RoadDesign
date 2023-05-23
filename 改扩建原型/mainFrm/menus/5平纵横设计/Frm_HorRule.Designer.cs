namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_HorRule
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dgv_PlanewideningSetMng = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大于 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小于 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.拼宽方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_PlanewideningSetMng = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlanewideningSetMng)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.Location = new System.Drawing.Point(266, 397);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(71, 26);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(461, 397);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 26);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "关闭";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Update.Location = new System.Drawing.Point(365, 397);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(71, 26);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // dgv_PlanewideningSetMng
            // 
            this.dgv_PlanewideningSetMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PlanewideningSetMng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.大于,
            this.小于,
            this.拼宽方式});
            this.dgv_PlanewideningSetMng.Location = new System.Drawing.Point(7, 49);
            this.dgv_PlanewideningSetMng.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_PlanewideningSetMng.Name = "dgv_PlanewideningSetMng";
            this.dgv_PlanewideningSetMng.RowHeadersWidth = 51;
            this.dgv_PlanewideningSetMng.RowTemplate.Height = 27;
            this.dgv_PlanewideningSetMng.Size = new System.Drawing.Size(526, 330);
            this.dgv_PlanewideningSetMng.TabIndex = 14;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "orderID";
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 6;
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Visible = false;
            this.序号.Width = 60;
            // 
            // 大于
            // 
            this.大于.DataPropertyName = "greater";
            this.大于.HeaderText = "大于(m)";
            this.大于.MinimumWidth = 6;
            this.大于.Name = "大于";
            this.大于.ReadOnly = true;
            this.大于.Width = 120;
            // 
            // 小于
            // 
            this.小于.DataPropertyName = "less";
            this.小于.HeaderText = "小于(m)";
            this.小于.MinimumWidth = 6;
            this.小于.Name = "小于";
            this.小于.ReadOnly = true;
            this.小于.Width = 120;
            // 
            // 拼宽方式
            // 
            this.拼宽方式.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.拼宽方式.DataPropertyName = "WideningName";
            this.拼宽方式.HeaderText = "拼宽方式";
            this.拼宽方式.MinimumWidth = 6;
            this.拼宽方式.Name = "拼宽方式";
            this.拼宽方式.ReadOnly = true;
            // 
            // cb_PlanewideningSetMng
            // 
            this.cb_PlanewideningSetMng.BackColor = System.Drawing.SystemColors.Window;
            this.cb_PlanewideningSetMng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PlanewideningSetMng.FormattingEnabled = true;
            this.cb_PlanewideningSetMng.Items.AddRange(new object[] {
            "拼宽规则1",
            "拼宽规则2"});
            this.cb_PlanewideningSetMng.Location = new System.Drawing.Point(105, 15);
            this.cb_PlanewideningSetMng.Margin = new System.Windows.Forms.Padding(2);
            this.cb_PlanewideningSetMng.Name = "cb_PlanewideningSetMng";
            this.cb_PlanewideningSetMng.Size = new System.Drawing.Size(202, 20);
            this.cb_PlanewideningSetMng.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "拼宽规则：";
            // 
            // Frm_Widening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 438);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dgv_PlanewideningSetMng);
            this.Controls.Add(this.cb_PlanewideningSetMng);
            this.Controls.Add(this.label2);
            this.Name = "Frm_Widening";
            this.Text = "Frm_Widening";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlanewideningSetMng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dgv_PlanewideningSetMng;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 大于;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小于;
        private System.Windows.Forms.DataGridViewTextBoxColumn 拼宽方式;
        private System.Windows.Forms.ComboBox cb_PlanewideningSetMng;
        private System.Windows.Forms.Label label2;
    }
}