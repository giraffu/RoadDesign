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
    public partial class Frm_CreateSec : Form
    {
        public Frm_CreateSec()
        {
            InitializeComponent();
            init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_DecisionPts frm = new Frm_DecisionPts(selectRule);
            frm.Owner = this;
            frm.ShowDialog();
        }
        int selectRule = 1;
        void init()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            //添加行
            string[] row0 = { "1", "台阶1", "台阶", "-1", "加铺区域1" };
            string[] row1 = { "2", "H1R", "台阶", "-20", "加铺区域1" };
            string[] row2 = { "3", "H2L", "边部构造", "-1", "加铺区域1" };
            string[] row3 = { "4", "H2R", "中央分隔带", "-20", "加铺区域1" };

            dgv_compCombine.Rows.Add(row0);
            dgv_compCombine.Rows.Add(row1);
            dgv_compCombine.Rows.Add(row2);
            dgv_compCombine.Rows.Add(row3);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectRule = comboBox2.SelectedIndex;
            btn_decisionSet.Visible = selectRule != 3;
        }

        private void cb_bool_allowMirror_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
