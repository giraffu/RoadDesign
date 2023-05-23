namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_CrossSecModels
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
            this.tv_CrossMng = new System.Windows.Forms.TreeView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_arrange = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.说明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.参数名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.参数值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.父编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arrange)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_CrossMng
            // 
            this.tv_CrossMng.Location = new System.Drawing.Point(11, 93);
            this.tv_CrossMng.Margin = new System.Windows.Forms.Padding(2);
            this.tv_CrossMng.Name = "tv_CrossMng";
            this.tv_CrossMng.Size = new System.Drawing.Size(175, 291);
            this.tv_CrossMng.TabIndex = 47;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(718, 401);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 26);
            this.btn_Cancel.TabIndex = 53;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Location = new System.Drawing.Point(626, 401);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(71, 26);
            this.btn_OK.TabIndex = 52;
            this.btn_OK.Text = "保存";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(265, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 30);
            this.btn_delete.TabIndex = 51;
            this.btn_delete.Text = "删除横断面";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(152, 23);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(90, 30);
            this.btn_copy.TabIndex = 50;
            this.btn_copy.Text = "复制横断面";
            this.btn_copy.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(39, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 30);
            this.btn_add.TabIndex = 49;
            this.btn_add.Text = "添加横断面";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_arrange
            // 
            this.dgv_arrange.AllowUserToOrderColumns = true;
            this.dgv_arrange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_arrange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.名称,
            this.说明,
            this.参数名称,
            this.参数值,
            this.编号,
            this.父编号});
            this.dgv_arrange.Location = new System.Drawing.Point(206, 93);
            this.dgv_arrange.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_arrange.MultiSelect = false;
            this.dgv_arrange.Name = "dgv_arrange";
            this.dgv_arrange.ReadOnly = true;
            this.dgv_arrange.RowHeadersWidth = 51;
            this.dgv_arrange.RowTemplate.Height = 27;
            this.dgv_arrange.Size = new System.Drawing.Size(583, 291);
            this.dgv_arrange.TabIndex = 48;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "orderID";
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 6;
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Width = 60;
            // 
            // 名称
            // 
            this.名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.名称.DataPropertyName = "text";
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            // 
            // 说明
            // 
            this.说明.DataPropertyName = "Explain";
            this.说明.HeaderText = "拼宽方式";
            this.说明.MinimumWidth = 6;
            this.说明.Name = "说明";
            this.说明.ReadOnly = true;
            // 
            // 参数名称
            // 
            this.参数名称.DataPropertyName = "parameterName";
            this.参数名称.HeaderText = "段落类型";
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
            this.参数值.ReadOnly = true;
            this.参数值.Visible = false;
            this.参数值.Width = 150;
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "GUID";
            this.编号.HeaderText = "编号";
            this.编号.MinimumWidth = 6;
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            this.编号.Visible = false;
            this.编号.Width = 125;
            // 
            // 父编号
            // 
            this.父编号.DataPropertyName = "PGUID";
            this.父编号.HeaderText = "父编号";
            this.父编号.MinimumWidth = 6;
            this.父编号.Name = "父编号";
            this.父编号.ReadOnly = true;
            this.父编号.Visible = false;
            this.父编号.Width = 125;
            // 
            // Frm_CrossSecModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tv_CrossMng);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_arrange);
            this.Name = "Frm_CrossSecModels";
            this.Text = "Frm_CrossSecModels";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arrange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_CrossMng;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_arrange;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 说明;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参数名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参数值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 父编号;
    }
}