namespace Ma_Hoa_AES.GiaoDien_TrangChu
{
    partial class GiaoDien_TrangChu
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
            this.giaodienTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.Form1TrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.Form1Ceasar = new System.Windows.Forms.ToolStripMenuItem();
            this.Form1Trimethius = new System.Windows.Forms.ToolStripMenuItem();
            this.Form1Belasco = new System.Windows.Forms.ToolStripMenuItem();
            this.Form1Vignere = new System.Windows.Forms.ToolStripMenuItem();
            this.Form1Xor = new System.Windows.Forms.ToolStripMenuItem();
            this.thuậtToánCeasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaodienTrangChu,
            this.thuậtToánCeasarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1318, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giaodienTrangChu
            // 
            this.giaodienTrangChu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Form1TrangChu,
            this.Form1Ceasar,
            this.Form1Trimethius,
            this.Form1Belasco,
            this.Form1Vignere,
            this.Form1Xor});
            this.giaodienTrangChu.Name = "giaodienTrangChu";
            this.giaodienTrangChu.Size = new System.Drawing.Size(69, 20);
            this.giaodienTrangChu.Text = "Giao diện";
            // 
            // Form1TrangChu
            // 
            this.Form1TrangChu.Name = "Form1TrangChu";
            this.Form1TrangChu.Size = new System.Drawing.Size(189, 22);
            this.Form1TrangChu.Text = "Trang chủ";
            this.Form1TrangChu.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // Form1Ceasar
            // 
            this.Form1Ceasar.Name = "Form1Ceasar";
            this.Form1Ceasar.Size = new System.Drawing.Size(189, 22);
            this.Form1Ceasar.Text = "Thuật toán Ceasar";
            this.Form1Ceasar.Click += new System.EventHandler(this.thuậtToánCeasarToolStripMenuItem1_Click);
            // 
            // Form1Trimethius
            // 
            this.Form1Trimethius.Name = "Form1Trimethius";
            this.Form1Trimethius.Size = new System.Drawing.Size(189, 22);
            this.Form1Trimethius.Text = "Thuật toán Trimethius";
            this.Form1Trimethius.Click += new System.EventHandler(this.thuậtToánTrimethiusToolStripMenuItem_Click);
            // 
            // Form1Belasco
            // 
            this.Form1Belasco.Name = "Form1Belasco";
            this.Form1Belasco.Size = new System.Drawing.Size(189, 22);
            this.Form1Belasco.Text = "Thuật toán Belasco";
            this.Form1Belasco.Click += new System.EventHandler(this.Form1Belasco_Click);
            // 
            // Form1Vignere
            // 
            this.Form1Vignere.Name = "Form1Vignere";
            this.Form1Vignere.Size = new System.Drawing.Size(189, 22);
            this.Form1Vignere.Text = "Thuật toán Vignere";
            this.Form1Vignere.Click += new System.EventHandler(this.Form1Vignere_Click);
            // 
            // Form1Xor
            // 
            this.Form1Xor.Name = "Form1Xor";
            this.Form1Xor.Size = new System.Drawing.Size(189, 22);
            this.Form1Xor.Text = "Thuật toán Xor";
            this.Form1Xor.Click += new System.EventHandler(this.Form1Xor_Click);
            // 
            // thuậtToánCeasarToolStripMenuItem
            // 
            this.thuậtToánCeasarToolStripMenuItem.Name = "thuậtToánCeasarToolStripMenuItem";
            this.thuậtToánCeasarToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // GiaoDien_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 721);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GiaoDien_TrangChu";
            this.Text = "GiaoDien_TrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem giaodienTrangChu;
        private System.Windows.Forms.ToolStripMenuItem thuậtToánCeasarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Form1TrangChu;
        private System.Windows.Forms.ToolStripMenuItem Form1Ceasar;
        private System.Windows.Forms.ToolStripMenuItem Form1Trimethius;
        private System.Windows.Forms.ToolStripMenuItem Form1Belasco;
        private System.Windows.Forms.ToolStripMenuItem Form1Vignere;
        private System.Windows.Forms.ToolStripMenuItem Form1Xor;
    }
}