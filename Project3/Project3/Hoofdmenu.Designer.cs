namespace Project3
{
    partial class Hoofdmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoofdmenu));
            this.buttonSub3 = new System.Windows.Forms.Button();
            this.buttonSub2 = new System.Windows.Forms.Button();
            this.buttonSub1 = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSub3
            // 
            this.buttonSub3.Location = new System.Drawing.Point(408, 12);
            this.buttonSub3.Name = "buttonSub3";
            this.buttonSub3.Size = new System.Drawing.Size(359, 142);
            this.buttonSub3.TabIndex = 6;
            this.buttonSub3.Text = "button3";
            this.buttonSub3.UseVisualStyleBackColor = true;
            this.buttonSub3.Click += new System.EventHandler(this.buttonSub3_Click);
            // 
            // buttonSub2
            // 
            this.buttonSub2.Location = new System.Drawing.Point(228, 160);
            this.buttonSub2.Name = "buttonSub2";
            this.buttonSub2.Size = new System.Drawing.Size(359, 142);
            this.buttonSub2.TabIndex = 5;
            this.buttonSub2.Text = "button2";
            this.buttonSub2.UseVisualStyleBackColor = true;
            // 
            // buttonSub1
            // 
            this.buttonSub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub1.Location = new System.Drawing.Point(43, 12);
            this.buttonSub1.Name = "buttonSub1";
            this.buttonSub1.Size = new System.Drawing.Size(359, 142);
            this.buttonSub1.TabIndex = 4;
            this.buttonSub1.Text = "Misdaad per provincie";
            this.buttonSub1.UseVisualStyleBackColor = true;
            this.buttonSub1.Click += new System.EventHandler(this.buttonSub1_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuit.Image")));
            this.buttonQuit.Location = new System.Drawing.Point(358, 331);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(98, 89);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonSub3);
            this.Controls.Add(this.buttonSub2);
            this.Controls.Add(this.buttonSub1);
            this.Name = "Hoofdmenu";
            this.Text = "Hoofdmenu";
            this.Load += new System.EventHandler(this.Hoofdmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonSub3;
        private System.Windows.Forms.Button buttonSub2;
        private System.Windows.Forms.Button buttonSub1;
    }
}