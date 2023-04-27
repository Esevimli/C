using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustripvetoolstrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();//richtextboxa seçtiğin metni kesme özelliğini ekler
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string yt = richTextBox1.Font.FontFamily.ToString();
            richTextBox1.Font = new Font(yt, 10);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string yt = richTextBox1.Font.FontFamily.ToString();
            richTextBox1.Font = new Font(yt, 20);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string yt = richTextBox1.Font.FontFamily.ToString();
            richTextBox1.Font = new Font(yt, 30);
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yt = richTextBox1.Font.FontFamily.ToString();
            int yb = int.Parse(toolStripComboBox1.Text);
            richTextBox1.Font = new Font(yt, yb);
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
    }
}
