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
    public partial class FrmPersonelPuanlandırma : Form
    {
        public FrmPersonelPuanlandırma()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        private void FrmPersonelPuanlandırma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelVeriTabanıDataSet7.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.otelVeriTabanıDataSet7.Tbl_Personel);

        }

        private void btnPersonelePuanVer_Click(object sender, EventArgs e)
        {
            sql.PersonelePuanVer(lblPerid.Text, txtPerPuan.Text);
            dataGridView1.DataSource = sql.verilerigoster("Select * from Tbl_Personel");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblPerid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm geri = new FrmAnaForm();
            geri.Show();
            this.Hide();
        }
    }
}
