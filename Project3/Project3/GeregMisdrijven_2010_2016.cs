using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class GeregMisdrijven_2010_2016
    {
        //getter and setter properties
        //Acts as data carrier in our application
        public string SoortMisdrijf { get; set; }

        public int Jaar2010 { get; set; }

        public int Jaar2011 { get; set; }

        public int Jaar2012 { get; set; }

        public int Jaar2013 { get; set; }

        public int Jaar2014 { get; set; }

        public int Jaar2015 { get; set; }

        public int Jaar2016 { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data from database
        public DataTable Select(string province, string extquery)
        {
            //Step 1 Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing Sql Query
                string sql = "SELECT * FROM " + province + "Tbl " + extquery + ";";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating Sql Data adapter with cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dt;
        }
    }
}
