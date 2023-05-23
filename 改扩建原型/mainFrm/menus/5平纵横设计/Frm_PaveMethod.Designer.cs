namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_PaveMethod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PaveMethod));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Edit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_roadStruct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bn_StandardOverlayWay = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.dgv_StandardOverlayWay = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厚度初值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厚度变化值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材料 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tv_StandardOverlayWayMng = new System.Windows.Forms.TreeView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_StandardOverlayWay)).BeginInit();
            this.bn_StandardOverlayWay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StandardOverlayWay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(208, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Location = new System.Drawing.Point(629, 453);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(71, 26);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.Text = "保存";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_copy.Location = new System.Drawing.Point(114, 453);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(71, 26);
            this.btn_copy.TabIndex = 24;
            this.btn_copy.Text = "复制";
            this.btn_copy.UseVisualStyleBackColor = false;
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_New.Location = new System.Drawing.Point(21, 453);
            this.btn_New.Margin = new System.Windows.Forms.Padding(2);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(71, 26);
            this.btn_New.TabIndex = 23;
            this.btn_New.Text = "新建";
            this.btn_New.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Edit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_roadStruct);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bn_StandardOverlayWay);
            this.groupBox2.Controls.Add(this.tb_Name);
            this.groupBox2.Controls.Add(this.dgv_StandardOverlayWay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(230, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(574, 441);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑";
            // 
            // lbl_Edit
            // 
            this.lbl_Edit.AutoSize = true;
            this.lbl_Edit.ForeColor = System.Drawing.Color.Red;
            this.lbl_Edit.Location = new System.Drawing.Point(544, 54);
            this.lbl_Edit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Edit.Name = "lbl_Edit";
            this.lbl_Edit.Size = new System.Drawing.Size(29, 12);
            this.lbl_Edit.TabIndex = 25;
            this.lbl_Edit.Text = "编辑";
            this.lbl_Edit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "状态：";
            this.label1.Visible = false;
            // 
            // cb_roadStruct
            // 
            this.cb_roadStruct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_roadStruct.FormattingEnabled = true;
            this.cb_roadStruct.Items.AddRange(new object[] {
            "路面结构1",
            "路面结构2",
            "路面结构3"});
            this.cb_roadStruct.Location = new System.Drawing.Point(454, 51);
            this.cb_roadStruct.Margin = new System.Windows.Forms.Padding(2);
            this.cb_roadStruct.Name = "cb_roadStruct";
            this.cb_roadStruct.Size = new System.Drawing.Size(43, 20);
            this.cb_roadStruct.TabIndex = 23;
            this.cb_roadStruct.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "选择路面结构模板：";
            this.label5.Visible = false;
            // 
            // bn_StandardOverlayWay
            // 
            this.bn_StandardOverlayWay.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bn_StandardOverlayWay.CountItem = this.bindingNavigatorCountItem;
            this.bn_StandardOverlayWay.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bn_StandardOverlayWay.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bn_StandardOverlayWay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bn_StandardOverlayWay.Location = new System.Drawing.Point(2, 16);
            this.bn_StandardOverlayWay.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_StandardOverlayWay.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_StandardOverlayWay.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_StandardOverlayWay.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_StandardOverlayWay.Name = "bn_StandardOverlayWay";
            this.bn_StandardOverlayWay.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_StandardOverlayWay.Size = new System.Drawing.Size(570, 27);
            this.bn_StandardOverlayWay.TabIndex = 18;
            this.bn_StandardOverlayWay.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(88, 49);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(232, 21);
            this.tb_Name.TabIndex = 17;
            // 
            // dgv_StandardOverlayWay
            // 
            this.dgv_StandardOverlayWay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StandardOverlayWay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.名称,
            this.厚度初值,
            this.厚度变化值,
            this.材料});
            this.dgv_StandardOverlayWay.Location = new System.Drawing.Point(14, 82);
            this.dgv_StandardOverlayWay.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_StandardOverlayWay.Name = "dgv_StandardOverlayWay";
            this.dgv_StandardOverlayWay.RowHeadersWidth = 51;
            this.dgv_StandardOverlayWay.RowTemplate.Height = 27;
            this.dgv_StandardOverlayWay.Size = new System.Drawing.Size(554, 351);
            this.dgv_StandardOverlayWay.TabIndex = 16;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "SortID";
            this.序号.Frozen = true;
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 6;
            this.序号.Name = "序号";
            this.序号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.序号.Visible = false;
            this.序号.Width = 60;
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "OverlayName";
            this.名称.HeaderText = "名称";
            this.名称.MinimumWidth = 100;
            this.名称.Name = "名称";
            this.名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 厚度初值
            // 
            this.厚度初值.DataPropertyName = "thicknessStart";
            this.厚度初值.HeaderText = "厚度初值(cm)";
            this.厚度初值.MinimumWidth = 100;
            this.厚度初值.Name = "厚度初值";
            this.厚度初值.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 厚度变化值
            // 
            this.厚度变化值.DataPropertyName = "thicknessEnd";
            this.厚度变化值.HeaderText = "厚度变化值(cm)";
            this.厚度变化值.MinimumWidth = 110;
            this.厚度变化值.Name = "厚度变化值";
            this.厚度变化值.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.厚度变化值.Width = 110;
            // 
            // 材料
            // 
            this.材料.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.材料.DataPropertyName = "Material";
            this.材料.HeaderText = "材料";
            this.材料.MinimumWidth = 6;
            this.材料.Name = "材料";
            this.材料.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.材料.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "加铺方式名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_StandardOverlayWayMng);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(207, 442);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加铺方式";
            // 
            // tv_StandardOverlayWayMng
            // 
            this.tv_StandardOverlayWayMng.Location = new System.Drawing.Point(4, 19);
            this.tv_StandardOverlayWayMng.Margin = new System.Windows.Forms.Padding(2);
            this.tv_StandardOverlayWayMng.Name = "tv_StandardOverlayWayMng";
            this.tv_StandardOverlayWayMng.Size = new System.Drawing.Size(199, 419);
            this.tv_StandardOverlayWayMng.TabIndex = 12;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(721, 453);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 26);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // Frm_PaveMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "Frm_PaveMethod";
            this.Text = "Frm_StandardOverlayWay";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn_StandardOverlayWay)).EndInit();
            this.bn_StandardOverlayWay.ResumeLayout(false);
            this.bn_StandardOverlayWay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StandardOverlayWay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_roadStruct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingNavigator bn_StandardOverlayWay;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DataGridView dgv_StandardOverlayWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厚度初值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厚度变化值;
        private System.Windows.Forms.DataGridViewComboBoxColumn 材料;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tv_StandardOverlayWayMng;
        private System.Windows.Forms.Button btn_Cancel;
    }
}