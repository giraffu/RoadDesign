namespace RoadExpensionDesign.mainFrm.menus
{
    partial class Frm_RoadStruct
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtb_Explain = new System.Windows.Forms.RichTextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_MoveUp = new System.Windows.Forms.Button();
            this.btn_MoveDown = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tv_StandardRoadwayModel = new System.Windows.Forms.TreeView();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtb_Explain);
            this.groupBox2.Location = new System.Drawing.Point(12, 371);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(376, 98);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模板简要信息";
            // 
            // rtb_Explain
            // 
            this.rtb_Explain.Location = new System.Drawing.Point(4, 20);
            this.rtb_Explain.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_Explain.Name = "rtb_Explain";
            this.rtb_Explain.Size = new System.Drawing.Size(368, 74);
            this.rtb_Explain.TabIndex = 0;
            this.rtb_Explain.Text = "";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(318, 67);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(71, 26);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_MoveUp
            // 
            this.btn_MoveUp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_MoveUp.Location = new System.Drawing.Point(317, 198);
            this.btn_MoveUp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MoveUp.Name = "btn_MoveUp";
            this.btn_MoveUp.Size = new System.Drawing.Size(71, 26);
            this.btn_MoveUp.TabIndex = 22;
            this.btn_MoveUp.Text = "上移";
            this.btn_MoveUp.UseVisualStyleBackColor = false;
            // 
            // btn_MoveDown
            // 
            this.btn_MoveDown.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_MoveDown.Location = new System.Drawing.Point(318, 243);
            this.btn_MoveDown.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MoveDown.Name = "btn_MoveDown";
            this.btn_MoveDown.Size = new System.Drawing.Size(71, 26);
            this.btn_MoveDown.TabIndex = 21;
            this.btn_MoveDown.Text = "下移";
            this.btn_MoveDown.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(317, 292);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 26);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "关闭";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Del.Location = new System.Drawing.Point(317, 154);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(71, 26);
            this.btn_Del.TabIndex = 19;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = false;
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_New.Location = new System.Drawing.Point(317, 25);
            this.btn_New.Margin = new System.Windows.Forms.Padding(2);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(71, 26);
            this.btn_New.TabIndex = 18;
            this.btn_New.Text = "新建";
            this.btn_New.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_StandardRoadwayModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(283, 345);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标准路幅列表";
            // 
            // tv_StandardRoadwayModel
            // 
            this.tv_StandardRoadwayModel.Location = new System.Drawing.Point(4, 26);
            this.tv_StandardRoadwayModel.Margin = new System.Windows.Forms.Padding(2);
            this.tv_StandardRoadwayModel.Name = "tv_StandardRoadwayModel";
            this.tv_StandardRoadwayModel.Size = new System.Drawing.Size(275, 319);
            this.tv_StandardRoadwayModel.TabIndex = 0;
            // 
            // btn_Rename
            // 
            this.btn_Rename.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Rename.Location = new System.Drawing.Point(317, 109);
            this.btn_Rename.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(71, 26);
            this.btn_Rename.TabIndex = 16;
            this.btn_Rename.Text = "重命名";
            this.btn_Rename.UseVisualStyleBackColor = false;
            // 
            // Frm_StandardRoadway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_MoveUp);
            this.Controls.Add(this.btn_MoveDown);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Rename);
            this.Name = "Frm_StandardRoadway";
            this.Text = "Frm_StandardRoadway";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtb_Explain;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_MoveUp;
        private System.Windows.Forms.Button btn_MoveDown;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tv_StandardRoadwayModel;
        private System.Windows.Forms.Button btn_Rename;
    }
}