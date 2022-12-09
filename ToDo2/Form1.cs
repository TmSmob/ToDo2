using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo2
{
    public partial class Form1 : Form
    {
        private Timer timer1;
        private Label label1;
        private IContainer components;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Merhaba Ahmet";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Gule Gule Ahmet";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Gule Gule Emirhan";
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(a == 0)
            {
                this.BackColor = Color.Red;
                a++;
            }
            else if(a == 1)
            {
                this.BackColor = Color.Blue;
                a++;
            }
            else
            {
            this.BackColor = Color.Green;
                a = 0;
            }
        }
    }
}
