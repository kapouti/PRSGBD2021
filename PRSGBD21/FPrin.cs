using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRSGBD21
{
    public partial class FPrin : Form
    {
        private int MEM_ID_Courant;
        public FPrin()
        {
            InitializeComponent();
        }

        private void ButMEM_Click(object sender, EventArgs e)
        {
            ucAffMEM1.Visible = true;
            ucRechercherMEM1.Visible = true;
        }

        private void ucRechercherMEM1_Load(object sender, EventArgs e)
        {

        }

        

        private void PanPrin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucAffMEM1_Load(object sender, EventArgs e)
        {

        }

        private void ucRechercherMEM1_SelectMEM_1(int MEM_ID)
        {

            this.MEM_ID_Courant = MEM_ID;

            this.ucAffMEM1.RefreshData(MEM_ID);
        }

        private void PanPrin_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
