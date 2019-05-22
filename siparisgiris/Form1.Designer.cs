namespace siparisgiris
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişDüzeltmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            this.siparişİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişDüzeltmeToolStripMenuItem,
            this.yeniGirişToolStripMenuItem});
            this.siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            this.siparişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // girişDüzeltmeToolStripMenuItem
            // 
            this.girişDüzeltmeToolStripMenuItem.Name = "girişDüzeltmeToolStripMenuItem";
            this.girişDüzeltmeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.girişDüzeltmeToolStripMenuItem.Text = "Giriş Düzeltme İzleme";
            this.girişDüzeltmeToolStripMenuItem.Click += new System.EventHandler(this.girişDüzeltmeToolStripMenuItem_Click);
            // 
            // yeniGirişToolStripMenuItem
            // 
            this.yeniGirişToolStripMenuItem.Name = "yeniGirişToolStripMenuItem";
            this.yeniGirişToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.yeniGirişToolStripMenuItem.Text = "Yeni Giriş";
            this.yeniGirişToolStripMenuItem.Click += new System.EventHandler(this.yeniGirişToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(235, 101);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişDüzeltmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniGirişToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

