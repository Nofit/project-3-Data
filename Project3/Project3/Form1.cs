using System;
using System.Collections;
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
        string totaal_query = "WHERE soort_misdrijf LIKE '%totaal%'";
        string verniel_query = "WHERE soort_misdrijf LIKE '%Vernielingen%'";
        string drugs_query = "WHERE soort_misdrijf LIKE '%drug%'";
        int counter = -1;
        List<string> orderedList = new List<string>(new string[] {});
        string last_province = "";
        int trackbar_index = 0;
        bool showprovincetext = false;
        string checked_items = "";
        bool misdaad_aantal = true;
    


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackbar_index = Jaarbalk.Value;
            set_data_and_map(CheckLastprovince()); //references to the function.. what shows data on screen and changes map to corresponding province
            return_checked_provinces();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
            crimeCategoryBox.Visible = true;
            crimeCatLabel.Visible = true;         
            try
            {

                if (provinceBox.SelectedIndex == 0)//flevoland
                {
                    set_settings_province(0, "Flevoland");
                }
                if (provinceBox.SelectedIndex == 1)
                {
                    set_settings_province(1, "Drenthe");
                }
                if (provinceBox.SelectedIndex == 2)
                {
                    set_settings_province(2, "Groningen");
                }
                return_checked_provinces();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please refrain from spamming the program.");
                counter = -1;
                provinceBox.SetItemChecked(0, false);
                provinceBox.SetItemChecked(1, false);
                provinceBox.SetItemChecked(2, false);
                orderedList.Clear();
            }
            set_data_and_map(CheckLastprovince()); //references to the function.. what shows data on screen and changes map to corresponding province
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_data_and_map(CheckLastprovince()); //references to the function.. what shows data on screen and changes map to corresponding province
            return_checked_provinces();
            if(provinceBox.GetItemChecked(0) == false & provinceBox.GetItemChecked(1) == false & provinceBox.GetItemChecked(2) == false)
            {
                System.Windows.Forms.MessageBox.Show("Select a province first!");
            }
        }

        private void pictureBox1_Click_4(object sender, EventArgs e)
        {

        }

        private string data_format(string province, string misdrijf_filter = "") //This function formats the data obtained from database into the texbox
        {
            //First argument is for the province name, second argument is for the columnname
            //third argument is for the Extended query which follows after 'FROM tableName'
            DataTable dt = gm1.Select(province, misdrijf_filter); //returns Table according to Query .. gm1 is name of object
            DataTable bt = gm1.Select_bevolking(misdrijf_filter);
            string data = "";//Empty string for creating the text with data
            string bdata = "";
            int aantalmisdaden = 0;
            int bevolking = 0;
            int sum = 0;

            foreach (DataRow row in dt.Rows) //Counts the rows from the Table
            {
                data = data + (row[trackbar_index + 1]); // Connects rows with each to make suitable to print row[0] and row[1] indicate which columns of a row you want to select
                if (misdaad_aantal == false)
                { 
                    foreach (DataRow row2 in bt.Rows)
                    {
                        bdata = bdata + (row2[trackbar_index + 2]);
                    }
                    aantalmisdaden = Int32.Parse(data);
                    bevolking = Int32.Parse(bdata);
                    sum = aantalmisdaden / (bevolking / 1000);
                    data = sum.ToString();
                }
            }             
            return data;
        }

        private void button1_Click_2(object sender, EventArgs e) //This button sums up all the items in orderedList
        {

        }
        
        private string CheckLastprovince() //This function checks what the last checked province and returns it, when counter -1, means list is empty therefore nothing is selected.
        {
            if (counter >= 0) //list is not empty has 1 or more items in it.. ans so returns the last checked province
            {
                last_province = orderedList[counter];
            }
            else
            {
                last_province = ""; //empty list... cause counter < 0 ... so there will be no data shown..
            }
            return last_province;
        }

        private void province_map() //This function places the corresponding image with the last checked province
        {
            if (CheckLastprovince() == "Flevoland") //Checks if the last selected province corresponds with 'Flevoland'
            {
                pictureBox1.Image = Properties.Resources.Flevoland_arced; //sets the picture with Flevoland arced.
            }
            else if (CheckLastprovince() == "Drenthe")
            {
                pictureBox1.Image = Properties.Resources.Drenthe_arced; //sets the picture with Drenthe arced.
            }
            else if (CheckLastprovince() == "Groningen")
            {
                pictureBox1.Image = Properties.Resources.Groningen_arced; //sets the picture with Groningen arced.
            }
            else
            {
                pictureBox1.Image = Properties.Resources.full_map; //When there is nothing checked in the checkboxlist.. set the full map with nothing arced.
            }
        }
        private void set_settings_province(int index_num, string province) 
            //This function wraps up and sets the settings for the last checked province.
        {
            if (provinceBox.GetItemChecked(index_num)) //checks if checked at the given index
            {
                ShowText.Text = province; //Shows text of the last checked province

                crimeCategoryBox.SetSelected(0, true); //Sets automatically selection at misdrijven Totaal filter
                crimeCategoryBox.SetItemChecked(0, true); //Sets automatically check at misdrijven Totaal filter

                if (counter < 2) //Counts up only till 2 ... 2 indicates the number of indexes in the checkboxlist and so the number of indexes allowed in the orderedlist 
                {
                    counter++;
                }

                orderedList.Add(province); //Adds last checked province into the list

                checked_items = provinceBox.CheckedItems[counter].ToString();

                Console.WriteLine(checked_items);

                province_map(); //Function that changes the map according to the last checked province

                Console.WriteLine(orderedList[counter].ToString()); //Test which provinces are currently in the list.. in the order the user ticked the boxes.
                Console.WriteLine(counter.ToString()); //Test ..keeps track of the index a province is placed in the orderedList
            }
            else if (provinceBox.GetItemChecked(index_num) == false) //checks if unchecked at the given index
            {
   
                orderedList.RemoveAt(orderedList.IndexOf(province)); //removes a province from the orderedList at the last index of the list
                counter--; //then reduces the count..         
                
                province_map(); //Function that changes the map according to the last checked province

                if (counter >= 0) //For preventing IndexOutofRange errors.. cause cannot accept a index with a counter of -1
                {
                    Console.WriteLine(orderedList[counter].ToString());
                }
                Console.WriteLine(counter.ToString());
            }
            if (checked_items.Contains("Flevoland"))
            {
                bxFlevoland.Visible = true;
            }
            if (checked_items.Contains("Drenthe"))
            {
                bxDrenthe.Visible = true;
            }
            if (checked_items.Contains("Groningen"))
            {
                bxGroningen.Visible = true;
            }
            if (checked_items.Contains("Flevoland") == false)
            {
                bxFlevoland.Visible = false;
            }
            if (checked_items.Contains("Drenthe") == false)
            {
                bxDrenthe.Visible = false;
            }
            if (checked_items.Contains("Groningen") == false)
            {
                bxGroningen.Visible = false;
            }
        }
        private void set_data_and_map(string province) 
            //This functions shows data in the screen and changes the map according to the last selected province.. 
            //It also unchecks other crime category checks, cause only one check at a time for the crimecategorybox is allowed.
        {
            if (crimeCategoryBox.SelectedIndex == 0) //Misdrijven Totaal 
            {
                ShowText.Text = province; //Shows text of the last checked province

                //Unchecks Checked Item
                crimeCategoryBox.SetItemChecked(1, false);
                crimeCategoryBox.SetItemChecked(2, false);
            //    data_format(CheckLastprovince(), totaal_query); //This function processes the last selected province, column, 
                //and extended query into a query.. which then retrieves data from database and prints the data into textbox
                //In this case the totaal_query gets processed
                province_map(); //Function that changes the map according to the last checked province
            }
            if (crimeCategoryBox.SelectedIndex == 1) //Vernielingen 
            {
                ShowText.Text = province; //Shows text of the last checked province

                //Unchecks Checked Item
                crimeCategoryBox.SetItemChecked(0, false);
                crimeCategoryBox.SetItemChecked(2, false);
               // data_format(CheckLastprovince(), verniel_query); //references the verniel_query
                province_map(); //Function that changes the map according to the last checked province
            }
            if (crimeCategoryBox.SelectedIndex == 2) //Drugsmisdrijven
            {
                ShowText.Text = province; //Shows text of the last checked province

                //Unchecks Checked Item
                crimeCategoryBox.SetItemChecked(0, false);
                crimeCategoryBox.SetItemChecked(1, false);
              //  data_format(CheckLastprovince(), drugs_query); //references the drugs_query
                province_map(); //Function that changes the map according to the last checked province
            }
        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void halloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bxFlevoland_TextChanged(object sender, EventArgs e)
        {

        }
        private void return_checked_provinces()
        {
            bool flevo = true;
            bool drenthe = true;
            bool groningen = true;

            for (int i = 0; i < orderedList.Count; i++)
            {
                if (orderedList[i].Contains("Flevoland"))
                {
                    bxFlevoland.Visible = true;
                    flevo = false;
                    bxFlevoland.Text = data_format("Flevoland", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Drenthe"))
                {
                    bxDrenthe.Visible = true;
                    drenthe = false;
                    bxDrenthe.Text = data_format("Drenthe", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Groningen"))
                {
                    bxGroningen.Visible = true;
                    groningen = false;
                    bxGroningen.Text = data_format("Groningen", return_misdrijf_type());
                }
            }
            if (flevo)
            {
                bxFlevoland.Visible = false;
            }
            if (drenthe)
            {
                bxDrenthe.Visible = false;
            }
            if (groningen)
            {
                bxGroningen.Visible = false;
            }
        }


        private string return_misdrijf_type()
        //This functions shows data in the screen and changes the map according to the last selected province.. 
        //It also unchecks other crime category checks, cause only one check at a time for the crimecategorybox is allowed.
        {
            if (crimeCategoryBox.SelectedIndex == 0) //Misdrijven Totaal 
            {
                return totaal_query;
   
            }
            if (crimeCategoryBox.SelectedIndex == 1) //Vernielingen 
            {
                return verniel_query;

            }
            if (crimeCategoryBox.SelectedIndex == 2) //Drugsmisdrijven
            {
                return drugs_query;
            }
            return "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                misdaad_aantal = true;
                counter = -1;
                provinceBox.SetItemChecked(0, false);
                provinceBox.SetItemChecked(1, false);
                provinceBox.SetItemChecked(2, false);
                orderedList.Clear();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                misdaad_aantal = false;
                counter = -1;
                provinceBox.SetItemChecked(0, false);
                provinceBox.SetItemChecked(1, false);
                provinceBox.SetItemChecked(2, false);
                orderedList.Clear();
            }
        }
    }
}
