using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panelvetabindex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = -1, f = -1, b = -1, ort = 0;

        



        //KAYDET
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                a = int.Parse(textBox1.Text);
            else
                a = -1;

            if (textBox2.Text != "")
                f = int.Parse(textBox2.Text);
            else
                f = -1;
            if (textBox3.Text != "")
                b = int.Parse(textBox3.Text);
            else
                b = -1;


            label5.Text = "Notlar Kaydedildi!...";

            if (a == -1)
                label6.Text = "Arasınav: "+ "Girmedi" +"\n";
            else
            label6.Text = "Arasınav: " + a + "\n";
            if (f == -1)
                label6.Text += "Final: "+ "Girmedi" + "\n";
            else
                label6.Text += "Final: " + f + "\n";
            if (b == -1)
                label6.Text += "Bütünleme: "+"Girmedi" + "\n";
            else
                label6.Text += "Bütünleme: " + b;

        }

        //ort hesapla
        private void button1_Click(object sender, EventArgs e)
        {
            if(b==-1)//bütünlemeye girmediyse if(arasınav ve finali hesaplar) girmediyse else(arasınav ve bütünleme hesaplar)
            {
                ort = Convert.ToInt32(Math.Round((a == -1 ? 0 : a) * 0.3 + (f == -1 ? 0 : f) * 0.7));//burdaki ? if olarak kullanılıyo eğer a == -1 ise bu parantezden 0 çıkar değil ise(:) a değişkeni çıkar
            }
            else
            {
                ort = Convert.ToInt32(Math.Round((a == -1 ? 0 : a) * 0.3 + (b == -1 ? 0 : b) * 0.7));
            }

            string durum =(ort >= 60 ? "BAŞARILI" : "BAŞARISIZ");

            label7.Text = "ORTALAMA: " + ort;
            label8.Text = "DURUM: " + durum;
        }


        //tab dan taba geçerken labelları değiştirir
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==0)
            {
                label7.Text = "ORTALAMA: ";
                label8.Text = "DURUM: ";
            }
        }


    }
}
