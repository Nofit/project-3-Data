using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_3_Data
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();

            //connect to database
            SqlConnection conn = new SqlConnection("Data Source=145.24.222.239,8080;Network Library=DBMSSOCN;Initial Catalog=Project3dbs;User ID=pm;Password=project3;");
            conn.Open();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
       

            //close current window and open the next one
            this.Hide();
            Leeftijd l = new Leeftijd();
            l.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            


            //close current window and open the next one
            this.Hide();
            Regio R = new Regio();
            R.Show();

        }
    }
}
