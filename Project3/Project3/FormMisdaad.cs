using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Project3;


namespace WindowsFormsApp1test
{
    

    public partial class FormMisdaad : Form
    {
        DataGetter dataGetter;
        private SqlConnection conn;
        

        public FormMisdaad()
        {
            InitializeComponent();
            dataGetter = new DataGetter();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {


            if (checkBox1.CheckState == CheckState.Checked)
            {
                label1.Text = trackBar1.Value.ToString("vrouw 50") + "%";

            }

            if (checkBox2.CheckState == CheckState.Checked)
            {
                label2.Text = ("Vrouw") + "%";
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                label3.Text = ("Vrouw") + "%";
            }

            if (checkBox4.CheckState == CheckState.Checked)
            {
                label4.Text = ("Vrouw") + "%";
            }

            if (checkBox5.CheckState == CheckState.Checked)
            {
                label5.Text = ("Vrouw") + "%";
            }

            if (checkBox6.CheckState == CheckState.Checked)
            {
                label6.Text = ("Vrouw") + "%";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                label7.Text = ("Vrouw") + "%";
            }

            if (checkBox8.CheckState == CheckState.Checked)
            {
                label8.Text = ("Vrouw") + "%";
            }

            if (checkBox9.CheckState == CheckState.Checked)
            {
                label9.Text = ("Vrouw") + "%";
            }

            if (checkBox10.CheckState == CheckState.Checked)
            {
                label10.Text = ("Vrouw") + "%";
            }

            if (checkBox11.CheckState == CheckState.Checked)
            {
                label11.Text = ("Vrouw") + "%";
            }

            if (checkBox12.CheckState == CheckState.Checked)
            {
                label12.Text = ("Vrouw") + "%";
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a misdrijf");
                return;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                label1.Text = ("Man") + "%";

            }

            if (checkBox2.CheckState == CheckState.Checked)
            {
                label2.Text = ("Man") + "%";
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                label3.Text = ("Man") + "%";
            }

            if (checkBox4.CheckState == CheckState.Checked)
            {
                label4.Text = ("Man") + "%";
            }

            if (checkBox5.CheckState == CheckState.Checked)
            {
                label5.Text = ("Man") + "%";
            }

            if (checkBox6.CheckState == CheckState.Checked)
            {
                label6.Text = ("Man") + "%";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                label7.Text = ("Man") + "%";
            }

            if (checkBox8.CheckState == CheckState.Checked)
            {
                label8.Text = ("Man") + "%";
            }

            if (checkBox9.CheckState == CheckState.Checked)
            {
                label9.Text = ("Man") + "%";
            }

            if (checkBox10.CheckState == CheckState.Checked)
            {
                label10.Text = ("Man") + "%";
            }

            if (checkBox11.CheckState == CheckState.Checked)
            {
                label11.Text = ("Man") + "%";
            }

            if (checkBox12.CheckState == CheckState.Checked)
            {
                label12.Text = ("Man") + "%";
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a misdrijf");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
        }

        private void FormMisdaad_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 9;


            if (checkBox1.CheckState == CheckState.Checked)
            {
                //queries??
                label1.Text = trackBar1.Value.ToString("Man 50") + "%";


            }

            if (checkBox2.CheckState == CheckState.Checked)
            {
                label2.Text = trackBar1.Value.ToString("Man 50") + "%";
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                label3.Text = trackBar1.Value.ToString("Man 50") + "%";
            }

            if (checkBox4.CheckState == CheckState.Checked)
            {
                label4.Text = trackBar1.Value.ToString("Man 50") + "%";
            }

            if (checkBox5.CheckState == CheckState.Checked)
            {
                label5.Text = trackBar1.Value.ToString("Man 50") + "%";
            }

            if (checkBox6.CheckState == CheckState.Checked)
            {
                label6.Text = trackBar1.Value.ToString("Vrouw 50") + "%";

            }

            if (checkBox12.CheckState == CheckState.Checked)
            {
                label12.Text = trackBar1.Value.ToString("Vrouw 50") + "%";
            }

            if (checkBox11.CheckState == CheckState.Checked)
            {
                label11.Text = trackBar1.Value.ToString("Vrouw 50") + "%";






                //errormsg
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a misdrijf");
                    return;
                }

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoofdmenu h = new Hoofdmenu();
            h.Show();
        }
    }
}
