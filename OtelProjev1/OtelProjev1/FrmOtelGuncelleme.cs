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
    public partial class FrmOtelGuncelleme : Form
    {
        public FrmOtelGuncelleme()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        private void FrmOtelGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelVeriTabanıDataSet2.Tbl_OtelBilgi' table. You can move, or remove it, as needed.
            this.tbl_OtelBilgiTableAdapter.Fill(this.otelVeriTabanıDataSet2.Tbl_OtelBilgi);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sql.OtelBilgisiGuncelle(txtOtelAd.Text, txtBulil.Text, txtBulilce.Text, txtAdres.Text, txtTelefon.Text, txtEposta.Text, txtYıldızsayisi.Text, txtOdasayisi.Text, cmbOdatipi.Text, txtOtelpuani.Text,txtOtelid.Text);
            dataGridView1.DataSource = sql.verilerigoster("Select * from Tbl_OtelBilgi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtOtelid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtOtelAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBulil.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtBulilce.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtEposta.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtYıldızsayisi.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtOdasayisi.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            cmbOdatipi.Text= dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtOtelpuani.Text= dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
