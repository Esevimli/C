using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "BAŞLA")
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            string metin;
            metin = label1.Text;
            int u = metin.Length;

            string ilk = metin.Substring(0, 1);//0 dan başla 1 e kadar (metnin ilk harfini alıyo) 
            string sonraki = metin.Substring(1, u - 1);//1 den başla sonakadar (u-1 uzunluk - 1 yani son harfi alıyo) 1 inci harftan sonuncu harfa kadar olan harfleri alır
            label1.Text = sonraki + ilk;//1.nci harftan sonrakileri başa kaydırıp ilk harfi sona kaydırıyo
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value);

        }
    }
}
