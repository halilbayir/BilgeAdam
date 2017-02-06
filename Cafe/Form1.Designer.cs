namespace Cafe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbYemekler = new System.Windows.Forms.ComboBox();
            this.cmbIcecekler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numaricYemekAdet = new System.Windows.Forms.NumericUpDown();
            this.numericIcecekAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lboxHesap = new System.Windows.Forms.ListBox();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricYemekAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIcecekAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSiparisVer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericIcecekAdet);
            this.panel1.Controls.Add(this.numaricYemekAdet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbIcecekler);
            this.panel1.Controls.Add(this.cmbYemekler);
            this.panel1.Location = new System.Drawing.Point(34, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 176);
            this.panel1.TabIndex = 0;
            // 
            // cmbYemekler
            // 
            this.cmbYemekler.FormattingEnabled = true;
            this.cmbYemekler.Location = new System.Drawing.Point(55, 56);
            this.cmbYemekler.Name = "cmbYemekler";
            this.cmbYemekler.Size = new System.Drawing.Size(121, 21);
            this.cmbYemekler.TabIndex = 0;
            // 
            // cmbIcecekler
            // 
            this.cmbIcecekler.FormattingEnabled = true;
            this.cmbIcecekler.Location = new System.Drawing.Point(55, 103);
            this.cmbIcecekler.Name = "cmbIcecekler";
            this.cmbIcecekler.Size = new System.Drawing.Size(121, 21);
            this.cmbIcecekler.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yemekler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İcecekler";
            // 
            // numaricYemekAdet
            // 
            this.numaricYemekAdet.Location = new System.Drawing.Point(193, 57);
            this.numaricYemekAdet.Name = "numaricYemekAdet";
            this.numaricYemekAdet.Size = new System.Drawing.Size(38, 20);
            this.numaricYemekAdet.TabIndex = 4;
            // 
            // numericIcecekAdet
            // 
            this.numericIcecekAdet.Location = new System.Drawing.Point(193, 106);
            this.numericIcecekAdet.Name = "numericIcecekAdet";
            this.numericIcecekAdet.Size = new System.Drawing.Size(38, 20);
            this.numericIcecekAdet.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(71, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Siparişler";
            // 
            // lboxHesap
            // 
            this.lboxHesap.FormattingEnabled = true;
            this.lboxHesap.Location = new System.Drawing.Point(299, 12);
            this.lboxHesap.Name = "lboxHesap";
            this.lboxHesap.Size = new System.Drawing.Size(189, 290);
            this.lboxHesap.TabIndex = 1;
            this.lboxHesap.DoubleClick += new System.EventHandler(this.lboxHesap_DoubleClick);
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(75, 139);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisVer.TabIndex = 8;
            this.btnSiparisVer.Text = "Siparis ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 340);
            this.Controls.Add(this.lboxHesap);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricYemekAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIcecekAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIcecekler;
        private System.Windows.Forms.ComboBox cmbYemekler;
        private System.Windows.Forms.NumericUpDown numericIcecekAdet;
        private System.Windows.Forms.NumericUpDown numaricYemekAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lboxHesap;
        private System.Windows.Forms.Button btnSiparisVer;
    }
}

