using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "BAŞLA")
            {
                timer1.Interval = Convert.ToInt32(numericUpDown1.Value);
                timer1.Start();
                button1.Text = "DURDUR";
            }
            else
            {
                timer1.Stop();
                button1.Text = "BAŞLA";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value);
        }
        int x, y, yonX=10, yonY = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left < -14) yonX = 10;
            if (pictureBox1.Left > this.Width - pictureBox1.Width -5) yonX = -10;

            if (pictureBox1.Top < 0) yonY = 10;
            if (pictureBox1.Top > this.Height - pictureBox1.Height- 40) yonY = -10;

            pictureBox1.Left += yonX;
            pictureBox1.Top += yonY;
        }
    }
}
