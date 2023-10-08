namespace projeOdev
{
    partial class Receteler
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
            this.dataRecete = new System.Windows.Forms.DataGridView();
            this.ReceteViewbyNo = new System.Windows.Forms.Button();
            this.mskdtxtboxHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceteViewbyTC = new System.Windows.Forms.Button();
            this.mskdtxtReceteNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceteViewAll = new System.Windows.Forms.Button();
            this.mskdtxtboxİlacNo = new System.Windows.Forms.MaskedTextBox();
            this.HastaViewbyIlac = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecete)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataRecete);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reçete Görüntüleme";
            // 
            // dataRecete
            // 
            this.dataRecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRecete.Location = new System.Drawing.Point(3, 23);
            this.dataRecete.Name = "dataRecete";
            this.dataRecete.RowHeadersWidth = 51;
            this.dataRecete.RowTemplate.Height = 29;
            this.dataRecete.Size = new System.Drawing.Size(1049, 224);
            this.dataRecete.TabIndex = 0;
            // 
            // ReceteViewbyNo
            // 
            this.ReceteViewbyNo.Location = new System.Drawing.Point(94, 100);
            this.ReceteViewbyNo.Name = "ReceteViewbyNo";
            this.ReceteViewbyNo.Size = new System.Drawing.Size(172, 56);
            this.ReceteViewbyNo.TabIndex = 1;
            this.ReceteViewbyNo.Text = "Hastanın Reçetesini Görüntüle";
            this.ReceteViewbyNo.UseVisualStyleBackColor = true;
            this.ReceteViewbyNo.Click += new System.EventHandler(this.ReceteViewbyNo_Click);
            // 
            // mskdtxtboxHastaTC
            // 
            this.mskdtxtboxHastaTC.Location = new System.Drawing.Point(185, 62);
            this.mskdtxtboxHastaTC.Mask = "00000000000";
            this.mskdtxtboxHastaTC.Name = "mskdtxtboxHastaTC";
            this.mskdtxtboxHastaTC.Size = new System.Drawing.Size(73, 27);
            this.mskdtxtboxHastaTC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Giriniz";
            // 
            // ReceteViewbyTC
            // 
            this.ReceteViewbyTC.Location = new System.Drawing.Point(97, 107);
            this.ReceteViewbyTC.Name = "ReceteViewbyTC";
            this.ReceteViewbyTC.Size = new System.Drawing.Size(172, 56);
            this.ReceteViewbyTC.TabIndex = 4;
            this.ReceteViewbyTC.Text = "Hastaya Ait Tüm Reçeteleri Görüntüle";
            this.ReceteViewbyTC.UseVisualStyleBackColor = true;
            this.ReceteViewbyTC.Click += new System.EventHandler(this.ReceteViewbyTC_Click);
            // 
            // mskdtxtReceteNo
            // 
            this.mskdtxtReceteNo.Location = new System.Drawing.Point(224, 55);
            this.mskdtxtReceteNo.Mask = "0000";
            this.mskdtxtReceteNo.Name = "mskdtxtReceteNo";
            this.mskdtxtReceteNo.Size = new System.Drawing.Size(42, 27);
            this.mskdtxtReceteNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reçete No Giriniz";
            // 
            // btnReceteViewAll
            // 
            this.btnReceteViewAll.Location = new System.Drawing.Point(437, 106);
            this.btnReceteViewAll.Name = "btnReceteViewAll";
            this.btnReceteViewAll.Size = new System.Drawing.Size(172, 56);
            this.btnReceteViewAll.TabIndex = 1;
            this.btnReceteViewAll.Text = "Tüm Reçeteleri Göster";
            this.btnReceteViewAll.UseVisualStyleBackColor = true;
            this.btnReceteViewAll.Click += new System.EventHandler(this.btnReceteViewAll_Click);
            // 
            // mskdtxtboxİlacNo
            // 
            this.mskdtxtboxİlacNo.Location = new System.Drawing.Point(514, 59);
            this.mskdtxtboxİlacNo.Mask = "0000";
            this.mskdtxtboxİlacNo.Name = "mskdtxtboxİlacNo";
            this.mskdtxtboxİlacNo.Size = new System.Drawing.Size(42, 27);
            this.mskdtxtboxİlacNo.TabIndex = 10;
            // 
            // HastaViewbyIlac
            // 
            this.HastaViewbyIlac.Location = new System.Drawing.Point(384, 119);
            this.HastaViewbyIlac.Name = "HastaViewbyIlac";
            this.HastaViewbyIlac.Size = new System.Drawing.Size(172, 56);
            this.HastaViewbyIlac.TabIndex = 8;
            this.HastaViewbyIlac.Text = "İlacın Yazıldığı Tüm Hastaları Göster";
            this.HastaViewbyIlac.UseVisualStyleBackColor = true;
            this.HastaViewbyIlac.Click += new System.EventHandler(this.HastaViewbyIlac_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "İlaç Barkod No Giriniz";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 268);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1075, 318);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1067, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hastaya Ait Reçeteler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(34, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(364, 262);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.mskdtxtReceteNo);
            this.tabPage4.Controls.Add(this.ReceteViewbyNo);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(356, 229);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Reçete No İle Arama";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.mskdtxtboxHastaTC);
            this.tabPage5.Controls.Add(this.ReceteViewbyTC);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(356, 229);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "TC İle Arama";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mskdtxtboxİlacNo);
            this.tabPage2.Controls.Add(this.HastaViewbyIlac);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1067, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bir İlacın Yazıldığı Hastalar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnReceteViewAll);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1067, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tüm Reçeteler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Receteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 598);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Receteler";
            this.Text = "Receteler";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRecete)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataRecete;
        private Button ReceteViewbyNo;
        private MaskedTextBox mskdtxtReceteNo;
        private Label label1;
        private Button btnReceteViewAll;
        private MaskedTextBox mskdtxtboxHastaTC;
        private Label label2;
        private Button ReceteViewbyTC;
        private MaskedTextBox mskdtxtboxİlacNo;
        private Button HastaViewbyIlac;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabPage tabPage5;
    }
}