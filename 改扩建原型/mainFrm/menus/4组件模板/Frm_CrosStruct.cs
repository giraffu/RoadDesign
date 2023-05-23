using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadExpensionDesign.mainFrm.menus
{
    public partial class Frm_CrosStruct : Form
    {
        #region 公共变量
        int step = 0;//台阶数 
        #endregion


        public Frm_CrosStruct()
        {
            InitializeComponent();
            initTemp();
        }


        #region 构件信息

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void initTemp()
        {
            cb_MaterialID.SelectedIndex = 0;
            cb_place.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
            this.height.Visible = true;
            this.width.Visible = true;
            this.slope.Visible = false;
            this.cb_Milling.Visible = false;
            this.cb_Milling.Checked = true;
            this.cb_Height.Checked = true;
            this.cb_Height.Visible = false;

        }

        /// <summary>
        /// 选择不同的横向构件触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex == 3)
            {
                this.cb_Milling.Visible = true;
                this.dgv_component.Visible = false;
                this.label7.Visible= false;
                cb_place.Visible = false;
                pn_show.Visible = false;
                this.cb_MaterialID.Visible= false;
                setVisible();
                cb_MillingChange();
                cb_HeightChange();

            }
            else if (cb_type.SelectedIndex == 2)
            {
                this.cb_Milling.Visible = false;
                this.dgv_component.Visible = true;
                this.cb_MaterialID.Visible = true;
                this.label3.Visible = true;
                this.label7.Visible = true;
                nud_step.Visible = true;
                cb_place.Visible = true;
                pn_show.Visible = true;
                this.cb_Height.Visible = false;
                setVisible();
            }
            else if(cb_type.SelectedIndex == 1)
            {
                this.cb_Milling.Visible = false;
                this.dgv_component.Visible = true;
                this.label7.Visible = false;
                this.cb_MaterialID.Visible = false;
                this.label3.Visible = true;
                nud_step.Visible = true;
                cb_place.Visible = true;
                pn_show.Visible = true;
                this.cb_Height.Visible = false;
                setVisible();
            }
            else
            {
                this.cb_Milling.Visible = false;
                this.dgv_component.Visible = true;
                this.cb_MaterialID.Visible = true;
                this.label3.Visible = true;
                this.label7.Visible = true;
                nud_step.Visible = true;
                cb_place.Visible = true;
                pn_show.Visible = true;
                this.cb_Height.Visible = false;
                setVisible();
            }
        }

        //更改台阶数
        private void nud_step_ValueChanged(object sender, EventArgs e)
        {
            step = (int)nud_step.Value;
            int leng = dgv_component.Rows.Count;
            if (step > 0)
            {
                for (int i = leng; i < step + 2; i++)
                {
                    dgv_component.Rows.Add(new string[] { i.ToString(), "0", "0", "0" });
                }
                
            }
        }
        /// <summary>
        /// 设置表格的列是否可见
        /// </summary>
        private void setVisible()
        {
            if (chb_Grading.Checked && !chb_BingRoad.Checked)
            {
                this.height.Visible = true;
                this.width.Visible = true;
                this.slope.Visible = true;
            }
            else if (chb_Grading.Checked && chb_BingRoad.Checked)
            {
                this.height.Visible = false;
                this.width.Visible = true;
                this.slope.Visible = true;
            }
            else if (!chb_Grading.Checked && chb_BingRoad.Checked)
            {
                this.height.Visible = false;
                this.width.Visible = true;
                this.slope.Visible = false;
            }
            else
            {
                this.height.Visible = true;
                this.width.Visible = true;
                this.slope.Visible = false;
            }
        }
        private void chb_BingRoad_CheckStateChanged(object sender, EventArgs e)
        {
            setVisible();
        }

        private void chb_Grading_CheckStateChanged(object sender, EventArgs e)
        {
            setVisible();
        }

        private void cb_Milling_CheckedChanged(object sender, EventArgs e)
        {
            cb_MillingChange();
        }

        private void cb_MillingChange()
        {
            this.cb_Height.Visible = cb_Milling.Checked;
            this.dgv_component.Visible = cb_Milling.Checked;
        }

        private void cb_Height_CheckedChanged(object sender, EventArgs e)
        {
            cb_HeightChange();
        }

        private void cb_HeightChange()
        {
            if (cb_Height.Checked == true)
            {
                this.dgv_component.Visible = true;
                this.height.Visible = true;
                this.width.Visible = false;
                this.slope.Visible = false;
                this.nud_step.Visible = true;
                this.label3.Visible = true;
            }
            else 
            { 
                this.dgv_component.Visible = false;
                this.nud_step.Visible = false;
                this.label3.Visible = false;
            }
        }
        #endregion
        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
