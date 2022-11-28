namespace MultiForm_Tanulo
{
    partial class TanuloFormInsert
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
            this.InsertJegy = new System.Windows.Forms.NumericUpDown();
            this.InsertJelleg = new System.Windows.Forms.TextBox();
            this.InsertDatum = new System.Windows.Forms.DateTimePicker();
            this.InsertTantargy = new System.Windows.Forms.TextBox();
            this.InsertNev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HozzaadButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.InsertID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InsertJegy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(498, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új  tanuló adatainak hozzáadása";
            // 
            // InsertJegy
            // 
            this.InsertJegy.Location = new System.Drawing.Point(512, 551);
            this.InsertJegy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.InsertJegy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InsertJegy.Name = "InsertJegy";
            this.InsertJegy.Size = new System.Drawing.Size(33, 26);
            this.InsertJegy.TabIndex = 20;
            this.InsertJegy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InsertJelleg
            // 
            this.InsertJelleg.Location = new System.Drawing.Point(520, 510);
            this.InsertJelleg.Name = "InsertJelleg";
            this.InsertJelleg.Size = new System.Drawing.Size(100, 26);
            this.InsertJelleg.TabIndex = 19;
            // 
            // InsertDatum
            // 
            this.InsertDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InsertDatum.Location = new System.Drawing.Point(524, 477);
            this.InsertDatum.Name = "InsertDatum";
            this.InsertDatum.Size = new System.Drawing.Size(123, 26);
            this.InsertDatum.TabIndex = 18;
            // 
            // InsertTantargy
            // 
            this.InsertTantargy.Location = new System.Drawing.Point(540, 441);
            this.InsertTantargy.Name = "InsertTantargy";
            this.InsertTantargy.Size = new System.Drawing.Size(117, 26);
            this.InsertTantargy.TabIndex = 17;
            // 
            // InsertNev
            // 
            this.InsertNev.Location = new System.Drawing.Point(508, 403);
            this.InsertNev.Name = "InsertNev";
            this.InsertNev.Size = new System.Drawing.Size(100, 26);
            this.InsertNev.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jegy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Jelleg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tantárgy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Név:";
            // 
            // HozzaadButton
            // 
            this.HozzaadButton.Location = new System.Drawing.Point(795, 551);
            this.HozzaadButton.Name = "HozzaadButton";
            this.HozzaadButton.Size = new System.Drawing.Size(182, 61);
            this.HozzaadButton.TabIndex = 21;
            this.HozzaadButton.Text = "Hozzáadás";
            this.HozzaadButton.UseVisualStyleBackColor = true;
            this.HozzaadButton.Click += new System.EventHandler(this.HozzaadButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Id:";
            // 
            // InsertID
            // 
            this.InsertID.Location = new System.Drawing.Point(112, 42);
            this.InsertID.Name = "InsertID";
            this.InsertID.ReadOnly = true;
            this.InsertID.Size = new System.Drawing.Size(100, 26);
            this.InsertID.TabIndex = 23;
            // 
            // TanuloFormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.InsertID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HozzaadButton);
            this.Controls.Add(this.InsertJegy);
            this.Controls.Add(this.InsertJelleg);
            this.Controls.Add(this.InsertDatum);
            this.Controls.Add(this.InsertTantargy);
            this.Controls.Add(this.InsertNev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TanuloFormInsert";
            this.Text = "TanuloFormInsert";
            this.Load += new System.EventHandler(this.TanuloFormInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InsertJegy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HozzaadButton;
        public System.Windows.Forms.NumericUpDown InsertJegy;
        public System.Windows.Forms.TextBox InsertJelleg;
        public System.Windows.Forms.DateTimePicker InsertDatum;
        public System.Windows.Forms.TextBox InsertTantargy;
        public System.Windows.Forms.TextBox InsertNev;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox InsertID;
    }
}