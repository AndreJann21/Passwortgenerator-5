namespace Passwortgenerator5_WF
{
    partial class Output_Safe_Password
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
            this.btn_close2 = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_input1 = new System.Windows.Forms.TextBox();
            this.lbl_fys = new System.Windows.Forms.Label();
            this.txtb_fys = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_close2
            // 
            this.btn_close2.Location = new System.Drawing.Point(260, 235);
            this.btn_close2.Name = "btn_close2";
            this.btn_close2.Size = new System.Drawing.Size(159, 23);
            this.btn_close2.TabIndex = 0;
            this.btn_close2.Text = "Close";
            this.btn_close2.UseVisualStyleBackColor = true;
            this.btn_close2.Click += new System.EventHandler(this.btn_close2_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(116, 49);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password:";
            // 
            // txt_input1
            // 
            this.txt_input1.Location = new System.Drawing.Point(193, 46);
            this.txt_input1.Multiline = true;
            this.txt_input1.Name = "txt_input1";
            this.txt_input1.PasswordChar = '*';
            this.txt_input1.ReadOnly = true;
            this.txt_input1.Size = new System.Drawing.Size(233, 20);
            this.txt_input1.TabIndex = 2;
            // 
            // lbl_fys
            // 
            this.lbl_fys.AutoSize = true;
            this.lbl_fys.Location = new System.Drawing.Point(68, 98);
            this.lbl_fys.Name = "lbl_fys";
            this.lbl_fys.Size = new System.Drawing.Size(104, 13);
            this.lbl_fys.TabIndex = 3;
            this.lbl_fys.Text = "Fisher-Yates-Shuffle:";
            // 
            // txtb_fys
            // 
            this.txtb_fys.Location = new System.Drawing.Point(193, 95);
            this.txtb_fys.Name = "txtb_fys";
            this.txtb_fys.PasswordChar = '*';
            this.txtb_fys.ReadOnly = true;
            this.txtb_fys.Size = new System.Drawing.Size(233, 20);
            this.txtb_fys.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(198, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "unlock password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(317, 132);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "whole password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(71, 235);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(144, 23);
            this.btn_copy.TabIndex = 8;
            this.btn_copy.Text = "copy password";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // Output_Safe_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 303);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtb_fys);
            this.Controls.Add(this.lbl_fys);
            this.Controls.Add(this.txt_input1);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.btn_close2);
            this.Name = "Output_Safe_Password";
            this.Text = "Output_Safe_Password";
            this.Load += new System.EventHandler(this.Output_Safe_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close2;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_input1;
        private System.Windows.Forms.Label lbl_fys;
        private System.Windows.Forms.TextBox txtb_fys;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btn_copy;
    }
}