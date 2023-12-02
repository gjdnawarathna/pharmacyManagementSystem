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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                //create an object to CheckUser class
                CheckUser checkUser = new CheckUser();

                if (checkUser.ChecktheUser(username, password))
                {
                    //message box saying user exist add an icon too
                    MessageBox.Show("Loggin Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // naviage to the dashboard
                    Form1 dash = new Form1(checkUser.getCurrentUser());
                    dash.Show();
                    this.Hide();




                }
                else
                {
                    MessageBox.Show("Invalid username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("System error occured " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
