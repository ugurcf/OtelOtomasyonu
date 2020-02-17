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
    public partial class FrmOtelEkle : Form
    {
        public FrmOtelEkle()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        // SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-ONB0MHF9;Initial Catalog=OtelVeriTabanı;Integrated Security=True");
        private void btnOtelKaydet_Click(object sender, EventArgs e)
        {
            sql.OtelEkle(txtOtelAd.Text, txtBulil.Text, txtBulilce.Text, txtAdres.Text, txtTelefon.Text, txtEposta.Text, txtYıldızsayisi.Text, txtOdasayisi.Text, cmbOdatipi.Text, txtOtelpuani.Text);
            MessageBox.Show("Otel Başarıyla Kaydedildi!\n");
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();

        }
    }
}
