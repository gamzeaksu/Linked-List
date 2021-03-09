namespace VeriYapıları_Ödev_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rbSona = new System.Windows.Forms.RadioButton();
            this.rbSıraya = new System.Windows.Forms.RadioButton();
            this.rbBasa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.rbOrtalamayaGöre = new System.Windows.Forms.RadioButton();
            this.rbAdaGöre = new System.Windows.Forms.RadioButton();
            this.rbNumarayaGöre = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSıra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbGirilenSırayı = new System.Windows.Forms.RadioButton();
            this.rbGirilenNumarayı = new System.Windows.Forms.RadioButton();
            this.BtnSilme = new System.Windows.Forms.Button();
            this.rbTumunu = new System.Windows.Forms.RadioButton();
            this.rbSondakini = new System.Windows.Forms.RadioButton();
            this.rbBastakini = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnListeBoyu = new System.Windows.Forms.Button();
            this.lblListeBoyu = new System.Windows.Forms.Label();
            this.listBoxSıralı = new System.Windows.Forms.ListBox();
            this.btnListeBos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sıralı Liste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numara :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "AdSoyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ortalama :";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(120, 12);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(142, 27);
            this.txtNumara.TabIndex = 7;
            this.txtNumara.TextChanged += new System.EventHandler(this.TxtNumara_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(120, 63);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(142, 27);
            this.txtAdSoyad.TabIndex = 8;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(120, 114);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(142, 27);
            this.txtOrtalama.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.rbSona);
            this.groupBox1.Controls.Add(this.rbSıraya);
            this.groupBox1.Controls.Add(this.rbBasa);
            this.groupBox1.Location = new System.Drawing.Point(300, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 220);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme İşlemi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(59, 171);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 34);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // rbSona
            // 
            this.rbSona.AutoSize = true;
            this.rbSona.Location = new System.Drawing.Point(42, 128);
            this.rbSona.Name = "rbSona";
            this.rbSona.Size = new System.Drawing.Size(72, 24);
            this.rbSona.TabIndex = 2;
            this.rbSona.TabStop = true;
            this.rbSona.Text = "Sona";
            this.rbSona.UseVisualStyleBackColor = true;
            // 
            // rbSıraya
            // 
            this.rbSıraya.AutoSize = true;
            this.rbSıraya.Location = new System.Drawing.Point(42, 87);
            this.rbSıraya.Name = "rbSıraya";
            this.rbSıraya.Size = new System.Drawing.Size(83, 24);
            this.rbSıraya.TabIndex = 1;
            this.rbSıraya.TabStop = true;
            this.rbSıraya.Text = "Sıraya";
            this.rbSıraya.UseVisualStyleBackColor = true;
            // 
            // rbBasa
            // 
            this.rbBasa.AutoSize = true;
            this.rbBasa.Location = new System.Drawing.Point(42, 46);
            this.rbBasa.Name = "rbBasa";
            this.rbBasa.Size = new System.Drawing.Size(73, 24);
            this.rbBasa.TabIndex = 0;
            this.rbBasa.TabStop = true;
            this.rbBasa.Text = "Başa";
            this.rbBasa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Controls.Add(this.rbOrtalamayaGöre);
            this.groupBox2.Controls.Add(this.rbAdaGöre);
            this.groupBox2.Controls.Add(this.rbNumarayaGöre);
            this.groupBox2.Location = new System.Drawing.Point(300, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 220);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listeme İşlemi";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(59, 171);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(109, 34);
            this.BtnListele.TabIndex = 3;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click_1);
            // 
            // rbOrtalamayaGöre
            // 
            this.rbOrtalamayaGöre.AutoSize = true;
            this.rbOrtalamayaGöre.Location = new System.Drawing.Point(42, 128);
            this.rbOrtalamayaGöre.Name = "rbOrtalamayaGöre";
            this.rbOrtalamayaGöre.Size = new System.Drawing.Size(159, 24);
            this.rbOrtalamayaGöre.TabIndex = 2;
            this.rbOrtalamayaGöre.TabStop = true;
            this.rbOrtalamayaGöre.Text = "Ortalamaya öre";
            this.rbOrtalamayaGöre.UseVisualStyleBackColor = true;
            // 
            // rbAdaGöre
            // 
            this.rbAdaGöre.AutoSize = true;
            this.rbAdaGöre.Location = new System.Drawing.Point(42, 87);
            this.rbAdaGöre.Name = "rbAdaGöre";
            this.rbAdaGöre.Size = new System.Drawing.Size(176, 24);
            this.rbAdaGöre.TabIndex = 1;
            this.rbAdaGöre.TabStop = true;
            this.rbAdaGöre.Text = "Ada Soyada Göre";
            this.rbAdaGöre.UseVisualStyleBackColor = true;
            // 
            // rbNumarayaGöre
            // 
            this.rbNumarayaGöre.AutoSize = true;
            this.rbNumarayaGöre.Location = new System.Drawing.Point(42, 46);
            this.rbNumarayaGöre.Name = "rbNumarayaGöre";
            this.rbNumarayaGöre.Size = new System.Drawing.Size(161, 24);
            this.rbNumarayaGöre.TabIndex = 0;
            this.rbNumarayaGöre.TabStop = true;
            this.rbNumarayaGöre.Text = "Numaraya Göre";
            this.rbNumarayaGöre.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSıra);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rbGirilenSırayı);
            this.groupBox3.Controls.Add(this.rbGirilenNumarayı);
            this.groupBox3.Controls.Add(this.BtnSilme);
            this.groupBox3.Controls.Add(this.rbTumunu);
            this.groupBox3.Controls.Add(this.rbSondakini);
            this.groupBox3.Controls.Add(this.rbBastakini);
            this.groupBox3.Location = new System.Drawing.Point(600, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 359);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Silme İşlemi";
            // 
            // txtSıra
            // 
            this.txtSıra.Location = new System.Drawing.Point(152, 256);
            this.txtSıra.Name = "txtSıra";
            this.txtSıra.Size = new System.Drawing.Size(88, 27);
            this.txtSıra.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numara/Sıra :";
            // 
            // rbGirilenSırayı
            // 
            this.rbGirilenSırayı.AutoSize = true;
            this.rbGirilenSırayı.Location = new System.Drawing.Point(59, 214);
            this.rbGirilenSırayı.Name = "rbGirilenSırayı";
            this.rbGirilenSırayı.Size = new System.Drawing.Size(140, 24);
            this.rbGirilenSırayı.TabIndex = 5;
            this.rbGirilenSırayı.TabStop = true;
            this.rbGirilenSırayı.Text = "Girilen Sırayı";
            this.rbGirilenSırayı.UseVisualStyleBackColor = true;
            // 
            // rbGirilenNumarayı
            // 
            this.rbGirilenNumarayı.AutoSize = true;
            this.rbGirilenNumarayı.Location = new System.Drawing.Point(59, 172);
            this.rbGirilenNumarayı.Name = "rbGirilenNumarayı";
            this.rbGirilenNumarayı.Size = new System.Drawing.Size(171, 24);
            this.rbGirilenNumarayı.TabIndex = 4;
            this.rbGirilenNumarayı.TabStop = true;
            this.rbGirilenNumarayı.Text = "Girilen Numarayı";
            this.rbGirilenNumarayı.UseVisualStyleBackColor = true;
            // 
            // BtnSilme
            // 
            this.BtnSilme.Location = new System.Drawing.Point(80, 306);
            this.BtnSilme.Name = "BtnSilme";
            this.BtnSilme.Size = new System.Drawing.Size(109, 34);
            this.BtnSilme.TabIndex = 3;
            this.BtnSilme.Text = "Silme";
            this.BtnSilme.UseVisualStyleBackColor = true;
            this.BtnSilme.Click += new System.EventHandler(this.BtnSilme_Click);
            // 
            // rbTumunu
            // 
            this.rbTumunu.AutoSize = true;
            this.rbTumunu.Location = new System.Drawing.Point(59, 130);
            this.rbTumunu.Name = "rbTumunu";
            this.rbTumunu.Size = new System.Drawing.Size(96, 24);
            this.rbTumunu.TabIndex = 2;
            this.rbTumunu.TabStop = true;
            this.rbTumunu.Text = "Tümünü";
            this.rbTumunu.UseVisualStyleBackColor = true;
            // 
            // rbSondakini
            // 
            this.rbSondakini.AutoSize = true;
            this.rbSondakini.Location = new System.Drawing.Point(59, 88);
            this.rbSondakini.Name = "rbSondakini";
            this.rbSondakini.Size = new System.Drawing.Size(111, 24);
            this.rbSondakini.TabIndex = 1;
            this.rbSondakini.TabStop = true;
            this.rbSondakini.Text = "Sondakini";
            this.rbSondakini.UseVisualStyleBackColor = true;
            // 
            // rbBastakini
            // 
            this.rbBastakini.AutoSize = true;
            this.rbBastakini.Location = new System.Drawing.Point(59, 46);
            this.rbBastakini.Name = "rbBastakini";
            this.rbBastakini.Size = new System.Drawing.Size(108, 24);
            this.rbBastakini.TabIndex = 0;
            this.rbBastakini.TabStop = true;
            this.rbBastakini.Text = "Baştakini";
            this.rbBastakini.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnListeBoyu);
            this.groupBox4.Controls.Add(this.lblListeBoyu);
            this.groupBox4.Location = new System.Drawing.Point(600, 461);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 144);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Liste Boyutu";
            // 
            // btnListeBoyu
            // 
            this.btnListeBoyu.Location = new System.Drawing.Point(53, 99);
            this.btnListeBoyu.Name = "btnListeBoyu";
            this.btnListeBoyu.Size = new System.Drawing.Size(169, 34);
            this.btnListeBoyu.TabIndex = 13;
            this.btnListeBoyu.Text = "Liste Boyutu";
            this.btnListeBoyu.UseVisualStyleBackColor = true;
            this.btnListeBoyu.Click += new System.EventHandler(this.BtnListeBoyu_Click);
            // 
            // lblListeBoyu
            // 
            this.lblListeBoyu.AutoSize = true;
            this.lblListeBoyu.Location = new System.Drawing.Point(75, 52);
            this.lblListeBoyu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListeBoyu.Name = "lblListeBoyu";
            this.lblListeBoyu.Size = new System.Drawing.Size(114, 20);
            this.lblListeBoyu.TabIndex = 14;
            this.lblListeBoyu.Text = "---------------";
            // 
            // listBoxSıralı
            // 
            this.listBoxSıralı.FormattingEnabled = true;
            this.listBoxSıralı.ItemHeight = 20;
            this.listBoxSıralı.Location = new System.Drawing.Point(13, 214);
            this.listBoxSıralı.Name = "listBoxSıralı";
            this.listBoxSıralı.Size = new System.Drawing.Size(249, 324);
            this.listBoxSıralı.TabIndex = 13;
            // 
            // btnListeBos
            // 
            this.btnListeBos.Location = new System.Drawing.Point(614, 19);
            this.btnListeBos.Name = "btnListeBos";
            this.btnListeBos.Size = new System.Drawing.Size(208, 43);
            this.btnListeBos.TabIndex = 13;
            this.btnListeBos.Text = "LİSTE BOŞ?";
            this.btnListeBos.UseVisualStyleBackColor = true;
            this.btnListeBos.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(296, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Lütfen sayı giriniz.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(54, 556);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 50);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gamze AKSU\r\n171180005";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(902, 647);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnListeBos);
            this.Controls.Add(this.listBoxSıralı);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rbSona;
        private System.Windows.Forms.RadioButton rbSıraya;
        private System.Windows.Forms.RadioButton rbBasa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.RadioButton rbOrtalamayaGöre;
        private System.Windows.Forms.RadioButton rbAdaGöre;
        private System.Windows.Forms.RadioButton rbNumarayaGöre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSıra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbGirilenSırayı;
        private System.Windows.Forms.RadioButton rbGirilenNumarayı;
        private System.Windows.Forms.Button BtnSilme;
        private System.Windows.Forms.RadioButton rbTumunu;
        private System.Windows.Forms.RadioButton rbSondakini;
        private System.Windows.Forms.RadioButton rbBastakini;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnListeBoyu;
        private System.Windows.Forms.ListBox listBoxSıralı;
        private System.Windows.Forms.Label lblListeBoyu;
        private System.Windows.Forms.Button btnListeBos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

