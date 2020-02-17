namespace OtelProjev1
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnOtelsil = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnOtelKaydet = new System.Windows.Forms.Button();
            this.btnGiriseDon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetici Formu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.btnOtelsil);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.btnOtelKaydet);
            this.groupBox1.Location = new System.Drawing.Point(369, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 588);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici İşlemleri";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(19, 517);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(337, 48);
            this.button16.TabIndex = 7;
            this.button16.Text = "Personel Bilgisi Sil";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(19, 452);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(337, 48);
            this.button14.TabIndex = 9;
            this.button14.Text = "Personeli Puanlandır";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(19, 389);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(337, 48);
            this.button13.TabIndex = 8;
            this.button13.Text = "Personel Listeleme İşlemleri";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(19, 326);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(337, 48);
            this.button12.TabIndex = 7;
            this.button12.Text = "Personel Bilgisi Güncelle";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(19, 256);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(337, 48);
            this.btnPersonelEkle.TabIndex = 5;
            this.btnPersonelEkle.Text = "Personel Bilgisi Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnOtelsil
            // 
            this.btnOtelsil.Location = new System.Drawing.Point(19, 191);
            this.btnOtelsil.Name = "btnOtelsil";
            this.btnOtelsil.Size = new System.Drawing.Size(337, 48);
            this.btnOtelsil.TabIndex = 4;
            this.btnOtelsil.Text = "Otel Kaydı Sil";
            this.btnOtelsil.UseVisualStyleBackColor = true;
            this.btnOtelsil.Click += new System.EventHandler(this.btnOtelsil_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(19, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(337, 48);
            this.button9.TabIndex = 3;
            this.button9.Text = "Otel Bilgilerini Güncelle";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnOtelKaydet
            // 
            this.btnOtelKaydet.Location = new System.Drawing.Point(19, 56);
            this.btnOtelKaydet.Name = "btnOtelKaydet";
            this.btnOtelKaydet.Size = new System.Drawing.Size(337, 48);
            this.btnOtelKaydet.TabIndex = 2;
            this.btnOtelKaydet.Text = "Yeni Otel Kaydet";
            this.btnOtelKaydet.UseVisualStyleBackColor = true;
            this.btnOtelKaydet.Click += new System.EventHandler(this.btnOtelKaydet_Click);
            // 
            // btnGiriseDon
            // 
            this.btnGiriseDon.Location = new System.Drawing.Point(19, 82);
            this.btnGiriseDon.Name = "btnGiriseDon";
            this.btnGiriseDon.Size = new System.Drawing.Size(312, 69);
            this.btnGiriseDon.TabIndex = 5;
            this.btnGiriseDon.Text = "Kullanıcı Değiştir";
            this.btnGiriseDon.UseVisualStyleBackColor = true;
            this.btnGiriseDon.Click += new System.EventHandler(this.btnGiriseDon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 638);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiriseDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnOtelsil;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnOtelKaydet;
        private System.Windows.Forms.Button btnGiriseDon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

