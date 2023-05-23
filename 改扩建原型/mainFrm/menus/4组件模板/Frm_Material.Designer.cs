namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_Material
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
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dgv_Material = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.颜色1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.颜色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材质 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Material)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Edit.Location = new System.Drawing.Point(84, 397);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(71, 26);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = "编辑";
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_create.Location = new System.Drawing.Point(9, 397);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(71, 26);
            this.btn_create.TabIndex = 16;
            this.btn_create.Text = "添加";
            this.btn_create.UseVisualStyleBackColor = false;
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Del.Location = new System.Drawing.Point(159, 397);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(71, 26);
            this.btn_Del.TabIndex = 15;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = false;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Location = new System.Drawing.Point(400, 397);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(71, 26);
            this.btn_OK.TabIndex = 14;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // dgv_Material
            // 
            this.dgv_Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Material.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.名称,
            this.argb,
            this.颜色1,
            this.MaterialID,
            this.颜色,
            this.材质});
            this.dgv_Material.Location = new System.Drawing.Point(7, 16);
            this.dgv_Material.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Material.Name = "dgv_Material";
            this.dgv_Material.ReadOnly = true;
            this.dgv_Material.RowHeadersWidth = 51;
            this.dgv_Material.RowTemplate.Height = 27;
            this.dgv_Material.Size = new System.Drawing.Size(470, 366);
            this.dgv_Material.TabIndex = 13;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "序号";
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 6;
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.序号.Visible = false;
            this.序号.Width = 80;
            // 
            // 名称
            // 
            this.名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.名称.DataPropertyName = "名称";
            this.名称.HeaderText = "名称";
            this.名称.MinimumWidth = 6;
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // argb
            // 
            this.argb.HeaderText = "颜色";
            this.argb.MinimumWidth = 6;
            this.argb.Name = "argb";
            this.argb.ReadOnly = true;
            this.argb.Width = 60;
            // 
            // 颜色1
            // 
            this.颜色1.DataPropertyName = "argb";
            this.颜色1.HeaderText = "颜色";
            this.颜色1.MinimumWidth = 6;
            this.颜色1.Name = "颜色1";
            this.颜色1.ReadOnly = true;
            this.颜色1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.颜色1.Visible = false;
            this.颜色1.Width = 125;
            // 
            // MaterialID
            // 
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.HeaderText = "MaterialID";
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.ReadOnly = true;
            this.MaterialID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaterialID.Visible = false;
            // 
            // 颜色
            // 
            this.颜色.DataPropertyName = "颜色";
            this.颜色.HeaderText = "颜色";
            this.颜色.Name = "颜色";
            this.颜色.ReadOnly = true;
            this.颜色.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.颜色.Visible = false;
            // 
            // 材质
            // 
            this.材质.DataPropertyName = "materialQuality";
            this.材质.HeaderText = "材质";
            this.材质.Name = "材质";
            this.材质.ReadOnly = true;
            // 
            // Frm_MaterialStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 438);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_Material);
            this.Name = "Frm_MaterialStore";
            this.Text = "Frm_MaterialStore";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Material)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView dgv_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn argb;
        private System.Windows.Forms.DataGridViewTextBoxColumn 颜色1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 颜色;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材质;
    }
}