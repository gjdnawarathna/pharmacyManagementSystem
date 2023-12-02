using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_N
{
    internal class CheckUser
    {
        private Database db = new Database();
        private string currentUser;
        public bool ChecktheUser(string username, string password)
        {

            string query = "SELECT * FROM admin WHERE username = '" + username + "' AND Password = '" + password + "';";

            DataSet ds = db.ReadData(query, "userExist");

            if (ds.Tables["userExist"].Rows.Count >= 1)
            {
                currentUser = ds.Tables[0].Rows[0]["username"].ToString();
                return true;

            }
            else
            {
                return false;
            }




        }
        public string getCurrentUser()
        {
            return currentUser;
        }
    }
}
