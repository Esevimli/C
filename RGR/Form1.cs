using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true) //bu if eğer radio1 işaretliyse label2 ve textbox 2 yi görünmez yapıyo
            {
                label2.Visible = false; //label2.Hide(); olarakta yazılabilir aynı şey 
                textBox2.Visible = false;

                label1.Text = "KENAR: ";

                textBox1.Clear(); textBox1.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) //bu if eğer radio2 işaretliyse label2 ve textbox 2 yi görünür yapar üstte radio1 ile görünmez yaptıkya ondan buna tıklandığında tekrar görünür yapmamız gerekir
            {
                label2.Visible = true; //label2.Show(); olarakta yazılabilir aynı şey 
                textBox2.Visible = true;

                label1.Text = "1.KENAR: ";

                textBox1.Clear(); textBox2.Clear(); textBox1.Focus();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) 
            {
                label2.Visible = false; //label2.Hide(); olarakta yazılabilir aynı şey 
                textBox2.Visible = false;

                label1.Text = "YARIÇAP: ";

                textBox1.Clear(); textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alan=0;
            if(radioButton1.Checked)
            {
                double k = double.Parse(textBox1.Text);
                alan = k * k;
                
            }
            else if(radioButton2.Checked)
            {
                double k1 = double.Parse(textBox1.Text);
                double k2 = double.Parse(textBox2.Text);
                alan = k1 * k2;

            }
            else if (radioButton3.Checked)
            {
                double r = double.Parse(textBox1.Text);
                alan = Math.PI * r * r;
            }
            label3.Text = "SONUÇ: " + alan;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label5.Visible = false; //label2.Hide(); olarakta yazılabilir aynı şey 
                textBox4.Visible = false;

                label4.Text = "KENAR: ";

                textBox3.Clear(); textBox3.Focus();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true) 
            {
                label5.Visible = true; //label2.Show(); olarakta yazılabilir aynı şey 
                textBox4.Visible = true;

                label4.Text = "1.KENAR: ";

                textBox3.Clear(); textBox4.Clear(); textBox3.Focus();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                label5.Visible = false; //label2.Hide(); olarakta yazılabilir aynı şey 
                textBox4.Visible = false;

                label4.Text = "YARIÇAP: ";

                textBox3.Clear(); textBox3.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double çevre = 0;
            if (radioButton4.Checked)
            {
                double k = double.Parse(textBox3.Text);
                çevre = k * 4;

            }
            else if (radioButton5.Checked)
            {
                double k1 = double.Parse(textBox3.Text);
                double k2 = double.Parse(textBox4.Text);
                çevre = k1 * 2 + k2 * 2;

            }
            else if (radioButton6.Checked)
            {
                double r = double.Parse(textBox3.Text);
                çevre = 2 * Math.PI * r;
            }
            label6.Text = "SONUÇ: " + çevre;
        }
    }
}
