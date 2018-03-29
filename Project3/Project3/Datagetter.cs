using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1test
{
    class DataGetter
    {
        public string soort_misdrijf { get; set; }

        public int jaar_2005 { get; set; }

        public int jaar_2006 { get; set; }

        public int jaar_2007 { get; set; }

        public int jaar_2008 { get; set; }

        public int jaar_2009 { get; set; }

        public int jaar_2010 { get; set; }

        public int jaar_2011 { get; set; }

        public int jaar_2012 { get; set; }

        public int jaar_2013 { get; set; }

        public int jaar_2014 { get; set; }

        public int jaar_2015 { get; set; }

        public int jaar_2016 { get; set; }

        public DataGetter()
        {
            connection = new SqlConnection("Data Source=145.24.222.239,8080;Network Library=DBMSSOCN;Initial Catalog=Project3dbs;User ID=pm;Password=project3;");
        }

       
        public DataTable Select(string province, string extquery = "")
        {

            SqlConnection conn = new SqlConnection();
            DataTable dt = new DataTable();

            province = province.ToLower();
            string sql = "SELECT * FROM misdaad_" + province + " " + extquery + ";";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            adapter.Fill(dt);


            conn.Close();


            return dt;
        }


        private SqlConnection connection;


    }
}
