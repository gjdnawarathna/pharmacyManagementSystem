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
    public partial class Form8 : Form
    {
        private string med_id;
        private DataSet ds;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(100000, 999999);
            med_id = "MED_" + id.ToString();
            textBox3.Text = med_id;

            Database database = new Database();
            string sql = "SELECT sup_id, sup_name FROM supplier";
            DataSet ds = database.ReadData(sql, "supData");
            comboBox1.DisplayMember = "sup_id";
            comboBox1.ValueMember = "sup_id";
            comboBox1.DataSource = ds.Tables["supData"];

            loadDatagrid();
        

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                Database database = new Database();
                string sql = "INSERT INTO medicine" +
                    "(med_id, med_name, quentity, exp_date, manu_date, sup_id) VALUES " +
                    "('" + med_id + "', '" + textBox1.Text + "', '" + textBox2.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', '" + dateTimePicker3.Value.ToString("dd/MM/yyyy") + "', '" + comboBox1.SelectedValue.ToString() + "')";
                if (database.InsertData(sql))
                {
                    MessageBox.Show("Successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                ds = database.ReadData("select * from medicine", "allSuppliers");
                dataGridView1.DataSource = ds.Tables["allSuppliers"];
                dataGridView2.DataSource = ds.Tables["allSuppliers"];
                dataGridView3.DataSource = ds.Tables["allSuppliers"];

                DataGridViewButtonColumn UpdateBtn = new DataGridViewButtonColumn();
                UpdateBtn.Name = "Update";
                UpdateBtn.Text = "Update";
                UpdateBtn.UseColumnTextForButtonValue = true;
                int columnIndex = 0;

                if (dataGridView1.Columns["Update"] == null)
                {
                    dataGridView1.Columns.Insert(dataGridView1.Columns.Count, UpdateBtn);
                }


                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.Name = "Remove";
                DeleteBtn.Text = "Remove";
                DeleteBtn.UseColumnTextForButtonValue = true;
                

                if (dataGridView2.Columns["Remove"] == null)
                {
                    dataGridView2.Columns.Insert(dataGridView2.Columns.Count, DeleteBtn);
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        public void loadDatagrid2()
        {

            try
            {


                Database database = new Database();
                ds = database.ReadData("select * from medicine", "allSuppliers");
                dataGridView1.DataSource = ds.Tables["allSuppliers"];
                dataGridView2.DataSource = ds.Tables["allSuppliers"];
                dataGridView3.DataSource = ds.Tables["allSuppliers"];

                DataGridViewButtonColumn UpdateBtn = new DataGridViewButtonColumn();
                UpdateBtn.Name = "Update";
                UpdateBtn.Text = "Update";
                UpdateBtn.UseColumnTextForButtonValue = true;
                int columnIndex = 0;

                if (dataGridView1.Columns["Update"] == null)
                {
                    dataGridView1.Columns.Insert(dataGridView1.Columns.Count, UpdateBtn);
                }


                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.Name = "Remove";
                DeleteBtn.Text = "Remove";
                DeleteBtn.UseColumnTextForButtonValue = true;


                if (dataGridView2.Columns["Remove"] == null)
                {
                    dataGridView2.Columns.Insert(dataGridView2.Columns.Count, DeleteBtn);
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }




        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                

                loadDatagrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView1.Rows.Count > 0)
                {
                    if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
                    {



                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        //Do something with your button.
                        //MessageBox.Show("I was clicked " + row.Cells[0].Value.ToString());
                        string updateMedId = row.Cells[1].Value.ToString();
                        Form11 form11 = new Form11(updateMedId);
                        form11.Show();

                    }
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridView2.Rows.Count > 0)
                {
                    if (e.ColumnIndex == dataGridView2.Columns["Remove"].Index)
                    {



                        DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                        //Do something with your button.
                        //MessageBox.Show("I was clicked " + row.Cells[0].Value.ToString());
                        string removeMedId = row.Cells[1].Value.ToString();

                        Database database = new Database();
                        string sql = "DELETE FROM medicine WHERE med_id = '" + removeMedId + "'";
                        if(database.DeleteData(sql))
                        {
                            MessageBox.Show("Successfully removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDatagrid2();
                        
                        }
                        else
                        {
                            MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
            findData(textBox5.Text);
        }

        public void findData(string keyWord) {
           string sql = "SELECT * FROM medicine WHERE med_id LIKE '%"+ keyWord +"%'" +
                "OR med_name LIKE '%"+ keyWord +"%'" +
                "OR quentity LIKE '%"+ keyWord +"%' " +
                "OR manu_date LIKE '%"+ keyWord +"%' " +
                "OR exp_date LIKE '%"+ keyWord +"%'" +
                "OR sup_id LIKE '%"+ keyWord +"%'";
            Database database = new Database();
            ds = database.ReadData(sql, "filterData");
            dataGridView3.DataSource= ds.Tables["filterData"];
        }

       
    }
}
