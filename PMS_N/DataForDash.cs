using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PMS_N
{
  class DataForDash : Database
    {
        Database Database = new Database();

        public int getMedicineCount()
        {
            string query = "SELECT COUNT(*) FROM medicine";
            int count = Database.CountData(query);
            return count;
        }

        public int getSupplierCount()
        {
            string query = "SELECT COUNT(*) FROM supplier";
            int count = Database.CountData(query);
            return count;
        }
    }
}
