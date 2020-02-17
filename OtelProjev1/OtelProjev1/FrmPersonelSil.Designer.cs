namespace OtelProjev1
{
    partial class FrmPersonelSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelSil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelVeriTabanıDataSet6 = new OtelProjev1.OtelVeriTabanıDataSet6();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new OtelProjev1.OtelVeriTabanıDataSet6TableAdapters.Tbl_PersonelTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(22, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Listesi";
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(897, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.FillWeight = 40F;
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 40;
            // 
            // pertcDataGridViewTextBoxColumn
            // 
            this.pertcDataGridViewTextBoxColumn.DataPropertyName = "Pertc";
            this.pertcDataGridViewTextBoxColumn.FillWeight = 40F;
            this.pertcDataGridViewTextBoxColumn.HeaderText = "Pertc";
            this.pertcDataGridViewTextBoxColumn.Name = "pertcDataGridViewTextBoxColumn";
            this.pertcDataGridViewTextBoxColumn.Width = 40;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.FillWeight = 60F;
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 60;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.FillWeight = 75F;
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 75;
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
            this.perAdresDataGridViewTextBoxColumn.FillWeight = 60F;
            this.perAdresDataGridViewTextBoxColumn.HeaderText = "PerAdres";
            this.perAdresDataGridViewTextBoxColumn.Name = "perAdresDataGridViewTextBoxColumn";
            this.perAdresDataGridViewTextBoxColumn.Width = 60;
            // 
            // perDepartmanDataGridViewTextBoxColumn
            // 
            this.perDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PerDepartman";
            this.perDepartmanDataGridViewTextBoxColumn.FillWeight = 75F;
            this.perDepartmanDataGridViewTextBoxColumn.HeaderText = "PerDepartman";
            this.perDepartmanDataGridViewTextBoxColumn.Name = "perDepartmanDataGridViewTextBoxColumn";
            this.perDepartmanDataGridViewTextBoxColumn.Width = 75;
            // 
            // perPozisyonDataGridViewTextBoxColumn
            // 
            this.perPozisyonDataGridViewTextBoxColumn.DataPropertyName = "PerPozisyon";
            this.perPozisyonDataGridViewTextBoxColumn.FillWeight = 80F;
            this.perPozisyonDataGridViewTextBoxColumn.HeaderText = "PerPozisyon";
            this.perPozisyonDataGridViewTextBoxColumn.Name = "perPozisyonDataGridViewTextBoxColumn";
            this.perPozisyonDataGridViewTextBoxColumn.Width = 80;
            // 
            // perPuanDataGridViewTextBoxColumn
            // 
            this.perPuanDataGridViewTextBoxColumn.DataPropertyName = "PerPuan";
            this.perPuanDataGridViewTextBoxColumn.FillWeight = 50F;
            this.perPuanDataGridViewTextBoxColumn.HeaderText = "PerPuan";
            this.perPuanDataGridViewTextBoxColumn.Name = "perPuanDataGridViewTextBoxColumn";
            this.perPuanDataGridViewTextBoxColumn.Width = 50;
            // 
            // calistigiOtelDataGridViewTextBoxColumn
            // 
            this.calistigiOtelDataGridViewTextBoxColumn.DataPropertyName = "CalistigiOtel";
            this.calistigiOtelDataGridViewTextBoxColumn.FillWeight = 90F;
            this.calistigiOtelDataGridViewTextBoxColumn.HeaderText = "CalistigiOtel";
            this.calistigiOtelDataGridViewTextBoxColumn.Name = "calistigiOtelDataGridViewTextBoxColumn";
            this.calistigiOtelDataGridViewTextBoxColumn.Width = 90;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.otelVeriTabanıDataSet6;
            // 
            // otelVeriTabanıDataSet6
            // 
            this.otelVeriTabanıDataSet6.DataSetName = "OtelVeriTabanıDataSet6";
            this.otelVeriTabanıDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Silme Ekranı";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(22, 72);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(147, 58);
            this.btnPersonelSil.TabIndex = 2;
            this.btnPersonelSil.Text = "Personel Kaydı Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(731, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(947, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPersonelSil";
            this.Text = "FrmPersonelSil";
            this.Load += new System.EventHandler(this.FrmPersonelSil_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private OtelVeriTabanıDataSet6 otelVeriTabanıDataSet6;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private OtelVeriTabanıDataSet6TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
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