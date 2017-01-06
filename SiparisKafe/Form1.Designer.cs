namespace SiparisKafe
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
            this.panelSiparisler = new System.Windows.Forms.Panel();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.numaricIcecekMiktar = new System.Windows.Forms.NumericUpDown();
            this.numaricYemekMiktar = new System.Windows.Forms.NumericUpDown();
            this.cmbIcecekler = new System.Windows.Forms.ComboBox();
            this.cmbYemekler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYemek = new System.Windows.Forms.Label();
            this.panelArayuz = new System.Windows.Forms.Panel();
            this.lstboxHesapBilgileri = new System.Windows.Forms.ListBox();
            this.panelSiparisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricIcecekMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaricYemekMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSiparisler
            // 
            this.panelSiparisler.Controls.Add(this.btnSiparisEkle);
            this.panelSiparisler.Controls.Add(this.numaricIcecekMiktar);
            this.panelSiparisler.Controls.Add(this.numaricYemekMiktar);
            this.panelSiparisler.Controls.Add(this.cmbIcecekler);
            this.panelSiparisler.Controls.Add(this.cmbYemekler);
            this.panelSiparisler.Controls.Add(this.label2);
            this.panelSiparisler.Controls.Add(this.lblYemek);
            this.panelSiparisler.Location = new System.Drawing.Point(44, 224);
            this.panelSiparisler.Name = "panelSiparisler";
            this.panelSiparisler.Size = new System.Drawing.Size(244, 150);
            this.panelSiparisler.TabIndex = 8;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(92, 109);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisEkle.TabIndex = 5;
            this.btnSiparisEkle.Text = "Sipariş Ver";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // numaricIcecekMiktar
            // 
            this.numaricIcecekMiktar.Location = new System.Drawing.Point(199, 73);
            this.numaricIcecekMiktar.Name = "numaricIcecekMiktar";
            this.numaricIcecekMiktar.Size = new System.Drawing.Size(34, 20);
            this.numaricIcecekMiktar.TabIndex = 4;
            // 
            // numaricYemekMiktar
            // 
            this.numaricYemekMiktar.Location = new System.Drawing.Point(199, 35);
            this.numaricYemekMiktar.Name = "numaricYemekMiktar";
            this.numaricYemekMiktar.Size = new System.Drawing.Size(34, 20);
            this.numaricYemekMiktar.TabIndex = 2;
            // 
            // cmbIcecekler
            // 
            this.cmbIcecekler.FormattingEnabled = true;
            this.cmbIcecekler.Location = new System.Drawing.Point(72, 73);
            this.cmbIcecekler.Name = "cmbIcecekler";
            this.cmbIcecekler.Size = new System.Drawing.Size(121, 21);
            this.cmbIcecekler.TabIndex = 3;
            // 
            // cmbYemekler
            // 
            this.cmbYemekler.FormattingEnabled = true;
            this.cmbYemekler.Location = new System.Drawing.Point(72, 34);
            this.cmbYemekler.Name = "cmbYemekler";
            this.cmbYemekler.Size = new System.Drawing.Size(121, 21);
            this.cmbYemekler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecekler:";
            // 
            // lblYemek
            // 
            this.lblYemek.AutoSize = true;
            this.lblYemek.Location = new System.Drawing.Point(12, 34);
            this.lblYemek.Name = "lblYemek";
            this.lblYemek.Size = new System.Drawing.Size(54, 13);
            this.lblYemek.TabIndex = 0;
            this.lblYemek.Text = "Yemekler:";
            // 
            // panelArayuz
            // 
            this.panelArayuz.Location = new System.Drawing.Point(44, 52);
            this.panelArayuz.Name = "panelArayuz";
            this.panelArayuz.Size = new System.Drawing.Size(244, 166);
            this.panelArayuz.TabIndex = 7;
            // 
            // lstboxHesapBilgileri
            // 
            this.lstboxHesapBilgileri.FormattingEnabled = true;
            this.lstboxHesapBilgileri.Location = new System.Drawing.Point(305, 52);
            this.lstboxHesapBilgileri.Name = "lstboxHesapBilgileri";
            this.lstboxHesapBilgileri.Size = new System.Drawing.Size(206, 316);
            this.lstboxHesapBilgileri.TabIndex = 9;
            this.lstboxHesapBilgileri.DoubleClick += new System.EventHandler(this.lstboxHesapBilgileri_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(554, 427);
            this.Controls.Add(this.panelSiparisler);
            this.Controls.Add(this.panelArayuz);
            this.Controls.Add(this.lstboxHesapBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSiparisler.ResumeLayout(false);
            this.panelSiparisler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricIcecekMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaricYemekMiktar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSiparisler;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.NumericUpDown numaricIcecekMiktar;
        private System.Windows.Forms.NumericUpDown numaricYemekMiktar;
        private System.Windows.Forms.ComboBox cmbIcecekler;
        private System.Windows.Forms.ComboBox cmbYemekler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYemek;
        private System.Windows.Forms.Panel panelArayuz;
        private System.Windows.Forms.ListBox lstboxHesapBilgileri;
    }
}

