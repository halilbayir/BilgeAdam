namespace WindowsFormsApplication2
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
            this.radioOgrenci = new System.Windows.Forms.RadioButton();
            this.radioOgretmen = new System.Windows.Forms.RadioButton();
            this.btnKartEkle = new System.Windows.Forms.Button();
            this.radioTam = new System.Windows.Forms.RadioButton();
            this.lstBoxKartListe = new System.Windows.Forms.ListBox();
            this.txtOkulAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxOkulAdi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpBoxOkulAdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.txtBakiye);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grpBoxOkulAdi);
            this.groupBox1.Controls.Add(this.lstBoxKartListe);
            this.groupBox1.Controls.Add(this.radioTam);
            this.groupBox1.Controls.Add(this.btnKartEkle);
            this.groupBox1.Controls.Add(this.radioOgretmen);
            this.groupBox1.Controls.Add(this.radioOgrenci);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Oluştur";
            // 
            // radioOgrenci
            // 
            this.radioOgrenci.AutoSize = true;
            this.radioOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioOgrenci.Location = new System.Drawing.Point(24, 50);
            this.radioOgrenci.Name = "radioOgrenci";
            this.radioOgrenci.Size = new System.Drawing.Size(83, 21);
            this.radioOgrenci.TabIndex = 0;
            this.radioOgrenci.TabStop = true;
            this.radioOgrenci.Text = "Öğrenci";
            this.radioOgrenci.UseVisualStyleBackColor = true;
            this.radioOgrenci.CheckedChanged += new System.EventHandler(this.radioOgrenci_CheckedChanged);
            // 
            // radioOgretmen
            // 
            this.radioOgretmen.AutoSize = true;
            this.radioOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioOgretmen.Location = new System.Drawing.Point(24, 77);
            this.radioOgretmen.Name = "radioOgretmen";
            this.radioOgretmen.Size = new System.Drawing.Size(97, 21);
            this.radioOgretmen.TabIndex = 1;
            this.radioOgretmen.TabStop = true;
            this.radioOgretmen.Text = "Öğretmen";
            this.radioOgretmen.UseVisualStyleBackColor = true;
            // 
            // btnKartEkle
            // 
            this.btnKartEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKartEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKartEkle.Location = new System.Drawing.Point(24, 167);
            this.btnKartEkle.Name = "btnKartEkle";
            this.btnKartEkle.Size = new System.Drawing.Size(75, 30);
            this.btnKartEkle.TabIndex = 2;
            this.btnKartEkle.Text = "EKLE";
            this.btnKartEkle.UseVisualStyleBackColor = false;
            this.btnKartEkle.Click += new System.EventHandler(this.btnKartEkle_Click);
            // 
            // radioTam
            // 
            this.radioTam.AutoSize = true;
            this.radioTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTam.Location = new System.Drawing.Point(24, 104);
            this.radioTam.Name = "radioTam";
            this.radioTam.Size = new System.Drawing.Size(57, 21);
            this.radioTam.TabIndex = 3;
            this.radioTam.TabStop = true;
            this.radioTam.Text = "Tam";
            this.radioTam.UseVisualStyleBackColor = true;
            // 
            // lstBoxKartListe
            // 
            this.lstBoxKartListe.FormattingEnabled = true;
            this.lstBoxKartListe.Location = new System.Drawing.Point(6, 228);
            this.lstBoxKartListe.Name = "lstBoxKartListe";
            this.lstBoxKartListe.Size = new System.Drawing.Size(311, 134);
            this.lstBoxKartListe.TabIndex = 4;
            this.lstBoxKartListe.DoubleClick += new System.EventHandler(this.lstBoxKartListe_DoubleClick);
            // 
            // txtOkulAdi
            // 
            this.txtOkulAdi.Location = new System.Drawing.Point(12, 49);
            this.txtOkulAdi.Name = "txtOkulAdi";
            this.txtOkulAdi.Size = new System.Drawing.Size(100, 20);
            this.txtOkulAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Okul Adı:";
            // 
            // grpBoxOkulAdi
            // 
            this.grpBoxOkulAdi.BackColor = System.Drawing.Color.OrangeRed;
            this.grpBoxOkulAdi.Controls.Add(this.label1);
            this.grpBoxOkulAdi.Controls.Add(this.txtOkulAdi);
            this.grpBoxOkulAdi.Location = new System.Drawing.Point(165, 77);
            this.grpBoxOkulAdi.Name = "grpBoxOkulAdi";
            this.grpBoxOkulAdi.Size = new System.Drawing.Size(152, 100);
            this.grpBoxOkulAdi.TabIndex = 6;
            this.grpBoxOkulAdi.TabStop = false;
            this.grpBoxOkulAdi.Text = "Okul Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(162, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bakiye:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(165, 36);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(125, 20);
            this.txtBakiye.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(402, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxOkulAdi.ResumeLayout(false);
            this.grpBoxOkulAdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTam;
        private System.Windows.Forms.Button btnKartEkle;
        private System.Windows.Forms.RadioButton radioOgretmen;
        private System.Windows.Forms.RadioButton radioOgrenci;
        private System.Windows.Forms.ListBox lstBoxKartListe;
        private System.Windows.Forms.GroupBox grpBoxOkulAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOkulAdi;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label2;
    }
}

