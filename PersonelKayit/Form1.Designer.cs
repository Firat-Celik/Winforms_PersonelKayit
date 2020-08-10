namespace PersonelKayit
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_resimekle = new System.Windows.Forms.Button();
            this.pic_resim = new System.Windows.Forms.PictureBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_kisilistesi = new System.Windows.Forms.ComboBox();
            this.txt_dg_soyisim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_dg_resim = new System.Windows.Forms.PictureBox();
            this.txt_dg_isim = new System.Windows.Forms.TextBox();
            this.txt_dg_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dg_eposta = new System.Windows.Forms.TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_resim)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dg_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.btn_resimekle);
            this.groupBox1.Controls.Add(this.pic_resim);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_eposta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_soyisim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_isim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt EKLE";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(38, 231);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(197, 23);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_resimekle
            // 
            this.btn_resimekle.Location = new System.Drawing.Point(256, 231);
            this.btn_resimekle.Name = "btn_resimekle";
            this.btn_resimekle.Size = new System.Drawing.Size(130, 23);
            this.btn_resimekle.TabIndex = 3;
            this.btn_resimekle.Text = "Resim EKLE";
            this.btn_resimekle.UseVisualStyleBackColor = true;
            this.btn_resimekle.Click += new System.EventHandler(this.btn_resimekle_Click);
            // 
            // pic_resim
            // 
            this.pic_resim.Location = new System.Drawing.Point(256, 58);
            this.pic_resim.Name = "pic_resim";
            this.pic_resim.Size = new System.Drawing.Size(130, 167);
            this.pic_resim.TabIndex = 2;
            this.pic_resim.TabStop = false;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(78, 169);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(157, 20);
            this.txt_tel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tel";
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(78, 143);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(157, 20);
            this.txt_eposta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eposta";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(78, 117);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(157, 20);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(78, 91);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(157, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_kisilistesi);
            this.groupBox2.Controls.Add(this.txt_dg_soyisim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pic_dg_resim);
            this.groupBox2.Controls.Add(this.txt_dg_isim);
            this.groupBox2.Controls.Add(this.txt_dg_tel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_dg_eposta);
            this.groupBox2.Location = new System.Drawing.Point(440, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 277);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Görüntüle";
            // 
            // cmb_kisilistesi
            // 
            this.cmb_kisilistesi.FormattingEnabled = true;
            this.cmb_kisilistesi.Location = new System.Drawing.Point(6, 19);
            this.cmb_kisilistesi.Name = "cmb_kisilistesi";
            this.cmb_kisilistesi.Size = new System.Drawing.Size(409, 21);
            this.cmb_kisilistesi.TabIndex = 4;
            this.cmb_kisilistesi.SelectedIndexChanged += new System.EventHandler(this.cmb_kisilistesi_SelectedIndexChanged);
            // 
            // txt_dg_soyisim
            // 
            this.txt_dg_soyisim.Location = new System.Drawing.Point(80, 117);
            this.txt_dg_soyisim.Name = "txt_dg_soyisim";
            this.txt_dg_soyisim.Size = new System.Drawing.Size(157, 20);
            this.txt_dg_soyisim.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "İsim";
            // 
            // pic_dg_resim
            // 
            this.pic_dg_resim.Location = new System.Drawing.Point(258, 58);
            this.pic_dg_resim.Name = "pic_dg_resim";
            this.pic_dg_resim.Size = new System.Drawing.Size(130, 167);
            this.pic_dg_resim.TabIndex = 2;
            this.pic_dg_resim.TabStop = false;
            // 
            // txt_dg_isim
            // 
            this.txt_dg_isim.Location = new System.Drawing.Point(80, 91);
            this.txt_dg_isim.Name = "txt_dg_isim";
            this.txt_dg_isim.Size = new System.Drawing.Size(157, 20);
            this.txt_dg_isim.TabIndex = 1;
            // 
            // txt_dg_tel
            // 
            this.txt_dg_tel.Location = new System.Drawing.Point(80, 169);
            this.txt_dg_tel.Name = "txt_dg_tel";
            this.txt_dg_tel.Size = new System.Drawing.Size(157, 20);
            this.txt_dg_tel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Soyisim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Eposta";
            // 
            // txt_dg_eposta
            // 
            this.txt_dg_eposta.Location = new System.Drawing.Point(80, 143);
            this.txt_dg_eposta.Name = "txt_dg_eposta";
            this.txt_dg_eposta.Size = new System.Drawing.Size(157, 20);
            this.txt_dg_eposta.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Personel Kayıt Ekranı -Fırat ÇELİK-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_resim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dg_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_resimekle;
        private System.Windows.Forms.PictureBox pic_resim;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_kisilistesi;
        private System.Windows.Forms.TextBox txt_dg_soyisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_dg_resim;
        private System.Windows.Forms.TextBox txt_dg_isim;
        private System.Windows.Forms.TextBox txt_dg_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dg_eposta;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

