using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GeregMisdrijven_2010_2016 gm1 = new GeregMisdrijven_2010_2016();
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowText.Text = "Kaart van Nederland";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowText.Text = "Gelderland";
            //Load data on textbox

            //Eerste Argument is voor de column_naam, het tweede argument is voor Extended query die achter 'FROM tableName' komt
            DataTable dt = gm1.Select("Gelderland");

            int counter = 0;
            string data = "";
            foreach (DataRow row in dt.Rows)
            {
                counter++;
                data = data + (counter + ". " + row[0] + " " + row[1] + "\r\n"); /// Appearance van de informatie..

            }
            DataShow.Text = data;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DrentheButton_Click(object sender, EventArgs e)
        {

        }

        private void FlevolandButton_Click(object sender, EventArgs e)
        {

        }

        private void GroningenButton_Click(object sender, EventArgs e)
        {
 
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comparisonBox.Visible = true;
            comparisonLabel.Visible = true;
            crimeCategoryBox.Visible = true;
            crimeCatLabel.Visible = true;

            if (provinceBox.SelectedIndex == 0)
            {
                provinceBox.SetItemChecked(1, false);
                provinceBox.SetItemChecked(2, false);

                ShowText.Text = "Flevoland";
            }
            else
            {
            }

            if (provinceBox.SelectedIndex == 1)
            {
                ///checkedListBox1.SetItemCheckState(0, uncheck1);
                provinceBox.SetItemChecked(0, false);
                provinceBox.SetItemChecked(2, false);        

                ShowText.Text = "Drenthe";
 
            }

            if (provinceBox.SelectedIndex == 2)
            {
                ///checkedListBox1.SetItemCheckState(0, uncheck1);
                provinceBox.SetItemChecked(0, false);
                provinceBox.SetItemChecked(1, false);


                ShowText.Text = "Groningen";
                //Load data on textbox

                //Eerste Argument is voor de column_naam, het tweede argument is voor Extended query die achter 'FROM tableName' komt
                DataTable dt = gm1.Select("Groningen");

                int counter = 0;
                string data = "";
                foreach (DataRow row in dt.Rows)
                {
                    counter++;
                    data = data + (counter + ". " + row[0] + " " + row[1] + "\r\n"); /// Appearance van de informatie..

                }
                DataShow.Text = data;
            }
            else
            {
            }

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string misdrijf_filter = "";

            if (provinceBox.SelectedIndex == 0) //Flevoland
            {
                //Unchecks Checked Item

                ShowText.Text = "Flevoland";
                //Load data on textbox

                //Eerste Argument is voor de column_naam, het tweede argument is voor Extended query die achter 'FROM tableName' komt
                DataTable dt = gm1.Select("Flevoland", "*", misdrijf_filter);

                int counter = 0;
                string data = "";
                foreach (DataRow row in dt.Rows)
                {
                    counter++;
                    data = data + (counter + ". " + row[0] + " " + row[1] + "\r\n"); /// Appearance van de informatie..

                }
                DataShow.Text = data;

                if (crimeCategoryBox.SelectedIndex == 0) //Totaal 
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(1, false);
                    crimeCategoryBox.SetItemChecked(2, false);

                    misdrijf_filter = "WHERE Soort_misdrijf LIKE 'Totaal%'";

                    dt = gm1.Select("Flevoland", "*", misdrijf_filter);

                    counter = 0;
                    data = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        data = data + (counter + ". " + row[0] + " " + row[1] + "\r\n"); /// Appearance van de informatie..

                    }

                    DataShow.Text = data;

                }
                //else
                //{
                //    //Unchecks Checked Item
                //    //checkedListBox2.SetItemChecked(1, false);
                //    //checkedListBox2.SetItemChecked(2, false);

                //    misdrijf_filter = "";

                //    dt = gm1.Select("Flevoland", "*", misdrijf_filter);

                //    counter = 0;
                //    data = "";
                //    foreach (DataRow row in dt.Rows)
                //    {
                //        counter++;
                //        data = data + (counter + ". " + row[0] + " " + row[1] + "\r\n"); /// Appearance van de informatie..

                //    }

                //    DataShow.Text = data;
                //}
            }

            if (provinceBox.SelectedIndex == 1) //Drenthe
            {
                //Load data on textbox

                //Eerste Argument is voor de column_naam, het tweede argument is voor Extended query die achter 'FROM tableName' komt

                DataTable dt = gm1.Select("Drenthe", "Jaar_2014, Jaar_2016", "WHERE Soort_misdrijf LIKE '%seksuele%'"); /// 1 argument

                int counter = 0;
                string data = "";
                foreach (DataRow row in dt.Rows)
                {
                    counter++;
                    data = data + (counter + ". " + row[0] + " " + row[1] + "\r\n"); /// Appearance van de informatie..

                }
                DataShow.Text = data;

                if (crimeCategoryBox.SelectedIndex == 0) //Totaal 
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(1, false);
                    crimeCategoryBox.SetItemChecked(2, false);

                    misdrijf_filter = "WHERE Soort_misdrijf LIKE 'Totaal%'";

                    dt = gm1.Select("Drenthe", "*", misdrijf_filter);

                    counter = 0;
                    data = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        data = data + (counter + ". " + row[0] + " " + row[1] + "\r\n"); /// Appearance van de informatie..

                    }

                    DataShow.Text = data;

                }
                else
                {
                    //Unchecks Checked Item
                    //checkedListBox2.SetItemChecked(1, false);
                    //checkedListBox2.SetItemChecked(2, false);

                    misdrijf_filter = "";

                    dt = gm1.Select("Drenthe", "*", misdrijf_filter);

                    counter = 0;
                    data = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        data = data + (counter + ". " + row[0] + " " + row[1] + "\r\n"); /// Appearance van de informatie..

                    }

                    DataShow.Text = data;
                }
            }
            
        }

        private void pictureBox1_Click_4(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comparisonBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comparisonLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
