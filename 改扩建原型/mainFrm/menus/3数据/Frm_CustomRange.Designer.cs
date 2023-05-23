namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_CustomRange
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dgv_Construct = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.起点桩号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.终点桩号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Construct)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(664, 357);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 26);
            this.btn_Cancel.TabIndex = 51;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Location = new System.Drawing.Point(570, 357);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(71, 26);
            this.btn_OK.TabIndex = 50;
            this.btn_OK.Text = "保存";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // dgv_Construct
            // 
            this.dgv_Construct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Construct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.起点桩号,
            this.终点桩号,
            this.位置,
            this.类型});
            this.dgv_Construct.Location = new System.Drawing.Point(10, 11);
            this.dgv_Construct.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Construct.Name = "dgv_Construct";
            this.dgv_Construct.RowHeadersWidth = 51;
            this.dgv_Construct.RowTemplate.Height = 27;
            this.dgv_Construct.Size = new System.Drawing.Size(725, 330);
            this.dgv_Construct.TabIndex = 49;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "orderid";
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 6;
            this.序号.Name = "序号";
            this.序号.Visible = false;
            this.序号.Width = 125;
            // 
            // 起点桩号
            // 
            this.起点桩号.DataPropertyName = "startStake";
            this.起点桩号.HeaderText = "起点桩号";
            this.起点桩号.MinimumWidth = 6;
            this.起点桩号.Name = "起点桩号";
            this.起点桩号.Width = 150;
            // 
            // 终点桩号
            // 
            this.终点桩号.DataPropertyName = "endStake";
            this.终点桩号.HeaderText = "终点桩号";
            this.终点桩号.MinimumWidth = 6;
            this.终点桩号.Name = "终点桩号";
            this.终点桩号.Width = 150;
            // 
            // 位置
            // 
            this.位置.DataPropertyName = "place";
            this.位置.HeaderText = "位置";
            this.位置.Name = "位置";
            this.位置.Width = 150;
            // 
            // 类型
            // 
            this.类型.DataPropertyName = "Explain";
            this.类型.HeaderText = "段落名称";
            this.类型.MinimumWidth = 6;
            this.类型.Name = "类型";
            this.类型.Width = 220;
            // 
            // Frm_CustomRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 395);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_Construct);
            this.Name = "Frm_CustomRange";
            this.Text = "自定义段落信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Construct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView dgv_Construct;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 起点桩号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 终点桩号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
    }
}