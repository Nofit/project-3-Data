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
        string totaal_query = "WHERE Soort_misdrijf LIKE 'Totaal%'";
        string verniel_query = "WHERE Soort_misdrijf LIKE 'Vernielingen'";
        string drugs_query = "WHERE Soort_misdrijf LIKE 'Drug%'";
        


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
            data_format("Gelderland");

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

                crimeCategoryBox.SetSelected(0, true);
                crimeCategoryBox.SetItemChecked(0, true);

                pictureBox1.Image = Project3.Properties.Resources.Flevoland_arced;
            }


            if (provinceBox.SelectedIndex == 1)
            {

                provinceBox.SetItemChecked(0, false);
                provinceBox.SetItemChecked(2, false);        

                ShowText.Text = "Drenthe";

                crimeCategoryBox.SetSelected(0, true);
                crimeCategoryBox.SetItemChecked(0, true);

                pictureBox1.Image = Project3.Properties.Resources.Drenthe_arced;
            }

            if (provinceBox.SelectedIndex == 2)
            {

                provinceBox.SetItemChecked(0, false);
                provinceBox.SetItemChecked(1, false);

                ShowText.Text = "Groningen";

                crimeCategoryBox.SetSelected(0, true);
                crimeCategoryBox.SetItemChecked(0, true);


                pictureBox1.Image = Project3.Properties.Resources.Groningen_arced;
            }

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (provinceBox.SelectedIndex == 0) //Flevoland
            {       
                //Load data on textbox           
                data_format("Flevoland");

                if (crimeCategoryBox.SelectedIndex == 0) //Totaal 
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(1, false);
                    crimeCategoryBox.SetItemChecked(2, false);

                    data_format("Flevoland", "*", totaal_query);

                }
                if (crimeCategoryBox.SelectedIndex == 1)
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(0, false);
                    crimeCategoryBox.SetItemChecked(2, false);

                    data_format("Flevoland", "*", verniel_query);
                }
                if (crimeCategoryBox.SelectedIndex == 2)
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(0, false);
                    crimeCategoryBox.SetItemChecked(1, false);

                    data_format("Flevoland", "*", drugs_query);
                }
            }

            if (provinceBox.SelectedIndex == 1) //Drenthe
            {
                //Load data on textbox 
                data_format("Drenthe"); /// 1 argument

                if (crimeCategoryBox.SelectedIndex == 0) //Totaal 
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(1, false);
                    crimeCategoryBox.SetItemChecked(2, false);

                    data_format("Drenthe", "*", totaal_query);
                }
                if (crimeCategoryBox.SelectedIndex == 1)
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(0, false);
                    crimeCategoryBox.SetItemChecked(2, false);

                    data_format("Drenthe", "*", verniel_query);
                }
                if (crimeCategoryBox.SelectedIndex == 2)
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(0, false);
                    crimeCategoryBox.SetItemChecked(1, false);

                    data_format("Drenthe", "*", drugs_query);
                }

            }
            if (provinceBox.SelectedIndex == 2)//Groningen
            {
                //Load data on textbox 
                data_format("Groningen"); /// 1 argument

                if (crimeCategoryBox.SelectedIndex == 0) //Totaal 
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(1, false);
                    crimeCategoryBox.SetItemChecked(2, false);

                    data_format("Groningen", "*", totaal_query);
                }
                if (crimeCategoryBox.SelectedIndex == 1)
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(0, false);
                    crimeCategoryBox.SetItemChecked(2, false);

                    data_format("Groningen", "*", verniel_query);
                }
                if (crimeCategoryBox.SelectedIndex == 2)
                {
                    //Unchecks Checked Item
                    crimeCategoryBox.SetItemChecked(0, false);
                    crimeCategoryBox.SetItemChecked(1, false);

                    data_format("Groningen", "*", drugs_query);
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

        public void data_format(string province, string columnName = "*", string misdrijf_filter = "")
        {
            //Eerste Argument is voor de column_naam, het tweede argument is voor Extended query die achter 'FROM tableName' komt
            DataTable dt = gm1.Select(province, columnName, misdrijf_filter);

            int counter = 0;
            string data = "";
            foreach (DataRow row in dt.Rows)
            {
                counter++;
                data = data + (counter + ". " + row[0] + " " + row[1] + "\r\n"); /// Appearance van de informatie..

            }
            DataShow.Text = data;
        }
        public void uncheck_items()
        {

        }
    }
}
