namespace OtelProjev1
{
    partial class FrmOtelPuanVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtelPuanVer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPuanVer = new System.Windows.Forms.Button();
            this.lblOtelid = new System.Windows.Forms.Label();
            this.txtOtelPuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulunduguilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulunduguilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yıldızsayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelPuaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOtelBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelVeriTabanıDataSet8 = new OtelProjev1.OtelVeriTabanıDataSet8();
            this.tbl_OtelBilgiTableAdapter = new OtelProjev1.OtelVeriTabanıDataSet8TableAdapters.Tbl_OtelBilgiTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOtelBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnPuanVer);
            this.groupBox1.Controls.Add(this.lblOtelid);
            this.groupBox1.Controls.Add(this.txtOtelPuan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otele Puan Veriniz:";
            // 
            // btnPuanVer
            // 
            this.btnPuanVer.Location = new System.Drawing.Point(36, 129);
            this.btnPuanVer.Name = "btnPuanVer";
            this.btnPuanVer.Size = new System.Drawing.Size(229, 49);
            this.btnPuanVer.TabIndex = 46;
            this.btnPuanVer.Text = "Puan Ver";
            this.btnPuanVer.UseVisualStyleBackColor = true;
            this.btnPuanVer.Click += new System.EventHandler(this.btnPuanVer_Click);
            // 
            // lblOtelid
            // 
            this.lblOtelid.AutoSize = true;
            this.lblOtelid.Location = new System.Drawing.Point(143, 45);
            this.lblOtelid.Name = "lblOtelid";
            this.lblOtelid.Size = new System.Drawing.Size(0, 20);
            this.lblOtelid.TabIndex = 45;
            // 
            // txtOtelPuan
            // 
            this.txtOtelPuan.Location = new System.Drawing.Point(147, 79);
            this.txtOtelPuan.Multiline = true;
            this.txtOtelPuan.Name = "txtOtelPuan";
            this.txtOtelPuan.Size = new System.Drawing.Size(101, 30);
            this.txtOtelPuan.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Otel Puan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otel ID:";
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.Location = new System.Drawing.Point(748, 31);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(109, 65);
            this.btnGeriDön.TabIndex = 1;
            this.btnGeriDön.Text = "Geri Dön";
            this.btnGeriDön.UseVisualStyleBackColor = true;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(22, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 281);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otel Tablosu";
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
            this.yıldızsayisiDataGridViewTextBoxColumn,
            this.otelPuaniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOtelBilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // otelidDataGridViewTextBoxColumn
            // 
            this.otelidDataGridViewTextBoxColumn.DataPropertyName = "Otelid";
            this.otelidDataGridViewTextBoxColumn.FillWeight = 40F;
            this.otelidDataGridViewTextBoxColumn.HeaderText = "Otelid";
            this.otelidDataGridViewTextBoxColumn.Name = "otelidDataGridViewTextBoxColumn";
            this.otelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.otelidDataGridViewTextBoxColumn.Width = 40;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.FillWeight = 60F;
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 50;
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
            // yıldızsayisiDataGridViewTextBoxColumn
            // 
            this.yıldızsayisiDataGridViewTextBoxColumn.DataPropertyName = "Yıldızsayisi";
            this.yıldızsayisiDataGridViewTextBoxColumn.HeaderText = "Yıldızsayisi";
            this.yıldızsayisiDataGridViewTextBoxColumn.Name = "yıldızsayisiDataGridViewTextBoxColumn";
            // 
            // otelPuaniDataGridViewTextBoxColumn
            // 
            this.otelPuaniDataGridViewTextBoxColumn.DataPropertyName = "OtelPuani";
            this.otelPuaniDataGridViewTextBoxColumn.FillWeight = 80F;
            this.otelPuaniDataGridViewTextBoxColumn.HeaderText = "OtelPuani";
            this.otelPuaniDataGridViewTextBoxColumn.Name = "otelPuaniDataGridViewTextBoxColumn";
            this.otelPuaniDataGridViewTextBoxColumn.Width = 80;
            // 
            // tblOtelBilgiBindingSource
            // 
            this.tblOtelBilgiBindingSource.DataMember = "Tbl_OtelBilgi";
            this.tblOtelBilgiBindingSource.DataSource = this.otelVeriTabanıDataSet8;
            // 
            // otelVeriTabanıDataSet8
            // 
            this.otelVeriTabanıDataSet8.DataSetName = "OtelVeriTabanıDataSet8";
            this.otelVeriTabanıDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_OtelBilgiTableAdapter
            // 
            this.tbl_OtelBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOtelPuanVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(886, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGeriDön);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOtelPuanVer";
            this.Text = "FrmOtelPuanVer";
            this.Load += new System.EventHandler(this.FrmOtelPuanVer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOtelBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelVeriTabanıDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOtelid;
        private System.Windows.Forms.TextBox txtOtelPuan;
        private System.Windows.Forms.Button btnGeriDön;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtelVeriTabanıDataSet8 otelVeriTabanıDataSet8;
        private System.Windows.Forms.BindingSource tblOtelBilgiBindingSource;
        private OtelVeriTabanıDataSet8TableAdapters.Tbl_OtelBilgiTableAdapter tbl_OtelBilgiTableAdapter;
        private System.Windows.Forms.Button btnPuanVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulunduguilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulunduguilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yıldızsayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelPuaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}