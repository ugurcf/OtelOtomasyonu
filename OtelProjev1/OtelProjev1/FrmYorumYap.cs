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
    public partial class FrmYorumYap : Form
    {
        SQL sql = new SQL();
        public FrmYorumYap()
        {
            InitializeComponent();
        }
        public string MusterİD { get; set; }

       
        private void FrmYorumYap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelVeriTabanıDataSet9.Tbl_OtelBilgi' table. You can move, or remove it, as needed.
            this.tbl_OtelBilgiTableAdapter.Fill(this.otelVeriTabanıDataSet9.Tbl_OtelBilgi);
            label2.Text = MusterİD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriForm mform = new MusteriForm();
            mform.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblOtelid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            FrmGiris frm = new FrmGiris();
        }

        private void btnYorumYap_Click(object sender, EventArgs e)
        {
            string a = sql.SatirSayisi();
            sql.YorumYap(lblOtelid.Text,a,label2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }
    }
}
