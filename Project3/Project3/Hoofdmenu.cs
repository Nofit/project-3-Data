using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_3_Data;

namespace Project3
{
    public partial class Hoofdmenu : Form
    {
        Form1 sub1 = new Form1();
        StartScreen s = new StartScreen();
   
        public Hoofdmenu()
        {
            InitializeComponent();

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();//this.Close();
            //sub1.Close();
        }

        private void buttonSub1_Click(object sender, EventArgs e)
        {
            sub1.Show();
            this.Hide();         
        }

        private void buttonSub3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Hoofdmenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonSub2_Click(object sender, EventArgs e)
        {
            s.Show();
            this.Hide();
        }
    }
}
