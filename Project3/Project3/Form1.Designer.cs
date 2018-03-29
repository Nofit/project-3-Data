namespace Project3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Jaarbalk = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.provinceLable = new System.Windows.Forms.Label();
            this.crimeCatLabel = new System.Windows.Forms.Label();
            this.provinceBox = new System.Windows.Forms.CheckedListBox();
            this.crimeCategoryBox = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bxZH = new System.Windows.Forms.TextBox();
            this.bxNH = new System.Windows.Forms.TextBox();
            this.bxUtrecht = new System.Windows.Forms.TextBox();
            this.bxFlevoland = new System.Windows.Forms.TextBox();
            this.bxFriesland = new System.Windows.Forms.TextBox();
            this.bxGroningen = new System.Windows.Forms.TextBox();
            this.bxDrenthe = new System.Windows.Forms.TextBox();
            this.bxOverijssel = new System.Windows.Forms.TextBox();
            this.bxGelderland = new System.Windows.Forms.TextBox();
            this.bxNB = new System.Windows.Forms.TextBox();
            this.bxLimburg = new System.Windows.Forms.TextBox();
            this.bxZeeland = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chosenMisdaadbx = new System.Windows.Forms.TextBox();
            this.chosenYearbx = new System.Windows.Forms.TextBox();
            this.secretlableshh = new System.Windows.Forms.Label();
            this.pictureBoxArray1 = new Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(this.components);
            this.chosenCompareYearbx = new System.Windows.Forms.TextBox();
            this.compareLbl = new System.Windows.Forms.Label();
            this.VergelijkJaarbalk = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.label2010 = new System.Windows.Forms.Label();
            this.label2011 = new System.Windows.Forms.Label();
            this.label2012 = new System.Windows.Forms.Label();
            this.label2014 = new System.Windows.Forms.Label();
            this.label2016 = new System.Windows.Forms.Label();
            this.label2013 = new System.Windows.Forms.Label();
            this.label2015 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Jaarbalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VergelijkJaarbalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Jaarbalk
            // 
            this.Jaarbalk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Jaarbalk.LargeChange = 1;
            this.Jaarbalk.Location = new System.Drawing.Point(227, 816);
            this.Jaarbalk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Jaarbalk.Maximum = 6;
            this.Jaarbalk.Name = "Jaarbalk";
            this.Jaarbalk.Size = new System.Drawing.Size(657, 56);
            this.Jaarbalk.TabIndex = 1;
            this.Jaarbalk.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(221, 855);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "2010";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(325, 855);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "2011";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(427, 855);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "2012";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(636, 855);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "2014";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PaleGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(843, 855);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "2016";
            // 
            // provinceLable
            // 
            this.provinceLable.AutoSize = true;
            this.provinceLable.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceLable.ForeColor = System.Drawing.Color.White;
            this.provinceLable.Location = new System.Drawing.Point(771, 206);
            this.provinceLable.Name = "provinceLable";
            this.provinceLable.Size = new System.Drawing.Size(113, 28);
            this.provinceLable.TabIndex = 30;
            this.provinceLable.Text = "Provincies:";
            this.provinceLable.Click += new System.EventHandler(this.label12_Click);
            // 
            // crimeCatLabel
            // 
            this.crimeCatLabel.AutoSize = true;
            this.crimeCatLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimeCatLabel.ForeColor = System.Drawing.Color.White;
            this.crimeCatLabel.Location = new System.Drawing.Point(771, 535);
            this.crimeCatLabel.Name = "crimeCatLabel";
            this.crimeCatLabel.Size = new System.Drawing.Size(146, 28);
            this.crimeCatLabel.TabIndex = 31;
            this.crimeCatLabel.Text = "Soort misdrijf:";
            this.crimeCatLabel.Visible = false;
            this.crimeCatLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // provinceBox
            // 
            this.provinceBox.BackColor = System.Drawing.SystemColors.Control;
            this.provinceBox.CheckOnClick = true;
            this.provinceBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceBox.ForeColor = System.Drawing.Color.Indigo;
            this.provinceBox.FormattingEnabled = true;
            this.provinceBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.provinceBox.IntegralHeight = false;
            this.provinceBox.Items.AddRange(new object[] {
            "Drenthe",
            "Flevoland",
            "Friesland",
            "Gelderland",
            "Groningen",
            "Limburg",
            "Noord-Brabant",
            "Noord-Holland",
            "Overijssel",
            "Utrecht",
            "Zeeland",
            "Zuid-Holland"});
            this.provinceBox.Location = new System.Drawing.Point(776, 236);
            this.provinceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(306, 288);
            this.provinceBox.TabIndex = 35;
            this.provinceBox.ThreeDCheckBoxes = true;
            this.provinceBox.UseCompatibleTextRendering = true;
            this.provinceBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // crimeCategoryBox
            // 
            this.crimeCategoryBox.BackColor = System.Drawing.SystemColors.Control;
            this.crimeCategoryBox.CheckOnClick = true;
            this.crimeCategoryBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimeCategoryBox.ForeColor = System.Drawing.Color.Indigo;
            this.crimeCategoryBox.FormattingEnabled = true;
            this.crimeCategoryBox.HorizontalExtent = 100;
            this.crimeCategoryBox.IntegralHeight = false;
            this.crimeCategoryBox.Items.AddRange(new object[] {
            "Totale misdrijven",
            "Vermogensmisdrijven\t",
            "Vernielingen",
            "Gewelds- en seksuele misdrijven",
            "Misdrijven WvSr (overig)",
            "Verkeersmisdrijven",
            "Drugsmisdrijven",
            "(Vuur)wapenmisdrijven",
            "Misdrijven overige wetten"});
            this.crimeCategoryBox.Location = new System.Drawing.Point(776, 566);
            this.crimeCategoryBox.Margin = new System.Windows.Forms.Padding(4, 3, 2, 2);
            this.crimeCategoryBox.Name = "crimeCategoryBox";
            this.crimeCategoryBox.Size = new System.Drawing.Size(306, 218);
            this.crimeCategoryBox.TabIndex = 36;
            this.crimeCategoryBox.ThreeDCheckBoxes = true;
            this.crimeCategoryBox.UseCompatibleTextRendering = true;
            this.crimeCategoryBox.Visible = false;
            this.crimeCategoryBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.PaleGreen;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SeaGreen;
            this.label13.Location = new System.Drawing.Point(531, 855);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "2013";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.PaleGreen;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SeaGreen;
            this.label14.Location = new System.Drawing.Point(739, 855);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 60;
            this.label14.Text = "2015";
            // 
            // bxZH
            // 
            this.bxZH.BackColor = System.Drawing.SystemColors.Control;
            this.bxZH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxZH.Location = new System.Drawing.Point(265, 487);
            this.bxZH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxZH.Name = "bxZH";
            this.bxZH.ReadOnly = true;
            this.bxZH.Size = new System.Drawing.Size(107, 28);
            this.bxZH.TabIndex = 65;
            this.bxZH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxZH.Visible = false;
            // 
            // bxNH
            // 
            this.bxNH.BackColor = System.Drawing.SystemColors.Control;
            this.bxNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxNH.Location = new System.Drawing.Point(328, 313);
            this.bxNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxNH.Name = "bxNH";
            this.bxNH.ReadOnly = true;
            this.bxNH.Size = new System.Drawing.Size(107, 28);
            this.bxNH.TabIndex = 66;
            this.bxNH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxNH.Visible = false;
            // 
            // bxUtrecht
            // 
            this.bxUtrecht.BackColor = System.Drawing.SystemColors.Control;
            this.bxUtrecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxUtrecht.Location = new System.Drawing.Point(379, 440);
            this.bxUtrecht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxUtrecht.Name = "bxUtrecht";
            this.bxUtrecht.ReadOnly = true;
            this.bxUtrecht.Size = new System.Drawing.Size(107, 28);
            this.bxUtrecht.TabIndex = 67;
            this.bxUtrecht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxUtrecht.Visible = false;
            // 
            // bxFlevoland
            // 
            this.bxFlevoland.BackColor = System.Drawing.SystemColors.Control;
            this.bxFlevoland.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxFlevoland.Location = new System.Drawing.Point(426, 355);
            this.bxFlevoland.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxFlevoland.Name = "bxFlevoland";
            this.bxFlevoland.ReadOnly = true;
            this.bxFlevoland.Size = new System.Drawing.Size(107, 28);
            this.bxFlevoland.TabIndex = 68;
            this.bxFlevoland.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxFlevoland.Visible = false;
            this.bxFlevoland.TextChanged += new System.EventHandler(this.bxFlevoland_TextChanged);
            // 
            // bxFriesland
            // 
            this.bxFriesland.BackColor = System.Drawing.SystemColors.Control;
            this.bxFriesland.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxFriesland.Location = new System.Drawing.Point(448, 195);
            this.bxFriesland.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxFriesland.Name = "bxFriesland";
            this.bxFriesland.ReadOnly = true;
            this.bxFriesland.Size = new System.Drawing.Size(107, 28);
            this.bxFriesland.TabIndex = 69;
            this.bxFriesland.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxFriesland.Visible = false;
            // 
            // bxGroningen
            // 
            this.bxGroningen.BackColor = System.Drawing.SystemColors.Control;
            this.bxGroningen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxGroningen.Location = new System.Drawing.Point(602, 147);
            this.bxGroningen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxGroningen.Name = "bxGroningen";
            this.bxGroningen.ReadOnly = true;
            this.bxGroningen.Size = new System.Drawing.Size(107, 28);
            this.bxGroningen.TabIndex = 70;
            this.bxGroningen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxGroningen.Visible = false;
            // 
            // bxDrenthe
            // 
            this.bxDrenthe.BackColor = System.Drawing.SystemColors.Control;
            this.bxDrenthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxDrenthe.Location = new System.Drawing.Point(593, 250);
            this.bxDrenthe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxDrenthe.Name = "bxDrenthe";
            this.bxDrenthe.ReadOnly = true;
            this.bxDrenthe.Size = new System.Drawing.Size(107, 28);
            this.bxDrenthe.TabIndex = 71;
            this.bxDrenthe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxDrenthe.Visible = false;
            // 
            // bxOverijssel
            // 
            this.bxOverijssel.BackColor = System.Drawing.SystemColors.Control;
            this.bxOverijssel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxOverijssel.Location = new System.Drawing.Point(571, 364);
            this.bxOverijssel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxOverijssel.Name = "bxOverijssel";
            this.bxOverijssel.ReadOnly = true;
            this.bxOverijssel.Size = new System.Drawing.Size(107, 28);
            this.bxOverijssel.TabIndex = 72;
            this.bxOverijssel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxOverijssel.Visible = false;
            // 
            // bxGelderland
            // 
            this.bxGelderland.BackColor = System.Drawing.SystemColors.Control;
            this.bxGelderland.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxGelderland.Location = new System.Drawing.Point(522, 451);
            this.bxGelderland.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxGelderland.Name = "bxGelderland";
            this.bxGelderland.ReadOnly = true;
            this.bxGelderland.Size = new System.Drawing.Size(107, 28);
            this.bxGelderland.TabIndex = 73;
            this.bxGelderland.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxGelderland.Visible = false;
            // 
            // bxNB
            // 
            this.bxNB.BackColor = System.Drawing.SystemColors.Control;
            this.bxNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxNB.Location = new System.Drawing.Point(393, 566);
            this.bxNB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxNB.Name = "bxNB";
            this.bxNB.ReadOnly = true;
            this.bxNB.Size = new System.Drawing.Size(107, 28);
            this.bxNB.TabIndex = 74;
            this.bxNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxNB.Visible = false;
            // 
            // bxLimburg
            // 
            this.bxLimburg.BackColor = System.Drawing.SystemColors.Control;
            this.bxLimburg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxLimburg.Location = new System.Drawing.Point(503, 660);
            this.bxLimburg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxLimburg.Name = "bxLimburg";
            this.bxLimburg.ReadOnly = true;
            this.bxLimburg.Size = new System.Drawing.Size(107, 28);
            this.bxLimburg.TabIndex = 75;
            this.bxLimburg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxLimburg.Visible = false;
            // 
            // bxZeeland
            // 
            this.bxZeeland.BackColor = System.Drawing.SystemColors.Control;
            this.bxZeeland.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxZeeland.Location = new System.Drawing.Point(186, 576);
            this.bxZeeland.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxZeeland.Name = "bxZeeland";
            this.bxZeeland.ReadOnly = true;
            this.bxZeeland.Size = new System.Drawing.Size(107, 28);
            this.bxZeeland.TabIndex = 76;
            this.bxZeeland.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxZeeland.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Indigo;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Misdaad aantallen",
            "Misdaad per 1.000 inwoners",
            "Procentuele verandering over jaren"});
            this.comboBox1.Location = new System.Drawing.Point(776, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 26);
            this.comboBox1.TabIndex = 77;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chosenMisdaadbx
            // 
            this.chosenMisdaadbx.BackColor = System.Drawing.SystemColors.Control;
            this.chosenMisdaadbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chosenMisdaadbx.Cursor = System.Windows.Forms.Cursors.No;
            this.chosenMisdaadbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenMisdaadbx.ForeColor = System.Drawing.Color.Indigo;
            this.chosenMisdaadbx.Location = new System.Drawing.Point(295, 40);
            this.chosenMisdaadbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chosenMisdaadbx.Multiline = true;
            this.chosenMisdaadbx.Name = "chosenMisdaadbx";
            this.chosenMisdaadbx.ReadOnly = true;
            this.chosenMisdaadbx.Size = new System.Drawing.Size(417, 33);
            this.chosenMisdaadbx.TabIndex = 78;
            this.chosenMisdaadbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chosenMisdaadbx.Visible = false;
            this.chosenMisdaadbx.TextChanged += new System.EventHandler(this.chosenMisdaadbx_TextChanged);
            // 
            // chosenYearbx
            // 
            this.chosenYearbx.BackColor = System.Drawing.Color.PaleGreen;
            this.chosenYearbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chosenYearbx.Cursor = System.Windows.Forms.Cursors.No;
            this.chosenYearbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenYearbx.ForeColor = System.Drawing.Color.SeaGreen;
            this.chosenYearbx.Location = new System.Drawing.Point(123, 263);
            this.chosenYearbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chosenYearbx.Multiline = true;
            this.chosenYearbx.Name = "chosenYearbx";
            this.chosenYearbx.ReadOnly = true;
            this.chosenYearbx.Size = new System.Drawing.Size(133, 39);
            this.chosenYearbx.TabIndex = 79;
            this.chosenYearbx.Text = "2010";
            this.chosenYearbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chosenYearbx.TextChanged += new System.EventHandler(this.chosenYearbx_TextChanged);
            // 
            // secretlableshh
            // 
            this.secretlableshh.AutoSize = true;
            this.secretlableshh.Location = new System.Drawing.Point(722, 972);
            this.secretlableshh.Name = "secretlableshh";
            this.secretlableshh.Size = new System.Drawing.Size(0, 17);
            this.secretlableshh.TabIndex = 88;
            // 
            // chosenCompareYearbx
            // 
            this.chosenCompareYearbx.BackColor = System.Drawing.Color.Plum;
            this.chosenCompareYearbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chosenCompareYearbx.Cursor = System.Windows.Forms.Cursors.No;
            this.chosenCompareYearbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenCompareYearbx.ForeColor = System.Drawing.Color.Indigo;
            this.chosenCompareYearbx.Location = new System.Drawing.Point(123, 399);
            this.chosenCompareYearbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chosenCompareYearbx.Multiline = true;
            this.chosenCompareYearbx.Name = "chosenCompareYearbx";
            this.chosenCompareYearbx.ReadOnly = true;
            this.chosenCompareYearbx.Size = new System.Drawing.Size(133, 39);
            this.chosenCompareYearbx.TabIndex = 89;
            this.chosenCompareYearbx.Text = "2010";
            this.chosenCompareYearbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chosenCompareYearbx.Visible = false;
            this.chosenCompareYearbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // compareLbl
            // 
            this.compareLbl.AutoSize = true;
            this.compareLbl.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareLbl.ForeColor = System.Drawing.Color.White;
            this.compareLbl.Location = new System.Drawing.Point(101, 222);
            this.compareLbl.Name = "compareLbl";
            this.compareLbl.Size = new System.Drawing.Size(187, 29);
            this.compareLbl.TabIndex = 90;
            this.compareLbl.Text = "Ten opzichte van:";
            this.compareLbl.Visible = false;
            // 
            // VergelijkJaarbalk
            // 
            this.VergelijkJaarbalk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.VergelijkJaarbalk.LargeChange = 1;
            this.VergelijkJaarbalk.Location = new System.Drawing.Point(227, 902);
            this.VergelijkJaarbalk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VergelijkJaarbalk.Maximum = 6;
            this.VergelijkJaarbalk.Name = "VergelijkJaarbalk";
            this.VergelijkJaarbalk.Size = new System.Drawing.Size(657, 56);
            this.VergelijkJaarbalk.TabIndex = 80;
            this.VergelijkJaarbalk.Visible = false;
            this.VergelijkJaarbalk.Scroll += new System.EventHandler(this.VergelijkJaarbalk_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(542, 902);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 63;
            this.label17.Visible = false;
            // 
            // label2010
            // 
            this.label2010.AutoSize = true;
            this.label2010.BackColor = System.Drawing.Color.Plum;
            this.label2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2010.ForeColor = System.Drawing.Color.Indigo;
            this.label2010.Location = new System.Drawing.Point(221, 941);
            this.label2010.Name = "label2010";
            this.label2010.Size = new System.Drawing.Size(49, 20);
            this.label2010.TabIndex = 81;
            this.label2010.Text = "2010";
            this.label2010.Visible = false;
            // 
            // label2011
            // 
            this.label2011.AutoSize = true;
            this.label2011.BackColor = System.Drawing.Color.Plum;
            this.label2011.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2011.ForeColor = System.Drawing.Color.Indigo;
            this.label2011.Location = new System.Drawing.Point(325, 941);
            this.label2011.Name = "label2011";
            this.label2011.Size = new System.Drawing.Size(49, 20);
            this.label2011.TabIndex = 82;
            this.label2011.Text = "2011";
            this.label2011.Visible = false;
            // 
            // label2012
            // 
            this.label2012.AutoSize = true;
            this.label2012.BackColor = System.Drawing.Color.Plum;
            this.label2012.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2012.ForeColor = System.Drawing.Color.Indigo;
            this.label2012.Location = new System.Drawing.Point(427, 941);
            this.label2012.Name = "label2012";
            this.label2012.Size = new System.Drawing.Size(49, 20);
            this.label2012.TabIndex = 83;
            this.label2012.Text = "2012";
            this.label2012.Visible = false;
            // 
            // label2014
            // 
            this.label2014.AutoSize = true;
            this.label2014.BackColor = System.Drawing.Color.Plum;
            this.label2014.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2014.ForeColor = System.Drawing.Color.Indigo;
            this.label2014.Location = new System.Drawing.Point(636, 941);
            this.label2014.Name = "label2014";
            this.label2014.Size = new System.Drawing.Size(49, 20);
            this.label2014.TabIndex = 84;
            this.label2014.Text = "2014";
            this.label2014.Visible = false;
            // 
            // label2016
            // 
            this.label2016.AutoSize = true;
            this.label2016.BackColor = System.Drawing.Color.Plum;
            this.label2016.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2016.ForeColor = System.Drawing.Color.Indigo;
            this.label2016.Location = new System.Drawing.Point(843, 941);
            this.label2016.Name = "label2016";
            this.label2016.Size = new System.Drawing.Size(49, 20);
            this.label2016.TabIndex = 85;
            this.label2016.Text = "2016";
            this.label2016.Visible = false;
            this.label2016.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2013
            // 
            this.label2013.AutoSize = true;
            this.label2013.BackColor = System.Drawing.Color.Plum;
            this.label2013.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2013.ForeColor = System.Drawing.Color.Indigo;
            this.label2013.Location = new System.Drawing.Point(531, 941);
            this.label2013.Name = "label2013";
            this.label2013.Size = new System.Drawing.Size(49, 20);
            this.label2013.TabIndex = 86;
            this.label2013.Text = "2013";
            this.label2013.Visible = false;
            // 
            // label2015
            // 
            this.label2015.AutoSize = true;
            this.label2015.BackColor = System.Drawing.Color.Plum;
            this.label2015.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2015.ForeColor = System.Drawing.Color.Indigo;
            this.label2015.Location = new System.Drawing.Point(739, 941);
            this.label2015.Name = "label2015";
            this.label2015.Size = new System.Drawing.Size(49, 20);
            this.label2015.TabIndex = 87;
            this.label2015.Text = "2015";
            this.label2015.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project3.Properties.Resources.full_map;
            this.pictureBox1.Location = new System.Drawing.Point(168, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_4);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Indigo;
            this.Back.Location = new System.Drawing.Point(23, 24);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(134, 35);
            this.Back.TabIndex = 91;
            this.Back.Text = "Hoofdmenu";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(943, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 30);
            this.button1.TabIndex = 92;
            this.button1.Text = "Alles selecteren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(776, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 30);
            this.button2.TabIndex = 93;
            this.button2.Text = "Verwijder selecties";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1128, 998);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.secretlableshh);
            this.Controls.Add(this.label2015);
            this.Controls.Add(this.label2013);
            this.Controls.Add(this.label2016);
            this.Controls.Add(this.label2014);
            this.Controls.Add(this.label2012);
            this.Controls.Add(this.label2011);
            this.Controls.Add(this.label2010);
            this.Controls.Add(this.chosenMisdaadbx);
            this.Controls.Add(this.compareLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chosenCompareYearbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bxGroningen);
            this.Controls.Add(this.bxFriesland);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bxDrenthe);
            this.Controls.Add(this.bxFlevoland);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bxOverijssel);
            this.Controls.Add(this.bxUtrecht);
            this.Controls.Add(this.provinceLable);
            this.Controls.Add(this.bxGelderland);
            this.Controls.Add(this.bxNH);
            this.Controls.Add(this.crimeCatLabel);
            this.Controls.Add(this.bxNB);
            this.Controls.Add(this.bxZH);
            this.Controls.Add(this.provinceBox);
            this.Controls.Add(this.bxLimburg);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.crimeCategoryBox);
            this.Controls.Add(this.bxZeeland);
            this.Controls.Add(this.chosenYearbx);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Jaarbalk);
            this.Controls.Add(this.VergelijkJaarbalk);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crime in the Netherlands - Statistics Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Jaarbalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArray1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VergelijkJaarbalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar Jaarbalk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label provinceLable;
        private System.Windows.Forms.Label crimeCatLabel;
        private System.Windows.Forms.CheckedListBox provinceBox;
        private System.Windows.Forms.CheckedListBox crimeCategoryBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox bxZH;
        private System.Windows.Forms.TextBox bxNH;
        private System.Windows.Forms.TextBox bxUtrecht;
        private System.Windows.Forms.TextBox bxFlevoland;
        private System.Windows.Forms.TextBox bxFriesland;
        private System.Windows.Forms.TextBox bxGroningen;
        private System.Windows.Forms.TextBox bxDrenthe;
        private System.Windows.Forms.TextBox bxOverijssel;
        private System.Windows.Forms.TextBox bxGelderland;
        private System.Windows.Forms.TextBox bxNB;
        private System.Windows.Forms.TextBox bxLimburg;
        private System.Windows.Forms.TextBox bxZeeland;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox chosenMisdaadbx;
        private System.Windows.Forms.TextBox chosenYearbx;
        private System.Windows.Forms.Label secretlableshh;
        private Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray pictureBoxArray1;
        private System.Windows.Forms.TextBox chosenCompareYearbx;
        private System.Windows.Forms.Label compareLbl;
        private System.Windows.Forms.TrackBar VergelijkJaarbalk;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2010;
        private System.Windows.Forms.Label label2011;
        private System.Windows.Forms.Label label2012;
        private System.Windows.Forms.Label label2014;
        private System.Windows.Forms.Label label2016;
        private System.Windows.Forms.Label label2013;
        private System.Windows.Forms.Label label2015;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

