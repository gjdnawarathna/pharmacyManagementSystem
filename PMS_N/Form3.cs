using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PMS_N
{
    public partial class Form3 : Form
    {
        private object panel3;
        private string supID;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int id = rnd.Next(100000, 999999);
                supID = "SUP_" + id.ToString();
                textBox2.Text = supID;
                loadDatagrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            





        }

        public void loadDatagrid()
        {

            try
            {
                Database database = new Database();
                DataSet ds = database.ReadData("select * from supplier", "allSuppliers");
                dataGridView1.DataSource = ds.Tables["allSuppliers"];

                

                DataGridViewButtonColumn UpdateBtn = new DataGridViewButtonColumn();
                UpdateBtn.Name = "Update";
                UpdateBtn.Text = "Update";
                UpdateBtn.UseColumnTextForButtonValue = true;
                int columnIndex = 0;

                if (dataGridView1.Columns["Update"] == null)
                {
                    dataGridView1.Columns.Insert(dataGridView1.Columns.Count, UpdateBtn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ACButton_Click(object sender, EventArgs e)
        {

        }

        private void ACButton_Click_1(object sender, EventArgs e)
        {
           /* Form7 form7 = new Form7();
            form7.TopLevel = false;
           *//* panel3.Controls.Add(form7);*//*
            form7.BringToFront();
            form7.Show();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                Database db = new Database();

                

                //validate user inputs in textboxes and checkwhether textbox1 contain a name , textbox3 contain name, and textbox4 contain a telephone number

                string name = textBox1.Text;
                
                string company = textBox3.Text;
                string telephone = textBox4.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(supID) || string.IsNullOrEmpty(company) || string.IsNullOrEmpty(telephone))
                {

                    MessageBox.Show("Please fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (Regex.IsMatch(telephone, @"^\d{10}$"))
                {

                    MessageBox.Show("Please use a valid phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string sql = "INSERT INTO supplier (sup_id,sup_name,company_name,telephone) VALUES ('" + supID + "' ,'" + name + "','" + company + "','" + telephone + "')";

                    if (db.InsertData(sql))
                    {

                        MessageBox.Show("New supplier registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            




        }

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    //Do something with your button.
                    //MessageBox.Show("I was clicked " + row.Cells[0].Value.ToString());
                    string updateSupId = row.Cells[1].Value.ToString();
                    Form7 form7 = new Form7(updateSupId);
                    form7.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                loadDatagrid();

            }
            catch(Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
