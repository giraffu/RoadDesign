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
    public partial class Frm_ModifySection : Form
    {
        public Frm_ModifySection()
        {
            InitializeComponent();
        }
        void initgird()
        {
            dgv_sectionInfo.RowHeadersVisible = false;

        }
    }
}
