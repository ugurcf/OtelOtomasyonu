namespace OtelProjev1
{
    partial class FrmOtelSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtelSilme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.otelVeriTabanıDataSet3 = new OtelProjev1.OtelVeriTabanıDataSet3();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.tbl_OtelBilgiTableAdapter = new OtelProjev1.OtelVeriTabanıDataSet3TableAdapters.Tbl_OtelBilgiTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOtelBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oteller";
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
            this.dataGridView1.Size = new System.Drawing.Size(860, 313);
            this.dataGridView1.TabIndex = 0;
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
            this.tblOtelBilgiBindingSource.DataSource = this.otelVeriTabanıDataSet3;
            // 
            // otelVeriTabanıDataSet3
            // 
            this.otelVeriTabanıDataSet3.DataSetName = "OtelVeriTabanıDataSet3";
            this.otelVeriTabanıDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(342, 179);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(212, 89);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(768, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(107, 73);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "↶";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // tbl_OtelBilgiTableAdapter
            // 
            this.tbl_OtelBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOtelSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(894, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOtelSilme";
            this.Text = "FrmOtelSilme";
            this.Load += new System.EventHandler(this.FrmOtelSilme_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOtelBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
        private OtelVeriTabanıDataSet3 otelVeriTabanıDataSet3;
        private System.Windows.Forms.BindingSource tblOtelBilgiBindingSource;
        private OtelVeriTabanıDataSet3TableAdapters.Tbl_OtelBilgiTableAdapter tbl_OtelBilgiTableAdapter;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}