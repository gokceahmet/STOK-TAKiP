namespace AMP12A_1904_STOKTAKİPPROGRAMI.Resources.pagess
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTedarikci = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUrun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.grdUrunListesi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.Label();
            this.mskTxtMusteriTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TXT3 = new System.Windows.Forms.Label();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.lblPersonelAdSoyad = new System.Windows.Forms.Label();
            this.lblYetki = new System.Windows.Forms.Label();
            this.grdSatilacakUrunler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.urun_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.txt6 = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunListesi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilacakUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdUrunListesi);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 594);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN LİSTESİ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTedarikci,
            this.menuUrun,
            this.menuSatis,
            this.menuMusteri,
            this.menuPersonel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1457, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTedarikci
            // 
            this.menuTedarikci.Name = "menuTedarikci";
            this.menuTedarikci.Size = new System.Drawing.Size(128, 20);
            this.menuTedarikci.Text = "TEDARİKÇİ İŞLEMLER";
            // 
            // menuUrun
            // 
            this.menuUrun.Name = "menuUrun";
            this.menuUrun.Size = new System.Drawing.Size(108, 20);
            this.menuUrun.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // menuSatis
            // 
            this.menuSatis.Name = "menuSatis";
            this.menuSatis.Size = new System.Drawing.Size(107, 20);
            this.menuSatis.Text = "SATIŞ DETAYLARI";
            // 
            // menuMusteri
            // 
            this.menuMusteri.Name = "menuMusteri";
            this.menuMusteri.Size = new System.Drawing.Size(123, 20);
            this.menuMusteri.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // menuPersonel
            // 
            this.menuPersonel.Name = "menuPersonel";
            this.menuPersonel.Size = new System.Drawing.Size(132, 20);
            this.menuPersonel.Text = "PERSONEL İŞLEMLERİ";
            // 
            // grdUrunListesi
            // 
            this.grdUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUrunListesi.Location = new System.Drawing.Point(6, 19);
            this.grdUrunListesi.Name = "grdUrunListesi";
            this.grdUrunListesi.Size = new System.Drawing.Size(785, 569);
            this.grdUrunListesi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGenelToplam);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSatisYap);
            this.groupBox2.Controls.Add(this.txtNot);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.grdSatilacakUrunler);
            this.groupBox2.Controls.Add(this.btnMusteriSec);
            this.groupBox2.Controls.Add(this.mskTxtMusteriTelefon);
            this.groupBox2.Controls.Add(this.TXT3);
            this.groupBox2.Controls.Add(this.txtMusteriAdSoyad);
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Location = new System.Drawing.Point(815, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 594);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SATIŞ İŞLEMİ";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "clay-plus-sign-mathematics-blue-cute-graphic-kids.jpg");
            this.ımageList1.Images.SetKeyName(1, "pngtree-vector-plus-icon-png-image_1025536.jpg");
            this.ımageList1.Images.SetKeyName(2, "images.png");
            this.ımageList1.Images.SetKeyName(3, "5580015.png");
            this.ımageList1.Images.SetKeyName(4, "240_F_593409283_I4k3yom1SnaehxGL9sxSanHIasRpCf7S.jpg");
            this.ımageList1.Images.SetKeyName(5, "plus-button.png");
            this.ımageList1.Images.SetKeyName(6, "plus.png");
            this.ımageList1.Images.SetKeyName(7, "clay-plus-sign-mathematics-blue-cute-graphic-kids.jpg");
            this.ımageList1.Images.SetKeyName(8, "v793-ning-06.jpg");
            this.ımageList1.Images.SetKeyName(9, "images.jpg");
            this.ımageList1.Images.SetKeyName(10, "12640335.png");
            this.ımageList1.Images.SetKeyName(11, "4558759.png");
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Enabled = false;
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(266, 78);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(159, 20);
            this.txtMusteriAdSoyad.TabIndex = 28;
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2.Location = new System.Drawing.Point(204, 81);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(56, 13);
            this.txt2.TabIndex = 27;
            this.txt2.Text = "Müşteri :";
            // 
            // mskTxtMusteriTelefon
            // 
            this.mskTxtMusteriTelefon.Location = new System.Drawing.Point(266, 52);
            this.mskTxtMusteriTelefon.Mask = "(999) 000-0000";
            this.mskTxtMusteriTelefon.Name = "mskTxtMusteriTelefon";
            this.mskTxtMusteriTelefon.Size = new System.Drawing.Size(159, 20);
            this.mskTxtMusteriTelefon.TabIndex = 30;
            // 
            // TXT3
            // 
            this.TXT3.AutoSize = true;
            this.TXT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXT3.Location = new System.Drawing.Point(157, 55);
            this.TXT3.Name = "TXT3";
            this.TXT3.Size = new System.Drawing.Size(103, 13);
            this.TXT3.TabIndex = 29;
            this.TXT3.Text = "Müşteri Telefon :";
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriSec.ImageKey = "12640335.png";
            this.btnMusteriSec.ImageList = this.ımageList1;
            this.btnMusteriSec.Location = new System.Drawing.Point(431, 43);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(101, 37);
            this.btnMusteriSec.TabIndex = 31;
            this.btnMusteriSec.Text = "SEÇ";
            this.btnMusteriSec.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            // 
            // lblPersonelAdSoyad
            // 
            this.lblPersonelAdSoyad.AutoSize = true;
            this.lblPersonelAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelAdSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPersonelAdSoyad.Location = new System.Drawing.Point(1099, 24);
            this.lblPersonelAdSoyad.Name = "lblPersonelAdSoyad";
            this.lblPersonelAdSoyad.Size = new System.Drawing.Size(76, 13);
            this.lblPersonelAdSoyad.TabIndex = 32;
            this.lblPersonelAdSoyad.Text = "personel adı";
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetki.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYetki.Location = new System.Drawing.Point(1239, 24);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(34, 13);
            this.lblYetki.TabIndex = 33;
            this.lblYetki.Text = "yetki";
            // 
            // grdSatilacakUrunler
            // 
            this.grdSatilacakUrunler.AllowUserToAddRows = false;
            this.grdSatilacakUrunler.AllowUserToDeleteRows = false;
            this.grdSatilacakUrunler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdSatilacakUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilacakUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urun_kodu,
            this.urun_adi,
            this.miktar,
            this.birimfiyat,
            this.toplam});
            this.grdSatilacakUrunler.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.grdSatilacakUrunler.Location = new System.Drawing.Point(99, 174);
            this.grdSatilacakUrunler.Name = "grdSatilacakUrunler";
            this.grdSatilacakUrunler.Size = new System.Drawing.Size(514, 264);
            this.grdSatilacakUrunler.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(284, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "SATIŞ YAPILICAK ÜRÜNLER";
            // 
            // urun_kodu
            // 
            this.urun_kodu.HeaderText = "Kod";
            this.urun_kodu.Name = "urun_kodu";
            // 
            // urun_adi
            // 
            this.urun_adi.HeaderText = "Ürün Adı";
            this.urun_adi.Name = "urun_adi";
            // 
            // miktar
            // 
            this.miktar.HeaderText = "Miktar";
            this.miktar.Name = "miktar";
            // 
            // birimfiyat
            // 
            this.birimfiyat.HeaderText = "BirimFiyat";
            this.birimfiyat.Name = "birimfiyat";
            // 
            // toplam
            // 
            this.toplam.HeaderText = "Toplam";
            this.toplam.Name = "toplam";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.ImageKey = "plus-button.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(17, 249);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(76, 37);
            this.btnEkle.TabIndex = 34;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "240_F_593409283_I4k3yom1SnaehxGL9sxSanHIasRpCf7S.jpg";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(17, 307);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 37);
            this.btnSil.TabIndex = 35;
            this.btnSil.Text = "SİL";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(160, 444);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(453, 66);
            this.txtNot.TabIndex = 37;
            this.txtNot.Text = "";
            // 
            // txt6
            // 
            this.txt6.AutoSize = true;
            this.txt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt6.Location = new System.Drawing.Point(90, 472);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(64, 13);
            this.txt6.TabIndex = 36;
            this.txt6.Text = "Not Ekle :";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisYap.ImageKey = "4558759.png";
            this.btnSatisYap.ImageList = this.ımageList1;
            this.btnSatisYap.Location = new System.Drawing.Point(99, 531);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(134, 37);
            this.btnSatisYap.TabIndex = 38;
            this.btnSatisYap.Text = "SATIŞ YAP";
            this.btnSatisYap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Enabled = false;
            this.txtGenelToplam.Location = new System.Drawing.Point(528, 544);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(53, 20);
            this.txtGenelToplam.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(424, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Genel Toplam :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "₺";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 656);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblPersonelAdSoyad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnaSayfa";
            this.Text = "STOK TAKİP PROGRAMI";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunListesi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilacakUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTedarikci;
        private System.Windows.Forms.ToolStripMenuItem menuUrun;
        private System.Windows.Forms.ToolStripMenuItem menuSatis;
        private System.Windows.Forms.ToolStripMenuItem menuMusteri;
        private System.Windows.Forms.ToolStripMenuItem menuPersonel;
        private System.Windows.Forms.DataGridView grdUrunListesi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.MaskedTextBox mskTxtMusteriTelefon;
        private System.Windows.Forms.Label TXT3;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.DataGridView grdSatilacakUrunler;
        private System.Windows.Forms.Label lblPersonelAdSoyad;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Label txt6;
        private System.Windows.Forms.Label label5;
    }
}