﻿namespace Hotel_Management
{
    partial class Form_ClientInfo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ClientID = new System.Windows.Forms.Label();
            this.label_ClientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ClientID = new System.Windows.Forms.TextBox();
            this.txt_ClientName = new System.Windows.Forms.TextBox();
            this.txt_ClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_BackToLogin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Add = new System.Windows.Forms.Label();
            this.label_Edit = new System.Windows.Forms.Label();
            this.label_Delete = new System.Windows.Forms.Label();
            this.label_Search = new System.Windows.Forms.Label();
            this.label_Exit = new System.Windows.Forms.Label();
            this.errorProviderforclient = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforclient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Information";
            // 
            // label_ClientID
            // 
            this.label_ClientID.AutoSize = true;
            this.label_ClientID.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientID.Location = new System.Drawing.Point(31, 144);
            this.label_ClientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ClientID.Name = "label_ClientID";
            this.label_ClientID.Size = new System.Drawing.Size(110, 32);
            this.label_ClientID.TabIndex = 1;
            this.label_ClientID.Text = "Client ID";
            // 
            // label_ClientName
            // 
            this.label_ClientName.AutoSize = true;
            this.label_ClientName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientName.Location = new System.Drawing.Point(31, 235);
            this.label_ClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ClientName.Name = "label_ClientName";
            this.label_ClientName.Size = new System.Drawing.Size(147, 32);
            this.label_ClientName.TabIndex = 2;
            this.label_ClientName.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number";
            // 
            // txt_ClientID
            // 
            this.txt_ClientID.Location = new System.Drawing.Point(37, 198);
            this.txt_ClientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ClientID.Name = "txt_ClientID";
            this.txt_ClientID.Size = new System.Drawing.Size(205, 22);
            this.txt_ClientID.TabIndex = 4;
            // 
            // txt_ClientName
            // 
            this.txt_ClientName.Location = new System.Drawing.Point(37, 283);
            this.txt_ClientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ClientName.Name = "txt_ClientName";
            this.txt_ClientName.Size = new System.Drawing.Size(205, 22);
            this.txt_ClientName.TabIndex = 5;
            // 
            // txt_ClientPhoneNumber
            // 
            this.txt_ClientPhoneNumber.Location = new System.Drawing.Point(37, 375);
            this.txt_ClientPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ClientPhoneNumber.Name = "txt_ClientPhoneNumber";
            this.txt_ClientPhoneNumber.Size = new System.Drawing.Size(205, 22);
            this.txt_ClientPhoneNumber.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ethiopia",
            "Kenya",
            "Ghana",
            "Egypt",
            "Israel",
            "China",
            "United States",
            "Canada",
            "United Kingdom"});
            this.comboBox1.Location = new System.Drawing.Point(37, 465);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 30);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Country";
            // 
            // label_BackToLogin
            // 
            this.label_BackToLogin.AutoSize = true;
            this.label_BackToLogin.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BackToLogin.Location = new System.Drawing.Point(577, 511);
            this.label_BackToLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BackToLogin.Name = "label_BackToLogin";
            this.label_BackToLogin.Size = new System.Drawing.Size(165, 32);
            this.label_BackToLogin.TabIndex = 9;
            this.label_BackToLogin.Text = "Back To Menu";
            this.label_BackToLogin.Click += new System.EventHandler(this.label_BackToLogin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(759, 270);
            this.dataGridView1.TabIndex = 10;
            // 
            // label_Add
            // 
            this.label_Add.AutoSize = true;
            this.label_Add.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Add.Location = new System.Drawing.Point(464, 465);
            this.label_Add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Add.Name = "label_Add";
            this.label_Add.Size = new System.Drawing.Size(61, 32);
            this.label_Add.TabIndex = 11;
            this.label_Add.Text = "Add";
            this.label_Add.Click += new System.EventHandler(this.label_Add_Click);
            // 
            // label_Edit
            // 
            this.label_Edit.AutoSize = true;
            this.label_Edit.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Edit.Location = new System.Drawing.Point(623, 465);
            this.label_Edit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Edit.Name = "label_Edit";
            this.label_Edit.Size = new System.Drawing.Size(57, 32);
            this.label_Edit.TabIndex = 12;
            this.label_Edit.Text = "Edit";
            // 
            // label_Delete
            // 
            this.label_Delete.AutoSize = true;
            this.label_Delete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delete.Location = new System.Drawing.Point(896, 462);
            this.label_Delete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Delete.Name = "label_Delete";
            this.label_Delete.Size = new System.Drawing.Size(83, 32);
            this.label_Delete.TabIndex = 13;
            this.label_Delete.Text = "Delete";
            this.label_Delete.Click += new System.EventHandler(this.label_Delete_Click);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(739, 465);
            this.label_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(85, 32);
            this.label_Search.TabIndex = 14;
            this.label_Search.Text = "Search";
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.Location = new System.Drawing.Point(1013, 0);
            this.label_Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(53, 45);
            this.label_Exit.TabIndex = 15;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // errorProviderforclient
            // 
            this.errorProviderforclient.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderforclient.ContainerControl = this;
            // 
            // Form_ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.label_Delete);
            this.Controls.Add(this.label_Edit);
            this.Controls.Add(this.label_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_BackToLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_ClientPhoneNumber);
            this.Controls.Add(this.txt_ClientName);
            this.Controls.Add(this.txt_ClientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ClientName);
            this.Controls.Add(this.label_ClientID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_ClientInfo";
            this.Text = "Form_ClientInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ClientID;
        private System.Windows.Forms.Label label_ClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ClientID;
        private System.Windows.Forms.TextBox txt_ClientName;
        private System.Windows.Forms.TextBox txt_ClientPhoneNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_BackToLogin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Add;
        private System.Windows.Forms.Label label_Edit;
        private System.Windows.Forms.Label label_Delete;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.ErrorProvider errorProviderforclient;
    }
}