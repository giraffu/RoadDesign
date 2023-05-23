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
    public partial class Frm_CrossSecModels : Form
    {
        public Frm_CrossSecModels()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Frm_CreateSec frm = new Frm_CreateSec();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
