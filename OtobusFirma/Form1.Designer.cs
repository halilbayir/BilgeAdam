namespace OtobusFirma
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.grpBoxCinsiyet = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbOtobusTuru = new System.Windows.Forms.ComboBox();
            this.rdBtnKdn = new System.Windows.Forms.RadioButton();
            this.rdBtnErkek = new System.Windows.Forms.RadioButton();
            this.LboxMusteriler = new System.Windows.Forms.ListBox();
            this.grpBoxCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(2, 16);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(122, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // grpBoxCinsiyet
            // 
            this.grpBoxCinsiyet.Controls.Add(this.rdBtnKdn);
            this.grpBoxCinsiyet.Controls.Add(this.rdBtnErkek);
            this.grpBoxCinsiyet.Location = new System.Drawing.Point(3, 42);
            this.grpBoxCinsiyet.Name = "grpBoxCinsiyet";
            this.grpBoxCinsiyet.Size = new System.Drawing.Size(129, 100);
            this.grpBoxCinsiyet.TabIndex = 2;
            this.grpBoxCinsiyet.TabStop = false;
            this.grpBoxCinsiyet.Text = "groupBox1";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 199);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(91, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbOtobusTuru
            // 
            this.cmbOtobusTuru.FormattingEnabled = true;
            this.cmbOtobusTuru.Items.AddRange(new object[] {
            "Setra",
            "Travego"});
            this.cmbOtobusTuru.Location = new System.Drawing.Point(3, 159);
            this.cmbOtobusTuru.Name = "cmbOtobusTuru";
            this.cmbOtobusTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbOtobusTuru.TabIndex = 4;
            // 
            // rdBtnKdn
            // 
            this.rdBtnKdn.AutoSize = true;
            this.rdBtnKdn.Location = new System.Drawing.Point(0, 55);
            this.rdBtnKdn.Name = "rdBtnKdn";
            this.rdBtnKdn.Size = new System.Drawing.Size(52, 17);
            this.rdBtnKdn.TabIndex = 5;
            this.rdBtnKdn.TabStop = true;
            this.rdBtnKdn.Text = "Kadın";
            this.rdBtnKdn.UseVisualStyleBackColor = true;
            // 
            // rdBtnErkek
            // 
            this.rdBtnErkek.AutoSize = true;
            this.rdBtnErkek.Location = new System.Drawing.Point(0, 32);
            this.rdBtnErkek.Name = "rdBtnErkek";
            this.rdBtnErkek.Size = new System.Drawing.Size(53, 17);
            this.rdBtnErkek.TabIndex = 6;
            this.rdBtnErkek.TabStop = true;
            this.rdBtnErkek.Text = "Erkek";
            this.rdBtnErkek.UseVisualStyleBackColor = true;
            // 
            // LboxMusteriler
            // 
            this.LboxMusteriler.FormattingEnabled = true;
            this.LboxMusteriler.Location = new System.Drawing.Point(147, 19);
            this.LboxMusteriler.Name = "LboxMusteriler";
            this.LboxMusteriler.Size = new System.Drawing.Size(237, 238);
            this.LboxMusteriler.TabIndex = 5;
            this.LboxMusteriler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LboxMusteriler_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 261);
            this.Controls.Add(this.LboxMusteriler);
            this.Controls.Add(this.cmbOtobusTuru);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.grpBoxCinsiyet);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxCinsiyet.ResumeLayout(false);
            this.grpBoxCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.GroupBox grpBoxCinsiyet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbOtobusTuru;
        private System.Windows.Forms.RadioButton rdBtnKdn;
        private System.Windows.Forms.RadioButton rdBtnErkek;
        private System.Windows.Forms.ListBox LboxMusteriler;
    }
}

