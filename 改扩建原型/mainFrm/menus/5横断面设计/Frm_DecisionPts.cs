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
    public partial class Frm_DecisionPts : Form
    {
        public Frm_DecisionPts()
        {
            InitializeComponent();
        }
        public Frm_DecisionPts(int i)
        {
            InitializeComponent();
            //setRule(i);
            initDeciSet();
        }
        void setRule(int i)
        {
            ////隐藏选项卡
            //this.dgv_ruleControl.Region = new Region(new RectangleF(this.tabPage1.Left, this.tabPage1.Top, this.tabPage1.Width, this.tabPage1.Height));
            //switch (i)
            //{
            //    default:
            //        dgv_ruleControl.SelectTab(0);
           
            //        break;
            //    case 1:
            //        dgv_ruleControl.SelectTab(1);
            //        break;
            //    case 2:
            //        dgv_ruleControl.SelectTab(2);
            //        break;
            //}
        }
        private void initDeciSet()
        {
            DataTable dtReturn1 = new DataTable();
            //dtReturn1.Columns.Add("判定点");
            //dtReturn1.Columns.Add("横向参照");
            //dtReturn1.Columns.Add("横移距离(m)");
            //dtReturn1.Columns.Add("所属区域");

            //添加行
            string[] row0 = { "1" ,"H1L", "新路设计线", "-1", "加铺区域1"};
            string[] row1 = { "2", "H1R", "新路设计线", "-20", "加铺区域1" };
            string[] row2 = { "3", "H2L", "新路设计线", "-1", "加铺区域1" };
            string[] row3 = { "4", "H2R", "新路设计线", "-20", "加铺区域1" };
            string[] row5 = { "5", "h1L", "老路设计线", "1", "加铺区域2" };
            string[] row6 = { "6", "h1R", "老路设计线", "1", "加铺区域2" };
            string[] row7 = { "7", "h2L", "老路设计线", "10", "加铺区域2" };
            string[] row4 = { "8", "h2R", "老路设计线", "10", "加铺区域2" };
            dgv_deciset.Rows.Add(row0);
            dgv_deciset.Rows.Add(row1);
            dgv_deciset.Rows.Add(row2);
            dgv_deciset.Rows.Add(row3);
            dgv_deciset.Rows.Add(row4);
            dgv_deciset.Rows.Add(row5);
            dgv_deciset.Rows.Add(row6);
            dgv_deciset.Rows.Add(row7);

            string[] row01 = { "1", "加铺区域1", "优先取大值" };
            string[] row02 = { "2", "加铺区域2", "优先取大值" };
            dgv_decirule.Rows.Add(row01);
            dgv_decirule.Rows.Add(row02);
        }
    }
}
