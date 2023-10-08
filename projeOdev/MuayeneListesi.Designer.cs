namespace projeOdev
{
    partial class MuayeneListesi
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
            this.dataMuayeneler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMuayeneler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataMuayeneler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Muayene Listesi";
            // 
            // dataMuayeneler
            // 
            this.dataMuayeneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMuayeneler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMuayeneler.Location = new System.Drawing.Point(3, 23);
            this.dataMuayeneler.Name = "dataMuayeneler";
            this.dataMuayeneler.RowHeadersWidth = 51;
            this.dataMuayeneler.RowTemplate.Height = 29;
            this.dataMuayeneler.Size = new System.Drawing.Size(1081, 179);
            this.dataMuayeneler.TabIndex = 0;
            // 
            // MuayeneListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 565);
            this.Controls.Add(this.groupBox1);
            this.Name = "MuayeneListesi";
            this.Text = "MuayeneListesi";
            this.Load += new System.EventHandler(this.MuayeneListesi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMuayeneler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataMuayeneler;
    }
}