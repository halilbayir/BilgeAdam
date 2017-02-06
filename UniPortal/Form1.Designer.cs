namespace UniPortal
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
            this.cmbKisiSec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişi Seçin:";
            // 
            // cmbKisiSec
            // 
            this.cmbKisiSec.FormattingEnabled = true;
            this.cmbKisiSec.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretim Gör."});
            this.cmbKisiSec.Location = new System.Drawing.Point(3, 38);
            this.cmbKisiSec.Name = "cmbKisiSec";
            this.cmbKisiSec.Size = new System.Drawing.Size(121, 21);
            this.cmbKisiSec.TabIndex = 1;
            this.cmbKisiSec.SelectedIndexChanged += new System.EventHandler(this.cmbKisiSec_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 145);
            this.Controls.Add(this.cmbKisiSec);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKisiSec;
    }
}

