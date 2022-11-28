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
            this.label2 = new System.Windows.Forms.Label();
            this.NevText = new System.Windows.Forms.TextBox();
            this.JegyNum = new System.Windows.Forms.NumericUpDown();
            this.JellegText = new System.Windows.Forms.TextBox();
            this.DatumTime = new System.Windows.Forms.DateTimePicker();
            this.TantargyText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TanuloBox = new System.Windows.Forms.ListBox();
            this.NyitID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JegyNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(380, 254);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // NevText
            // 
            this.NevText.Location = new System.Drawing.Point(363, 320);
            this.NevText.Name = "NevText";
            this.NevText.Size = new System.Drawing.Size(187, 26);
            this.NevText.TabIndex = 3;
            // 
            // JegyNum
            // 
            this.JegyNum.Location = new System.Drawing.Point(359, 472);
            this.JegyNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.JegyNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.JegyNum.Name = "JegyNum";
            this.JegyNum.Size = new System.Drawing.Size(33, 26);
            this.JegyNum.TabIndex = 20;
            this.JegyNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JellegText
            // 
            this.JellegText.Location = new System.Drawing.Point(370, 431);
            this.JellegText.Name = "JellegText";
            this.JellegText.Size = new System.Drawing.Size(100, 26);
            this.JellegText.TabIndex = 19;
            // 
            // DatumTime
            // 
            this.DatumTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumTime.Location = new System.Drawing.Point(374, 398);
            this.DatumTime.Name = "DatumTime";
            this.DatumTime.Size = new System.Drawing.Size(123, 26);
            this.DatumTime.TabIndex = 18;
            // 
            // TantargyText
            // 
            this.TantargyText.Location = new System.Drawing.Point(390, 362);
            this.TantargyText.Name = "TantargyText";
            this.TantargyText.Size = new System.Drawing.Size(117, 26);
            this.TantargyText.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jegy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Jelleg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tantárgy:";
            // 
            // TanuloBox
            // 
            this.TanuloBox.FormattingEnabled = true;
            this.TanuloBox.ItemHeight = 19;
            this.TanuloBox.Location = new System.Drawing.Point(1039, 478);
            this.TanuloBox.Name = "TanuloBox";
            this.TanuloBox.Size = new System.Drawing.Size(120, 137);
            this.TanuloBox.TabIndex = 21;
            // 
            // NyitID
            // 
            this.NyitID.Location = new System.Drawing.Point(1059, 45);
            this.NyitID.Name = "NyitID";
            this.NyitID.ReadOnly = true;
            this.NyitID.Size = new System.Drawing.Size(100, 26);
            this.NyitID.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1025, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Id:";
            // 
            // NyitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.NyitID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TanuloBox);
            this.Controls.Add(this.JegyNum);
            this.Controls.Add(this.JellegText);
            this.Controls.Add(this.DatumTime);
            this.Controls.Add(this.TantargyText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NevText);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.JegyNum)).EndInit();
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
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NevText;
        private System.Windows.Forms.NumericUpDown JegyNum;
        private System.Windows.Forms.TextBox JellegText;
        private System.Windows.Forms.DateTimePicker DatumTime;
        private System.Windows.Forms.TextBox TantargyText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox TanuloBox;
        public System.Windows.Forms.TextBox NyitID;
        private System.Windows.Forms.Label label7;
    }
}

