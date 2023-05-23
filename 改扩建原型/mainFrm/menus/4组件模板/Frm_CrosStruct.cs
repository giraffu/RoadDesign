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
        private void initTemp()
        {
            cb_MaterialID.SelectedIndex = 0;
            cb_place.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_type.SelectedIndex)
            {
                case 0:

                    break;

                default:
                    break;
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

        private void setVisible()
        {
            if (chb_Grading.Checked && !chb_BingRoad.Checked)
            {
                this.参数名称.Visible = true;
                this.Column1.Visible = true;
                this.Column2.Visible = true;
            }
            else if (chb_Grading.Checked && chb_BingRoad.Checked)
            {
                this.参数名称.Visible = false;
                this.Column1.Visible = true;
                this.Column2.Visible = true;
            }
            else if (!chb_Grading.Checked && chb_BingRoad.Checked)
            {
                this.参数名称.Visible = true;
                this.Column1.Visible = true;
                this.Column2.Visible = false;
            }
            else
            {
                this.参数名称.Visible = false;
                this.Column1.Visible = true;
                this.Column2.Visible = true;
            }
        }

        #endregion

        private void chb_BingRoad_CheckStateChanged(object sender, EventArgs e)
        {
            setVisible();
        }

        private void chb_Grading_CheckStateChanged(object sender, EventArgs e)
        {
            setVisible();
        }
    }
}
