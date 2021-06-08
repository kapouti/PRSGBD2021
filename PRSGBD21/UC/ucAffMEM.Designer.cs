
namespace PRSGBD21.UC
{
    partial class ucAffMEM
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TbMail = new MetroFramework.Controls.MetroTextBox();
            this.bsMEM = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.TbLocalite = new MetroFramework.Controls.MetroTextBox();
            this.TbDteInscr = new MetroFramework.Controls.MetroTextBox();
            this.TbDern_Coti = new MetroFramework.Controls.MetroTextBox();
            this.TbDteNaiss = new MetroFramework.Controls.MetroTextBox();
            this.TbNum_Tel = new MetroFramework.Controls.MetroTextBox();
            this.TbNumGSM = new MetroFramework.Controls.MetroTextBox();
            this.TbNom = new MetroFramework.Controls.MetroTextBox();
            this.TbPrénom = new MetroFramework.Controls.MetroTextBox();
            this.TbSexe = new MetroFramework.Controls.MetroTextBox();
            this.TbRue = new MetroFramework.Controls.MetroTextBox();
            this.TbNom_Resi = new MetroFramework.Controls.MetroTextBox();
            this.TbNum = new MetroFramework.Controls.MetroTextBox();
            this.TbCP = new MetroFramework.Controls.MetroTextBox();
            this.TbId = new MetroFramework.Controls.MetroTextBox();
            this.CbPilote = new MetroFramework.Controls.MetroCheckBox();
            this.CbAdmin = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtModifier = new MetroFramework.Controls.MetroButton();
            this.BtSupprimer = new MetroFramework.Controls.MetroButton();
            this.BtQuit = new MetroFramework.Controls.MetroButton();
            this.BtAjouter = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bsMEM)).BeginInit();
            this.SuspendLayout();
            // 
            // TbMail
            // 
            // 
            // 
            // 
            this.TbMail.CustomButton.Image = null;
            this.TbMail.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.TbMail.CustomButton.Name = "";
            this.TbMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbMail.CustomButton.TabIndex = 1;
            this.TbMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbMail.CustomButton.UseSelectable = true;
            this.TbMail.CustomButton.Visible = false;
            this.TbMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_MAIL", true));
            this.TbMail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbMail.Lines = new string[0];
            this.TbMail.Location = new System.Drawing.Point(153, 381);
            this.TbMail.MaxLength = 32767;
            this.TbMail.Name = "TbMail";
            this.TbMail.PasswordChar = '\0';
            this.TbMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbMail.SelectedText = "";
            this.TbMail.SelectionLength = 0;
            this.TbMail.SelectionStart = 0;
            this.TbMail.ShortcutsEnabled = true;
            this.TbMail.Size = new System.Drawing.Size(247, 23);
            this.TbMail.TabIndex = 66;
            this.TbMail.UseSelectable = true;
            this.TbMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bsMEM
            // 
            this.bsMEM.DataSource = typeof(DTO2.MEM);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(8, 381);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(103, 20);
            this.metroLabel14.TabIndex = 65;
            this.metroLabel14.Text = "Adresse Mail:";
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // TbLocalite
            // 
            // 
            // 
            // 
            this.TbLocalite.CustomButton.Image = null;
            this.TbLocalite.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.TbLocalite.CustomButton.Name = "";
            this.TbLocalite.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbLocalite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbLocalite.CustomButton.TabIndex = 1;
            this.TbLocalite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbLocalite.CustomButton.UseSelectable = true;
            this.TbLocalite.CustomButton.Visible = false;
            this.TbLocalite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_LOC", true));
            this.TbLocalite.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbLocalite.Lines = new string[0];
            this.TbLocalite.Location = new System.Drawing.Point(153, 335);
            this.TbLocalite.MaxLength = 32767;
            this.TbLocalite.Name = "TbLocalite";
            this.TbLocalite.PasswordChar = '\0';
            this.TbLocalite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbLocalite.SelectedText = "";
            this.TbLocalite.SelectionLength = 0;
            this.TbLocalite.SelectionStart = 0;
            this.TbLocalite.ShortcutsEnabled = true;
            this.TbLocalite.Size = new System.Drawing.Size(184, 23);
            this.TbLocalite.TabIndex = 64;
            this.TbLocalite.UseSelectable = true;
            this.TbLocalite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbLocalite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbDteInscr
            // 
            // 
            // 
            // 
            this.TbDteInscr.CustomButton.Image = null;
            this.TbDteInscr.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.TbDteInscr.CustomButton.Name = "";
            this.TbDteInscr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbDteInscr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbDteInscr.CustomButton.TabIndex = 1;
            this.TbDteInscr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbDteInscr.CustomButton.UseSelectable = true;
            this.TbDteInscr.CustomButton.Visible = false;
            this.TbDteInscr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_DTE_INS", true));
            this.TbDteInscr.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbDteInscr.Lines = new string[0];
            this.TbDteInscr.Location = new System.Drawing.Point(583, 13);
            this.TbDteInscr.MaxLength = 32767;
            this.TbDteInscr.Name = "TbDteInscr";
            this.TbDteInscr.PasswordChar = '\0';
            this.TbDteInscr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbDteInscr.SelectedText = "";
            this.TbDteInscr.SelectionLength = 0;
            this.TbDteInscr.SelectionStart = 0;
            this.TbDteInscr.ShortcutsEnabled = true;
            this.TbDteInscr.Size = new System.Drawing.Size(148, 23);
            this.TbDteInscr.TabIndex = 63;
            this.TbDteInscr.UseSelectable = true;
            this.TbDteInscr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbDteInscr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbDern_Coti
            // 
            // 
            // 
            // 
            this.TbDern_Coti.CustomButton.Image = null;
            this.TbDern_Coti.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.TbDern_Coti.CustomButton.Name = "";
            this.TbDern_Coti.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbDern_Coti.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbDern_Coti.CustomButton.TabIndex = 1;
            this.TbDern_Coti.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbDern_Coti.CustomButton.UseSelectable = true;
            this.TbDern_Coti.CustomButton.Visible = false;
            this.TbDern_Coti.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_ANN_DER_COTI", true));
            this.TbDern_Coti.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbDern_Coti.Lines = new string[0];
            this.TbDern_Coti.Location = new System.Drawing.Point(583, 57);
            this.TbDern_Coti.MaxLength = 32767;
            this.TbDern_Coti.Name = "TbDern_Coti";
            this.TbDern_Coti.PasswordChar = '\0';
            this.TbDern_Coti.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbDern_Coti.SelectedText = "";
            this.TbDern_Coti.SelectionLength = 0;
            this.TbDern_Coti.SelectionStart = 0;
            this.TbDern_Coti.ShortcutsEnabled = true;
            this.TbDern_Coti.Size = new System.Drawing.Size(148, 23);
            this.TbDern_Coti.TabIndex = 62;
            this.TbDern_Coti.UseSelectable = true;
            this.TbDern_Coti.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbDern_Coti.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbDteNaiss
            // 
            // 
            // 
            // 
            this.TbDteNaiss.CustomButton.Image = null;
            this.TbDteNaiss.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.TbDteNaiss.CustomButton.Name = "";
            this.TbDteNaiss.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbDteNaiss.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbDteNaiss.CustomButton.TabIndex = 1;
            this.TbDteNaiss.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbDteNaiss.CustomButton.UseSelectable = true;
            this.TbDteNaiss.CustomButton.Visible = false;
            this.TbDteNaiss.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_DTE_NAI", true));
            this.TbDteNaiss.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbDteNaiss.Lines = new string[0];
            this.TbDteNaiss.Location = new System.Drawing.Point(153, 179);
            this.TbDteNaiss.MaxLength = 32767;
            this.TbDteNaiss.Name = "TbDteNaiss";
            this.TbDteNaiss.PasswordChar = '\0';
            this.TbDteNaiss.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbDteNaiss.SelectedText = "";
            this.TbDteNaiss.SelectionLength = 0;
            this.TbDteNaiss.SelectionStart = 0;
            this.TbDteNaiss.ShortcutsEnabled = true;
            this.TbDteNaiss.Size = new System.Drawing.Size(148, 23);
            this.TbDteNaiss.TabIndex = 61;
            this.TbDteNaiss.UseSelectable = true;
            this.TbDteNaiss.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbDteNaiss.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbNum_Tel
            // 
            // 
            // 
            // 
            this.TbNum_Tel.CustomButton.Image = null;
            this.TbNum_Tel.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TbNum_Tel.CustomButton.Name = "";
            this.TbNum_Tel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbNum_Tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbNum_Tel.CustomButton.TabIndex = 1;
            this.TbNum_Tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbNum_Tel.CustomButton.UseSelectable = true;
            this.TbNum_Tel.CustomButton.Visible = false;
            this.TbNum_Tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_NUM_TEL", true));
            this.TbNum_Tel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbNum_Tel.Lines = new string[0];
            this.TbNum_Tel.Location = new System.Drawing.Point(154, 412);
            this.TbNum_Tel.MaxLength = 32767;
            this.TbNum_Tel.Name = "TbNum_Tel";
            this.TbNum_Tel.PasswordChar = '\0';
            this.TbNum_Tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbNum_Tel.SelectedText = "";
            this.TbNum_Tel.SelectionLength = 0;
            this.TbNum_Tel.SelectionStart = 0;
            this.TbNum_Tel.ShortcutsEnabled = true;
            this.TbNum_Tel.Size = new System.Drawing.Size(183, 23);
            this.TbNum_Tel.TabIndex = 60;
            this.TbNum_Tel.UseSelectable = true;
            this.TbNum_Tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbNum_Tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbNumGSM
            // 
            // 
            // 
            // 
            this.TbNumGSM.CustomButton.Image = null;
            this.TbNumGSM.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.TbNumGSM.CustomButton.Name = "";
            this.TbNumGSM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbNumGSM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbNumGSM.CustomButton.TabIndex = 1;
            this.TbNumGSM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbNumGSM.CustomButton.UseSelectable = true;
            this.TbNumGSM.CustomButton.Visible = false;
            this.TbNumGSM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_NUM_GSM", true));
            this.TbNumGSM.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbNumGSM.Lines = new string[0];
            this.TbNumGSM.Location = new System.Drawing.Point(153, 446);
            this.TbNumGSM.MaxLength = 32767;
            this.TbNumGSM.Name = "TbNumGSM";
            this.TbNumGSM.PasswordChar = '\0';
            this.TbNumGSM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbNumGSM.SelectedText = "";
            this.TbNumGSM.SelectionLength = 0;
            this.TbNumGSM.SelectionStart = 0;
            this.TbNumGSM.ShortcutsEnabled = true;
            this.TbNumGSM.Size = new System.Drawing.Size(184, 23);
            this.TbNumGSM.TabIndex = 59;
            this.TbNumGSM.UseSelectable = true;
            this.TbNumGSM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbNumGSM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbNom
            // 
            // 
            // 
            // 
            this.TbNom.CustomButton.Image = null;
            this.TbNom.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.TbNom.CustomButton.Name = "";
            this.TbNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbNom.CustomButton.TabIndex = 1;
            this.TbNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbNom.CustomButton.UseSelectable = true;
            this.TbNom.CustomButton.Visible = false;
            this.TbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_NOM", true));
            this.TbNom.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbNom.Lines = new string[0];
            this.TbNom.Location = new System.Drawing.Point(153, 54);
            this.TbNom.MaxLength = 32767;
            this.TbNom.Name = "TbNom";
            this.TbNom.PasswordChar = '\0';
            this.TbNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbNom.SelectedText = "";
            this.TbNom.SelectionLength = 0;
            this.TbNom.SelectionStart = 0;
            this.TbNom.ShortcutsEnabled = true;
            this.TbNom.Size = new System.Drawing.Size(163, 23);
            this.TbNom.TabIndex = 58;
            this.TbNom.UseSelectable = true;
            this.TbNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbPrénom
            // 
            // 
            // 
            // 
            this.TbPrénom.CustomButton.Image = null;
            this.TbPrénom.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.TbPrénom.CustomButton.Name = "";
            this.TbPrénom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbPrénom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbPrénom.CustomButton.TabIndex = 1;
            this.TbPrénom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbPrénom.CustomButton.UseSelectable = true;
            this.TbPrénom.CustomButton.Visible = false;
            this.TbPrénom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_PRN", true));
            this.TbPrénom.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbPrénom.Lines = new string[0];
            this.TbPrénom.Location = new System.Drawing.Point(153, 92);
            this.TbPrénom.MaxLength = 32767;
            this.TbPrénom.Name = "TbPrénom";
            this.TbPrénom.PasswordChar = '\0';
            this.TbPrénom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbPrénom.SelectedText = "";
            this.TbPrénom.SelectionLength = 0;
            this.TbPrénom.SelectionStart = 0;
            this.TbPrénom.ShortcutsEnabled = true;
            this.TbPrénom.Size = new System.Drawing.Size(163, 23);
            this.TbPrénom.TabIndex = 57;
            this.TbPrénom.UseSelectable = true;
            this.TbPrénom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbPrénom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbSexe
            // 
            // 
            // 
            // 
            this.TbSexe.CustomButton.Image = null;
            this.TbSexe.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.TbSexe.CustomButton.Name = "";
            this.TbSexe.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbSexe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbSexe.CustomButton.TabIndex = 1;
            this.TbSexe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbSexe.CustomButton.UseSelectable = true;
            this.TbSexe.CustomButton.Visible = false;
            this.TbSexe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_SEX", true));
            this.TbSexe.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbSexe.Lines = new string[0];
            this.TbSexe.Location = new System.Drawing.Point(153, 133);
            this.TbSexe.MaxLength = 32767;
            this.TbSexe.Name = "TbSexe";
            this.TbSexe.PasswordChar = '\0';
            this.TbSexe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbSexe.SelectedText = "";
            this.TbSexe.SelectionLength = 0;
            this.TbSexe.SelectionStart = 0;
            this.TbSexe.ShortcutsEnabled = true;
            this.TbSexe.Size = new System.Drawing.Size(45, 23);
            this.TbSexe.TabIndex = 56;
            this.TbSexe.UseSelectable = true;
            this.TbSexe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbSexe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbRue
            // 
            // 
            // 
            // 
            this.TbRue.CustomButton.Image = null;
            this.TbRue.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TbRue.CustomButton.Name = "";
            this.TbRue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbRue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbRue.CustomButton.TabIndex = 1;
            this.TbRue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbRue.CustomButton.UseSelectable = true;
            this.TbRue.CustomButton.Visible = false;
            this.TbRue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_RUE", true));
            this.TbRue.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbRue.Lines = new string[0];
            this.TbRue.Location = new System.Drawing.Point(154, 219);
            this.TbRue.MaxLength = 32767;
            this.TbRue.Name = "TbRue";
            this.TbRue.PasswordChar = '\0';
            this.TbRue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbRue.SelectedText = "";
            this.TbRue.SelectionLength = 0;
            this.TbRue.SelectionStart = 0;
            this.TbRue.ShortcutsEnabled = true;
            this.TbRue.Size = new System.Drawing.Size(183, 23);
            this.TbRue.TabIndex = 55;
            this.TbRue.UseSelectable = true;
            this.TbRue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbRue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbNom_Resi
            // 
            // 
            // 
            // 
            this.TbNom_Resi.CustomButton.Image = null;
            this.TbNom_Resi.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.TbNom_Resi.CustomButton.Name = "";
            this.TbNom_Resi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbNom_Resi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbNom_Resi.CustomButton.TabIndex = 1;
            this.TbNom_Resi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbNom_Resi.CustomButton.UseSelectable = true;
            this.TbNom_Resi.CustomButton.Visible = false;
            this.TbNom_Resi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_NOM_RESI", true));
            this.TbNom_Resi.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbNom_Resi.Lines = new string[0];
            this.TbNom_Resi.Location = new System.Drawing.Point(154, 247);
            this.TbNom_Resi.MaxLength = 32767;
            this.TbNom_Resi.Name = "TbNom_Resi";
            this.TbNom_Resi.PasswordChar = '\0';
            this.TbNom_Resi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbNom_Resi.SelectedText = "";
            this.TbNom_Resi.SelectionLength = 0;
            this.TbNom_Resi.SelectionStart = 0;
            this.TbNom_Resi.ShortcutsEnabled = true;
            this.TbNom_Resi.Size = new System.Drawing.Size(246, 23);
            this.TbNom_Resi.TabIndex = 54;
            this.TbNom_Resi.UseSelectable = true;
            this.TbNom_Resi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbNom_Resi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbNum
            // 
            // 
            // 
            // 
            this.TbNum.CustomButton.Image = null;
            this.TbNum.CustomButton.Location = new System.Drawing.Point(22, 1);
            this.TbNum.CustomButton.Name = "";
            this.TbNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbNum.CustomButton.TabIndex = 1;
            this.TbNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbNum.CustomButton.UseSelectable = true;
            this.TbNum.CustomButton.Visible = false;
            this.TbNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_NUM", true));
            this.TbNum.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbNum.Lines = new string[0];
            this.TbNum.Location = new System.Drawing.Point(154, 276);
            this.TbNum.MaxLength = 32767;
            this.TbNum.Name = "TbNum";
            this.TbNum.PasswordChar = '\0';
            this.TbNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbNum.SelectedText = "";
            this.TbNum.SelectionLength = 0;
            this.TbNum.SelectionStart = 0;
            this.TbNum.ShortcutsEnabled = true;
            this.TbNum.Size = new System.Drawing.Size(44, 23);
            this.TbNum.TabIndex = 53;
            this.TbNum.UseSelectable = true;
            this.TbNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbCP
            // 
            // 
            // 
            // 
            this.TbCP.CustomButton.Image = null;
            this.TbCP.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.TbCP.CustomButton.Name = "";
            this.TbCP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbCP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbCP.CustomButton.TabIndex = 1;
            this.TbCP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbCP.CustomButton.UseSelectable = true;
            this.TbCP.CustomButton.Visible = false;
            this.TbCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_CP", true));
            this.TbCP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbCP.Lines = new string[0];
            this.TbCP.Location = new System.Drawing.Point(154, 305);
            this.TbCP.MaxLength = 32767;
            this.TbCP.Name = "TbCP";
            this.TbCP.PasswordChar = '\0';
            this.TbCP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbCP.SelectedText = "";
            this.TbCP.SelectionLength = 0;
            this.TbCP.SelectionStart = 0;
            this.TbCP.ShortcutsEnabled = true;
            this.TbCP.Size = new System.Drawing.Size(183, 23);
            this.TbCP.TabIndex = 52;
            this.TbCP.UseSelectable = true;
            this.TbCP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbCP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TbId
            // 
            // 
            // 
            // 
            this.TbId.CustomButton.Image = null;
            this.TbId.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.TbId.CustomButton.Name = "";
            this.TbId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbId.CustomButton.TabIndex = 1;
            this.TbId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbId.CustomButton.UseSelectable = true;
            this.TbId.CustomButton.Visible = false;
            this.TbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMEM, "MBR_ID", true));
            this.TbId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TbId.Lines = new string[0];
            this.TbId.Location = new System.Drawing.Point(153, 13);
            this.TbId.MaxLength = 32767;
            this.TbId.Name = "TbId";
            this.TbId.PasswordChar = '\0';
            this.TbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbId.SelectedText = "";
            this.TbId.SelectionLength = 0;
            this.TbId.SelectionStart = 0;
            this.TbId.ShortcutsEnabled = true;
            this.TbId.Size = new System.Drawing.Size(45, 23);
            this.TbId.TabIndex = 51;
            this.TbId.UseSelectable = true;
            this.TbId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CbPilote
            // 
            this.CbPilote.AutoSize = true;
            this.CbPilote.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMEM, "MBR_EST_PILOTE", true));
            this.CbPilote.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.CbPilote.Location = new System.Drawing.Point(583, 133);
            this.CbPilote.Name = "CbPilote";
            this.CbPilote.Size = new System.Drawing.Size(48, 20);
            this.CbPilote.TabIndex = 50;
            this.CbPilote.Text = "Oui";
            this.CbPilote.UseSelectable = true;
            // 
            // CbAdmin
            // 
            this.CbAdmin.AutoSize = true;
            this.CbAdmin.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsMEM, "MBR_EST_ADMIN", true));
            this.CbAdmin.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.CbAdmin.Location = new System.Drawing.Point(583, 92);
            this.CbAdmin.Name = "CbAdmin";
            this.CbAdmin.Size = new System.Drawing.Size(48, 20);
            this.CbAdmin.TabIndex = 49;
            this.CbAdmin.Text = "Oui";
            this.CbAdmin.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(358, 133);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(104, 20);
            this.metroLabel13.TabIndex = 48;
            this.metroLabel13.Text = "Est un pilote :";
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(8, 415);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(143, 20);
            this.metroLabel12.TabIndex = 47;
            this.metroLabel12.Text = "Num de téléphone:";
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(8, 449);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(110, 20);
            this.metroLabel11.TabIndex = 46;
            this.metroLabel11.Text = "Num de GSM :";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(354, 16);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(141, 20);
            this.metroLabel10.TabIndex = 45;
            this.metroLabel10.Text = "Date d\'inscription :";
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(354, 54);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(185, 20);
            this.metroLabel9.TabIndex = 44;
            this.metroLabel9.Text = "Date dernière cotisation :";
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(354, 95);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(108, 20);
            this.metroLabel8.TabIndex = 43;
            this.metroLabel8.Text = "Est un admin :";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(8, 57);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 20);
            this.metroLabel6.TabIndex = 42;
            this.metroLabel6.Text = "Nom: ";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(8, 95);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 20);
            this.metroLabel5.TabIndex = 41;
            this.metroLabel5.Text = "Prénom :";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(8, 133);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 20);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Sexe :";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(6, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(142, 20);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Date de naissance :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(8, 222);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 20);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Adresse :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(8, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 20);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Id:";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // BtModifier
            // 
            this.BtModifier.Location = new System.Drawing.Point(397, 487);
            this.BtModifier.Name = "BtModifier";
            this.BtModifier.Size = new System.Drawing.Size(118, 39);
            this.BtModifier.TabIndex = 69;
            this.BtModifier.Text = "Modifier";
            this.BtModifier.UseSelectable = true;
            // 
            // BtSupprimer
            // 
            this.BtSupprimer.Location = new System.Drawing.Point(521, 487);
            this.BtSupprimer.Name = "BtSupprimer";
            this.BtSupprimer.Size = new System.Drawing.Size(118, 39);
            this.BtSupprimer.TabIndex = 67;
            this.BtSupprimer.Text = "Supprimer";
            this.BtSupprimer.UseSelectable = true;
            // 
            // BtQuit
            // 
            this.BtQuit.Location = new System.Drawing.Point(645, 487);
            this.BtQuit.Name = "BtQuit";
            this.BtQuit.Size = new System.Drawing.Size(118, 39);
            this.BtQuit.TabIndex = 68;
            this.BtQuit.Text = "Quitter";
            this.BtQuit.UseSelectable = true;
            // 
            // BtAjouter
            // 
            this.BtAjouter.Location = new System.Drawing.Point(8, 485);
            this.BtAjouter.Name = "BtAjouter";
            this.BtAjouter.Size = new System.Drawing.Size(118, 41);
            this.BtAjouter.TabIndex = 70;
            this.BtAjouter.Text = "Ajouter";
            this.BtAjouter.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(411, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 281);
            this.panel1.TabIndex = 71;
            // 
            // ucAffMEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtModifier);
            this.Controls.Add(this.BtSupprimer);
            this.Controls.Add(this.BtQuit);
            this.Controls.Add(this.BtAjouter);
            this.Controls.Add(this.TbMail);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.TbLocalite);
            this.Controls.Add(this.TbDteInscr);
            this.Controls.Add(this.TbDern_Coti);
            this.Controls.Add(this.TbDteNaiss);
            this.Controls.Add(this.TbNum_Tel);
            this.Controls.Add(this.TbNumGSM);
            this.Controls.Add(this.TbNom);
            this.Controls.Add(this.TbPrénom);
            this.Controls.Add(this.TbSexe);
            this.Controls.Add(this.TbRue);
            this.Controls.Add(this.TbNom_Resi);
            this.Controls.Add(this.TbNum);
            this.Controls.Add(this.TbCP);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.CbPilote);
            this.Controls.Add(this.CbAdmin);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ucAffMEM";
            this.Size = new System.Drawing.Size(773, 546);
            this.Load += new System.EventHandler(this.ucAffMEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TbMail;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox TbLocalite;
        private MetroFramework.Controls.MetroTextBox TbDteInscr;
        private MetroFramework.Controls.MetroTextBox TbDern_Coti;
        private MetroFramework.Controls.MetroTextBox TbDteNaiss;
        private MetroFramework.Controls.MetroTextBox TbNum_Tel;
        private MetroFramework.Controls.MetroTextBox TbNumGSM;
        private MetroFramework.Controls.MetroTextBox TbNom;
        private MetroFramework.Controls.MetroTextBox TbPrénom;
        private MetroFramework.Controls.MetroTextBox TbSexe;
        private MetroFramework.Controls.MetroTextBox TbRue;
        private MetroFramework.Controls.MetroTextBox TbNom_Resi;
        private MetroFramework.Controls.MetroTextBox TbNum;
        private MetroFramework.Controls.MetroTextBox TbCP;
        private MetroFramework.Controls.MetroTextBox TbId;
        private MetroFramework.Controls.MetroCheckBox CbPilote;
        private MetroFramework.Controls.MetroCheckBox CbAdmin;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtModifier;
        private MetroFramework.Controls.MetroButton BtSupprimer;
        private MetroFramework.Controls.MetroButton BtQuit;
        private MetroFramework.Controls.MetroButton BtAjouter;
        private System.Windows.Forms.BindingSource bsMEM;
        private System.Windows.Forms.Panel panel1;
    }
}
