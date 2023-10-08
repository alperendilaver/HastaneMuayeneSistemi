namespace projeOdev
{
    partial class HastaKaydet
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
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBekar = new System.Windows.Forms.RadioButton();
            this.radioEvli = new System.Windows.Forms.RadioButton();
            this.dateDogum = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxDogumYeri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxAd = new System.Windows.Forms.TextBox();
            this.mskdtxtboxTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHastaEkle.ForeColor = System.Drawing.Color.White;
            this.btnHastaEkle.Location = new System.Drawing.Point(367, 348);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(162, 81);
            this.btnHastaEkle.TabIndex = 0;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBekar);
            this.groupBox1.Controls.Add(this.radioEvli);
            this.groupBox1.Controls.Add(this.dateDogum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtboxAdres);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtboxDogumYeri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtboxSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtboxAd);
            this.groupBox1.Controls.Add(this.mskdtxtboxTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(202, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eklenecek Hasta Bilgileri";
            // 
            // radioBekar
            // 
            this.radioBekar.AutoSize = true;
            this.radioBekar.Location = new System.Drawing.Point(214, 191);
            this.radioBekar.Name = "radioBekar";
            this.radioBekar.Size = new System.Drawing.Size(67, 24);
            this.radioBekar.TabIndex = 19;
            this.radioBekar.Text = "Bekar";
            this.radioBekar.UseVisualStyleBackColor = true;
            // 
            // radioEvli
            // 
            this.radioEvli.AutoSize = true;
            this.radioEvli.Location = new System.Drawing.Point(155, 191);
            this.radioEvli.Name = "radioEvli";
            this.radioEvli.Size = new System.Drawing.Size(53, 24);
            this.radioEvli.TabIndex = 18;
            this.radioEvli.Text = "Evli";
            this.radioEvli.UseVisualStyleBackColor = true;
            // 
            // dateDogum
            // 
            this.dateDogum.Location = new System.Drawing.Point(151, 158);
            this.dateDogum.Name = "dateDogum";
            this.dateDogum.Size = new System.Drawing.Size(140, 27);
            this.dateDogum.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(66, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Adres:";
            // 
            // txtboxAdres
            // 
            this.txtboxAdres.Location = new System.Drawing.Point(136, 228);
            this.txtboxAdres.Multiline = true;
            this.txtboxAdres.Name = "txtboxAdres";
            this.txtboxAdres.Size = new System.Drawing.Size(286, 83);
            this.txtboxAdres.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Medeni Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğum Yeri:";
            // 
            // txtboxDogumYeri
            // 
            this.txtboxDogumYeri.Location = new System.Drawing.Point(151, 125);
            this.txtboxDogumYeri.Name = "txtboxDogumYeri";
            this.txtboxDogumYeri.Size = new System.Drawing.Size(125, 27);
            this.txtboxDogumYeri.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta Soyadı:";
            // 
            // txtboxSoyad
            // 
            this.txtboxSoyad.Location = new System.Drawing.Point(151, 92);
            this.txtboxSoyad.Name = "txtboxSoyad";
            this.txtboxSoyad.Size = new System.Drawing.Size(125, 27);
            this.txtboxSoyad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta Adı:";
            // 
            // txtboxAd
            // 
            this.txtboxAd.Location = new System.Drawing.Point(151, 59);
            this.txtboxAd.Name = "txtboxAd";
            this.txtboxAd.Size = new System.Drawing.Size(125, 27);
            this.txtboxAd.TabIndex = 3;
            // 
            // mskdtxtboxTC
            // 
            this.mskdtxtboxTC.Location = new System.Drawing.Point(151, 26);
            this.mskdtxtboxTC.Mask = "00000000000";
            this.mskdtxtboxTC.Name = "mskdtxtboxTC";
            this.mskdtxtboxTC.Size = new System.Drawing.Size(89, 27);
            this.mskdtxtboxTC.TabIndex = 2;
            this.mskdtxtboxTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta TC:";
            // 
            // HastaKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 508);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "HastaKaydet";
            this.Text = "HastaKaydet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHastaEkle;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox txtboxAdres;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtboxDogumYeri;
        private Label label3;
        private TextBox txtboxSoyad;
        private Label label2;
        private TextBox txtboxAd;
        private MaskedTextBox mskdtxtboxTC;
        private Label label1;
        private DateTimePicker dateDogum;
        private RadioButton radioEvli;
        private RadioButton radioBekar;
    }
}