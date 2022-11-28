namespace MultiForm_Tanulo
{
    partial class TanuloFormUpdate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateNev = new System.Windows.Forms.TextBox();
            this.UpdateTantargy = new System.Windows.Forms.TextBox();
            this.UpdateDatum = new System.Windows.Forms.DateTimePicker();
            this.UpdateJelleg = new System.Windows.Forms.TextBox();
            this.UpdateJegy = new System.Windows.Forms.NumericUpDown();
            this.ModositButton = new System.Windows.Forms.Button();
            this.UpdateID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateJegy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(402, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanuló adatainak módosítása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tantárgy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dátum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jelleg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jegy:";
            // 
            // UpdateNev
            // 
            this.UpdateNev.Location = new System.Drawing.Point(396, 380);
            this.UpdateNev.Name = "UpdateNev";
            this.UpdateNev.Size = new System.Drawing.Size(100, 26);
            this.UpdateNev.TabIndex = 6;
            // 
            // UpdateTantargy
            // 
            this.UpdateTantargy.Location = new System.Drawing.Point(428, 418);
            this.UpdateTantargy.Name = "UpdateTantargy";
            this.UpdateTantargy.Size = new System.Drawing.Size(117, 26);
            this.UpdateTantargy.TabIndex = 7;
            // 
            // UpdateDatum
            // 
            this.UpdateDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UpdateDatum.Location = new System.Drawing.Point(412, 454);
            this.UpdateDatum.Name = "UpdateDatum";
            this.UpdateDatum.Size = new System.Drawing.Size(123, 26);
            this.UpdateDatum.TabIndex = 8;
            // 
            // UpdateJelleg
            // 
            this.UpdateJelleg.Location = new System.Drawing.Point(408, 487);
            this.UpdateJelleg.Name = "UpdateJelleg";
            this.UpdateJelleg.Size = new System.Drawing.Size(100, 26);
            this.UpdateJelleg.TabIndex = 9;
            // 
            // UpdateJegy
            // 
            this.UpdateJegy.Location = new System.Drawing.Point(397, 528);
            this.UpdateJegy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UpdateJegy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpdateJegy.Name = "UpdateJegy";
            this.UpdateJegy.Size = new System.Drawing.Size(33, 26);
            this.UpdateJegy.TabIndex = 10;
            this.UpdateJegy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ModositButton
            // 
            this.ModositButton.Location = new System.Drawing.Point(709, 561);
            this.ModositButton.Name = "ModositButton";
            this.ModositButton.Size = new System.Drawing.Size(182, 61);
            this.ModositButton.TabIndex = 11;
            this.ModositButton.Text = "Módosítás";
            this.ModositButton.UseVisualStyleBackColor = true;
            this.ModositButton.Click += new System.EventHandler(this.ModositButton_Click);
            // 
            // UpdateID
            // 
            this.UpdateID.Location = new System.Drawing.Point(71, 38);
            this.UpdateID.Name = "UpdateID";
            this.UpdateID.ReadOnly = true;
            this.UpdateID.Size = new System.Drawing.Size(100, 26);
            this.UpdateID.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Id:";
            // 
            // TanuloFormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.UpdateID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ModositButton);
            this.Controls.Add(this.UpdateJegy);
            this.Controls.Add(this.UpdateJelleg);
            this.Controls.Add(this.UpdateDatum);
            this.Controls.Add(this.UpdateTantargy);
            this.Controls.Add(this.UpdateNev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TanuloFormUpdate";
            this.Text = "TanuloFormUpdate";
            this.Load += new System.EventHandler(this.TanuloFormUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateJegy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UpdateNev;
        private System.Windows.Forms.TextBox UpdateTantargy;
        private System.Windows.Forms.DateTimePicker UpdateDatum;
        private System.Windows.Forms.TextBox UpdateJelleg;
        private System.Windows.Forms.NumericUpDown UpdateJegy;
        private System.Windows.Forms.Button ModositButton;
        public System.Windows.Forms.TextBox UpdateID;
        private System.Windows.Forms.Label label7;
    }
}