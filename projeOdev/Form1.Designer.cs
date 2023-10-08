namespace projeOdev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKaydetToolStripMenuItem,
            this.muayeneEtToolStripMenuItem,
            this.reçeteRaporlarıToolStripMenuItem,
            this.muayeneListesiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaKaydetToolStripMenuItem
            // 
            this.hastaKaydetToolStripMenuItem.Name = "hastaKaydetToolStripMenuItem";
            this.hastaKaydetToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.hastaKaydetToolStripMenuItem.Text = "Hasta Kaydet";
            this.hastaKaydetToolStripMenuItem.Click += new System.EventHandler(this.hastaKaydetToolStripMenuItem_Click);
            // 
            // muayeneEtToolStripMenuItem
            // 
            this.muayeneEtToolStripMenuItem.Name = "muayeneEtToolStripMenuItem";
            this.muayeneEtToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.muayeneEtToolStripMenuItem.Text = "Muayene Et";
            this.muayeneEtToolStripMenuItem.Click += new System.EventHandler(this.muayeneEtToolStripMenuItem_Click);
            // 
            // reçeteRaporlarıToolStripMenuItem
            // 
            this.reçeteRaporlarıToolStripMenuItem.Name = "reçeteRaporlarıToolStripMenuItem";
            this.reçeteRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.reçeteRaporlarıToolStripMenuItem.Text = "Reçete Raporları";
            this.reçeteRaporlarıToolStripMenuItem.Click += new System.EventHandler(this.reçeteRaporlarıToolStripMenuItem_Click);
            // 
            // muayeneListesiToolStripMenuItem
            // 
            this.muayeneListesiToolStripMenuItem.Name = "muayeneListesiToolStripMenuItem";
            this.muayeneListesiToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.muayeneListesiToolStripMenuItem.Text = "Muayene Listesi";
            this.muayeneListesiToolStripMenuItem.Click += new System.EventHandler(this.muayeneListesiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 542);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Muayene Yönetim Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hastaKaydetToolStripMenuItem;
        private ToolStripMenuItem muayeneEtToolStripMenuItem;
        private ToolStripMenuItem reçeteRaporlarıToolStripMenuItem;
        private ToolStripMenuItem muayeneListesiToolStripMenuItem;
    }
}