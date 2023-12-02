using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMS_N
{
    public partial class Form11 : Form
    {
        private string update_Med_id;
        public Form11(string update_Med_id)
        {
            InitializeComponent();
            this.update_Med_id = update_Med_id;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                loadCombo();

                textBox1.Text = update_Med_id;
                Database database = new Database();

                DataSet ds = database.ReadData("SELECT * FROM medicine WHERE med_id = '" + update_Med_id + "' ", "sup_data");

                textBox2.Text = ds.Tables[0].Rows[0]["med_name"].ToString();
                textBox3.Text = ds.Tables[0].Rows[0]["quentity"].ToString();
                string exp_date = ds.Tables[0].Rows[0]["exp_date"].ToString();
                dateTimePicker1.Value = DateTime.ParseExact(exp_date, "dd/MM/yyyy", CultureInfo.InvariantCulture); 
                string manu_date = ds.Tables[0].Rows[0]["manu_date"].ToString();               
                dateTimePicker2.Value = DateTime.ParseExact(manu_date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                
                string sup_id = ds.Tables[0].Rows[0]["sup_id"].ToString();
                comboBox1.SelectedIndex = comboBox1.FindString(sup_id);

                

                

               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadCombo()
        {
            try
            {
                Database database = new Database();
                string sql = "SELECT sup_id, sup_name FROM supplier";
                DataSet ds = database.ReadData(sql, "supData");
                comboBox1.DisplayMember = "sup_id";
                comboBox1.ValueMember = "sup_id";
                comboBox1.DataSource = ds.Tables["supData"];
            }
            catch(Exception ex) {

                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = new Database();
                string sql = "UPDATE medicine SET " +
                    "med_name = '" + textBox2.Text + "', " +
                    "quentity = '" + textBox3.Text + "', " +
                    "exp_date = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'," +
                    "manu_date ='" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'," +
                    "sup_id = '"+ comboBox1.SelectedValue.ToString() +"' WHERE med_id = '"+ update_Med_id +"'  ";
                if (database.UpdateData(sql))
                {
                    MessageBox.Show("Store updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
