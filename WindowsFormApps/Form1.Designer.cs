namespace WindowsFormApps
{
    partial class ilkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ilkForm));
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.AdTxtBox = new System.Windows.Forms.TextBox();
            this.SifreTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KaydetBtn.BackgroundImage")));
            this.KaydetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KaydetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KaydetBtn.Location = new System.Drawing.Point(167, 128);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(38, 31);
            this.KaydetBtn.TabIndex = 0;
            this.KaydetBtn.UseVisualStyleBackColor = true;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // AdTxtBox
            // 
            this.AdTxtBox.Location = new System.Drawing.Point(89, 43);
            this.AdTxtBox.Name = "AdTxtBox";
            this.AdTxtBox.Size = new System.Drawing.Size(116, 20);
            this.AdTxtBox.TabIndex = 1;
            // 
            // SifreTxtBox
            // 
            this.SifreTxtBox.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.SifreTxtBox.Location = new System.Drawing.Point(89, 87);
            this.SifreTxtBox.Name = "SifreTxtBox";
            this.SifreTxtBox.Size = new System.Drawing.Size(116, 20);
            this.SifreTxtBox.TabIndex = 2;
            this.SifreTxtBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sifre";
            // 
            // ilkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(286, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreTxtBox);
            this.Controls.Add(this.AdTxtBox);
            this.Controls.Add(this.KaydetBtn);
            this.Name = "ilkForm";
            this.Text = "IlkUygulamam";
            this.Load += new System.EventHandler(this.ilkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.TextBox AdTxtBox;
        private System.Windows.Forms.TextBox SifreTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

