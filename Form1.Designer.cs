namespace DESEncrypter
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.cbPaddingOption = new System.Windows.Forms.CheckBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnGetHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(40, 112);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "ENC";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(136, 112);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "DEC";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // cbPaddingOption
            // 
            this.cbPaddingOption.AutoSize = true;
            this.cbPaddingOption.Location = new System.Drawing.Point(82, 141);
            this.cbPaddingOption.Name = "cbPaddingOption";
            this.cbPaddingOption.Size = new System.Drawing.Size(101, 17);
            this.cbPaddingOption.TabIndex = 2;
            this.cbPaddingOption.Text = "Ignore Padding ";
            this.cbPaddingOption.UseVisualStyleBackColor = true;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(22, 68);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(535, 20);
            this.tbPath.TabIndex = 3;
            this.tbPath.Text = "Input file path";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(563, 66);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(44, 23);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(22, 162);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(585, 147);
            this.lbLog.TabIndex = 5;
            // 
            // btnGetHash
            // 
            this.btnGetHash.Location = new System.Drawing.Point(258, 112);
            this.btnGetHash.Name = "btnGetHash";
            this.btnGetHash.Size = new System.Drawing.Size(75, 23);
            this.btnGetHash.TabIndex = 6;
            this.btnGetHash.Text = "Get Hash";
            this.btnGetHash.UseVisualStyleBackColor = true;
            this.btnGetHash.Click += new System.EventHandler(this.btnGetHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 329);
            this.Controls.Add(this.btnGetHash);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.cbPaddingOption);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "DES encrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.CheckBox cbPaddingOption;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnGetHash;
    }
}

