namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_PaveRange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PaveRange));
            this.cb_place = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bn_OverlayRegion = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dgv_OverlayRegion = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.起点桩号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.终点桩号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.加铺原则 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cb_RoadLine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bn_OverlayRegion)).BeginInit();
            this.bn_OverlayRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OverlayRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_place
            // 
            this.cb_place.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_place.FormattingEnabled = true;
            this.cb_place.Items.AddRange(new object[] {
            "左幅",
            "右幅"});
            this.cb_place.Location = new System.Drawing.Point(277, 35);
            this.cb_place.Margin = new System.Windows.Forms.Padding(2);
            this.cb_place.Name = "cb_place";
            this.cb_place.Size = new System.Drawing.Size(57, 20);
            this.cb_place.TabIndex = 65;
            this.cb_place.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 64;
            this.label3.Text = "位置：";
            this.label3.Visible = false;
            // 
            // bn_OverlayRegion
            // 
            this.bn_OverlayRegion.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bn_OverlayRegion.CountItem = this.bindingNavigatorCountItem;
            this.bn_OverlayRegion.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bn_OverlayRegion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bn_OverlayRegion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bn_OverlayRegion.Location = new System.Drawing.Point(0, 0);
            this.bn_OverlayRegion.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn_OverlayRegion.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn_OverlayRegion.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn_OverlayRegion.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn_OverlayRegion.Name = "bn_OverlayRegion";
            this.bn_OverlayRegion.PositionItem = this.bindingNavigatorPositionItem;
            this.bn_OverlayRegion.Size = new System.Drawing.Size(512, 27);
            this.bn_OverlayRegion.TabIndex = 63;
            this.bn_OverlayRegion.Text = "bindingNavigator1";
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
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(369, 407);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 26);
            this.btn_Cancel.TabIndex = 62;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Location = new System.Drawing.Point(272, 407);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(71, 26);
            this.btn_OK.TabIndex = 61;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // dgv_OverlayRegion
            // 
            this.dgv_OverlayRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OverlayRegion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.起点桩号,
            this.终点桩号,
            this.加铺原则});
            this.dgv_OverlayRegion.Location = new System.Drawing.Point(9, 59);
            this.dgv_OverlayRegion.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_OverlayRegion.Name = "dgv_OverlayRegion";
            this.dgv_OverlayRegion.RowHeadersWidth = 51;
            this.dgv_OverlayRegion.RowTemplate.Height = 27;
            this.dgv_OverlayRegion.Size = new System.Drawing.Size(492, 330);
            this.dgv_OverlayRegion.TabIndex = 60;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "orderid";
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 6;
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Visible = false;
            this.序号.Width = 60;
            // 
            // 起点桩号
            // 
            this.起点桩号.DataPropertyName = "startStake";
            this.起点桩号.HeaderText = "起点桩号";
            this.起点桩号.MinimumWidth = 6;
            this.起点桩号.Name = "起点桩号";
            // 
            // 终点桩号
            // 
            this.终点桩号.DataPropertyName = "endStake";
            this.终点桩号.HeaderText = "终点桩号";
            this.终点桩号.MinimumWidth = 6;
            this.终点桩号.Name = "终点桩号";
            // 
            // 加铺原则
            // 
            this.加铺原则.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.加铺原则.DataPropertyName = "OverlayRule";
            this.加铺原则.HeaderText = "加铺原则";
            this.加铺原则.MinimumWidth = 200;
            this.加铺原则.Name = "加铺原则";
            this.加铺原则.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.加铺原则.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cb_RoadLine
            // 
            this.cb_RoadLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RoadLine.FormattingEnabled = true;
            this.cb_RoadLine.Items.AddRange(new object[] {
            "K3"});
            this.cb_RoadLine.Location = new System.Drawing.Point(87, 35);
            this.cb_RoadLine.Margin = new System.Windows.Forms.Padding(2);
            this.cb_RoadLine.Name = "cb_RoadLine";
            this.cb_RoadLine.Size = new System.Drawing.Size(137, 20);
            this.cb_RoadLine.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 58;
            this.label2.Text = "新路设计线：";
            // 
            // Frm_PaveRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 438);
            this.Controls.Add(this.cb_place);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bn_OverlayRegion);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_OverlayRegion);
            this.Controls.Add(this.cb_RoadLine);
            this.Controls.Add(this.label2);
            this.Name = "Frm_PaveRange";
            this.Text = "Frm_OverlayRegion";
            ((System.ComponentModel.ISupportInitialize)(this.bn_OverlayRegion)).EndInit();
            this.bn_OverlayRegion.ResumeLayout(false);
            this.bn_OverlayRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OverlayRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_place;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingNavigator bn_OverlayRegion;
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
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView dgv_OverlayRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 起点桩号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 终点桩号;
        private System.Windows.Forms.DataGridViewComboBoxColumn 加铺原则;
        private System.Windows.Forms.ComboBox cb_RoadLine;
        private System.Windows.Forms.Label label2;
    }
}