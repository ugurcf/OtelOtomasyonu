using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProjev1
{
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();

        private void btnKullanıcıDegis_Click(object sender, EventArgs e)
        {
            FrmGiris giris = new FrmGiris();
            giris.Show();
            this.Hide();
        }
        
        public string musteriİD { get; set; }
        İkiliAramaAgaci agac;
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            label4.Text = musteriİD;

            LinkedList2 otelYorumlari = sql.YorumEkle();
            LinkedList otelCalisanlari = sql.PersonelEkle();
            agac = sql.AgacaOtelEKle(otelCalisanlari, otelYorumlari);
        }

            private void button3_Click(object sender, EventArgs e)
        {
            FrmOtelPuanVer pver = new FrmOtelPuanVer();
            pver.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmYorumYap yyorum = new FrmYorumYap();
            yyorum.MusterİD = musteriİD;
            yyorum.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            agac.InOrder();
            richTextBox1.Text = agac.DugumleriYazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            string o = "";
            string il = textBox1.Text;
            string ilce = textBox2.Text;
  
            o = agac.IlIlceDugumSayisi(il,ilce);

                richTextBox1.Text = o;
            agac.Temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            richTextBox1.Text = " ";
            string o = "";
            string il = textBox1.Text;
            string ilce = textBox2.Text;

            o = agac.IlIlceYildizDugumSayisi(il, ilce);

            richTextBox1.Text = o;
            agac.Temizle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            agac.PreOrder();
            richTextBox1.Text = agac.DugumleriYazdir();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            agac.InOrder();
            richTextBox1.Text = agac.DugumleriYazdir();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            agac.PostOrder();
            richTextBox1.Text = agac.DugumleriYazdir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            string o = "";
            string il = textBox1.Text;
            string ilce = textBox2.Text;

            o = agac.IlIlcePuanDugumSayisi(il, ilce);

            richTextBox1.Text = o;
            agac.Temizle();
        }
 
    }
}
