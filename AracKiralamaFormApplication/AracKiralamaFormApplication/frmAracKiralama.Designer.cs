namespace AracKiralamaFormApplication
{
    partial class frmAracKiralama
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
            this.isteklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralanabilirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralanmışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isteklerToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.araçKiralamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // isteklerToolStripMenuItem
            // 
            this.isteklerToolStripMenuItem.Name = "isteklerToolStripMenuItem";
            this.isteklerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.isteklerToolStripMenuItem.Text = "İstekler";
            this.isteklerToolStripMenuItem.Click += new System.EventHandler(this.isteklerToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiralanabilirToolStripMenuItem,
            this.kiralanmışToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // kiralanabilirToolStripMenuItem
            // 
            this.kiralanabilirToolStripMenuItem.Name = "kiralanabilirToolStripMenuItem";
            this.kiralanabilirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kiralanabilirToolStripMenuItem.Text = "Kiralanabilir";
            this.kiralanabilirToolStripMenuItem.Click += new System.EventHandler(this.kiralanabilirToolStripMenuItem_Click);
            // 
            // kiralanmışToolStripMenuItem
            // 
            this.kiralanmışToolStripMenuItem.Name = "kiralanmışToolStripMenuItem";
            this.kiralanmışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kiralanmışToolStripMenuItem.Text = "Kiralanmış";
            this.kiralanmışToolStripMenuItem.Click += new System.EventHandler(this.kiralanmışToolStripMenuItem_Click);
            // 
            // araçKiralamaToolStripMenuItem
            // 
            this.araçKiralamaToolStripMenuItem.Name = "araçKiralamaToolStripMenuItem";
            this.araçKiralamaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.araçKiralamaToolStripMenuItem.Text = "Araç Kiralama";
            this.araçKiralamaToolStripMenuItem.Click += new System.EventHandler(this.araçKiralamaToolStripMenuItem_Click);
            // 
            // frmAracKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 424);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAracKiralama";
            this.Text = "Araç Kiralama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAracKiralama_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem isteklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralanabilirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralanmışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçKiralamaToolStripMenuItem;
    }
}

