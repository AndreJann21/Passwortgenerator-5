namespace Passwortgenerator5_WF
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Capital = new System.Windows.Forms.Label();
            this.lbl_lowerCase = new System.Windows.Forms.Label();
            this.lbl_specialChars = new System.Windows.Forms.Label();
            this.lbl_Passwortgenerator = new System.Windows.Forms.Label();
            this.lbl_digits = new System.Windows.Forms.Label();
            this.btn_outputPswd = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txtb_clttsInput = new System.Windows.Forms.TextBox();
            this.txtb_llettersInput = new System.Windows.Forms.TextBox();
            this.txtb_specialInput = new System.Windows.Forms.TextBox();
            this.txtb_digitsInput = new System.Windows.Forms.TextBox();
            this.cb_quickpassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_Capital
            // 
            this.lbl_Capital.AutoSize = true;
            this.lbl_Capital.Location = new System.Drawing.Point(39, 118);
            this.lbl_Capital.Name = "lbl_Capital";
            this.lbl_Capital.Size = new System.Drawing.Size(127, 13);
            this.lbl_Capital.TabIndex = 1;
            this.lbl_Capital.Text = "Number of capital letters: ";
            // 
            // lbl_lowerCase
            // 
            this.lbl_lowerCase.AutoSize = true;
            this.lbl_lowerCase.Location = new System.Drawing.Point(39, 166);
            this.lbl_lowerCase.Name = "lbl_lowerCase";
            this.lbl_lowerCase.Size = new System.Drawing.Size(144, 13);
            this.lbl_lowerCase.TabIndex = 2;
            this.lbl_lowerCase.Text = "Number of lowercase letters: ";
            // 
            // lbl_specialChars
            // 
            this.lbl_specialChars.AutoSize = true;
            this.lbl_specialChars.Location = new System.Drawing.Point(39, 216);
            this.lbl_specialChars.Name = "lbl_specialChars";
            this.lbl_specialChars.Size = new System.Drawing.Size(151, 13);
            this.lbl_specialChars.TabIndex = 3;
            this.lbl_specialChars.Text = "Number of special characters: ";
            // 
            // lbl_Passwortgenerator
            // 
            this.lbl_Passwortgenerator.AutoSize = true;
            this.lbl_Passwortgenerator.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passwortgenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Passwortgenerator.Location = new System.Drawing.Point(109, 41);
            this.lbl_Passwortgenerator.Name = "lbl_Passwortgenerator";
            this.lbl_Passwortgenerator.Size = new System.Drawing.Size(210, 25);
            this.lbl_Passwortgenerator.TabIndex = 4;
            this.lbl_Passwortgenerator.Text = "Password Generator 5";
            // 
            // lbl_digits
            // 
            this.lbl_digits.AutoSize = true;
            this.lbl_digits.Location = new System.Drawing.Point(39, 268);
            this.lbl_digits.Name = "lbl_digits";
            this.lbl_digits.Size = new System.Drawing.Size(89, 13);
            this.lbl_digits.TabIndex = 5;
            this.lbl_digits.Text = "Number of digits: ";
            // 
            // btn_outputPswd
            // 
            this.btn_outputPswd.Location = new System.Drawing.Point(39, 334);
            this.btn_outputPswd.Name = "btn_outputPswd";
            this.btn_outputPswd.Size = new System.Drawing.Size(144, 34);
            this.btn_outputPswd.TabIndex = 6;
            this.btn_outputPswd.Text = "Safe password";
            this.btn_outputPswd.UseVisualStyleBackColor = true;
            this.btn_outputPswd.Click += new System.EventHandler(this.btn_outputPswd_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(207, 334);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(148, 34);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txtb_clttsInput
            // 
            this.txtb_clttsInput.Location = new System.Drawing.Point(250, 115);
            this.txtb_clttsInput.MaxLength = 3;
            this.txtb_clttsInput.Name = "txtb_clttsInput";
            this.txtb_clttsInput.Size = new System.Drawing.Size(105, 20);
            this.txtb_clttsInput.TabIndex = 10;
            this.txtb_clttsInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtb_llettersInput
            // 
            this.txtb_llettersInput.Location = new System.Drawing.Point(250, 163);
            this.txtb_llettersInput.MaxLength = 3;
            this.txtb_llettersInput.Name = "txtb_llettersInput";
            this.txtb_llettersInput.Size = new System.Drawing.Size(105, 20);
            this.txtb_llettersInput.TabIndex = 11;
            this.txtb_llettersInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtb_specialInput
            // 
            this.txtb_specialInput.Location = new System.Drawing.Point(250, 213);
            this.txtb_specialInput.MaxLength = 3;
            this.txtb_specialInput.Name = "txtb_specialInput";
            this.txtb_specialInput.Size = new System.Drawing.Size(105, 20);
            this.txtb_specialInput.TabIndex = 12;
            this.txtb_specialInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtb_digitsInput
            // 
            this.txtb_digitsInput.Location = new System.Drawing.Point(250, 265);
            this.txtb_digitsInput.MaxLength = 3;
            this.txtb_digitsInput.Name = "txtb_digitsInput";
            this.txtb_digitsInput.Size = new System.Drawing.Size(105, 20);
            this.txtb_digitsInput.TabIndex = 13;
            this.txtb_digitsInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cb_quickpassword
            // 
            this.cb_quickpassword.AutoSize = true;
            this.cb_quickpassword.ForeColor = System.Drawing.Color.Blue;
            this.cb_quickpassword.Location = new System.Drawing.Point(250, 301);
            this.cb_quickpassword.Name = "cb_quickpassword";
            this.cb_quickpassword.Size = new System.Drawing.Size(87, 17);
            this.cb_quickpassword.TabIndex = 14;
            this.cb_quickpassword.Text = "quick choice";
            this.cb_quickpassword.UseVisualStyleBackColor = true;
            this.cb_quickpassword.CheckedChanged += new System.EventHandler(this.cb_quickpassword_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 400);
            this.Controls.Add(this.cb_quickpassword);
            this.Controls.Add(this.txtb_digitsInput);
            this.Controls.Add(this.txtb_specialInput);
            this.Controls.Add(this.txtb_llettersInput);
            this.Controls.Add(this.txtb_clttsInput);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_outputPswd);
            this.Controls.Add(this.lbl_digits);
            this.Controls.Add(this.lbl_Passwortgenerator);
            this.Controls.Add(this.lbl_specialChars);
            this.Controls.Add(this.lbl_lowerCase);
            this.Controls.Add(this.lbl_Capital);
            this.Name = "Form1";
            this.Text = "Password Generator 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Capital;
        private System.Windows.Forms.Label lbl_lowerCase;
        private System.Windows.Forms.Label lbl_specialChars;
        private System.Windows.Forms.Label lbl_Passwortgenerator;
        private System.Windows.Forms.Label lbl_digits;
        private System.Windows.Forms.Button btn_outputPswd;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txtb_clttsInput;
        private System.Windows.Forms.TextBox txtb_llettersInput;
        private System.Windows.Forms.TextBox txtb_specialInput;
        private System.Windows.Forms.TextBox txtb_digitsInput;
        private System.Windows.Forms.CheckBox cb_quickpassword;
    }
}

