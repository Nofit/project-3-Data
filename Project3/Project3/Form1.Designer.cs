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
            this.ShowText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DataShow = new System.Windows.Forms.TextBox();
            this.provinceLable = new System.Windows.Forms.Label();
            this.crimeCatLabel = new System.Windows.Forms.Label();
            this.provinceBox = new System.Windows.Forms.CheckedListBox();
            this.crimeCategoryBox = new System.Windows.Forms.CheckedListBox();
            this.comparisonBox = new System.Windows.Forms.CheckedListBox();
            this.comparisonLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DrentheButton = new System.Windows.Forms.Button();
            this.listBoxArray1 = new Microsoft.VisualBasic.Compatibility.VB6.ListBoxArray(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Jaarbalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxArray1)).BeginInit();
            this.SuspendLayout();
            // 
            // Jaarbalk
            // 
            this.Jaarbalk.Location = new System.Drawing.Point(471, 828);
            this.Jaarbalk.Name = "Jaarbalk";
            this.Jaarbalk.Size = new System.Drawing.Size(503, 56);
            this.Jaarbalk.TabIndex = 1;
            this.Jaarbalk.Value = 10;
            this.Jaarbalk.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ShowText
            // 
            this.ShowText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ShowText.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ShowText.Enabled = false;
            this.ShowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowText.ForeColor = System.Drawing.Color.Black;
            this.ShowText.Location = new System.Drawing.Point(302, 12);
            this.ShowText.Multiline = true;
            this.ShowText.Name = "ShowText";
            this.ShowText.ReadOnly = true;
            this.ShowText.Size = new System.Drawing.Size(350, 39);
            this.ShowText.TabIndex = 4;
            this.ShowText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShowText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 867);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "2006";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 867);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "2007";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 867);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "2008";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 867);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "2009";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(655, 867);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "2010";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(702, 867);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "2011";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 867);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "2012";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(842, 867);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "2014";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(796, 867);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "2013";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(930, 867);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "2016";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(888, 867);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "2015";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // DataShow
            // 
            this.DataShow.AcceptsReturn = true;
            this.DataShow.BackColor = System.Drawing.Color.FloralWhite;
            this.DataShow.Cursor = System.Windows.Forms.Cursors.No;
            this.DataShow.HideSelection = false;
            this.DataShow.Location = new System.Drawing.Point(722, 12);
            this.DataShow.Multiline = true;
            this.DataShow.Name = "DataShow";
            this.DataShow.ReadOnly = true;
            this.DataShow.Size = new System.Drawing.Size(300, 282);
            this.DataShow.TabIndex = 23;
            this.DataShow.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // provinceLable
            // 
            this.provinceLable.AutoSize = true;
            this.provinceLable.Location = new System.Drawing.Point(1031, 313);
            this.provinceLable.Name = "provinceLable";
            this.provinceLable.Size = new System.Drawing.Size(128, 17);
            this.provinceLable.TabIndex = 30;
            this.provinceLable.Text = "Kies een provincie:";
            this.provinceLable.Click += new System.EventHandler(this.label12_Click);
            // 
            // crimeCatLabel
            // 
            this.crimeCatLabel.AutoSize = true;
            this.crimeCatLabel.Location = new System.Drawing.Point(1187, 313);
            this.crimeCatLabel.Name = "crimeCatLabel";
            this.crimeCatLabel.Size = new System.Drawing.Size(147, 17);
            this.crimeCatLabel.TabIndex = 31;
            this.crimeCatLabel.Text = "Kies het soort misdrijf:";
            this.crimeCatLabel.Visible = false;
            this.crimeCatLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // provinceBox
            // 
            this.provinceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.provinceBox.CheckOnClick = true;
            this.provinceBox.FormattingEnabled = true;
            this.provinceBox.IntegralHeight = false;
            this.provinceBox.Items.AddRange(new object[] {
            "Flevoland",
            "Drenthe",
            "Groningen"});
            this.provinceBox.Location = new System.Drawing.Point(1029, 333);
            this.provinceBox.MultiColumn = true;
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(130, 185);
            this.provinceBox.TabIndex = 35;
            this.provinceBox.ThreeDCheckBoxes = true;
            this.provinceBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // crimeCategoryBox
            // 
            this.crimeCategoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.crimeCategoryBox.CheckOnClick = true;
            this.crimeCategoryBox.FormattingEnabled = true;
            this.crimeCategoryBox.IntegralHeight = false;
            this.crimeCategoryBox.Items.AddRange(new object[] {
            "Misdrijven Totaal",
            "Vernielingen",
            "Drugsmisdrijven"});
            this.crimeCategoryBox.Location = new System.Drawing.Point(1190, 333);
            this.crimeCategoryBox.MultiColumn = true;
            this.crimeCategoryBox.Name = "crimeCategoryBox";
            this.crimeCategoryBox.Size = new System.Drawing.Size(162, 185);
            this.crimeCategoryBox.TabIndex = 36;
            this.crimeCategoryBox.ThreeDCheckBoxes = true;
            this.crimeCategoryBox.Visible = false;
            this.crimeCategoryBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // comparisonBox
            // 
            this.comparisonBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comparisonBox.CheckOnClick = true;
            this.comparisonBox.FormattingEnabled = true;
            this.comparisonBox.IntegralHeight = false;
            this.comparisonBox.Items.AddRange(new object[] {
            "Flevoland",
            "Drenthe",
            "Groningen"});
            this.comparisonBox.Location = new System.Drawing.Point(1029, 550);
            this.comparisonBox.MultiColumn = true;
            this.comparisonBox.Name = "comparisonBox";
            this.comparisonBox.Size = new System.Drawing.Size(130, 185);
            this.comparisonBox.TabIndex = 50;
            this.comparisonBox.ThreeDCheckBoxes = true;
            this.comparisonBox.Visible = false;
            this.comparisonBox.SelectedIndexChanged += new System.EventHandler(this.comparisonBox_SelectedIndexChanged);
            // 
            // comparisonLabel
            // 
            this.comparisonLabel.AutoSize = true;
            this.comparisonLabel.Location = new System.Drawing.Point(1039, 530);
            this.comparisonLabel.Name = "comparisonLabel";
            this.comparisonLabel.Size = new System.Drawing.Size(109, 17);
            this.comparisonLabel.TabIndex = 51;
            this.comparisonLabel.Text = "Vergelijken met:";
            this.comparisonLabel.Visible = false;
            this.comparisonLabel.Click += new System.EventHandler(this.comparisonLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project3.Properties.Resources.full_map;
            this.pictureBox1.Location = new System.Drawing.Point(38, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 741);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_4);
            // 
            // DrentheButton
            // 
            this.DrentheButton.BackColor = System.Drawing.Color.Transparent;
            this.DrentheButton.FlatAppearance.BorderSize = 0;
            this.DrentheButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DrentheButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DrentheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrentheButton.ForeColor = System.Drawing.Color.White;
            this.DrentheButton.Image = ((System.Drawing.Image)(resources.GetObject("DrentheButton.Image")));
            this.DrentheButton.Location = new System.Drawing.Point(431, 116);
            this.DrentheButton.Name = "DrentheButton";
            this.DrentheButton.Size = new System.Drawing.Size(181, 183);
            this.DrentheButton.TabIndex = 19;
            this.DrentheButton.UseVisualStyleBackColor = false;
            this.DrentheButton.Click += new System.EventHandler(this.DrentheButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1107, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1364, 934);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comparisonLabel);
            this.Controls.Add(this.comparisonBox);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crimeCategoryBox);
            this.Controls.Add(this.provinceBox);
            this.Controls.Add(this.crimeCatLabel);
            this.Controls.Add(this.provinceLable);
            this.Controls.Add(this.DrentheButton);
            this.Controls.Add(this.DataShow);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jaarbalk);
            this.Name = "Form1";
            this.Text = "Crime Statistics Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Jaarbalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxArray1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar Jaarbalk;
        private System.Windows.Forms.TextBox ShowText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button DrentheButton;
        private System.Windows.Forms.TextBox DataShow;
        private System.Windows.Forms.Label provinceLable;
        private System.Windows.Forms.Label crimeCatLabel;
        private System.Windows.Forms.CheckedListBox provinceBox;
        private System.Windows.Forms.CheckedListBox crimeCategoryBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox comparisonBox;
        private System.Windows.Forms.Label comparisonLabel;
        private Microsoft.VisualBasic.Compatibility.VB6.ListBoxArray listBoxArray1;
        private System.Windows.Forms.Button button1;
    }
}

