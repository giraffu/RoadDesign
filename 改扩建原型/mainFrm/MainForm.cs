//using RoadDesign.Common;
//using RoadDesign.Expert;
//using RoadDesign.global;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RoadExpensionDesign.mainFrm.menus;


namespace RoadExpensionDesign
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void SetTitle(string _title)
        {
            this.Text = "改扩建路面三维设计系统--" + _title;
        }
        #region 项目
        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_proj_add_Click(object sender, EventArgs e)
        {
            Frm_NewProject _Frm_NewProject = new Frm_NewProject();
            _Frm_NewProject.Owner = this;
            _Frm_NewProject.ShowDialog();
        }
        /// <summary>
        /// 打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //OpenProjectDB();
        }
        private void main_proj_setting_Click(object sender, EventArgs e)
        {
            new Frm_UserSetting().ShowDialog();
        }
        /// <summary>
        /// 项目信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProjectInfo _Frm_ProjectInfo = new Frm_ProjectInfo();
            _Frm_ProjectInfo.Owner = this;
            _Frm_ProjectInfo.ShowDialog();
        }
        #endregion
        #region 路线管理

        #endregion
        #region 数据
        /// <summary>
        /// 自定义段落
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_dataInput_customRange_Click(object sender, EventArgs e)
        {
            new Frm_CustomRange().ShowDialog();
        }
        #endregion
        #region 组件模板
        /// <summary>
        /// 路面结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_compModels_pave_Click(object sender, EventArgs e)
        {
            new Frm_PaveStruct().ShowDialog();
        }
        /// <summary>
        /// 标准路幅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_compModels_road_Click(object sender, EventArgs e)
        {
            new Frm_RoadStruct().ShowDialog();
        }
        /// <summary>
        /// 横向构件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_compModels_crosStr_Click(object sender, EventArgs e)
        {
            new Frm_CrosStruct().ShowDialog();
        }
        /// <summary>
        /// 材料库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_compModels_material_Click(object sender, EventArgs e)
        {
            new Frm_Material().ShowDialog();
        }
        /// <summary>
        /// 横断面模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_compModels_design_Click(object sender, EventArgs e)
        {
            new Frm_CrossSecModels().ShowDialog();
        }




        #endregion

        #region 横断面设计


        #endregion
        #region 平纵横设计
        /// <summary>
        /// 平面拼宽原则
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_design_horRule_Click(object sender, EventArgs e)
        {
            new Frm_HorRule().ShowDialog();

        }
        /// <summary>
        /// 计算拼宽段落
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_design_calHorSec_Click(object sender, EventArgs e)
        {
            new Frm_CalHorSection().ShowDialog();

        }
        /// <summary>
        /// 调整平面方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_design_modifyHorPlan_Click(object sender, EventArgs e)
        {
            new Frm_ModifySection().ShowDialog();

        }
        /// <summary>
        /// 加铺方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_design_PaveMethod_Click(object sender, EventArgs e)
        {
            new Frm_PaveMethod().ShowDialog();

        }
        /// <summary>
        /// 纵面加铺原则
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void main_design_verRule_Click(object sender, EventArgs e)
        {
            new Frm_VerRule().ShowDialog();

        }
        /// <summary>
        /// 定义纵面加铺区间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void main_design_paveRange_Click(object sender, EventArgs e)
        {
            new Frm_PaveRange().ShowDialog();

        }
        /// <summary>
        /// 计算纵面加铺方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void main_design_calPaveRange_Click(object sender, EventArgs e)
        {
            new Frm_CalPaveRange().ShowDialog();

        }
        /// <summary>
        /// 调整加铺方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_design_modifyPavePlan_Click(object sender, EventArgs e)
        {
            new Frm_ModifyPavePlan().ShowDialog();

        }











        #endregion

        #region 三维模型

        #endregion

        #region 成果输出

        #endregion

        #region 帮助

        #endregion




    }

}
