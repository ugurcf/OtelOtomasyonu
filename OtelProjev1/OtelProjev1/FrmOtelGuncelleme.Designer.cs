namespace OtelProjev1
{
    partial class FrmOtelGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtelGuncelleme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOtelid = new System.Windows.Forms.Label();
            this.txtOtelid = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbOdatipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOtelpuani = new System.Windows.Forms.TextBox();
            this.txtOtelAd = new System.Windows.Forms.TextBox();
            this.txtOdasayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYıldızsayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBulil = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtBulilce = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulunduguilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulunduguilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yıldızsayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odasayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odatipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelPuaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOtelBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelVeriTabanıDataSet2 = new OtelProjev1.OtelVeriTabanıDataSet2();
            this.tbl_OtelBilgiTableAdapter = new OtelProjev1.OtelVeriTabanıDataSet2TableAdapters.Tbl_OtelBilgiTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOtelBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblOtelid);
            this.groupBox1.Controls.Add(this.txtOtelid);
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.cmbOdatipi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOtelpuani);
            this.groupBox1.Controls.Add(this.txtOtelAd);
            this.groupBox1.Controls.Add(this.txtOdasayisi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYıldızsayisi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBulil);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.txtBulilce);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otel Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(804, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // lblOtelid
            // 
            this.lblOtelid.AutoSize = true;
            this.lblOtelid.Location = new System.Drawing.Point(25, 52);
            this.lblOtelid.Name = "lblOtelid";
            this.lblOtelid.Size = new System.Drawing.Size(90, 29);
            this.lblOtelid.TabIndex = 53;
            this.lblOtelid.Text = "Otel ID:";
            // 
            // txtOtelid
            // 
            this.txtOtelid.Location = new System.Drawing.Point(201, 49);
            this.txtOtelid.Multiline = true;
            this.txtOtelid.Name = "txtOtelid";
            this.txtOtelid.Size = new System.Drawing.Size(177, 29);
            this.txtOtelid.TabIndex = 52;
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(1092, 24);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(73, 48);
            this.btnGeri.TabIndex = 51;
            this.btnGeri.Text = "↶";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(804, 223);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(195, 59);
            this.btnGuncelle.TabIndex = 50;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbOdatipi
            // 
            this.cmbOdatipi.FormattingEnabled = true;
            this.cmbOdatipi.Location = new System.Drawing.Point(594, 194);
            this.cmbOdatipi.Name = "cmbOdatipi";
            this.cmbOdatipi.Size = new System.Drawing.Size(177, 36);
            this.cmbOdatipi.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Otel Ad:";
            // 
            // txtOtelpuani
            // 
            this.txtOtelpuani.Location = new System.Drawing.Point(594, 252);
            this.txtOtelpuani.Multiline = true;
            this.txtOtelpuani.Name = "txtOtelpuani";
            this.txtOtelpuani.Size = new System.Drawing.Size(177, 29);
            this.txtOtelpuani.TabIndex = 48;
            // 
            // txtOtelAd
            // 
            this.txtOtelAd.Location = new System.Drawing.Point(201, 95);
            this.txtOtelAd.Multiline = true;
            this.txtOtelAd.Name = "txtOtelAd";
            this.txtOtelAd.Size = new System.Drawing.Size(177, 29);
            this.txtOtelAd.TabIndex = 30;
            // 
            // txtOdasayisi
            // 
            this.txtOdasayisi.Location = new System.Drawing.Point(594, 145);
            this.txtOdasayisi.Multiline = true;
            this.txtOdasayisi.Name = "txtOdasayisi";
            this.txtOdasayisi.Size = new System.Drawing.Size(177, 29);
            this.txtOdasayisi.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bulunduğu İl:";
            // 
            // txtYıldızsayisi
            // 
            this.txtYıldızsayisi.Location = new System.Drawing.Point(594, 95);
            this.txtYıldızsayisi.Multiline = true;
            this.txtYıldızsayisi.Name = "txtYıldızsayisi";
            this.txtYıldızsayisi.Size = new System.Drawing.Size(177, 29);
            this.txtYıldızsayisi.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Bulunduğu İlçe:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 29);
            this.label10.TabIndex = 45;
            this.label10.Text = "Otel Puanı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Adres:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 29);
            this.label9.TabIndex = 44;
            this.label9.Text = "Oda Tipi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 43;
            this.label8.Text = "Oda Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "E-posta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Yıldız Sayısı:";
            // 
            // txtBulil
            // 
            this.txtBulil.Location = new System.Drawing.Point(201, 145);
            this.txtBulil.Multiline = true;
            this.txtBulil.Name = "txtBulil";
            this.txtBulil.Size = new System.Drawing.Size(177, 29);
            this.txtBulil.TabIndex = 37;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(594, 49);
            this.txtEposta.Multiline = true;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(177, 29);
            this.txtEposta.TabIndex = 41;
            // 
            // txtBulilce
            // 
            this.txtBulilce.Location = new System.Drawing.Point(201, 194);
            this.txtBulilce.Multiline = true;
            this.txtBulilce.Name = "txtBulilce";
            this.txtBulilce.Size = new System.Drawing.Size(177, 29);
            this.txtBulilce.TabIndex = 38;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(201, 303);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(177, 29);
            this.txtTelefon.TabIndex = 40;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(201, 249);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(177, 29);
            this.txtAdres.TabIndex = 39;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1203, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otel Listesi";
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
            this.telefonDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.yıldızsayisiDataGridViewTextBoxColumn,
            this.odasayisiDataGridViewTextBoxColumn,
            this.odatipiDataGridViewTextBoxColumn,
            this.otelPuaniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOtelBilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // otelidDataGridViewTextBoxColumn
            // 
            this.otelidDataGridViewTextBoxColumn.DataPropertyName = "Otelid";
            this.otelidDataGridViewTextBoxColumn.HeaderText = "Otelid";
            this.otelidDataGridViewTextBoxColumn.Name = "otelidDataGridViewTextBoxColumn";
            this.otelidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "Eposta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // yıldızsayisiDataGridViewTextBoxColumn
            // 
            this.yıldızsayisiDataGridViewTextBoxColumn.DataPropertyName = "Yıldızsayisi";
            this.yıldızsayisiDataGridViewTextBoxColumn.HeaderText = "Yıldızsayisi";
            this.yıldızsayisiDataGridViewTextBoxColumn.Name = "yıldızsayisiDataGridViewTextBoxColumn";
            // 
            // odasayisiDataGridViewTextBoxColumn
            // 
            this.odasayisiDataGridViewTextBoxColumn.DataPropertyName = "Odasayisi";
            this.odasayisiDataGridViewTextBoxColumn.HeaderText = "Odasayisi";
            this.odasayisiDataGridViewTextBoxColumn.Name = "odasayisiDataGridViewTextBoxColumn";
            // 
            // odatipiDataGridViewTextBoxColumn
            // 
            this.odatipiDataGridViewTextBoxColumn.DataPropertyName = "Odatipi";
            this.odatipiDataGridViewTextBoxColumn.HeaderText = "Odatipi";
            this.odatipiDataGridViewTextBoxColumn.Name = "odatipiDataGridViewTextBoxColumn";
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
            this.tblOtelBilgiBindingSource.DataSource = this.otelVeriTabanıDataSet2;
            // 
            // otelVeriTabanıDataSet2
            // 
            this.otelVeriTabanıDataSet2.DataSetName = "OtelVeriTabanıDataSet2";
            this.otelVeriTabanıDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_OtelBilgiTableAdapter
            // 
            this.tbl_OtelBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOtelGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1227, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOtelGuncelleme";
            this.Text = "FrmOtelGuncelleme";
            this.Load += new System.EventHandler(this.FrmOtelGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOtelBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbOdatipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOtelpuani;
        private System.Windows.Forms.TextBox txtOtelAd;
        private System.Windows.Forms.TextBox txtOdasayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYıldızsayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBulil;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtBulilce;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtelVeriTabanıDataSet2 otelVeriTabanıDataSet2;
        private System.Windows.Forms.BindingSource tblOtelBilgiBindingSource;
        private OtelVeriTabanıDataSet2TableAdapters.Tbl_OtelBilgiTableAdapter tbl_OtelBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulunduguilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulunduguilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yıldızsayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odasayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odatipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelPuaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblOtelid;
        private System.Windows.Forms.TextBox txtOtelid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}