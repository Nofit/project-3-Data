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
        int counter = -1;
        List<string> orderedList = new List<string>(new string[] {});
        string last_province = "";


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
            CheckLastprovince();
            comparisonBox.Visible = true;
            comparisonLabel.Visible = true;
            crimeCategoryBox.Visible = true;
            crimeCatLabel.Visible = true;

            //if (AllUnchecked(provinceBox.GetItemChecked(0), provinceBox.GetItemChecked(1), provinceBox.GetItemChecked(2)))
            //{
            //    DataShow.Text = "";
            //    pictureBox1.Image = Project3.Properties.Resources.full_map;
            //    counter = 0;
            //}

            if (provinceBox.SelectedIndex == 0)
            {
                if (provinceBox.GetItemChecked(0))
                {
                    ShowText.Text = "Flevoland";
                    crimeCategoryBox.SetSelected(0, true);
                    crimeCategoryBox.SetItemChecked(0, true);

                    if (counter < 2)
                    {
                        counter++;
                    }
                    orderedList.Add("Flevoland");
                    province_map();

                    Console.WriteLine(orderedList[counter].ToString());
                    Console.WriteLine(counter.ToString());
                }
                else if (provinceBox.GetItemChecked(0) == false)
                {
                    try
                    {
                        orderedList.RemoveAt(orderedList.IndexOf("Flevoland"));
                        counter--;
                        province_map();
                        if (counter >= 0)
                        {
                            Console.WriteLine(orderedList[counter].ToString());
                        }
                        Console.WriteLine(counter.ToString());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error!");
                    }
                }
            }

            if (provinceBox.SelectedIndex == 1)
            {     
                if (provinceBox.GetItemChecked(1))
                {
                    ShowText.Text = "Drenthe";
                    crimeCategoryBox.SetSelected(0, true);
                    crimeCategoryBox.SetItemChecked(0, true);

                    if (counter < 2)
                    {
                        counter++;
                    }
                    orderedList.Add("Drenthe");
                    province_map();

                    Console.WriteLine(orderedList[counter].ToString());
                    Console.WriteLine(counter.ToString());
                }
                else if (provinceBox.GetItemChecked(1) == false)
                {
                    try
                    {
                        orderedList.RemoveAt(orderedList.IndexOf("Drenthe"));
                        counter--;
                        province_map();
                        if (counter >= 0)
                        {
                            Console.WriteLine(orderedList[counter].ToString()); ;
                        }
                        Console.WriteLine(counter.ToString());
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Error!");
                    }
                }
            }
            if (provinceBox.SelectedIndex == 2)
            {
                if (provinceBox.GetItemChecked(2))
                {
                    ShowText.Text = "Groningen";
                    crimeCategoryBox.SetSelected(0, true);
                    crimeCategoryBox.SetItemChecked(0, true);

                    if (counter < 2)
                    {
                        counter++;
                    }
                    orderedList.Add("Groningen");
                    province_map();

                    Console.WriteLine(orderedList[counter].ToString());
                    Console.WriteLine(counter.ToString());
                }
                else if (provinceBox.GetItemChecked(2) == false)
                {
                    try
                    {
                        orderedList.RemoveAt(orderedList.IndexOf("Groningen"));
                        counter--;
                        province_map();
                        if (counter >= 0)
                        {
                            Console.WriteLine(orderedList[counter].ToString());
                        }
                        Console.WriteLine(counter.ToString());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error!");
                    }
 
                }

            }
            //Load data on textbox           
            // data_format(last_province);

            if (crimeCategoryBox.SelectedIndex == 0) //Totaal 
            {
                //Unchecks Checked Item
                crimeCategoryBox.SetItemChecked(1, false);
                crimeCategoryBox.SetItemChecked(2, false);
                
                data_format(CheckLastprovince(), "*", totaal_query);
                province_map();      
                  
            }
            if (crimeCategoryBox.SelectedIndex == 1)
            {
                //Unchecks Checked Item
                crimeCategoryBox.SetItemChecked(0, false);
                crimeCategoryBox.SetItemChecked(2, false);

                data_format(CheckLastprovince(), "*", verniel_query);
                province_map();
            }
            if (crimeCategoryBox.SelectedIndex == 2)
            {
                //Unchecks Checked Item
                crimeCategoryBox.SetItemChecked(0, false);
                crimeCategoryBox.SetItemChecked(1, false);

                data_format(CheckLastprovince(), "*", drugs_query);
                province_map();
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load data on textbox           
            // data_format(last_province);

            if (crimeCategoryBox.SelectedIndex == 0) //Totaal 
            {
                //Unchecks Checked Item
                crimeCategoryBox.SetItemChecked(1, false);
                crimeCategoryBox.SetItemChecked(2, false);

                data_format(CheckLastprovince(), "*", totaal_query);
                province_map();

            }
            if (crimeCategoryBox.SelectedIndex == 1)
            {
                //Unchecks Checked Item
                crimeCategoryBox.SetItemChecked(0, false);
                crimeCategoryBox.SetItemChecked(2, false);

                data_format(CheckLastprovince(), "*", verniel_query);
                province_map();
            }
            if (crimeCategoryBox.SelectedIndex == 2)
            {
                //Unchecks Checked Item
                crimeCategoryBox.SetItemChecked(0, false);
                crimeCategoryBox.SetItemChecked(1, false);

                data_format(CheckLastprovince(), "*", drugs_query);
                province_map();
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
        public Boolean AllUnchecked(Boolean flevo, Boolean drenthe, Boolean groningen)
        {
            Boolean check = false;
            if (!(flevo && drenthe && groningen)){
                check = true;
            }
            return check;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            foreach(string s in orderedList)
            {
                Console.WriteLine(s);
            }
        }
        
        public string CheckLastprovince()
        {
            if (counter >= 0)
            {
                last_province = orderedList[counter];
            }
            else
            {
                last_province = "";
            }
            return last_province;
        }

        public void province_map()
        {
            if (CheckLastprovince() == "Flevoland")
            {
                pictureBox1.Image = Properties.Resources.Flevoland_arced;
            }
            else if (CheckLastprovince() == "Drenthe")
            {
                pictureBox1.Image = Properties.Resources.Drenthe_arced;
            }
            else if (CheckLastprovince() == "Groningen")
            {
                pictureBox1.Image = Properties.Resources.Groningen_arced;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.full_map;
            }
        }
            
    }
}
