using System;

namespace Bank_Medicine
{
    partial class ForgetPasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordPage));
            this.TextUpdateEmail = new System.Windows.Forms.TextBox();
            this.TextUpdatePass = new System.Windows.Forms.TextBox();
            this.ButtonUpdatePassword = new System.Windows.Forms.Button();
            this.TextConPass = new System.Windows.Forms.TextBox();
            this.CheckBoxShow = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegToHomeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextUpdateEmail
            // 
            this.TextUpdateEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextUpdateEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextUpdateEmail.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUpdateEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.TextUpdateEmail.Location = new System.Drawing.Point(697, 267);
            this.TextUpdateEmail.Multiline = true;
            this.TextUpdateEmail.Name = "TextUpdateEmail";
            this.TextUpdateEmail.Size = new System.Drawing.Size(369, 22);
            this.TextUpdateEmail.TabIndex = 2;
            // 
            // TextUpdatePass
            // 
            this.TextUpdatePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextUpdatePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextUpdatePass.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUpdatePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.TextUpdatePass.Location = new System.Drawing.Point(697, 341);
            this.TextUpdatePass.Multiline = true;
            this.TextUpdatePass.Name = "TextUpdatePass";
            this.TextUpdatePass.Size = new System.Drawing.Size(384, 22);
            this.TextUpdatePass.TabIndex = 3;
            // 
            // ButtonUpdatePassword
            // 
            this.ButtonUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(43)))));
            this.ButtonUpdatePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonUpdatePassword.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdatePassword.Location = new System.Drawing.Point(769, 532);
            this.ButtonUpdatePassword.Name = "ButtonUpdatePassword";
            this.ButtonUpdatePassword.Size = new System.Drawing.Size(228, 29);
            this.ButtonUpdatePassword.TabIndex = 4;
            this.ButtonUpdatePassword.Text = "Submit";
            this.ButtonUpdatePassword.UseVisualStyleBackColor = false;
            this.ButtonUpdatePassword.Click += new System.EventHandler(this.ButtonUpdatePassword_Click);
            // 
            // TextConPass
            // 
            this.TextConPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextConPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextConPass.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextConPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.TextConPass.Location = new System.Drawing.Point(697, 418);
            this.TextConPass.Multiline = true;
            this.TextConPass.Name = "TextConPass";
            this.TextConPass.PasswordChar = '*';
            this.TextConPass.Size = new System.Drawing.Size(358, 22);
            this.TextConPass.TabIndex = 6;
            this.TextConPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextConPass_KeyUp);
            // 
            // CheckBoxShow
            // 
            this.CheckBoxShow.AutoSize = true;
            this.CheckBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxShow.Location = new System.Drawing.Point(980, 418);
            this.CheckBoxShow.Name = "CheckBoxShow";
            this.CheckBoxShow.Size = new System.Drawing.Size(0, 20);
            this.CheckBoxShow.TabIndex = 7;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHide.BackgroundImage")));
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(1061, 419);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(20, 20);
            this.btnHide.TabIndex = 8;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(1061, 419);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(20, 20);
            this.btnShow.TabIndex = 9;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // BACK
            // 
            this.BACK.BackColor = System.Drawing.Color.Transparent;
            this.BACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK.FlatAppearance.BorderSize = 0;
            this.BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.Color.White;
            this.BACK.Location = new System.Drawing.Point(1109, 11);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(90, 30);
            this.BACK.TabIndex = 19;
            this.BACK.Text = "Back";
            this.BACK.UseVisualStyleBackColor = false;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.RegToHomeBtn);
            this.panel1.Controls.Add(this.BACK);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 46);
            this.panel1.TabIndex = 20;
            // 
            // RegToHomeBtn
            // 
            this.RegToHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegToHomeBtn.FlatAppearance.BorderSize = 0;
            this.RegToHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegToHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegToHomeBtn.ForeColor = System.Drawing.Color.White;
            this.RegToHomeBtn.Location = new System.Drawing.Point(999, 11);
            this.RegToHomeBtn.Name = "RegToHomeBtn";
            this.RegToHomeBtn.Size = new System.Drawing.Size(95, 30);
            this.RegToHomeBtn.TabIndex = 21;
            this.RegToHomeBtn.Text = "Home";
            this.RegToHomeBtn.UseVisualStyleBackColor = false;
            // 
            // ForgetPasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.CheckBoxShow);
            this.Controls.Add(this.TextConPass);
            this.Controls.Add(this.ButtonUpdatePassword);
            this.Controls.Add(this.TextUpdatePass);
            this.Controls.Add(this.TextUpdateEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgetPasswordPage";
            this.Text = "Confirm Password";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextUpdateEmail;
        private System.Windows.Forms.TextBox TextUpdatePass;
        private System.Windows.Forms.Button ButtonUpdatePassword;
        private System.Windows.Forms.TextBox TextConPass;
        private System.Windows.Forms.Label CheckBoxShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegToHomeBtn;

        public EventHandler ForgetPasswordPage_Load { get; private set; }
        public EventHandler TextConPass_TextChanged { get; private set; }
    }
}