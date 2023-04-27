using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        string oncekiadres, adres, sonrakiadres;

        //web sayfası değiştiğinde(güncellendiğinde)
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            adres = webBrowser1.Url.ToString();
            textBox1.Text = adres;
        }
        //GİT
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            oncekiadres = adres;
            adres = textBox1.Text;
        }


       //GERİ     
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            sonrakiadres = adres;
            adres = oncekiadres;
        }

        
        //İLERİ
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            oncekiadres = adres;
            adres = sonrakiadres;
        }

        //DUR
        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
    }
}
