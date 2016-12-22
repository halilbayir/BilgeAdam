namespace otobüs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbOtobusTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTravego = new System.Windows.Forms.Panel();
            this.panelSetra = new System.Windows.Forms.Panel();
            this.gboxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.btnMusteriBilgiKaydet = new System.Windows.Forms.Button();
            this.txtYolcuIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOtobusTuru = new System.Windows.Forms.Label();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTravego.SuspendLayout();
            this.gboxMusteriBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbOtobusTuru
            // 
            this.cmbOtobusTuru.FormattingEnabled = true;
            this.cmbOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Setra"});
            this.cmbOtobusTuru.Location = new System.Drawing.Point(12, 103);
            this.cmbOtobusTuru.Name = "cmbOtobusTuru";
            this.cmbOtobusTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbOtobusTuru.TabIndex = 1;
            this.cmbOtobusTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOtobusTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otobüs Türü";
            // 
            // panelTravego
            // 
            this.panelTravego.Controls.Add(this.panelSetra);
            this.panelTravego.Location = new System.Drawing.Point(139, 77);
            this.panelTravego.Name = "panelTravego";
            this.panelTravego.Size = new System.Drawing.Size(304, 452);
            this.panelTravego.TabIndex = 3;
            // 
            // panelSetra
            // 
            this.panelSetra.Location = new System.Drawing.Point(3, 3);
            this.panelSetra.Name = "panelSetra";
            this.panelSetra.Size = new System.Drawing.Size(298, 437);
            this.panelSetra.TabIndex = 4;
            // 
            // gboxMusteriBilgileri
            // 
            this.gboxMusteriBilgileri.Controls.Add(this.btnMusteriBilgiKaydet);
            this.gboxMusteriBilgileri.Controls.Add(this.txtYolcuIsim);
            this.gboxMusteriBilgileri.Controls.Add(this.label2);
            this.gboxMusteriBilgileri.Location = new System.Drawing.Point(476, 83);
            this.gboxMusteriBilgileri.Name = "gboxMusteriBilgileri";
            this.gboxMusteriBilgileri.Size = new System.Drawing.Size(346, 376);
            this.gboxMusteriBilgileri.TabIndex = 4;
            this.gboxMusteriBilgileri.TabStop = false;
            this.gboxMusteriBilgileri.Text = "Müsteri Bilgileri";
            // 
            // btnMusteriBilgiKaydet
            // 
            this.btnMusteriBilgiKaydet.Location = new System.Drawing.Point(39, 171);
            this.btnMusteriBilgiKaydet.Name = "btnMusteriBilgiKaydet";
            this.btnMusteriBilgiKaydet.Size = new System.Drawing.Size(102, 23);
            this.btnMusteriBilgiKaydet.TabIndex = 2;
            this.btnMusteriBilgiKaydet.Text = "Kaydet";
            this.btnMusteriBilgiKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriBilgiKaydet.Click += new System.EventHandler(this.btnMusteriBilgiKaydet_Click);
            // 
            // txtYolcuIsim
            // 
            this.txtYolcuIsim.Location = new System.Drawing.Point(102, 19);
            this.txtYolcuIsim.Name = "txtYolcuIsim";
            this.txtYolcuIsim.Size = new System.Drawing.Size(100, 20);
            this.txtYolcuIsim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblOtobusTuru);
            this.groupBox1.Controls.Add(this.lblKoltukNo);
            this.groupBox1.Controls.Add(this.rbKadin);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Location = new System.Drawing.Point(476, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Otobüs Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Koltuk No:";
            // 
            // lblOtobusTuru
            // 
            this.lblOtobusTuru.AutoSize = true;
            this.lblOtobusTuru.Location = new System.Drawing.Point(82, 65);
            this.lblOtobusTuru.Name = "lblOtobusTuru";
            this.lblOtobusTuru.Size = new System.Drawing.Size(13, 13);
            this.lblOtobusTuru.TabIndex = 3;
            this.lblOtobusTuru.Text = "0";
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.AutoSize = true;
            this.lblKoltukNo.Location = new System.Drawing.Point(81, 36);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(13, 13);
            this.lblKoltukNo.TabIndex = 2;
            this.lblKoltukNo.Text = "0";
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKadin.Location = new System.Drawing.Point(84, 16);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(57, 17);
            this.rbKadin.TabIndex = 1;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.Location = new System.Drawing.Point(3, 16);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(58, 17);
            this.rbErkek.TabIndex = 0;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxMusteriBilgileri);
            this.Controls.Add(this.panelTravego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOtobusTuru);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTravego.ResumeLayout(false);
            this.gboxMusteriBilgileri.ResumeLayout(false);
            this.gboxMusteriBilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbOtobusTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTravego;
        private System.Windows.Forms.GroupBox gboxMusteriBilgileri;
        private System.Windows.Forms.TextBox txtYolcuIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.Panel panelSetra;
        private System.Windows.Forms.Button btnMusteriBilgiKaydet;
        private System.Windows.Forms.Label lblOtobusTuru;
        private System.Windows.Forms.Label lblKoltukNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

