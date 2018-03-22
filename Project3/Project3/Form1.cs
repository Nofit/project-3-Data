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
        string vermogen_query = "WHERE soort_misdrijf LIKE '%Vermogen%'";
        string verniel_query = "WHERE soort_misdrijf LIKE '%Vernielingen%'";
        string geweld_query = "WHERE soort_misdrijf LIKE '%Gewelds%'";
        string wvsr_query = "WHERE soort_misdrijf LIKE '%WvSr%'";
        string verkeer_query = "WHERE soort_misdrijf LIKE '%Verkeer%'";
        string drugs_query = "WHERE soort_misdrijf LIKE '%drug%'";
        string wapen_query = "WHERE soort_misdrijf LIKE '%wapen%'";
        string overige_query = "WHERE soort_misdrijf LIKE '%overige%'";
        string[] provincies = new string[] { "Drenthe", "Flevoland", "Friesland", "Gelderland", "Groningen", "Limburg", "Noord-Brabant", "Noord-Holland", "Overijssel", "Utrecht", "Zeeland", "Zuid-Holland" };
        string[] provincies_for_data = new string[] { "Drenthe", "Flevoland", "Friesland", "Gelderland", "Groningen", "Limburg", "NoordBrabant", "NoordHolland", "Overijssel", "Utrecht", "Zeeland", "ZuidHolland" };
        string[] crimes = new string[] { "Totale misdrijven", "Vermogensmisdrijven", "Vernielingen, misdr.openb.orde/gezag", "Gewelds - en seksuele misdrijven", "Misdrijven WvSr(overig)", "Verkeersmisdrijven", "Drugsmisdrijven", "(Vuur)wapenmisdrijven", "Misdrijven overige wetten" };
        string[] years = new string[] {"2010", "2011", "2012", "2013", "2014", "2015", "2016"};
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
            for(int index = 0; index < 7; index++)
            {
                if(trackbar_index == index)
                {
                    chosenYearbx.Text = years[index];
                }
            }
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
                for(int index = 0; index < 12; index++)
                {
                    if (provinceBox.SelectedIndex == index)//flevoland
                    {
                        set_settings_province(index, provincies[index]);
                    }
                }
                return_checked_provinces();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please refrain from spamming the program.");
                counter = -1;
                for(int index = 0; index < 12; index++)
                {
                    provinceBox.SetItemChecked(index, false);
                }           
                orderedList.Clear();
            }
            set_data_and_map(CheckLastprovince()); //references to the function.. what shows data on screen and changes map to corresponding province
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_data_and_map(CheckLastprovince()); //references to the function.. what shows data on screen and changes map to corresponding province
            return_checked_provinces();
            if(provinceBox.GetItemChecked(0) == false & provinceBox.GetItemChecked(1) == false & provinceBox.GetItemChecked(2) == false
                & provinceBox.GetItemChecked(3) == false & provinceBox.GetItemChecked(4) == false & provinceBox.GetItemChecked(5) == false
                & provinceBox.GetItemChecked(6) == false & provinceBox.GetItemChecked(7) == false & provinceBox.GetItemChecked(8) == false
                & provinceBox.GetItemChecked(9) == false & provinceBox.GetItemChecked(10) == false & provinceBox.GetItemChecked(11) == false)
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
            DataTable bt = gm1.Select_bevolking(province);
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
            if (CheckLastprovince() == "Drenthe") //Checks if the last selected province corresponds with 'Flevoland'
            {
                pictureBox1.Image = Properties.Resources.Drenthe_arced; //sets the picture with Flevoland arced.
            }
            else if (CheckLastprovince() == "Flevoland")
            {
                pictureBox1.Image = Properties.Resources.Flevoland_arced; //sets the picture with Drenthe arced.
            }
            else if (CheckLastprovince() == "Friesland")
            {
                pictureBox1.Image = Properties.Resources.Friesland_arced; //sets the picture with Groningen arced.
            }
            else if (CheckLastprovince() == "Gelderland")
            {
                pictureBox1.Image = Properties.Resources.Gelderland_arced; //sets the picture with Groningen arced.
            }
            else if (CheckLastprovince() == "Groningen")
            {
                pictureBox1.Image = Properties.Resources.Groningen_arced; //sets the picture with Groningen arced.
            }
            else if (CheckLastprovince() == "Limburg")
            {
                pictureBox1.Image = Properties.Resources.Limburg_arced; //sets the picture with Groningen arced.
            }
            else if (CheckLastprovince() == "Noord-Brabant")
            {
                pictureBox1.Image = Properties.Resources.NoordBrabant_arced; //sets the picture with Groningen arced.
            }
            else if (CheckLastprovince() == "Noord-Holland")
            {
                pictureBox1.Image = Properties.Resources.NoordHolland_arced; //sets the picture with Groningen arced.
            }
            else if (CheckLastprovince() == "Overijssel")
            {
                pictureBox1.Image = Properties.Resources.Overijssel_arced; //sets the picture with Groningen arced.
            }
            else if (CheckLastprovince() == "Utrecht")
            {
                pictureBox1.Image = Properties.Resources.Utrecht_arced; //sets the picture with Groningen arced.
            }
            else if (CheckLastprovince() == "Zeeland")
            {
                pictureBox1.Image = Properties.Resources.Zeeland_arced; //sets the picture with Groningen arced.
            }
            else if (CheckLastprovince() == "Zuid-Holland")
            {
                pictureBox1.Image = Properties.Resources.ZuidHolland_arced; //sets the picture with Groningen arced.
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

                if (counter < 11) //Counts up only till 2 ... 2 indicates the number of indexes in the checkboxlist and so the number of indexes allowed in the orderedlist 
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
        }
        private void set_data_and_map(string province) 
            //This functions shows data in the screen and changes the map according to the last selected province.. 
            //It also unchecks other crime category checks, cause only one check at a time for the crimecategorybox is allowed.
        {
  
            for(int index = 0; index < 10; index++)
            {
                if (crimeCategoryBox.SelectedIndex == index) //Misdrijven Totaal 
                {
                    ShowText.Text = province; //Shows text of the last checked province
                    chosenMisdaadbx.Text = crimes[index];
                    //Unchecks Checked Item
                    crime_uncheck(index);
                    //In this case the totaal_query gets processed
                    province_map(); //Function that changes the map according to the last checked province
                }
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
            bool drenthe = true;
            bool flevoland = true;
            bool friesland = true;
            bool gelderland = true;
            bool groningen = true;
            bool limburg = true;
            bool nb = true;
            bool nh = true;
            bool overijssel = true;
            bool utrecht = true;
            bool zeeland = true;
            bool zh = true;

            for (int i = 0; i < orderedList.Count; i++)
            {
                if (orderedList[i].Contains("Flevoland"))
                {
                    bxFlevoland.Visible = true;
                    flevoland = false;
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
                if (orderedList[i].Contains("Friesland"))
                {
                    bxFriesland.Visible = true;
                    friesland = false;
                    bxFriesland.Text = data_format("Friesland", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Gelderland"))
                {
                    bxGelderland.Visible = true;
                    gelderland = false;
                    bxGelderland.Text = data_format("Drenthe", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Limburg"))
                {
                    bxLimburg.Visible = true;
                    limburg = false;
                    bxLimburg.Text = data_format("Limburg", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Noord-Brabant"))
                {
                    bxNB.Visible = true;
                    nb = false;
                    bxNB.Text = data_format("NoordBrabant", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Noord-Holland"))
                {
                    bxNH.Visible = true;
                    nh = false;
                    bxNH.Text = data_format("NoordHolland", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Overijssel"))
                {
                    bxOverijssel.Visible = true;
                    overijssel = false;
                    bxOverijssel.Text = data_format("Overijssel", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Utrecht"))
                {
                    bxUtrecht.Visible = true;
                    utrecht = false;
                    bxUtrecht.Text = data_format("Utrecht", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Zeeland"))
                {
                    bxZeeland.Visible = true;
                    zeeland = false;
                    bxZeeland.Text = data_format("Zeeland", return_misdrijf_type());
                }
                if (orderedList[i].Contains("Zuid-Holland"))
                {
                    bxZH.Visible = true;
                    zh = false;
                    bxZH.Text = data_format("ZuidHolland", return_misdrijf_type());
                }
            }
            if (flevoland)
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
            if (friesland)
            {
                bxFriesland.Visible = false;
            }
            if (gelderland)
            {
                bxGelderland.Visible = false;
            }
            if (limburg)
            {
                bxLimburg.Visible = false;
            }
            if (nb)
            {
                bxNB.Visible = false;
            }
            if (nh)
            {
                bxNH.Visible = false;
            }
            if (overijssel)
            {
                bxOverijssel.Visible = false;
            }
            if (utrecht)
            {
                bxUtrecht.Visible = false;
            }
            if (zeeland)
            {
                bxZeeland.Visible = false;
            }
            if (zh)
            {
                bxZH.Visible = false;
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
                return vermogen_query;
            }
            if (crimeCategoryBox.SelectedIndex == 2) //Drugsmisdrijven
            {
                return verniel_query;
            }
            if (crimeCategoryBox.SelectedIndex == 3) //Drugsmisdrijven
            {
                return geweld_query;
            }
            if (crimeCategoryBox.SelectedIndex == 4) //Drugsmisdrijven
            {
                return wvsr_query;
            }
            if (crimeCategoryBox.SelectedIndex == 5) //Drugsmisdrijven
            {
                return verkeer_query;
            }
            if (crimeCategoryBox.SelectedIndex == 6) //Drugsmisdrijven
            {
                return drugs_query;
            }
            if (crimeCategoryBox.SelectedIndex == 7) //Drugsmisdrijven
            {
                return wapen_query;
            }
            if (crimeCategoryBox.SelectedIndex == 8) //Drugsmisdrijven
            {
                return overige_query;
            }
            return "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                misdaad_aantal = true;
                return_checked_provinces();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                misdaad_aantal = false;
                return_checked_provinces();
            }
        }
        private void crime_uncheck(int forbidden_int)
        {
            for(int x = 0; x < forbidden_int; x++)
            {
                crimeCategoryBox.SetItemChecked(x, false);
            }
            for (int y = 8; y > forbidden_int; y--)
            {
                crimeCategoryBox.SetItemChecked(y, false);
            }
        }
        private void chosenYearbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
