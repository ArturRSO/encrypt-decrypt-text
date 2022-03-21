namespace CryptographyApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtToEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncryptKey = new System.Windows.Forms.TextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToDecrypt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecripted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDecryptKey = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message to encrypt";
            // 
            // txtToEncrypt
            // 
            this.txtToEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToEncrypt.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToEncrypt.Location = new System.Drawing.Point(206, 12);
            this.txtToEncrypt.Multiline = true;
            this.txtToEncrypt.Name = "txtToEncrypt";
            this.txtToEncrypt.Size = new System.Drawing.Size(740, 82);
            this.txtToEncrypt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key";
            // 
            // txtEncryptKey
            // 
            this.txtEncryptKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEncryptKey.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptKey.Location = new System.Drawing.Point(56, 54);
            this.txtEncryptKey.Name = "txtEncryptKey";
            this.txtEncryptKey.Size = new System.Drawing.Size(116, 16);
            this.txtEncryptKey.TabIndex = 1;
            // 
            // btnCrypt
            // 
            this.btnCrypt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnCrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCrypt.Location = new System.Drawing.Point(68, 89);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(75, 23);
            this.btnCrypt.TabIndex = 2;
            this.btnCrypt.Text = "Encrypt";
            this.btnCrypt.UseVisualStyleBackColor = false;
            this.btnCrypt.Click += new System.EventHandler(this.BtnCrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Encrypted text";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEncrypted.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncrypted.Location = new System.Drawing.Point(206, 128);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(740, 82);
            this.txtEncrypted.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Message to decrypt";
            // 
            // txtToDecrypt
            // 
            this.txtToDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToDecrypt.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDecrypt.Location = new System.Drawing.Point(206, 302);
            this.txtToDecrypt.Multiline = true;
            this.txtToDecrypt.Name = "txtToDecrypt";
            this.txtToDecrypt.Size = new System.Drawing.Size(740, 82);
            this.txtToDecrypt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowText;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(34, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Decrypted text";
            // 
            // txtDecripted
            // 
            this.txtDecripted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDecripted.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecripted.Location = new System.Drawing.Point(206, 429);
            this.txtDecripted.Multiline = true;
            this.txtDecripted.Name = "txtDecripted";
            this.txtDecripted.Size = new System.Drawing.Size(740, 82);
            this.txtDecripted.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(15, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(931, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Brought to you by Artur RSO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.WindowText;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Key";
            // 
            // txtDecryptKey
            // 
            this.txtDecryptKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDecryptKey.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptKey.Location = new System.Drawing.Point(56, 346);
            this.txtDecryptKey.Name = "txtDecryptKey";
            this.txtDecryptKey.Size = new System.Drawing.Size(116, 16);
            this.txtDecryptKey.TabIndex = 1;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDecrypt.Location = new System.Drawing.Point(68, 381);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(455, 554);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(958, 632);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtDecryptKey);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.txtEncryptKey);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.txtDecripted);
            this.Controls.Add(this.txtToDecrypt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtToEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Cryptography Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncryptKey;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecripted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDecryptKey;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear;
    }
}

