using System;

namespace Bank_Medicine
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.TextID = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dateRegistration = new System.Windows.Forms.DateTimePicker();
            this.RegToHomeBtn = new System.Windows.Forms.Button();
            this.TextConfirmPass = new System.Windows.Forms.TextBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lebelSign = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextID
            // 
            this.TextID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextID.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.TextID.Location = new System.Drawing.Point(701, 203);
            this.TextID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextID.Multiline = true;
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(376, 22);
            this.TextID.TabIndex = 4;
            // 
            // TextName
            // 
            this.TextName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.TextName.Location = new System.Drawing.Point(701, 274);
            this.TextName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextName.Multiline = true;
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(376, 22);
            this.TextName.TabIndex = 5;
            // 
            // TextEmail
            // 
            this.TextEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextEmail.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.TextEmail.Location = new System.Drawing.Point(701, 340);
            this.TextEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextEmail.Multiline = true;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(376, 22);
            this.TextEmail.TabIndex = 6;
            // 
            // TextPassword
            // 
            this.TextPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPassword.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.TextPassword.Location = new System.Drawing.Point(701, 400);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextPassword.Multiline = true;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(376, 22);
            this.TextPassword.TabIndex = 7;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(43)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(773, 552);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(228, 29);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(379, 552);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 34);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // dateRegistration
            // 
            this.dateRegistration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRegistration.Location = new System.Drawing.Point(1082, 24);
            this.dateRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateRegistration.Name = "dateRegistration";
            this.dateRegistration.Size = new System.Drawing.Size(120, 22);
            this.dateRegistration.TabIndex = 11;
            // 
            // RegToHomeBtn
            // 
            this.RegToHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegToHomeBtn.FlatAppearance.BorderSize = 0;
            this.RegToHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegToHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegToHomeBtn.ForeColor = System.Drawing.Color.White;
            this.RegToHomeBtn.Location = new System.Drawing.Point(829, 11);
            this.RegToHomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegToHomeBtn.Name = "RegToHomeBtn";
            this.RegToHomeBtn.Size = new System.Drawing.Size(106, 30);
            this.RegToHomeBtn.TabIndex = 12;
            this.RegToHomeBtn.Text = "Home";
            this.RegToHomeBtn.UseVisualStyleBackColor = false;
            this.RegToHomeBtn.Click += new System.EventHandler(this.RegToHomeBtn_Click);
            // 
            // TextConfirmPass
            // 
            this.TextConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextConfirmPass.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.TextConfirmPass.Location = new System.Drawing.Point(701, 466);
            this.TextConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextConfirmPass.Multiline = true;
            this.TextConfirmPass.Name = "TextConfirmPass";
            this.TextConfirmPass.PasswordChar = '*';
            this.TextConfirmPass.Size = new System.Drawing.Size(350, 22);
            this.TextConfirmPass.TabIndex = 14;
            this.TextConfirmPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextConfirmPass_KeyUp);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHide.BackgroundImage")));
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(1057, 468);
            this.btnHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(20, 20);
            this.btnHide.TabIndex = 15;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click_1);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(1057, 468);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(20, 20);
            this.btnShow.TabIndex = 16;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // BACK
            // 
            this.BACK.BackColor = System.Drawing.Color.Transparent;
            this.BACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK.FlatAppearance.BorderSize = 0;
            this.BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.Color.White;
            this.BACK.Location = new System.Drawing.Point(966, 14);
            this.BACK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(92, 30);
            this.BACK.TabIndex = 17;
            this.BACK.Text = "Back";
            this.BACK.UseVisualStyleBackColor = false;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.RegToHomeBtn);
            this.panel1.Controls.Add(this.BACK);
            this.panel1.Controls.Add(this.dateRegistration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 46);
            this.panel1.TabIndex = 19;
            // 
            // lebelSign
            // 
            this.lebelSign.AutoSize = true;
            this.lebelSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebelSign.Location = new System.Drawing.Point(1088, 466);
            this.lebelSign.Name = "lebelSign";
            this.lebelSign.Size = new System.Drawing.Size(0, 20);
            this.lebelSign.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Alreday Have An Account ?";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.TextConfirmPass);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.lebelSign);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnSignUp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registration";
            this.Text = "Registration Page";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DateTimePicker dateRegistration;
        private System.Windows.Forms.Button RegToHomeBtn;
        private System.Windows.Forms.TextBox TextConfirmPass;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lebelSign;
        private System.Windows.Forms.Label label1;

        public EventHandler TextPassword_TextChanged { get; private set; }
    }
}