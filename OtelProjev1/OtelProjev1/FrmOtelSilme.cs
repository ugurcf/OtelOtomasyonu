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
    public partial class FrmOtelSilme : Form
    {
        public FrmOtelSilme()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        private void FrmOtelSilme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelVeriTabanıDataSet3.Tbl_OtelBilgi' table. You can move, or remove it, as needed.
            this.tbl_OtelBilgiTableAdapter.Fill(this.otelVeriTabanıDataSet3.Tbl_OtelBilgi);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string Otelid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            sql.OtelSil(Otelid);
            dataGridView1.DataSource = sql.verilerigoster("Select * from Tbl_OtelBilgi");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
