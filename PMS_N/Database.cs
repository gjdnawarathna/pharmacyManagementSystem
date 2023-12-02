using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_N
{
     class Database
    {
        // make sqlConnection object 
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pharmacyDB.mdf;Integrated Security=True;Connect Timeout=30");
        // check connection method
        public bool CheckConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                return true;
            }
            else
            {
                return false;
            }
        }

        // insert data method
        public bool InsertData(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
            con.Close();
        }

        // read data method
        public DataSet ReadData(string query, string tableName)
        {
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, tableName);

            return dataSet;
            con.Close();
        }

        // updateData Method

        public bool UpdateData(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
            con.Close();
        }

        // deleteData Method

        public bool DeleteData(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
            con.Close();
        }

        public int CountData(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }
    }

    
}
