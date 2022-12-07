namespace MultiForm_Tanulo
{
    partial class NyitoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanulokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tantargyakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanárokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TanuloBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(345, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanulók nyílvántartása";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanulokToolStripMenuItem,
            this.tantargyakToolStripMenuItem,
            this.tanárokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanulokToolStripMenuItem
            // 
            this.tanulokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.tanulokToolStripMenuItem.Name = "tanulokToolStripMenuItem";
            this.tanulokToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tanulokToolStripMenuItem.Text = "Tanulok";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // tantargyakToolStripMenuItem
            // 
            this.tantargyakToolStripMenuItem.Name = "tantargyakToolStripMenuItem";
            this.tantargyakToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.tantargyakToolStripMenuItem.Text = "Tantargyak";
            // 
            // tanárokToolStripMenuItem
            // 
            this.tanárokToolStripMenuItem.Name = "tanárokToolStripMenuItem";
            this.tanárokToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tanárokToolStripMenuItem.Text = "Tanárok";
            // 
            // TanuloBox
            // 
            this.TanuloBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TanuloBox.FormattingEnabled = true;
            this.TanuloBox.ItemHeight = 19;
            this.TanuloBox.Location = new System.Drawing.Point(0, 217);
            this.TanuloBox.Name = "TanuloBox";
            this.TanuloBox.Size = new System.Drawing.Size(1200, 441);
            this.TanuloBox.TabIndex = 21;
            // 
            // NyitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.TanuloBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NyitoForm";
            this.Text = "NyitoForm";
            this.Load += new System.EventHandler(this.NyitoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanulokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tantargyakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanárokToolStripMenuItem;
        public System.Windows.Forms.ListBox TanuloBox;
    }
}

