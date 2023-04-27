using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Veritabanı3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=vt.mdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM KAYIT", bag);
            OleDbDataAdapter adp = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            if (textBox1.Text != "")
                isim = textBox1.Text;
            else
                isim = "%";

            string sorgu = "SELECT * FROM KAYIT WHERE AD LIKE @ad  ";//@ ifadesi sorguya parametre eklemek için kullanılır
            OleDbCommand komut = new OleDbCommand(sorgu, bag);
            komut.Parameters.AddWithValue("@ad", isim);//sorgudaki ad parametresine isim değişkenindeki değeri verirsin
            OleDbDataAdapter adp = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
