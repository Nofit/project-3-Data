using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MindFusion.Charting;
using MindFusion.Charting.WinForms;
using System.Data.SqlClient;
using Project3;

namespace Project_3_Data
{
    public partial class Leeftijd : Form
    {
        public Leeftijd()
        {
            InitializeComponent();

            var data = new Project3.Project3dbsDataSetTableAdapters.onveiligheidsbelevenis_geslacht_leeftijdTableAdapter();

            DataBoundSeries series1 = new DataBoundSeries(data.GetData());

            //draw the chart
            series1.Title = "Onveiligheidsgevoel op leeftijd en geslacht";
            series1.XDataField = "id";
            series1.YDataField = "Procent";
            barChart1.Series.Add(series1);

            //chart settings
            barChart1.XAxis.Title = "Geslacht en Leeftijd";
            barChart1.YAxis.Title = "Percentage";
            barChart1.XAxis.MinValue = 0;
            barChart1.XAxis.MaxValue = 7;
            barChart1.YAxis.MinValue = 0.0;
            barChart1.YAxis.MaxValue = 100.0;
            barChart1.XAxis.Interval = 1;
            barChart1.YAxis.Interval = 10;
        }

        private void barChart1_DataItemClicked(object sender, MindFusion.Charting.HitResult e)
        {

        }

        private void onveiligheidsbelevenis_geslacht_leeftijdBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.onveiligheidsbelevenis_geslacht_leeftijdBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project3dbsDataSet);

        }

        private void Leeftijd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project3dbsDataSet.onveiligheidsbelevenis_geslacht_leeftijd' table. You can move, or remove it, as needed.
            this.onveiligheidsbelevenis_geslacht_leeftijdTableAdapter.Fill(this.project3dbsDataSet.onveiligheidsbelevenis_geslacht_leeftijd);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regio R = new Regio();
            R.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hoofdmenu H = new Hoofdmenu();
            H.Show();
            this.Close();
        }

        private void onveiligheidsbelevenis_geslacht_leeftijdDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
