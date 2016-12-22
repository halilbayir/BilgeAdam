namespace Aboneler
{
    partial class Form2
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
            this.txtAbNo = new System.Windows.Forms.TextBox();
            this.txtAboneNo = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtIlkIndex = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAbNo
            // 
            this.txtAbNo.Location = new System.Drawing.Point(133, 9);
            this.txtAbNo.Name = "txtAbNo";
            this.txtAbNo.ReadOnly = true;
            this.txtAbNo.Size = new System.Drawing.Size(162, 20);
            this.txtAbNo.TabIndex = 19;
            // 
            // txtAboneNo
            // 
            this.txtAboneNo.AutoSize = true;
            this.txtAboneNo.Location = new System.Drawing.Point(12, 9);
            this.txtAboneNo.Name = "txtAboneNo";
            this.txtAboneNo.Size = new System.Drawing.Size(58, 13);
            this.txtAboneNo.TabIndex = 18;
            this.txtAboneNo.Text = "Abone No:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(133, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(162, 20);
            this.txtAd.TabIndex = 17;
            // 
            // txtIlkIndex
            // 
            this.txtIlkIndex.AutoSize = true;
            this.txtIlkIndex.Location = new System.Drawing.Point(12, 72);
            this.txtIlkIndex.Name = "txtIlkIndex";
            this.txtIlkIndex.Size = new System.Drawing.Size(70, 13);
            this.txtIlkIndex.TabIndex = 15;
            this.txtIlkIndex.Text = "Toplam Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(133, 72);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(162, 20);
            this.txtTutar.TabIndex = 14;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.AutoSize = true;
            this.txtAdSoyad.Location = new System.Drawing.Point(12, 43);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(56, 13);
            this.txtAdSoyad.TabIndex = 12;
            this.txtAdSoyad.Text = "Ad Soyad:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 359);
            this.Controls.Add(this.txtAbNo);
            this.Controls.Add(this.txtAboneNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtIlkIndex);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAbNo;
        private System.Windows.Forms.Label txtAboneNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label txtIlkIndex;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label txtAdSoyad;
    }
}