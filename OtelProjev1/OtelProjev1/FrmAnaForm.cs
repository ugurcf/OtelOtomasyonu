using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelProjev1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = LAPTOP-ONB0MHF9; Initial Catalog = PersonelVeriTabani; Integrated Security = True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOtelKaydet_Click(object sender, EventArgs e)
        {
            FrmOtelEkle otelekle = new FrmOtelEkle();
            otelekle.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmOtelGuncelleme oguncelle = new FrmOtelGuncelleme();
            oguncelle.Show();
            this.Hide();
        }

        private void btnOtelsil_Click(object sender, EventArgs e)
        {
            FrmOtelSilme osil = new FrmOtelSilme();
            osil.Show();
            this.Hide();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelBilgi pbilgiekle = new FrmPersonelBilgi();
            pbilgiekle.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmPersonelGuncelle perguncelle = new FrmPersonelGuncelle();
            perguncelle.Show();
            this.Hide();
        }

        private void btnGiriseDon_Click(object sender, EventArgs e)
        {
            FrmGiris giris = new FrmGiris();
            giris.Show(); 
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmListelemeİslemleri listele = new FrmListelemeİslemleri();
            listele.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FrmPersonelSil psil = new FrmPersonelSil();
            psil.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmPersonelPuanlandırma puanla = new FrmPersonelPuanlandırma();
            puanla.Show();
            this.Hide();
        }
    }
}
