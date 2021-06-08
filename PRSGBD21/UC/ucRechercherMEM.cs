using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO2;
using DAL;
using BL1;

namespace PRSGBD21.UC
{
    public partial class ucRechercherMEM : UserControl
    {
        public event delSelect SelectMEM;
        public ucRechercherMEM()
        {
            InitializeComponent();
        }
        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.RefreshData();
                this.NotifierSélection();
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            this.NotifierSélection();
           
        }
        public void RefreshData()
        {

           //List<DTO2.MEM> liste = DAL.AccesMEM.SelectMEMByDebNom(this.textBox1.Text);
           // if (liste.Count > 0)
           // {
           //     this.listBox1.DataSource = DAL.AccesMEM.SelectMEMByDebNom(this.textBox1.Text);
           //     this.listBox1.Focus();
           // }
           // else
           //     this.listBox1.DataSource = null;
        }

        private void tbDebETU_NOM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.RefreshData();
                this.NotifierSélection();
            }
        }
       
        private void NotifierSélection()
        {
            if (this.listBox1.DataSource != null && this.SelectMEM != null)
                this.SelectMEM(((MEM)this.listBox1.SelectedItem).MBR_ID);
        }

        private void ucRechercherMEM_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
