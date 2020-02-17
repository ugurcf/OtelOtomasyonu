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
    public partial class FrmPersonelSil : Form
    {
        public FrmPersonelSil()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        private void FrmPersonelSil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelVeriTabanıDataSet6.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.otelVeriTabanıDataSet6.Tbl_Personel);

        }

        private void pictureBox1_Click(object sender, EventArgs e) //Geri Dönme butonu Adı değiştir en son !
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string Perid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            sql.PersonelSil(Perid);
            dataGridView1.DataSource = sql.verilerigoster("Select * from Tbl_Personel");
        }
    }
}
