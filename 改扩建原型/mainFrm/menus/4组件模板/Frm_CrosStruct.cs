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
        public Frm_CrosStruct()
        {
            InitializeComponent();
            bindTree();
            initTemp();
        }

        #region 横向构件列表树

        private void bindTree()
        {
            tv_componentMng.Nodes.Clear();
            //1.初始化根节点
            TreeNode medianNode = new TreeNode("中央分隔带");
            TreeNode stepsNode = new TreeNode("台阶");
            TreeNode edgeNode = new TreeNode("路面边部构造");
            TreeNode millingNode = new TreeNode("铣刨线");

            //2.查询现有的横截面模板

            //3.筛选

            //4.绑定树
            tv_componentMng.Nodes.Add(bindNode(medianNode, new string[] { "中分带1", "中分带2" }));
            tv_componentMng.Nodes.Add(bindNode(stepsNode, new string[] { "台阶1", "台阶2", "台阶3-绑定路面结构" }));
            tv_componentMng.Nodes.Add(bindNode(edgeNode, new string[] { "边部构造1", "边部构造2-绑定路面结构", "边部构造3" }));
            tv_componentMng.Nodes.Add(bindNode(millingNode, new string[] { "铣刨线1", "铣刨线2" }));

            tv_componentMng.ExpandAll();

        }

        private TreeNode bindNode(TreeNode _node, string[] _names)
        {
            foreach (string item in _names)
            {
                _node.Nodes.Add(item);
            }
            return _node;
        }
        #endregion

        #region 构件信息
        private void initTemp()
        {
            cb_MaterialID.SelectedIndex = 0;
            cb_place.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;

            //添加行
            string[] row0 = {"W1", "20" };
            string[] row1 = {"H1", "8" };
            string[] row2 = {"W2", "20" };
            string[] row3 = {"H2", "15" };

            dgv_component.Rows.Add(row0);
            dgv_component.Rows.Add(row1);
            dgv_component.Rows.Add(row2);
            dgv_component.Rows.Add(row3);


        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
