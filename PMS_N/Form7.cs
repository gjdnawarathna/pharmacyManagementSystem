using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS_N
{
    public partial class Form7 : Form
    {
        private string update_Sup_id;
        public Form7(string supId)
        {
            InitializeComponent();
            this.update_Sup_id = supId;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = new Database();
                string sql = "UPDATE supplier SET sup_name = '" + textBox1.Text + "', company_name = '" + textBox3.Text + "', telephone = '" + textBox4.Text + "' WHERE sup_id = '"+ update_Sup_id +"' ";
                if (database.UpdateData(sql))
                {
                    MessageBox.Show("Supplier updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            

        }

        private void Dashbord_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = update_Sup_id;
                Database database = new Database();

                DataSet ds = database.ReadData("SELECT * FROM supplier WHERE sup_id = '" + update_Sup_id + "' ", "sup_data");

                textBox1.Text = ds.Tables[0].Rows[0]["sup_name"].ToString();
                textBox3.Text = ds.Tables[0].Rows[0]["company_name"].ToString();
                textBox4.Text = ds.Tables[0].Rows[0]["telephone"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           

        }
    }
}
