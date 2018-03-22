using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class GeregMisdrijven_2010_2016
    {
        //getter and setter properties
        //Acts as data carrier in our application
        public string soort_misdrijf { get; set; }

        public int jaar_2010 { get; set; }

        public int jaar_2011 { get; set; }

        public int jaar_2012 { get; set; }

        public int jaar_2013 { get; set; }

        public int jaar_2014 { get; set; }

        public int jaar_2015 { get; set; }

        public int jaar_2016 { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data from database
        public DataTable Select(string province, string extquery = "")
        {
            //Step 1 Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                province = province.ToLower();
                //Step 2: Writing Sql Query
                string sql = "SELECT * FROM misdrijf_" + province + " " + extquery + ";";
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
        //Selecting data from database
        public DataTable Select_bevolking(string province, string extquery = "")
        {
            //Step 1 Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing Sql Query
                string sql = "SELECT * FROM bevolkingsontwikkeling WHERE regio LIKE %" + province + "%;";
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
