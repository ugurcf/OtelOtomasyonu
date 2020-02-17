namespace OtelProjev1
{
    partial class FrmListelemeİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListelemeİslemleri));
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelVeriTabanıDataSet5 = new OtelProjev1.OtelVeriTabanıDataSet5();
            this.tbl_PersonelTableAdapter = new OtelProjev1.OtelVeriTabanıDataSet5TableAdapters.Tbl_PersonelTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pertcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perPozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perPuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calistigiOtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(15, 12);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(113, 79);
            this.btnGeriDon.TabIndex = 0;
            this.btnGeriDon.Text = "↶";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(15, 125);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(298, 89);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Departmana Göre Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 340);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Tablosu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.pertcDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perTelDataGridViewTextBoxColumn,
            this.perAdresDataGridViewTextBoxColumn,
            this.perDepartmanDataGridViewTextBoxColumn,
            this.perPozisyonDataGridViewTextBoxColumn,
            this.perPuanDataGridViewTextBoxColumn,
            this.calistigiOtelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.otelVeriTabanıDataSet5;
            // 
            // otelVeriTabanıDataSet5
            // 
            this.otelVeriTabanıDataSet5.DataSetName = "OtelVeriTabanıDataSet5";
            this.otelVeriTabanıDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(770, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 89);
            this.button1.TabIndex = 3;
            this.button1.Text = "Puana Göre Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.FillWeight = 50F;
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 50;
            // 
            // pertcDataGridViewTextBoxColumn
            // 
            this.pertcDataGridViewTextBoxColumn.DataPropertyName = "Pertc";
            this.pertcDataGridViewTextBoxColumn.FillWeight = 50F;
            this.pertcDataGridViewTextBoxColumn.HeaderText = "Pertc";
            this.pertcDataGridViewTextBoxColumn.Name = "pertcDataGridViewTextBoxColumn";
            this.pertcDataGridViewTextBoxColumn.Width = 50;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.FillWeight = 80F;
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 80;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.FillWeight = 80F;
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 80;
            // 
            // perTelDataGridViewTextBoxColumn
            // 
            this.perTelDataGridViewTextBoxColumn.DataPropertyName = "PerTel";
            this.perTelDataGridViewTextBoxColumn.FillWeight = 50F;
            this.perTelDataGridViewTextBoxColumn.HeaderText = "PerTel";
            this.perTelDataGridViewTextBoxColumn.Name = "perTelDataGridViewTextBoxColumn";
            this.perTelDataGridViewTextBoxColumn.Width = 50;
            // 
            // perAdresDataGridViewTextBoxColumn
            // 
            this.perAdresDataGridViewTextBoxColumn.DataPropertyName = "PerAdres";
            this.perAdresDataGridViewTextBoxColumn.FillWeight = 80F;
            this.perAdresDataGridViewTextBoxColumn.HeaderText = "PerAdres";
            this.perAdresDataGridViewTextBoxColumn.Name = "perAdresDataGridViewTextBoxColumn";
            this.perAdresDataGridViewTextBoxColumn.Width = 80;
            // 
            // perDepartmanDataGridViewTextBoxColumn
            // 
            this.perDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PerDepartman";
            this.perDepartmanDataGridViewTextBoxColumn.HeaderText = "PerDepartman";
            this.perDepartmanDataGridViewTextBoxColumn.Name = "perDepartmanDataGridViewTextBoxColumn";
            // 
            // perPozisyonDataGridViewTextBoxColumn
            // 
            this.perPozisyonDataGridViewTextBoxColumn.DataPropertyName = "PerPozisyon";
            this.perPozisyonDataGridViewTextBoxColumn.HeaderText = "PerPozisyon";
            this.perPozisyonDataGridViewTextBoxColumn.Name = "perPozisyonDataGridViewTextBoxColumn";
            // 
            // perPuanDataGridViewTextBoxColumn
            // 
            this.perPuanDataGridViewTextBoxColumn.DataPropertyName = "PerPuan";
            this.perPuanDataGridViewTextBoxColumn.FillWeight = 70F;
            this.perPuanDataGridViewTextBoxColumn.HeaderText = "PerPuan";
            this.perPuanDataGridViewTextBoxColumn.Name = "perPuanDataGridViewTextBoxColumn";
            this.perPuanDataGridViewTextBoxColumn.Width = 70;
            // 
            // calistigiOtelDataGridViewTextBoxColumn
            // 
            this.calistigiOtelDataGridViewTextBoxColumn.DataPropertyName = "CalistigiOtel";
            this.calistigiOtelDataGridViewTextBoxColumn.FillWeight = 80F;
            this.calistigiOtelDataGridViewTextBoxColumn.HeaderText = "CalistigiOtel";
            this.calistigiOtelDataGridViewTextBoxColumn.Name = "calistigiOtelDataGridViewTextBoxColumn";
            this.calistigiOtelDataGridViewTextBoxColumn.Width = 80;
            // 
            // FrmListelemeİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1112, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGeriDon);
            this.Name = "FrmListelemeİslemleri";
            this.Text = "FrmListeleme";
            this.Load += new System.EventHandler(this.FrmDepartmanaGoreListele_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtelVeriTabanıDataSet5 otelVeriTabanıDataSet5;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private OtelVeriTabanıDataSet5TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pertcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDepartmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perPozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perPuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calistigiOtelDataGridViewTextBoxColumn;
    }
}