using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PMS_N
{
    public partial class Form1 : Form
    {
        private Form3 form3;
        private string currentUser;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);

        public Form1(string currentUser)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.currentUser = currentUser;
        }

      

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            palNav.Height = btnDashbord.Height;
            palNav.Top = btnDashbord.Top;
            palNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);

            Form2 form2 = new Form2();
            form2.TopLevel = false;
            panel3.Controls.Clear(); // Clear existing controls in panel3
            panel3.Controls.Add(form2);
            form2.Dock = DockStyle.Fill;
            form2.Show();
        }

        private void SupButton_Click(object sender, EventArgs e)
        {
            palNav.Height = SupButton.Height;
            palNav.Top = SupButton.Top;
            palNav.Left = SupButton.Left;
            SupButton.BackColor = Color.FromArgb(46, 51, 73);

            if (form3 == null || form3.IsDisposed) // Create new instance if not already created or disposed
                form3 = new Form3();

            form3.TopLevel = false;
            panel3.Controls.Clear(); // Clear existing controls in panel3
            panel3.Controls.Add(form3);
            form3.Dock = DockStyle.Fill;
            form3.Show();
        }

        private void MedButton_Click(object sender, EventArgs e)
        {
            palNav.Height = MedButton.Height;
            palNav.Top = MedButton.Top;
            palNav.Left = MedButton.Left;
            MedButton.BackColor = Color.FromArgb(46, 51, 73);

            Form8 form8 = new Form8();
            form8.TopLevel = false;
            panel3.Controls.Clear(); // Clear existing controls in panel3
            panel3.Controls.Add(form8);
            form8.Dock = DockStyle.Fill;
            form8.Show();
        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashbord.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void SupButton_Leave(object sender, EventArgs e)
        {
            SupButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void MedButton_Leave(object sender, EventArgs e)
        {
            MedButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void lbutton_Leave(object sender, EventArgs e)
        {
            lbutton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = currentUser;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setButton_Click(object sender, EventArgs e)
        {
            palNav.Height = setButton.Height;
            palNav.Top = setButton.Top;
            palNav.Left = setButton.Left;
            setButton.BackColor = Color.FromArgb(46, 51, 73);

            Form10 form10 = new Form10();
            form10.TopLevel = false;
            panel3.Controls.Clear(); // Clear existing controls in panel3
            panel3.Controls.Add(form10);
            form10.Dock = DockStyle.Fill;
            form10.Show();
        }

        private void setButton_Leave(object sender, EventArgs e)
        {
            setButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void lbutton_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
    }
}
