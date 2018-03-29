using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MindFusion.Charting.WinForms;
using MindFusion.Charting;
using MindFusion.Charting.Properties;
using MindFusion.Charting.Components;
using MindFusion.Charting.Commands;
using MindFusion.Charting.Gauges;
using MindFusion.Charting.ThreeD;
using System.Data.SqlClient;
using Project3;

namespace Project_3_Data
{
    public partial class Regio : Form
    {
        public Regio()
        {
            InitializeComponent();

            var data = new Project3.Project3dbsDataSetTableAdapters.onveiligheidsbelevenis_per_regioTableAdapter();

            DataBoundSeries series1 = new DataBoundSeries(data.GetData());

            //draw the chart
            series1.Title = "Onveiligheidsgevoel per regio";
            series1.XDataField = "Misdaad per 1000 inwoners";
            series1.YDataField = "procent van totale bevolking";
            scatterChart1.Series.Add(series1);

            //chart settings
            scatterChart1.ShowLegend = false;
            scatterChart1.XAxis.Title = "Misdaad per 1000 inwoners";
            scatterChart1.YAxis.Title = "Percentage";
            scatterChart1.XAxis.MinValue = 30.0;
            scatterChart1.XAxis.MaxValue = 70.0;
            scatterChart1.YAxis.MinValue = 20.0;
            scatterChart1.YAxis.MaxValue = 50.0;
            scatterChart1.XAxis.Interval = 5;
            scatterChart1.YAxis.Interval = 5;
            series1.ToolTipsDataField = "provincie onveiligheidsgevoel" ;
            
        }

        private void onveiligheidsbelevenis_per_regioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.onveiligheidsbelevenis_per_regioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project3dbsDataSet);

        }

        private void Regio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project3dbsDataSet.onveiligheidsbelevenis_per_regio' table. You can move, or remove it, as needed.
            this.onveiligheidsbelevenis_per_regioTableAdapter.Fill(this.project3dbsDataSet.onveiligheidsbelevenis_per_regio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leeftijd l = new Leeftijd();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hoofdmenu H = new Hoofdmenu();
            H.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onveiligheidsbelevenis_per_regioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
