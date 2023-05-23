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
    public partial class Frm_NewProject : Form
    {
        public Frm_NewProject()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void btn_projectInfo_Click(object sender, EventArgs e)
        {
            Frm_ProjectInfo _Frm_ProjectInfo = new Frm_ProjectInfo();
            _Frm_ProjectInfo.ShowDialog();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
