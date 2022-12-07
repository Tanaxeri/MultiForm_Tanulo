namespace MultiForm_Tanulo
{
    partial class TanuloFormDelete
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
            this.TorolJegy = new System.Windows.Forms.NumericUpDown();
            this.TorolJelleg = new System.Windows.Forms.TextBox();
            this.TorolDatum = new System.Windows.Forms.DateTimePicker();
            this.TorolTantargy = new System.Windows.Forms.TextBox();
            this.TorolNev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TorolesButton = new System.Windows.Forms.Button();
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TorolJegy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(463, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanuló adatainak törlése";
            // 
            // TorolJegy
            // 
            this.TorolJegy.Location = new System.Drawing.Point(474, 528);
            this.TorolJegy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TorolJegy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TorolJegy.Name = "TorolJegy";
            this.TorolJegy.Size = new System.Drawing.Size(33, 26);
            this.TorolJegy.TabIndex = 20;
            this.TorolJegy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TorolJelleg
            // 
            this.TorolJelleg.Location = new System.Drawing.Point(485, 487);
            this.TorolJelleg.Name = "TorolJelleg";
            this.TorolJelleg.Size = new System.Drawing.Size(100, 26);
            this.TorolJelleg.TabIndex = 19;
            // 
            // TorolDatum
            // 
            this.TorolDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TorolDatum.Location = new System.Drawing.Point(489, 454);
            this.TorolDatum.Name = "TorolDatum";
            this.TorolDatum.Size = new System.Drawing.Size(123, 26);
            this.TorolDatum.TabIndex = 18;
            // 
            // TorolTantargy
            // 
            this.TorolTantargy.Location = new System.Drawing.Point(505, 418);
            this.TorolTantargy.Name = "TorolTantargy";
            this.TorolTantargy.Size = new System.Drawing.Size(117, 26);
            this.TorolTantargy.TabIndex = 17;
            // 
            // TorolNev
            // 
            this.TorolNev.Location = new System.Drawing.Point(473, 380);
            this.TorolNev.Name = "TorolNev";
            this.TorolNev.Size = new System.Drawing.Size(100, 26);
            this.TorolNev.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jegy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Jelleg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tantárgy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Név:";
            // 
            // TorolesButton
            // 
            this.TorolesButton.Location = new System.Drawing.Point(715, 548);
            this.TorolesButton.Name = "TorolesButton";
            this.TorolesButton.Size = new System.Drawing.Size(182, 61);
            this.TorolesButton.TabIndex = 21;
            this.TorolesButton.Text = "Törlés";
            this.TorolesButton.UseVisualStyleBackColor = true;
            this.TorolesButton.Click += new System.EventHandler(this.TorolesButton_Click);
            // 
            // DeleteID
            // 
            this.DeleteID.Location = new System.Drawing.Point(71, 31);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.ReadOnly = true;
            this.DeleteID.Size = new System.Drawing.Size(100, 26);
            this.DeleteID.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Id:";
            // 
            // TanuloFormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.DeleteID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TorolesButton);
            this.Controls.Add(this.TorolJegy);
            this.Controls.Add(this.TorolJelleg);
            this.Controls.Add(this.TorolDatum);
            this.Controls.Add(this.TorolTantargy);
            this.Controls.Add(this.TorolNev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TanuloFormDelete";
            this.Text = "TanuloFormDelete";
            this.Load += new System.EventHandler(this.TanuloFormDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TorolJegy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TorolJegy;
        private System.Windows.Forms.TextBox TorolJelleg;
        private System.Windows.Forms.DateTimePicker TorolDatum;
        private System.Windows.Forms.TextBox TorolTantargy;
        private System.Windows.Forms.TextBox TorolNev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TorolesButton;
        public System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.Label label7;
    }
}