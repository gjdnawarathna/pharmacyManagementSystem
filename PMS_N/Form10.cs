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
    public partial class Form10 : Form
    {
        private string userName;
        private string password;

        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                getUserData();
            }catch(Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void getUserData()
        {
            Database database = new Database();
            string sql = "SELECT * FROM admin WHERE Id= 'ADMIN_000001'";
            DataSet ds = database.ReadData(sql, "admin");
            userName = ds.Tables["admin"].Rows[0]["username"].ToString();
            password = ds.Tables["admin"].Rows[0]["password"].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string typedUserName = textBox3.Text;
                string typedPassword = textBox1.Text;

                if (typedUserName == userName && typedPassword == password)
                {
                    string newPass = textBox5.Text;
                    string confirmPass = textBox4.Text;
                    string newUserName = textBox5.Text;

                    if (newPass == confirmPass)
                    {
                        Database database = new Database();
                        string sql = "UPDATE admin SET username = '" + newUserName + "', password = '" + newPass + "' WHERE Id = 'ADMIN_000001'";
                        if (database.UpdateData(sql))
                        {
                            MessageBox.Show("Username and password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error occured while updating username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("New password and confirm password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
