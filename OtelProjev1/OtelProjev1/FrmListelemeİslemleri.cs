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
    public partial class FrmListelemeİslemleri : Form
    {
        public FrmListelemeİslemleri()
        {
            InitializeComponent();
        }
        SQL sql = new SQL();
        private void FrmDepartmanaGoreListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelVeriTabanıDataSet5.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.otelVeriTabanıDataSet5.Tbl_Personel);
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmAnaForm anaform = new FrmAnaForm();
            anaform.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //SQl classı içinden datatable içinde fonksiyon oluşturduk onun döndürdüğü değere datagridwiew1e yolladık
            dataGridView1.DataSource= sql.DepartmanaGoreListele();
        }

        private void button1_Click(object sender, EventArgs e) //Puana Göre Listeleme
        {
            dataGridView1.DataSource = sql.PuanaGoreListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
