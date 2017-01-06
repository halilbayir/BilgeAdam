namespace KentKartDenemeHb
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdTam = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdOgrenci = new System.Windows.Forms.RadioButton();
            this.rdOgretmen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKardID = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtKartTuru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lboxKartKullananlar = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(165)));
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kent Kart";
            // 
            // rdTam
            // 
            this.rdTam.AutoSize = true;
            this.rdTam.Location = new System.Drawing.Point(6, 28);
            this.rdTam.Name = "rdTam";
            this.rdTam.Size = new System.Drawing.Size(46, 17);
            this.rdTam.TabIndex = 2;
            this.rdTam.TabStop = true;
            this.rdTam.Text = "Tam";
            this.rdTam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdOgretmen);
            this.groupBox1.Controls.Add(this.rdOgrenci);
            this.groupBox1.Controls.Add(this.rdTam);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Türü";
            // 
            // rdOgrenci
            // 
            this.rdOgrenci.AutoSize = true;
            this.rdOgrenci.Location = new System.Drawing.Point(6, 54);
            this.rdOgrenci.Name = "rdOgrenci";
            this.rdOgrenci.Size = new System.Drawing.Size(62, 17);
            this.rdOgrenci.TabIndex = 3;
            this.rdOgrenci.TabStop = true;
            this.rdOgrenci.Text = "Ogrenci";
            this.rdOgrenci.UseVisualStyleBackColor = true;
            // 
            // rdOgretmen
            // 
            this.rdOgretmen.AutoSize = true;
            this.rdOgretmen.Location = new System.Drawing.Point(6, 77);
            this.rdOgretmen.Name = "rdOgretmen";
            this.rdOgretmen.Size = new System.Drawing.Size(71, 17);
            this.rdOgretmen.TabIndex = 4;
            this.rdOgretmen.TabStop = true;
            this.rdOgretmen.Text = "Ogretmen";
            this.rdOgretmen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kart Seri No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bakiye";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(245, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 7;
            // 
            // txtKardID
            // 
            this.txtKardID.Location = new System.Drawing.Point(245, 76);
            this.txtKardID.Name = "txtKardID";
            this.txtKardID.Size = new System.Drawing.Size(100, 20);
            this.txtKardID.TabIndex = 8;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(245, 102);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 9;
            // 
            // txtKartTuru
            // 
            this.txtKartTuru.Location = new System.Drawing.Point(245, 128);
            this.txtKartTuru.Name = "txtKartTuru";
            this.txtKartTuru.Size = new System.Drawing.Size(100, 20);
            this.txtKartTuru.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kart Turu";
            // 
            // lboxKartKullananlar
            // 
            this.lboxKartKullananlar.FormattingEnabled = true;
            this.lboxKartKullananlar.Location = new System.Drawing.Point(18, 201);
            this.lboxKartKullananlar.Name = "lboxKartKullananlar";
            this.lboxKartKullananlar.Size = new System.Drawing.Size(336, 95);
            this.lboxKartKullananlar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 307);
            this.Controls.Add(this.lboxKartKullananlar);
            this.Controls.Add(this.txtKartTuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtKardID);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdTam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdOgretmen;
        private System.Windows.Forms.RadioButton rdOgrenci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKardID;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtKartTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboxKartKullananlar;
    }
}

