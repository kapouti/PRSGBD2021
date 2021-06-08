using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRSGBD21.UC
{
    public partial class ucAffMEM : UserControl
    {
        public ucAffMEM()
        {
            InitializeComponent();
        }
        public void RefreshData(int MEM_ID)
        {
            this.bsMEM.DataSource = BL1.ServicesMEM.REchMEM(MEM_ID);
        }

        public void ClearData()
        {
            this.bsMEM.Clear();
        }

        private void ucAffMEM_Load(object sender, EventArgs e)
        {

        }

        private void BtQuit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
