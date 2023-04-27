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


namespace Veritabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=vt.mdb");

        private void button1_Click(object sender, EventArgs e)//kayıt listele
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM KAYIT", bag);
            bag.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            listBox1.Items.Clear();
            string kayit = "";
            while(oku.Read())
            {
                kayit = "";//her kayıt okuduktan sonra temizler
                for (int i = 0; i < 4; i++)//veri tabanında 4 satır olduğu için 4
                    kayit += oku[i].ToString() + "\t";
                listBox1.Items.Add(kayit);
            }
            oku.Close();

            bag.Close();
        }

        private void button2_Click(object sender, EventArgs e)//kayıt listele nin tablo ile yapılan hali tablo daha uzun yazılır ama kayıtlara ulaşımı daha rahat oluyo datareader da kayıtları tek tek ve ilk kayıttan sona doğru almak zorundasın tabloda istediğin yerden alabilirsin ve birden fazlada çekebilirsin
        {
            OleDbCommand komut = new OleDbCommand("SELECT * FROM KAYIT", bag);
            bag.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            
            DataTable tablo = new DataTable();
            tablo.Load(oku);
            oku.Close();
            bag.Close();
            string kayit = "";
            listBox1.Items.Clear();
            for(int i = tablo.Rows.Count -1 ; i >= 0 ; i--)
            {
                kayit = "";
                for(int j = 0; j < 4; j++)
                    kayit += tablo.Rows[i][j].ToString() + "\t";
                listBox1.Items.Add(kayit);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
