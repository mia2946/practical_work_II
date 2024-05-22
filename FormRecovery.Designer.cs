namespace PracticalWorkII
{
    partial class FormRecovery
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
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsernameOrEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.labelErrorUserNotFound = new System.Windows.Forms.Label();
            this.labelErrorPasswords = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Enabled = false;
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(441, 252);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.PasswordChar = '*';
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(332, 31);
            this.textBoxRepeatPassword.TabIndex = 57;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonValidate.Location = new System.Drawing.Point(259, 272);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(112, 34);
            this.buttonValidate.TabIndex = 54;
            this.buttonValidate.Text = "VALIDATE";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(440, 175);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(332, 31);
            this.textBoxPassword.TabIndex = 52;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxUsernameOrEmail
            // 
            this.textBoxUsernameOrEmail.Location = new System.Drawing.Point(40, 175);
            this.textBoxUsernameOrEmail.Name = "textBoxUsernameOrEmail";
            this.textBoxUsernameOrEmail.Size = new System.Drawing.Size(331, 31);
            this.textBoxUsernameOrEmail.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(440, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 25);
            this.label9.TabIndex = 48;
            this.label9.Text = "NEW PASSWORD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Enter Username or Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(245, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "OOP CALCULATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(441, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "REPEAT PASSWORD:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 113);
            this.panel1.TabIndex = 55;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Enabled = false;
            this.buttonChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChangePassword.Location = new System.Drawing.Point(554, 359);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(219, 34);
            this.buttonChangePassword.TabIndex = 58;
            this.buttonChangePassword.Text = "CHANGE PASSWORD";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // labelErrorUserNotFound
            // 
            this.labelErrorUserNotFound.AutoSize = true;
            this.labelErrorUserNotFound.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelErrorUserNotFound.ForeColor = System.Drawing.Color.Red;
            this.labelErrorUserNotFound.Location = new System.Drawing.Point(40, 209);
            this.labelErrorUserNotFound.Name = "labelErrorUserNotFound";
            this.labelErrorUserNotFound.Size = new System.Drawing.Size(248, 25);
            this.labelErrorUserNotFound.TabIndex = 59;
            this.labelErrorUserNotFound.Text = "Username or Email not found";
            this.labelErrorUserNotFound.Visible = false;
            // 
            // labelErrorPasswords
            // 
            this.labelErrorPasswords.AutoSize = true;
            this.labelErrorPasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelErrorPasswords.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPasswords.Location = new System.Drawing.Point(442, 290);
            this.labelErrorPasswords.Name = "labelErrorPasswords";
            this.labelErrorPasswords.Size = new System.Drawing.Size(286, 25);
            this.labelErrorPasswords.TabIndex = 60;
            this.labelErrorPasswords.Text = "Both passwords must be the same";
            this.labelErrorPasswords.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(259, 350);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(112, 34);
            this.buttonClose.TabIndex = 61;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 434);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelErrorPasswords);
            this.Controls.Add(this.labelErrorUserNotFound);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.textBoxRepeatPassword);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsernameOrEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRecovery";
            this.Text = "FormRecovery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxRepeatPassword;
        private Button buttonValidate;
        private TextBox textBoxPassword;
        private TextBox textBoxUsernameOrEmail;
        private Label label9;
        private Label label1;
        private Label label4;
        private Label label2;
        private Panel panel1;
        private Button buttonChangePassword;
        private Label labelErrorUserNotFound;
        private Label labelErrorPasswords;
        private Button buttonClose;
    }
}