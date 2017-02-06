namespace CodeFirstSample_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuIslemler = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTumUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.DGridList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbUrunCategory = new System.Windows.Forms.ComboBox();
            this.numUpdownUrunFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuItemUrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdownUrunFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuIslemler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuIslemler
            // 
            this.MenuIslemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUrunEkle,
            this.MenuItemTumUrunler});
            this.MenuIslemler.Name = "MenuIslemler";
            this.MenuIslemler.Size = new System.Drawing.Size(60, 20);
            this.MenuIslemler.Text = "İşlemler";
            // 
            // MenuItemTumUrunler
            // 
            this.MenuItemTumUrunler.Name = "MenuItemTumUrunler";
            this.MenuItemTumUrunler.Size = new System.Drawing.Size(152, 22);
            this.MenuItemTumUrunler.Text = "Tüm Ürünler";
            this.MenuItemTumUrunler.Click += new System.EventHandler(this.MenuItemTumUrunler_Click);
            // 
            // DGridList
            // 
            this.DGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridList.Location = new System.Drawing.Point(12, 123);
            this.DGridList.Name = "DGridList";
            this.DGridList.Size = new System.Drawing.Size(410, 253);
            this.DGridList.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cmbUrunCategory);
            this.groupBox1.Controls.Add(this.numUpdownUrunFiyat);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(460, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 385);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Green;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(0, 281);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(236, 32);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbUrunCategory
            // 
            this.cmbUrunCategory.FormattingEnabled = true;
            this.cmbUrunCategory.Location = new System.Drawing.Point(6, 220);
            this.cmbUrunCategory.Name = "cmbUrunCategory";
            this.cmbUrunCategory.Size = new System.Drawing.Size(236, 24);
            this.cmbUrunCategory.TabIndex = 2;
            // 
            // numUpdownUrunFiyat
            // 
            this.numUpdownUrunFiyat.Location = new System.Drawing.Point(6, 139);
            this.numUpdownUrunFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpdownUrunFiyat.Name = "numUpdownUrunFiyat";
            this.numUpdownUrunFiyat.Size = new System.Drawing.Size(239, 23);
            this.numUpdownUrunFiyat.TabIndex = 1;
            this.numUpdownUrunFiyat.ValueChanged += new System.EventHandler(this.numUpdownUrunFiyat_ValueChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(6, 61);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(239, 23);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Kategori";
            // 
            // MenuItemUrunEkle
            // 
            this.MenuItemUrunEkle.Name = "MenuItemUrunEkle";
            this.MenuItemUrunEkle.Size = new System.Drawing.Size(152, 22);
            this.MenuItemUrunEkle.Text = "Ürün Ekle";
            this.MenuItemUrunEkle.Click += new System.EventHandler(this.MenuItemUrunEkle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(0, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DGridList);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdownUrunFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuIslemler;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTumUrunler;
        private System.Windows.Forms.DataGridView DGridList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbUrunCategory;
        private System.Windows.Forms.NumericUpDown numUpdownUrunFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUrunEkle;
        private System.Windows.Forms.Button button1;
    }
}

