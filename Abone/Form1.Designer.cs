namespace Abone
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioEv = new System.Windows.Forms.RadioButton();
            this.radioSirket = new System.Windows.Forms.RadioButton();
            this.SonMusteriEkle = new System.Windows.Forms.Button();
            this.lboxAboneisimler = new System.Windows.Forms.ListBox();
            this.lboxOdenenler = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abone Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abone Tipi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // radioEv
            // 
            this.radioEv.AutoSize = true;
            this.radioEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioEv.Location = new System.Drawing.Point(158, 58);
            this.radioEv.Name = "radioEv";
            this.radioEv.Size = new System.Drawing.Size(38, 19);
            this.radioEv.TabIndex = 4;
            this.radioEv.TabStop = true;
            this.radioEv.Text = "Ev";
            this.radioEv.UseVisualStyleBackColor = true;
            // 
            // radioSirket
            // 
            this.radioSirket.AutoSize = true;
            this.radioSirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioSirket.Location = new System.Drawing.Point(158, 83);
            this.radioSirket.Name = "radioSirket";
            this.radioSirket.Size = new System.Drawing.Size(56, 19);
            this.radioSirket.TabIndex = 5;
            this.radioSirket.TabStop = true;
            this.radioSirket.Text = "Şirket";
            this.radioSirket.UseVisualStyleBackColor = true;
            // 
            // SonMusteriEkle
            // 
            this.SonMusteriEkle.Location = new System.Drawing.Point(158, 453);
            this.SonMusteriEkle.Name = "SonMusteriEkle";
            this.SonMusteriEkle.Size = new System.Drawing.Size(75, 35);
            this.SonMusteriEkle.TabIndex = 6;
            this.SonMusteriEkle.Text = "Ödeme Bitir";
            this.SonMusteriEkle.UseVisualStyleBackColor = true;
            this.SonMusteriEkle.Click += new System.EventHandler(this.SonMusteriEkle_Click);
            // 
            // lboxAboneisimler
            // 
            this.lboxAboneisimler.FormattingEnabled = true;
            this.lboxAboneisimler.Location = new System.Drawing.Point(12, 301);
            this.lboxAboneisimler.Name = "lboxAboneisimler";
            this.lboxAboneisimler.Size = new System.Drawing.Size(157, 134);
            this.lboxAboneisimler.TabIndex = 7;
            this.lboxAboneisimler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lboxAboneisimler_MouseDoubleClick);
            // 
            // lboxOdenenler
            // 
            this.lboxOdenenler.FormattingEnabled = true;
            this.lboxOdenenler.Location = new System.Drawing.Point(218, 301);
            this.lboxOdenenler.Name = "lboxOdenenler";
            this.lboxOdenenler.Size = new System.Drawing.Size(155, 134);
            this.lboxOdenenler.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Abone Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Önceki Kullanılan Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(128, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Son Kullanılan Miktar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(426, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lboxOdenenler);
            this.Controls.Add(this.lboxAboneisimler);
            this.Controls.Add(this.SonMusteriEkle);
            this.Controls.Add(this.radioSirket);
            this.Controls.Add(this.radioEv);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioEv;
        private System.Windows.Forms.RadioButton radioSirket;
        private System.Windows.Forms.Button SonMusteriEkle;
        private System.Windows.Forms.ListBox lboxAboneisimler;
        private System.Windows.Forms.ListBox lboxOdenenler;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

