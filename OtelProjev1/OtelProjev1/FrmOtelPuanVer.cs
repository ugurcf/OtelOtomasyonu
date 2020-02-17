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
    public partial class FrmOtelPuanVer : Form
    {
        public FrmOtelPuanVer()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        private void FrmOtelPuanVer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelVeriTabanıDataSet8.Tbl_OtelBilgi' table. You can move, or remove it, as needed.
            this.tbl_OtelBilgiTableAdapter.Fill(this.otelVeriTabanıDataSet8.Tbl_OtelBilgi);

        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            MusteriForm mform = new MusteriForm();
            mform.Show();
            this.Hide();
        }

        private void btnPuanVer_Click(object sender, EventArgs e)
        {
            sql.OtelePuanVer(lblOtelid.Text, txtOtelPuan.Text);
            dataGridView1.DataSource = sql.verilerigoster("Select * from Tbl_OtelBilgi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblOtelid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
