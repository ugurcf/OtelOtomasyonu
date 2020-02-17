namespace OtelProjev1
{
    partial class FrmYorumYap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYorumYap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulunduguilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulunduguilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yıldızsayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelPuaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOtelBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelVeriTabanıDataSet9 = new OtelProjev1.OtelVeriTabanıDataSet9();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOtelid = new System.Windows.Forms.Label();
            this.btnYorumYap = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblYorum = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblMüsteriSoyad = new System.Windows.Forms.Label();
            this.lblMüsteriAd = new System.Windows.Forms.Label();
            this.tbl_OtelBilgiTableAdapter = new OtelProjev1.OtelVeriTabanıDataSet9TableAdapters.Tbl_OtelBilgiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOtelBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet9)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otel Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.otelidDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.bulunduguilDataGridViewTextBoxColumn,
            this.bulunduguilceDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.yıldızsayisiDataGridViewTextBoxColumn,
            this.otelPuaniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOtelBilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // otelidDataGridViewTextBoxColumn
            // 
            this.otelidDataGridViewTextBoxColumn.DataPropertyName = "Otelid";
            this.otelidDataGridViewTextBoxColumn.FillWeight = 60F;
            this.otelidDataGridViewTextBoxColumn.HeaderText = "Otelid";
            this.otelidDataGridViewTextBoxColumn.Name = "otelidDataGridViewTextBoxColumn";
            this.otelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.otelidDataGridViewTextBoxColumn.Width = 60;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // bulunduguilDataGridViewTextBoxColumn
            // 
            this.bulunduguilDataGridViewTextBoxColumn.DataPropertyName = "Bulunduguil";
            this.bulunduguilDataGridViewTextBoxColumn.HeaderText = "Bulunduguil";
            this.bulunduguilDataGridViewTextBoxColumn.Name = "bulunduguilDataGridViewTextBoxColumn";
            // 
            // bulunduguilceDataGridViewTextBoxColumn
            // 
            this.bulunduguilceDataGridViewTextBoxColumn.DataPropertyName = "Bulunduguilce";
            this.bulunduguilceDataGridViewTextBoxColumn.HeaderText = "Bulunduguilce";
            this.bulunduguilceDataGridViewTextBoxColumn.Name = "bulunduguilceDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // yıldızsayisiDataGridViewTextBoxColumn
            // 
            this.yıldızsayisiDataGridViewTextBoxColumn.DataPropertyName = "Yıldızsayisi";
            this.yıldızsayisiDataGridViewTextBoxColumn.HeaderText = "Yıldızsayisi";
            this.yıldızsayisiDataGridViewTextBoxColumn.Name = "yıldızsayisiDataGridViewTextBoxColumn";
            // 
            // otelPuaniDataGridViewTextBoxColumn
            // 
            this.otelPuaniDataGridViewTextBoxColumn.DataPropertyName = "OtelPuani";
            this.otelPuaniDataGridViewTextBoxColumn.HeaderText = "OtelPuani";
            this.otelPuaniDataGridViewTextBoxColumn.Name = "otelPuaniDataGridViewTextBoxColumn";
            // 
            // tblOtelBilgiBindingSource
            // 
            this.tblOtelBilgiBindingSource.DataMember = "Tbl_OtelBilgi";
            this.tblOtelBilgiBindingSource.DataSource = this.otelVeriTabanıDataSet9;
            // 
            // otelVeriTabanıDataSet9
            // 
            this.otelVeriTabanıDataSet9.DataSetName = "OtelVeriTabanıDataSet9";
            this.otelVeriTabanıDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblOtelid);
            this.groupBox2.Controls.Add(this.btnYorumYap);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.lblYorum);
            this.groupBox2.Controls.Add(this.lblEposta);
            this.groupBox2.Controls.Add(this.lblMüsteriSoyad);
            this.groupBox2.Controls.Add(this.lblMüsteriAd);
            this.groupBox2.Location = new System.Drawing.Point(25, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Otel ID:";
            // 
            // lblOtelid
            // 
            this.lblOtelid.AutoSize = true;
            this.lblOtelid.Location = new System.Drawing.Point(205, 36);
            this.lblOtelid.Name = "lblOtelid";
            this.lblOtelid.Size = new System.Drawing.Size(0, 17);
            this.lblOtelid.TabIndex = 11;
            // 
            // btnYorumYap
            // 
            this.btnYorumYap.BackColor = System.Drawing.Color.Beige;
            this.btnYorumYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYorumYap.Location = new System.Drawing.Point(142, 236);
            this.btnYorumYap.Name = "btnYorumYap";
            this.btnYorumYap.Size = new System.Drawing.Size(134, 38);
            this.btnYorumYap.TabIndex = 10;
            this.btnYorumYap.Text = "Yorum Yap";
            this.btnYorumYap.UseVisualStyleBackColor = false;
            this.btnYorumYap.Click += new System.EventHandler(this.btnYorumYap_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(162, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(162, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // lblYorum
            // 
            this.lblYorum.AutoSize = true;
            this.lblYorum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYorum.Location = new System.Drawing.Point(66, 196);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.Size = new System.Drawing.Size(75, 25);
            this.lblYorum.TabIndex = 4;
            this.lblYorum.Text = "Yorum:";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.Location = new System.Drawing.Point(55, 157);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(86, 25);
            this.lblEposta.TabIndex = 3;
            this.lblEposta.Text = "E-posta:";
            // 
            // lblMüsteriSoyad
            // 
            this.lblMüsteriSoyad.AutoSize = true;
            this.lblMüsteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMüsteriSoyad.Location = new System.Drawing.Point(-3, 113);
            this.lblMüsteriSoyad.Name = "lblMüsteriSoyad";
            this.lblMüsteriSoyad.Size = new System.Drawing.Size(144, 25);
            this.lblMüsteriSoyad.TabIndex = 2;
            this.lblMüsteriSoyad.Text = "Müşteri Soyad:";
            // 
            // lblMüsteriAd
            // 
            this.lblMüsteriAd.AutoSize = true;
            this.lblMüsteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMüsteriAd.Location = new System.Drawing.Point(25, 72);
            this.lblMüsteriAd.Name = "lblMüsteriAd";
            this.lblMüsteriAd.Size = new System.Drawing.Size(116, 25);
            this.lblMüsteriAd.TabIndex = 1;
            this.lblMüsteriAd.Text = "Müşteri Adı:";
            // 
            // tbl_OtelBilgiTableAdapter
            // 
            this.tbl_OtelBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(404, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(579, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "↶";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(404, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 251);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // FrmYorumYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(999, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmYorumYap";
            this.Text = "FrmYorumYap";
            this.Load += new System.EventHandler(this.FrmYorumYap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOtelBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet9)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private OtelVeriTabanıDataSet9 otelVeriTabanıDataSet9;
        private System.Windows.Forms.BindingSource tblOtelBilgiBindingSource;
        private OtelVeriTabanıDataSet9TableAdapters.Tbl_OtelBilgiTableAdapter tbl_OtelBilgiTableAdapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblYorum;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblMüsteriSoyad;
        private System.Windows.Forms.Label lblMüsteriAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulunduguilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulunduguilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yıldızsayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelPuaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYorumYap;
        private System.Windows.Forms.Label lblOtelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}