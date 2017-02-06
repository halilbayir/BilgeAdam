namespace insanKaynakları
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbElemanTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lstCalisanList = new System.Windows.Forms.ListBox();
            this.numMaas = new System.Windows.Forms.NumericUpDown();
            this.numSskNo = new System.Windows.Forms.NumericUpDown();
            this.numSatisAdet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSskNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatisAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELeman Türü";
            // 
            // cmbElemanTuru
            // 
            this.cmbElemanTuru.FormattingEnabled = true;
            this.cmbElemanTuru.Location = new System.Drawing.Point(89, 30);
            this.cmbElemanTuru.Name = "cmbElemanTuru";
            this.cmbElemanTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbElemanTuru.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satış Adeti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SSK No:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(56, 220);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(186, 179);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(24, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "button2";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // lstCalisanList
            // 
            this.lstCalisanList.FormattingEnabled = true;
            this.lstCalisanList.Location = new System.Drawing.Point(251, 30);
            this.lstCalisanList.Name = "lstCalisanList";
            this.lstCalisanList.Size = new System.Drawing.Size(212, 173);
            this.lstCalisanList.TabIndex = 10;
            this.lstCalisanList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCalisanList_MouseDoubleClick);
            // 
            // numMaas
            // 
            this.numMaas.Location = new System.Drawing.Point(90, 132);
            this.numMaas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaas.Name = "numMaas";
            this.numMaas.Size = new System.Drawing.Size(120, 20);
            this.numMaas.TabIndex = 11;
            // 
            // numSskNo
            // 
            this.numSskNo.Location = new System.Drawing.Point(90, 82);
            this.numSskNo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSskNo.Name = "numSskNo";
            this.numSskNo.Size = new System.Drawing.Size(120, 20);
            this.numSskNo.TabIndex = 12;
            // 
            // numSatisAdet
            // 
            this.numSatisAdet.Location = new System.Drawing.Point(89, 179);
            this.numSatisAdet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSatisAdet.Name = "numSatisAdet";
            this.numSatisAdet.Size = new System.Drawing.Size(91, 20);
            this.numSatisAdet.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 426);
            this.Controls.Add(this.numSatisAdet);
            this.Controls.Add(this.numSskNo);
            this.Controls.Add(this.numMaas);
            this.Controls.Add(this.lstCalisanList);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbElemanTuru);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSskNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatisAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbElemanTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ListBox lstCalisanList;
        private System.Windows.Forms.NumericUpDown numMaas;
        private System.Windows.Forms.NumericUpDown numSskNo;
        private System.Windows.Forms.NumericUpDown numSatisAdet;
    }
}

