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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Jaarbalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Jaarbalk
            // 
            this.Jaarbalk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Jaarbalk.LargeChange = 1;
            this.Jaarbalk.Location = new System.Drawing.Point(302, 831);
            this.Jaarbalk.Maximum = 11;
            this.Jaarbalk.Name = "Jaarbalk";
            this.Jaarbalk.Size = new System.Drawing.Size(657, 56);
            this.Jaarbalk.TabIndex = 1;
            this.Jaarbalk.Value = 11;
            this.Jaarbalk.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ShowText
            // 
            this.ShowText.BackColor = System.Drawing.SystemColors.Control;
            this.ShowText.Cursor = System.Windows.Forms.Cursors.No;
            this.ShowText.Enabled = false;
            this.ShowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowText.ForeColor = System.Drawing.Color.Indigo;
            this.ShowText.Location = new System.Drawing.Point(12, 12);
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
            this.label1.Location = new System.Drawing.Point(125, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(125, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(467, 870);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "2008";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(523, 870);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "2009";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(578, 870);
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
            this.label6.Location = new System.Drawing.Point(637, 870);
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
            this.label7.Location = new System.Drawing.Point(692, 870);
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
            this.label8.Location = new System.Drawing.Point(805, 870);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "2014";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(125, -3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 55;
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
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(125, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 54;
            // 
            // DataShow
            // 
            this.DataShow.AcceptsReturn = true;
            this.DataShow.BackColor = System.Drawing.Color.FloralWhite;
            this.DataShow.Cursor = System.Windows.Forms.Cursors.No;
            this.DataShow.HideSelection = false;
            this.DataShow.Location = new System.Drawing.Point(847, 9);
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
            this.provinceLable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceLable.ForeColor = System.Drawing.Color.White;
            this.provinceLable.Location = new System.Drawing.Point(843, 303);
            this.provinceLable.Name = "provinceLable";
            this.provinceLable.Size = new System.Drawing.Size(144, 23);
            this.provinceLable.TabIndex = 30;
            this.provinceLable.Text = "Kies een provincie:";
            this.provinceLable.Click += new System.EventHandler(this.label12_Click);
            // 
            // crimeCatLabel
            // 
            this.crimeCatLabel.AutoSize = true;
            this.crimeCatLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimeCatLabel.ForeColor = System.Drawing.Color.White;
            this.crimeCatLabel.Location = new System.Drawing.Point(843, 527);
            this.crimeCatLabel.Name = "crimeCatLabel";
            this.crimeCatLabel.Size = new System.Drawing.Size(172, 23);
            this.crimeCatLabel.TabIndex = 31;
            this.crimeCatLabel.Text = "Kies het soort misdrijf:";
            this.crimeCatLabel.Visible = false;
            this.crimeCatLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // provinceBox
            // 
            this.provinceBox.BackColor = System.Drawing.SystemColors.Control;
            this.provinceBox.CheckOnClick = true;
            this.provinceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceBox.ForeColor = System.Drawing.Color.Indigo;
            this.provinceBox.FormattingEnabled = true;
            this.provinceBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.provinceBox.IntegralHeight = false;
            this.provinceBox.Items.AddRange(new object[] {
            "Flevoland",
            "Drenthe",
            "Groningen"});
            this.provinceBox.Location = new System.Drawing.Point(847, 328);
            this.provinceBox.MultiColumn = true;
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(140, 185);
            this.provinceBox.TabIndex = 35;
            this.provinceBox.ThreeDCheckBoxes = true;
            this.provinceBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // crimeCategoryBox
            // 
            this.crimeCategoryBox.BackColor = System.Drawing.SystemColors.Control;
            this.crimeCategoryBox.CheckOnClick = true;
            this.crimeCategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crimeCategoryBox.ForeColor = System.Drawing.Color.Indigo;
            this.crimeCategoryBox.FormattingEnabled = true;
            this.crimeCategoryBox.IntegralHeight = false;
            this.crimeCategoryBox.Items.AddRange(new object[] {
            "Misdrijven Totaal",
            "Vernielingen",
            "Drugsmisdrijven"});
            this.crimeCategoryBox.Location = new System.Drawing.Point(847, 552);
            this.crimeCategoryBox.MultiColumn = true;
            this.crimeCategoryBox.Name = "crimeCategoryBox";
            this.crimeCategoryBox.Size = new System.Drawing.Size(168, 185);
            this.crimeCategoryBox.TabIndex = 36;
            this.crimeCategoryBox.ThreeDCheckBoxes = true;
            this.crimeCategoryBox.Visible = false;
            this.crimeCategoryBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project3.Properties.Resources.full_map;
            this.pictureBox1.Location = new System.Drawing.Point(163, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 741);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_4);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(1174, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(409, 870);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "2007";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(748, 870);
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
            this.label14.Location = new System.Drawing.Point(862, 870);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 60;
            this.label14.Text = "2015";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(352, 870);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 61;
            this.label15.Text = "2006";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(297, 870);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 62;
            this.label16.Text = "2005";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(616, 917);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 63;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1260, 934);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crimeCategoryBox);
            this.Controls.Add(this.provinceBox);
            this.Controls.Add(this.crimeCatLabel);
            this.Controls.Add(this.provinceLable);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crime in the Nederlands - Statistics Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Jaarbalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox DataShow;
        private System.Windows.Forms.Label provinceLable;
        private System.Windows.Forms.Label crimeCatLabel;
        private System.Windows.Forms.CheckedListBox provinceBox;
        private System.Windows.Forms.CheckedListBox crimeCategoryBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

