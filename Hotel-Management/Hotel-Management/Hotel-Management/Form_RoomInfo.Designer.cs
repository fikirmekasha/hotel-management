namespace Hotel_Management
{
    partial class Form_RoomInfo
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
            this.label_Search = new System.Windows.Forms.Label();
            this.label_Delete = new System.Windows.Forms.Label();
            this.label_Edit = new System.Windows.Forms.Label();
            this.label_Add = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_BackToLogin = new System.Windows.Forms.Label();
            this.txt_RoomPhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_RoomNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ClientName = new System.Windows.Forms.Label();
            this.label_RoomNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Yes = new System.Windows.Forms.RadioButton();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.label_Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.BackColor = System.Drawing.Color.Orange;
            this.label_Search.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(732, 449);
            this.label_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(85, 32);
            this.label_Search.TabIndex = 29;
            this.label_Search.Text = "Search";
            // 
            // label_Delete
            // 
            this.label_Delete.AutoSize = true;
            this.label_Delete.BackColor = System.Drawing.Color.Orange;
            this.label_Delete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Delete.Location = new System.Drawing.Point(889, 446);
            this.label_Delete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Delete.Name = "label_Delete";
            this.label_Delete.Size = new System.Drawing.Size(83, 32);
            this.label_Delete.TabIndex = 28;
            this.label_Delete.Text = "Delete";
            this.label_Delete.Click += new System.EventHandler(this.label_Delete_Click);
            // 
            // label_Edit
            // 
            this.label_Edit.AutoSize = true;
            this.label_Edit.BackColor = System.Drawing.Color.Orange;
            this.label_Edit.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Edit.Location = new System.Drawing.Point(616, 449);
            this.label_Edit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Edit.Name = "label_Edit";
            this.label_Edit.Size = new System.Drawing.Size(57, 32);
            this.label_Edit.TabIndex = 27;
            this.label_Edit.Text = "Edit";
            // 
            // label_Add
            // 
            this.label_Add.AutoSize = true;
            this.label_Add.BackColor = System.Drawing.Color.Orange;
            this.label_Add.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Add.Location = new System.Drawing.Point(457, 449);
            this.label_Add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Add.Name = "label_Add";
            this.label_Add.Size = new System.Drawing.Size(61, 32);
            this.label_Add.TabIndex = 26;
            this.label_Add.Text = "Add";
            this.label_Add.Click += new System.EventHandler(this.label_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(759, 270);
            this.dataGridView1.TabIndex = 25;
            // 
            // label_BackToLogin
            // 
            this.label_BackToLogin.AutoSize = true;
            this.label_BackToLogin.BackColor = System.Drawing.Color.Orange;
            this.label_BackToLogin.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BackToLogin.Location = new System.Drawing.Point(571, 495);
            this.label_BackToLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BackToLogin.Name = "label_BackToLogin";
            this.label_BackToLogin.Size = new System.Drawing.Size(165, 32);
            this.label_BackToLogin.TabIndex = 24;
            this.label_BackToLogin.Text = "Back To Menu";
            this.label_BackToLogin.Click += new System.EventHandler(this.label_BackToLogin_Click);
            // 
            // txt_RoomPhoneNumber
            // 
            this.txt_RoomPhoneNumber.Location = new System.Drawing.Point(31, 267);
            this.txt_RoomPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RoomPhoneNumber.Name = "txt_RoomPhoneNumber";
            this.txt_RoomPhoneNumber.Size = new System.Drawing.Size(205, 22);
            this.txt_RoomPhoneNumber.TabIndex = 20;
            // 
            // txt_RoomNumber
            // 
            this.txt_RoomNumber.Location = new System.Drawing.Point(31, 182);
            this.txt_RoomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RoomNumber.Name = "txt_RoomNumber";
            this.txt_RoomNumber.Size = new System.Drawing.Size(205, 22);
            this.txt_RoomNumber.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Available";
            // 
            // label_ClientName
            // 
            this.label_ClientName.AutoSize = true;
            this.label_ClientName.BackColor = System.Drawing.Color.Orange;
            this.label_ClientName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientName.Location = new System.Drawing.Point(24, 219);
            this.label_ClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ClientName.Name = "label_ClientName";
            this.label_ClientName.Size = new System.Drawing.Size(244, 32);
            this.label_ClientName.TabIndex = 17;
            this.label_ClientName.Text = "Room Phone Number";
            // 
            // label_RoomNumber
            // 
            this.label_RoomNumber.AutoSize = true;
            this.label_RoomNumber.BackColor = System.Drawing.Color.Orange;
            this.label_RoomNumber.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RoomNumber.Location = new System.Drawing.Point(24, 128);
            this.label_RoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RoomNumber.Name = "label_RoomNumber";
            this.label_RoomNumber.Size = new System.Drawing.Size(170, 32);
            this.label_RoomNumber.TabIndex = 16;
            this.label_RoomNumber.Text = "Room Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "Room Information";
            // 
            // radioButton_Yes
            // 
            this.radioButton_Yes.AutoSize = true;
            this.radioButton_Yes.BackColor = System.Drawing.Color.Orange;
            this.radioButton_Yes.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Yes.Location = new System.Drawing.Point(31, 343);
            this.radioButton_Yes.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Yes.Name = "radioButton_Yes";
            this.radioButton_Yes.Size = new System.Drawing.Size(71, 36);
            this.radioButton_Yes.TabIndex = 31;
            this.radioButton_Yes.TabStop = true;
            this.radioButton_Yes.Text = "Yes";
            this.radioButton_Yes.UseVisualStyleBackColor = false;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.BackColor = System.Drawing.Color.Orange;
            this.radioButton_No.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_No.Location = new System.Drawing.Point(31, 401);
            this.radioButton_No.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(68, 36);
            this.radioButton_No.TabIndex = 32;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "No";
            this.radioButton_No.UseVisualStyleBackColor = false;
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.Location = new System.Drawing.Point(1017, -2);
            this.label_Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(49, 45);
            this.label_Exit.TabIndex = 33;
            this.label_Exit.Text = "x";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // Form_RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::Hotel_Management.Properties.Resources.room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.radioButton_No);
            this.Controls.Add(this.radioButton_Yes);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.label_Delete);
            this.Controls.Add(this.label_Edit);
            this.Controls.Add(this.label_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_BackToLogin);
            this.Controls.Add(this.txt_RoomPhoneNumber);
            this.Controls.Add(this.txt_RoomNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ClientName);
            this.Controls.Add(this.label_RoomNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_RoomInfo";
            this.Text = "Form_RoomInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Label label_Delete;
        private System.Windows.Forms.Label label_Edit;
        private System.Windows.Forms.Label label_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_BackToLogin;
        private System.Windows.Forms.TextBox txt_RoomPhoneNumber;
        private System.Windows.Forms.TextBox txt_RoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ClientName;
        private System.Windows.Forms.Label label_RoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Yes;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.Label label_Exit;
    }
}