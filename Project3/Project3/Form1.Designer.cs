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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Jaarbalk = new System.Windows.Forms.TrackBar();
            this.ShowText = new System.Windows.Forms.TextBox();
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
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.halloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geresgisterdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manmvrouwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chosenMisdaadbx = new System.Windows.Forms.TextBox();
            this.chosenYearbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Jaarbalk)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Jaarbalk
            // 
            this.Jaarbalk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Jaarbalk.LargeChange = 1;
            this.Jaarbalk.Location = new System.Drawing.Point(302, 831);
            this.Jaarbalk.Maximum = 6;
            this.Jaarbalk.Name = "Jaarbalk";
            this.Jaarbalk.Size = new System.Drawing.Size(657, 56);
            this.Jaarbalk.TabIndex = 1;
            this.Jaarbalk.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ShowText
            // 
            this.ShowText.BackColor = System.Drawing.SystemColors.Control;
            this.ShowText.Cursor = System.Windows.Forms.Cursors.No;
            this.ShowText.Enabled = false;
            this.ShowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowText.ForeColor = System.Drawing.Color.Indigo;
            this.ShowText.Location = new System.Drawing.Point(509, 18);
            this.ShowText.Multiline = true;
            this.ShowText.Name = "ShowText";
            this.ShowText.ReadOnly = true;
            this.ShowText.Size = new System.Drawing.Size(350, 39);
            this.ShowText.TabIndex = 4;
            this.ShowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShowText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(299, 870);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "2010";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(405, 870);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "2011";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(506, 870);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "2012";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(715, 870);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "2014";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(920, 870);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "2016";
            // 
            // provinceLable
            // 
            this.provinceLable.AutoSize = true;
            this.provinceLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceLable.ForeColor = System.Drawing.Color.White;
            this.provinceLable.Location = new System.Drawing.Point(946, 269);
            this.provinceLable.Name = "provinceLable";
            this.provinceLable.Size = new System.Drawing.Size(103, 28);
            this.provinceLable.TabIndex = 30;
            this.provinceLable.Text = "Provincies:";
            this.provinceLable.Click += new System.EventHandler(this.label12_Click);
            // 
            // crimeCatLabel
            // 
            this.crimeCatLabel.AutoSize = true;
            this.crimeCatLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimeCatLabel.ForeColor = System.Drawing.Color.White;
            this.crimeCatLabel.Location = new System.Drawing.Point(945, 499);
            this.crimeCatLabel.Name = "crimeCatLabel";
            this.crimeCatLabel.Size = new System.Drawing.Size(176, 28);
            this.crimeCatLabel.TabIndex = 31;
            this.crimeCatLabel.Text = "Soorten misdrijven:";
            this.crimeCatLabel.Visible = false;
            this.crimeCatLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // provinceBox
            // 
            this.provinceBox.BackColor = System.Drawing.SystemColors.Control;
            this.provinceBox.CheckOnClick = true;
            this.provinceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceBox.ForeColor = System.Drawing.Color.Indigo;
            this.provinceBox.FormattingEnabled = true;
            this.provinceBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.provinceBox.IntegralHeight = false;
            this.provinceBox.Items.AddRange(new object[] {
            "Flevoland",
            "Drenthe",
            "Groningen"});
            this.provinceBox.Location = new System.Drawing.Point(950, 294);
            this.provinceBox.MultiColumn = true;
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(191, 185);
            this.provinceBox.TabIndex = 35;
            this.provinceBox.ThreeDCheckBoxes = true;
            this.provinceBox.UseCompatibleTextRendering = true;
            this.provinceBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // crimeCategoryBox
            // 
            this.crimeCategoryBox.BackColor = System.Drawing.SystemColors.Control;
            this.crimeCategoryBox.CheckOnClick = true;
            this.crimeCategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimeCategoryBox.ForeColor = System.Drawing.Color.Indigo;
            this.crimeCategoryBox.FormattingEnabled = true;
            this.crimeCategoryBox.HorizontalScrollbar = true;
            this.crimeCategoryBox.IntegralHeight = false;
            this.crimeCategoryBox.Items.AddRange(new object[] {
            "Misdrijven Totaal\t\t",
            "Vernielingen",
            "Drugsmisdrijven"});
            this.crimeCategoryBox.Location = new System.Drawing.Point(950, 530);
            this.crimeCategoryBox.MultiColumn = true;
            this.crimeCategoryBox.Name = "crimeCategoryBox";
            this.crimeCategoryBox.Size = new System.Drawing.Size(246, 189);
            this.crimeCategoryBox.TabIndex = 36;
            this.crimeCategoryBox.ThreeDCheckBoxes = true;
            this.crimeCategoryBox.UseCompatibleTextRendering = true;
            this.crimeCategoryBox.Visible = false;
            this.crimeCategoryBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(605, 870);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 59;
            this.label13.Text = "2013";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(815, 870);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 60;
            this.label14.Text = "2015";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(616, 917);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 63;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.halloToolStripMenuItem,
            this.geresgisterdToolStripMenuItem,
            this.manmvrouwToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(106, 934);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // halloToolStripMenuItem
            // 
            this.halloToolStripMenuItem.Name = "halloToolStripMenuItem";
            this.halloToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.halloToolStripMenuItem.Text = "hallo";
            this.halloToolStripMenuItem.Click += new System.EventHandler(this.halloToolStripMenuItem_Click);
            // 
            // geresgisterdToolStripMenuItem
            // 
            this.geresgisterdToolStripMenuItem.Name = "geresgisterdToolStripMenuItem";
            this.geresgisterdToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.geresgisterdToolStripMenuItem.Text = "geresgisterd";
            // 
            // manmvrouwToolStripMenuItem
            // 
            this.manmvrouwToolStripMenuItem.Name = "manmvrouwToolStripMenuItem";
            this.manmvrouwToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.manmvrouwToolStripMenuItem.Text = "manmvrouw";
            // 
            // bxZH
            // 
            this.bxZH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxZH.Location = new System.Drawing.Point(368, 506);
            this.bxZH.Name = "bxZH";
            this.bxZH.ReadOnly = true;
            this.bxZH.Size = new System.Drawing.Size(107, 28);
            this.bxZH.TabIndex = 65;
            this.bxZH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxZH.Visible = false;
            // 
            // bxNH
            // 
            this.bxNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxNH.Location = new System.Drawing.Point(412, 353);
            this.bxNH.Name = "bxNH";
            this.bxNH.ReadOnly = true;
            this.bxNH.Size = new System.Drawing.Size(107, 28);
            this.bxNH.TabIndex = 66;
            this.bxNH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxNH.Visible = false;
            // 
            // bxUtrecht
            // 
            this.bxUtrecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxUtrecht.Location = new System.Drawing.Point(495, 454);
            this.bxUtrecht.Name = "bxUtrecht";
            this.bxUtrecht.ReadOnly = true;
            this.bxUtrecht.Size = new System.Drawing.Size(107, 28);
            this.bxUtrecht.TabIndex = 67;
            this.bxUtrecht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxUtrecht.Visible = false;
            // 
            // bxFlevoland
            // 
            this.bxFlevoland.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxFlevoland.Location = new System.Drawing.Point(555, 343);
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
            this.bxFriesland.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxFriesland.Location = new System.Drawing.Point(581, 205);
            this.bxFriesland.Name = "bxFriesland";
            this.bxFriesland.ReadOnly = true;
            this.bxFriesland.Size = new System.Drawing.Size(107, 28);
            this.bxFriesland.TabIndex = 69;
            this.bxFriesland.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxFriesland.Visible = false;
            // 
            // bxGroningen
            // 
            this.bxGroningen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxGroningen.Location = new System.Drawing.Point(747, 151);
            this.bxGroningen.Name = "bxGroningen";
            this.bxGroningen.ReadOnly = true;
            this.bxGroningen.Size = new System.Drawing.Size(107, 28);
            this.bxGroningen.TabIndex = 70;
            this.bxGroningen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxGroningen.Visible = false;
            // 
            // bxDrenthe
            // 
            this.bxDrenthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxDrenthe.Location = new System.Drawing.Point(722, 258);
            this.bxDrenthe.Name = "bxDrenthe";
            this.bxDrenthe.ReadOnly = true;
            this.bxDrenthe.Size = new System.Drawing.Size(107, 28);
            this.bxDrenthe.TabIndex = 71;
            this.bxDrenthe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxDrenthe.Visible = false;
            // 
            // bxOverijssel
            // 
            this.bxOverijssel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxOverijssel.Location = new System.Drawing.Point(709, 373);
            this.bxOverijssel.Name = "bxOverijssel";
            this.bxOverijssel.ReadOnly = true;
            this.bxOverijssel.Size = new System.Drawing.Size(107, 28);
            this.bxOverijssel.TabIndex = 72;
            this.bxOverijssel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxOverijssel.Visible = false;
            // 
            // bxGelderland
            // 
            this.bxGelderland.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxGelderland.Location = new System.Drawing.Point(647, 468);
            this.bxGelderland.Name = "bxGelderland";
            this.bxGelderland.ReadOnly = true;
            this.bxGelderland.Size = new System.Drawing.Size(107, 28);
            this.bxGelderland.TabIndex = 73;
            this.bxGelderland.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxGelderland.Visible = false;
            // 
            // bxNB
            // 
            this.bxNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxNB.Location = new System.Drawing.Point(500, 596);
            this.bxNB.Name = "bxNB";
            this.bxNB.ReadOnly = true;
            this.bxNB.Size = new System.Drawing.Size(107, 28);
            this.bxNB.TabIndex = 74;
            this.bxNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxNB.Visible = false;
            // 
            // bxLimburg
            // 
            this.bxLimburg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxLimburg.Location = new System.Drawing.Point(623, 697);
            this.bxLimburg.Name = "bxLimburg";
            this.bxLimburg.ReadOnly = true;
            this.bxLimburg.Size = new System.Drawing.Size(107, 28);
            this.bxLimburg.TabIndex = 75;
            this.bxLimburg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxLimburg.Visible = false;
            // 
            // bxZeeland
            // 
            this.bxZeeland.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxZeeland.Location = new System.Drawing.Point(275, 610);
            this.bxZeeland.Name = "bxZeeland";
            this.bxZeeland.ReadOnly = true;
            this.bxZeeland.Size = new System.Drawing.Size(107, 28);
            this.bxZeeland.TabIndex = 76;
            this.bxZeeland.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bxZeeland.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project3.Properties.Resources.full_map;
            this.pictureBox1.Location = new System.Drawing.Point(245, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 741);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_4);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Misdaadaantallen",
            "Misdaad per 1.000 inwoners"});
            this.comboBox1.Location = new System.Drawing.Point(950, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 24);
            this.comboBox1.TabIndex = 77;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chosenMisdaadbx
            // 
            this.chosenMisdaadbx.BackColor = System.Drawing.Color.Salmon;
            this.chosenMisdaadbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chosenMisdaadbx.Cursor = System.Windows.Forms.Cursors.No;
            this.chosenMisdaadbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenMisdaadbx.ForeColor = System.Drawing.Color.Indigo;
            this.chosenMisdaadbx.Location = new System.Drawing.Point(131, 18);
            this.chosenMisdaadbx.Multiline = true;
            this.chosenMisdaadbx.Name = "chosenMisdaadbx";
            this.chosenMisdaadbx.ReadOnly = true;
            this.chosenMisdaadbx.Size = new System.Drawing.Size(363, 39);
            this.chosenMisdaadbx.TabIndex = 78;
            this.chosenMisdaadbx.Text = "[Soort misdrijf]";
            this.chosenMisdaadbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chosenYearbx
            // 
            this.chosenYearbx.BackColor = System.Drawing.Color.PaleGreen;
            this.chosenYearbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chosenYearbx.Cursor = System.Windows.Forms.Cursors.No;
            this.chosenYearbx.Enabled = false;
            this.chosenYearbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenYearbx.ForeColor = System.Drawing.Color.Indigo;
            this.chosenYearbx.Location = new System.Drawing.Point(154, 814);
            this.chosenYearbx.Multiline = true;
            this.chosenYearbx.Name = "chosenYearbx";
            this.chosenYearbx.ReadOnly = true;
            this.chosenYearbx.Size = new System.Drawing.Size(133, 39);
            this.chosenYearbx.TabIndex = 79;
            this.chosenYearbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chosenYearbx.TextChanged += new System.EventHandler(this.chosenYearbx_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1260, 934);
            this.Controls.Add(this.chosenYearbx);
            this.Controls.Add(this.chosenMisdaadbx);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bxZeeland);
            this.Controls.Add(this.bxLimburg);
            this.Controls.Add(this.bxNB);
            this.Controls.Add(this.bxGelderland);
            this.Controls.Add(this.bxOverijssel);
            this.Controls.Add(this.bxDrenthe);
            this.Controls.Add(this.bxGroningen);
            this.Controls.Add(this.bxFriesland);
            this.Controls.Add(this.bxFlevoland);
            this.Controls.Add(this.bxUtrecht);
            this.Controls.Add(this.bxNH);
            this.Controls.Add(this.bxZH);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crimeCategoryBox);
            this.Controls.Add(this.provinceBox);
            this.Controls.Add(this.crimeCatLabel);
            this.Controls.Add(this.provinceLable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Jaarbalk);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crime in the Netherlands - Statistics Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Jaarbalk)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar Jaarbalk;
        private System.Windows.Forms.TextBox ShowText;
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem halloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geresgisterdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manmvrouwToolStripMenuItem;
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
    }
}

