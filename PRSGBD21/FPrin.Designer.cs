
namespace PRSGBD21
{
    partial class FPrin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrin));
            this.ButMEM = new MetroFramework.Controls.MetroButton();
            this.ButAER = new MetroFramework.Controls.MetroButton();
            this.ButRES = new MetroFramework.Controls.MetroButton();
            this.ButHome = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.PanPrin = new MetroFramework.Controls.MetroPanel();
            this.ucAffMEM1 = new PRSGBD21.UC.ucAffMEM();
            this.ucRechercherMEM1 = new PRSGBD21.UC.ucRechercherMEM();
            this.metroPanel1.SuspendLayout();
            this.PanPrin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButMEM
            // 
            this.ButMEM.Location = new System.Drawing.Point(3, 186);
            this.ButMEM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButMEM.Name = "ButMEM";
            this.ButMEM.Size = new System.Drawing.Size(117, 76);
            this.ButMEM.TabIndex = 0;
            this.ButMEM.Text = "Membre";
            this.ButMEM.UseSelectable = true;
            this.ButMEM.Click += new System.EventHandler(this.ButMEM_Click);
            // 
            // ButAER
            // 
            this.ButAER.Location = new System.Drawing.Point(3, 279);
            this.ButAER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButAER.Name = "ButAER";
            this.ButAER.Size = new System.Drawing.Size(117, 76);
            this.ButAER.TabIndex = 1;
            this.ButAER.Text = "Aéronef";
            this.ButAER.UseSelectable = true;
            // 
            // ButRES
            // 
            this.ButRES.Location = new System.Drawing.Point(3, 374);
            this.ButRES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButRES.Name = "ButRES";
            this.ButRES.Size = new System.Drawing.Size(117, 76);
            this.ButRES.TabIndex = 2;
            this.ButRES.Text = "Réservation";
            this.ButRES.UseSelectable = true;
            // 
            // ButHome
            // 
            this.ButHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButHome.BackgroundImage")));
            this.ButHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButHome.Location = new System.Drawing.Point(3, 2);
            this.ButHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButHome.Name = "ButHome";
            this.ButHome.Size = new System.Drawing.Size(143, 162);
            this.ButHome.TabIndex = 3;
            this.ButHome.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.metroPanel1.Controls.Add(this.ButRES);
            this.metroPanel1.Controls.Add(this.ButHome);
            this.metroPanel1.Controls.Add(this.ButAER);
            this.metroPanel1.Controls.Add(this.ButMEM);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 12);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(149, 467);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // PanPrin
            // 
            this.PanPrin.BackColor = System.Drawing.Color.LightSlateGray;
            this.PanPrin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanPrin.BackgroundImage")));
            this.PanPrin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanPrin.Controls.Add(this.ucRechercherMEM1);
            this.PanPrin.Controls.Add(this.ucAffMEM1);
            this.PanPrin.HorizontalScrollbarBarColor = true;
            this.PanPrin.HorizontalScrollbarHighlightOnWheel = false;
            this.PanPrin.HorizontalScrollbarSize = 10;
            this.PanPrin.Location = new System.Drawing.Point(167, 14);
            this.PanPrin.Name = "PanPrin";
            this.PanPrin.Size = new System.Drawing.Size(1194, 642);
            this.PanPrin.TabIndex = 5;
            this.PanPrin.UseCustomBackColor = true;
            this.PanPrin.UseCustomForeColor = true;
            this.PanPrin.UseStyleColors = true;
            this.PanPrin.VerticalScrollbarBarColor = true;
            this.PanPrin.VerticalScrollbarHighlightOnWheel = false;
            this.PanPrin.VerticalScrollbarSize = 10;
            this.PanPrin.Paint += new System.Windows.Forms.PaintEventHandler(this.PanPrin_Paint_1);
            // 
            // ucAffMEM1
            // 
            this.ucAffMEM1.BackColor = System.Drawing.Color.LightSlateGray;
            this.ucAffMEM1.Location = new System.Drawing.Point(273, 37);
            this.ucAffMEM1.Name = "ucAffMEM1";
            this.ucAffMEM1.Size = new System.Drawing.Size(871, 546);
            this.ucAffMEM1.TabIndex = 6;
            this.ucAffMEM1.Visible = false;
            // 
            // ucRechercherMEM1
            // 
            this.ucRechercherMEM1.BackColor = System.Drawing.Color.LightSlateGray;
            this.ucRechercherMEM1.Location = new System.Drawing.Point(3, 37);
            this.ucRechercherMEM1.Name = "ucRechercherMEM1";
            this.ucRechercherMEM1.Size = new System.Drawing.Size(276, 466);
            this.ucRechercherMEM1.TabIndex = 5;
            this.ucRechercherMEM1.Visible = false;
            this.ucRechercherMEM1.SelectMEM += new PRSGBD21.delSelect(this.ucRechercherMEM1_SelectMEM_1);
            // 
            // FPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1373, 665);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.PanPrin);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FPrin";
            this.Text = "FPrin";
            this.metroPanel1.ResumeLayout(false);
            this.PanPrin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton ButMEM;
        private MetroFramework.Controls.MetroButton ButAER;
        private MetroFramework.Controls.MetroButton ButRES;
        private MetroFramework.Controls.MetroButton ButHome;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel PanPrin;
        private UC.ucRechercherMEM ucRechercherMEM1;
        private UC.ucAffMEM ucAffMEM1;
    }
}