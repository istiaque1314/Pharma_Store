using System;

namespace Bank_Medicine
{
    partial class Menu_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Page));
            this.meddatatable = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.textMedName = new System.Windows.Forms.TextBox();
            this.textMedQty = new System.Windows.Forms.TextBox();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.textMname = new System.Windows.Forms.TextBox();
            this.textMrp = new System.Windows.Forms.TextBox();
            this.textQty = new System.Windows.Forms.TextBox();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meddatatable)).BeginInit();
            this.SuspendLayout();
            // 
            // meddatatable
            // 
            this.meddatatable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.meddatatable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.meddatatable.BackgroundColor = System.Drawing.Color.White;
            this.meddatatable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.meddatatable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.meddatatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meddatatable.GridColor = System.Drawing.Color.White;
            this.meddatatable.Location = new System.Drawing.Point(750, 150);
            this.meddatatable.Name = "meddatatable";
            this.meddatatable.RowHeadersWidth = 51;
            this.meddatatable.RowTemplate.Height = 24;
            this.meddatatable.Size = new System.Drawing.Size(467, 382);
            this.meddatatable.TabIndex = 0;
            this.meddatatable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meddatatable_CellContentClick);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(43)))));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1142, 90);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(88, 30);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TextSearch
            // 
            this.TextSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TextSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextSearch.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearch.Location = new System.Drawing.Point(750, 97);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(386, 21);
            this.TextSearch.TabIndex = 2;
            // 
            // textMedName
            // 
            this.textMedName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.textMedName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMedName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textMedName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMedName.Location = new System.Drawing.Point(300, 516);
            this.textMedName.Multiline = true;
            this.textMedName.Name = "textMedName";
            this.textMedName.Size = new System.Drawing.Size(377, 30);
            this.textMedName.TabIndex = 19;
            // 
            // textMedQty
            // 
            this.textMedQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.textMedQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMedQty.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMedQty.Location = new System.Drawing.Point(300, 592);
            this.textMedQty.Multiline = true;
            this.textMedQty.Name = "textMedQty";
            this.textMedQty.Size = new System.Drawing.Size(377, 28);
            this.textMedQty.TabIndex = 20;
            // 
            // btnAddMed
            // 
            this.btnAddMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(43)))));
            this.btnAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMed.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMed.ForeColor = System.Drawing.Color.White;
            this.btnAddMed.Location = new System.Drawing.Point(382, 678);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(228, 28);
            this.btnAddMed.TabIndex = 21;
            this.btnAddMed.Text = "ADD";
            this.btnAddMed.UseVisualStyleBackColor = false;
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(43)))));
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBilling.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.ForeColor = System.Drawing.Color.White;
            this.btnBilling.Location = new System.Drawing.Point(880, 592);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(228, 29);
            this.btnBilling.TabIndex = 22;
            this.btnBilling.Text = "BILLING";
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // textMname
            // 
            this.textMname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.textMname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textMname.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMname.Location = new System.Drawing.Point(146, 159);
            this.textMname.Multiline = true;
            this.textMname.Name = "textMname";
            this.textMname.Size = new System.Drawing.Size(385, 26);
            this.textMname.TabIndex = 23;
            // 
            // textMrp
            // 
            this.textMrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.textMrp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textMrp.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMrp.Location = new System.Drawing.Point(146, 235);
            this.textMrp.Multiline = true;
            this.textMrp.Name = "textMrp";
            this.textMrp.Size = new System.Drawing.Size(385, 27);
            this.textMrp.TabIndex = 24;
            // 
            // textQty
            // 
            this.textQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(243)))));
            this.textQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textQty.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQty.Location = new System.Drawing.Point(146, 305);
            this.textQty.Multiline = true;
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(385, 27);
            this.textQty.TabIndex = 25;
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(43)))));
            this.ButtonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonInsert.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInsert.ForeColor = System.Drawing.Color.White;
            this.ButtonInsert.Location = new System.Drawing.Point(210, 381);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(228, 28);
            this.ButtonInsert.TabIndex = 29;
            this.ButtonInsert.Text = "ADD";
            this.ButtonInsert.UseVisualStyleBackColor = false;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(857, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Click here to make invoice";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(1096, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(144, 33);
            this.Home.TabIndex = 18;
            this.Home.Text = "Log out";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Menu_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1242, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.textQty);
            this.Controls.Add(this.textMrp);
            this.Controls.Add(this.textMname);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnAddMed);
            this.Controls.Add(this.textMedQty);
            this.Controls.Add(this.textMedName);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.meddatatable);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu_Page";
            this.Text = "Menu_Page";
            this.Load += new System.EventHandler(this.Menu_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meddatatable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView meddatatable;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.TextBox textMedName;
        private System.Windows.Forms.TextBox textMedQty;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.TextBox textMname;
        private System.Windows.Forms.TextBox textMrp;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Home;

        public EventHandler BACK_Click { get; private set; }
    }
}