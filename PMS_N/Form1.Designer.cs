using System;
using System.Windows.Forms;

namespace PMS_N
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbutton = new System.Windows.Forms.Button();
            this.palNav = new System.Windows.Forms.Panel();
            this.setButton = new System.Windows.Forms.Button();
            this.MedButton = new System.Windows.Forms.Button();
            this.SupButton = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lbutton);
            this.panel1.Controls.Add(this.palNav);
            this.panel1.Controls.Add(this.setButton);
            this.panel1.Controls.Add(this.MedButton);
            this.panel1.Controls.Add(this.SupButton);
            this.panel1.Controls.Add(this.btnDashbord);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 530);
            this.panel1.TabIndex = 0;
            // 
            // lbutton
            // 
            this.lbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbutton.FlatAppearance.BorderSize = 0;
            this.lbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbutton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbutton.Location = new System.Drawing.Point(0, 276);
            this.lbutton.Name = "lbutton";
            this.lbutton.Size = new System.Drawing.Size(182, 33);
            this.lbutton.TabIndex = 2;
            this.lbutton.Text = "Log Out";
            this.lbutton.UseVisualStyleBackColor = true;
            this.lbutton.Click += new System.EventHandler(this.lbutton_Click);
            this.lbutton.Leave += new System.EventHandler(this.lbutton_Leave);
            // 
            // palNav
            // 
            this.palNav.BackColor = System.Drawing.Color.Cyan;
            this.palNav.Location = new System.Drawing.Point(0, 167);
            this.palNav.Name = "palNav";
            this.palNav.Size = new System.Drawing.Size(5, 100);
            this.palNav.TabIndex = 1;
            // 
            // setButton
            // 
            this.setButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.setButton.FlatAppearance.BorderSize = 0;
            this.setButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setButton.ForeColor = System.Drawing.Color.Cyan;
            this.setButton.Location = new System.Drawing.Point(0, 243);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(182, 33);
            this.setButton.TabIndex = 2;
            this.setButton.Text = "Settings";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            this.setButton.Leave += new System.EventHandler(this.setButton_Leave);
            // 
            // MedButton
            // 
            this.MedButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MedButton.FlatAppearance.BorderSize = 0;
            this.MedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedButton.ForeColor = System.Drawing.Color.Cyan;
            this.MedButton.Location = new System.Drawing.Point(0, 210);
            this.MedButton.Name = "MedButton";
            this.MedButton.Size = new System.Drawing.Size(182, 33);
            this.MedButton.TabIndex = 2;
            this.MedButton.Text = "Medicine";
            this.MedButton.UseVisualStyleBackColor = true;
            this.MedButton.Click += new System.EventHandler(this.MedButton_Click);
            this.MedButton.Leave += new System.EventHandler(this.MedButton_Leave);
            // 
            // SupButton
            // 
            this.SupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupButton.FlatAppearance.BorderSize = 0;
            this.SupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupButton.ForeColor = System.Drawing.Color.Cyan;
            this.SupButton.Location = new System.Drawing.Point(0, 177);
            this.SupButton.Name = "SupButton";
            this.SupButton.Size = new System.Drawing.Size(182, 33);
            this.SupButton.TabIndex = 2;
            this.SupButton.Text = "Supplier";
            this.SupButton.UseVisualStyleBackColor = true;
            this.SupButton.Click += new System.EventHandler(this.SupButton_Click);
            this.SupButton.Leave += new System.EventHandler(this.SupButton_Leave);
            // 
            // btnDashbord
            // 
            this.btnDashbord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashbord.FlatAppearance.BorderSize = 0;
            this.btnDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashbord.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.Color.Cyan;
            this.btnDashbord.Location = new System.Drawing.Point(0, 144);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(182, 33);
            this.btnDashbord.TabIndex = 2;
            this.btnDashbord.Text = "Dashboard";
            this.btnDashbord.UseVisualStyleBackColor = true;
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            this.btnDashbord.Leave += new System.EventHandler(this.btnDashbord_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 144);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(40, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = " ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(182, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 530);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(92, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(582, 378);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(68, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pharmacy Stock Manegment System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MedButton;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Panel palNav;
        private System.Windows.Forms.Button lbutton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SupButton;
        private Button setButton;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}

