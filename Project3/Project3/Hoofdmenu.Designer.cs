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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSub3
            // 
            this.buttonSub3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub3.Location = new System.Drawing.Point(532, 242);
            this.buttonSub3.Name = "buttonSub3";
            this.buttonSub3.Size = new System.Drawing.Size(216, 142);
            this.buttonSub3.TabIndex = 6;
            this.buttonSub3.Text = "Verhouding man/vrouw onder verdachten";
            this.buttonSub3.UseVisualStyleBackColor = true;
            this.buttonSub3.Click += new System.EventHandler(this.buttonSub3_Click);
            // 
            // buttonSub2
            // 
            this.buttonSub2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub2.Location = new System.Drawing.Point(292, 242);
            this.buttonSub2.Name = "buttonSub2";
            this.buttonSub2.Size = new System.Drawing.Size(216, 142);
            this.buttonSub2.TabIndex = 5;
            this.buttonSub2.Text = "Onveiligheidsgevoel";
            this.buttonSub2.UseVisualStyleBackColor = true;
            this.buttonSub2.Click += new System.EventHandler(this.buttonSub2_Click);
            // 
            // buttonSub1
            // 
            this.buttonSub1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub1.Location = new System.Drawing.Point(53, 241);
            this.buttonSub1.Name = "buttonSub1";
            this.buttonSub1.Size = new System.Drawing.Size(216, 142);
            this.buttonSub1.TabIndex = 4;
            this.buttonSub1.Text = "Veiligheid over de jaren heen";
            this.buttonSub1.UseVisualStyleBackColor = true;
            this.buttonSub1.Click += new System.EventHandler(this.buttonSub1_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuit.Image")));
            this.buttonQuit.Location = new System.Drawing.Point(347, 490);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(98, 89);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(376, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Exit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(787, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Criminaliteit in Nederland - Statistieken Applicatie";
            // 
            // Hoofdmenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonSub3);
            this.Controls.Add(this.buttonSub2);
            this.Controls.Add(this.buttonSub1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hoofdmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoofdmenu";
            this.Load += new System.EventHandler(this.Hoofdmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonSub3;
        private System.Windows.Forms.Button buttonSub2;
        private System.Windows.Forms.Button buttonSub1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}