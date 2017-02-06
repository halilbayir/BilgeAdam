namespace Arabax
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numaricYakitDepoKapasite = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NumaricOrtTuketim100km = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericYakitFiyati = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMes = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTopUcret = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricYakitDepoKapasite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumaricOrtTuketim100km)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYakitFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblTopUcret);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numMes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericYakitFiyati);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NumaricOrtTuketim100km);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numaricYakitDepoKapasite);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 294);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yakıt Deposu Kapasitesi";
            // 
            // numaricYakitDepoKapasite
            // 
            this.numaricYakitDepoKapasite.DecimalPlaces = 2;
            this.numaricYakitDepoKapasite.Location = new System.Drawing.Point(9, 59);
            this.numaricYakitDepoKapasite.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numaricYakitDepoKapasite.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numaricYakitDepoKapasite.Name = "numaricYakitDepoKapasite";
            this.numaricYakitDepoKapasite.Size = new System.Drawing.Size(141, 20);
            this.numaricYakitDepoKapasite.TabIndex = 2;
            this.numaricYakitDepoKapasite.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "100 km\'de Kaç Lt Tüketiyor?";
            // 
            // NumaricOrtTuketim100km
            // 
            this.NumaricOrtTuketim100km.DecimalPlaces = 2;
            this.NumaricOrtTuketim100km.Location = new System.Drawing.Point(9, 122);
            this.NumaricOrtTuketim100km.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumaricOrtTuketim100km.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumaricOrtTuketim100km.Name = "NumaricOrtTuketim100km";
            this.NumaricOrtTuketim100km.Size = new System.Drawing.Size(141, 20);
            this.NumaricOrtTuketim100km.TabIndex = 4;
            this.NumaricOrtTuketim100km.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yakit Fiyati ₺";
            // 
            // numericYakitFiyati
            // 
            this.numericYakitFiyati.Location = new System.Drawing.Point(9, 178);
            this.numericYakitFiyati.Name = "numericYakitFiyati";
            this.numericYakitFiyati.Size = new System.Drawing.Size(141, 20);
            this.numericYakitFiyati.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mesafe";
            // 
            // numMes
            // 
            this.numMes.Location = new System.Drawing.Point(9, 252);
            this.numMes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMes.Name = "numMes";
            this.numMes.Size = new System.Drawing.Size(141, 20);
            this.numMes.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(25, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(156, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "KM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTopUcret
            // 
            this.lblTopUcret.AutoSize = true;
            this.lblTopUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopUcret.Location = new System.Drawing.Point(22, 276);
            this.lblTopUcret.Name = "lblTopUcret";
            this.lblTopUcret.Size = new System.Drawing.Size(84, 15);
            this.lblTopUcret.TabIndex = 12;
            this.lblTopUcret.Text = "toplam yakıt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 328);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricYakitDepoKapasite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumaricOrtTuketim100km)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYakitFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericYakitFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumaricOrtTuketim100km;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numaricYakitDepoKapasite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTopUcret;
    }
}

