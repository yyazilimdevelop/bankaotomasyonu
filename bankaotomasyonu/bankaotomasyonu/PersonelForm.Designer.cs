
namespace bankaotomasyonu
{
    partial class PersonelForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeMusteri = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txMusteriAd = new System.Windows.Forms.TextBox();
            this.txMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txMusteriNo = new System.Windows.Forms.TextBox();
            this.txMusteriSifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMusteriKayit = new System.Windows.Forms.Button();
            this.radioBireysel = new System.Windows.Forms.RadioButton();
            this.radioTicari = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonHesapAc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txEkBakiye = new System.Windows.Forms.TextBox();
            this.txMusteriAcNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonHesapSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hesap Aç";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hesap Sil";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşteri Numarası:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimeMusteri
            // 
            this.dateTimeMusteri.Location = new System.Drawing.Point(221, 135);
            this.dateTimeMusteri.Name = "dateTimeMusteri";
            this.dateTimeMusteri.Size = new System.Drawing.Size(200, 22);
            this.dateTimeMusteri.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Şifre:";
            // 
            // txMusteriAd
            // 
            this.txMusteriAd.Location = new System.Drawing.Point(221, 55);
            this.txMusteriAd.Name = "txMusteriAd";
            this.txMusteriAd.Size = new System.Drawing.Size(200, 22);
            this.txMusteriAd.TabIndex = 6;
            // 
            // txMusteriSoyad
            // 
            this.txMusteriSoyad.Location = new System.Drawing.Point(221, 97);
            this.txMusteriSoyad.Name = "txMusteriSoyad";
            this.txMusteriSoyad.Size = new System.Drawing.Size(200, 22);
            this.txMusteriSoyad.TabIndex = 7;
            // 
            // txMusteriNo
            // 
            this.txMusteriNo.Location = new System.Drawing.Point(221, 176);
            this.txMusteriNo.Name = "txMusteriNo";
            this.txMusteriNo.Size = new System.Drawing.Size(200, 22);
            this.txMusteriNo.TabIndex = 8;
            // 
            // txMusteriSifre
            // 
            this.txMusteriSifre.Location = new System.Drawing.Point(221, 216);
            this.txMusteriSifre.Name = "txMusteriSifre";
            this.txMusteriSifre.Size = new System.Drawing.Size(200, 22);
            this.txMusteriSifre.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioTicari);
            this.groupBox1.Controls.Add(this.radioBireysel);
            this.groupBox1.Controls.Add(this.buttonMusteriKayit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txMusteriSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txMusteriNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txMusteriSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txMusteriAd);
            this.groupBox1.Controls.Add(this.dateTimeMusteri);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(157, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 355);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // buttonMusteriKayit
            // 
            this.buttonMusteriKayit.Location = new System.Drawing.Point(194, 302);
            this.buttonMusteriKayit.Name = "buttonMusteriKayit";
            this.buttonMusteriKayit.Size = new System.Drawing.Size(103, 35);
            this.buttonMusteriKayit.TabIndex = 10;
            this.buttonMusteriKayit.Text = "Ekle";
            this.buttonMusteriKayit.UseVisualStyleBackColor = true;
            // 
            // radioBireysel
            // 
            this.radioBireysel.AutoSize = true;
            this.radioBireysel.Location = new System.Drawing.Point(221, 257);
            this.radioBireysel.Name = "radioBireysel";
            this.radioBireysel.Size = new System.Drawing.Size(76, 21);
            this.radioBireysel.TabIndex = 11;
            this.radioBireysel.TabStop = true;
            this.radioBireysel.Text = "Bireysel";
            this.radioBireysel.UseVisualStyleBackColor = true;
            // 
            // radioTicari
            // 
            this.radioTicari.AutoSize = true;
            this.radioTicari.Location = new System.Drawing.Point(329, 257);
            this.radioTicari.Name = "radioTicari";
            this.radioTicari.Size = new System.Drawing.Size(61, 21);
            this.radioTicari.TabIndex = 12;
            this.radioTicari.TabStop = true;
            this.radioTicari.Text = "Ticari";
            this.radioTicari.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Müşteri Tipi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.buttonHesapAc);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txEkBakiye);
            this.groupBox3.Controls.Add(this.txMusteriAcNo);
            this.groupBox3.Location = new System.Drawing.Point(183, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 215);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hesap Açılış";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Müşteri Numarası:";
            // 
            // buttonHesapAc
            // 
            this.buttonHesapAc.Location = new System.Drawing.Point(157, 151);
            this.buttonHesapAc.Name = "buttonHesapAc";
            this.buttonHesapAc.Size = new System.Drawing.Size(99, 32);
            this.buttonHesapAc.TabIndex = 18;
            this.buttonHesapAc.Text = "Hesap Aç";
            this.buttonHesapAc.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ek Bakiye Miktarı:";
            // 
            // txEkBakiye
            // 
            this.txEkBakiye.Location = new System.Drawing.Point(203, 98);
            this.txEkBakiye.Name = "txEkBakiye";
            this.txEkBakiye.Size = new System.Drawing.Size(184, 22);
            this.txEkBakiye.TabIndex = 17;
            // 
            // txMusteriAcNo
            // 
            this.txMusteriAcNo.Location = new System.Drawing.Point(203, 54);
            this.txMusteriAcNo.Name = "txMusteriAcNo";
            this.txMusteriAcNo.Size = new System.Drawing.Size(184, 22);
            this.txMusteriAcNo.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonHesapSil);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(168, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 186);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Sil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hesap Numarası:";
            // 
            // buttonHesapSil
            // 
            this.buttonHesapSil.Location = new System.Drawing.Point(185, 134);
            this.buttonHesapSil.Name = "buttonHesapSil";
            this.buttonHesapSil.Size = new System.Drawing.Size(99, 32);
            this.buttonHesapSil.TabIndex = 18;
            this.buttonHesapSil.Text = "Hesap Sil";
            this.buttonHesapSil.UseVisualStyleBackColor = true;
            this.buttonHesapSil.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(22, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(448, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hesabın Silinebilmesi İçin Hesap Bakiyesi ve Ek Bakiyesi 0 Olmalıdır";
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelForm";
            this.Text = "PersonelForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeMusteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txMusteriSifre;
        private System.Windows.Forms.TextBox txMusteriNo;
        private System.Windows.Forms.TextBox txMusteriSoyad;
        private System.Windows.Forms.TextBox txMusteriAd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioTicari;
        private System.Windows.Forms.RadioButton radioBireysel;
        private System.Windows.Forms.Button buttonMusteriKayit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonHesapAc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txEkBakiye;
        private System.Windows.Forms.TextBox txMusteriAcNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonHesapSil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}