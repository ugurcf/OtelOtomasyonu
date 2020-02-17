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
    public partial class FrmPersonelGuncelle : Form
    {
        public FrmPersonelGuncelle()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        private void FrmPersonelGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelVeriTabanıDataSet4.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.otelVeriTabanıDataSet4.Tbl_Personel);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            sql.PersonelBilgisiGuncelle(txtPerid.Text, txtPerTc.Text, txtPerAd.Text, txtPerSoyad.Text, txtPerTel.Text, txtPerAdres.Text, txtPerDepartman.Text, txtPerPozisyon.Text,txtPerPuan.Text,txtCalistigiYer.Text);
            dataGridView1.DataSource = sql.verilerigoster("Select * from Tbl_Personel");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtPerid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtPerTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtPerAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtPerSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtPerTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtPerAdres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtPerDepartman.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtPerPozisyon.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtPerPuan.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtCalistigiYer.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
             
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
