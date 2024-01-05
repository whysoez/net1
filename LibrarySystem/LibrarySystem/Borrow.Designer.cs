namespace LibrarySystem
{
    partial class Borrow
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
            this.dGBorrow = new System.Windows.Forms.DataGridView();
            this.bDeleteBorrow = new System.Windows.Forms.Button();
            this.bUpdateBorrow = new System.Windows.Forms.Button();
            this.bCreateBorrow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tborrowDeadlineTime = new System.Windows.Forms.TextBox();
            this.tGiveBack = new System.Windows.Forms.TextBox();
            this.tGiveTime = new System.Windows.Forms.TextBox();
            this.tborrowTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tborrowBookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.read = new System.Windows.Forms.Label();
            this.tborrowReaderId = new System.Windows.Forms.TextBox();
            this.bborrowBack = new System.Windows.Forms.Button();
            this.bRefreshData = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tSearchBook = new System.Windows.Forms.TextBox();
            this.bSearchBook = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFilterBookLanguage = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFilterBookType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFilterAuthor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bFilterBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGBorrow)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGBorrow
            // 
            this.dGBorrow.AllowUserToOrderColumns = true;
            this.dGBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGBorrow.Location = new System.Drawing.Point(40, 465);
            this.dGBorrow.Name = "dGBorrow";
            this.dGBorrow.RowHeadersWidth = 62;
            this.dGBorrow.RowTemplate.Height = 28;
            this.dGBorrow.Size = new System.Drawing.Size(1851, 378);
            this.dGBorrow.TabIndex = 50;
            // 
            // bDeleteBorrow
            // 
            this.bDeleteBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteBorrow.Location = new System.Drawing.Point(1992, 659);
            this.bDeleteBorrow.Name = "bDeleteBorrow";
            this.bDeleteBorrow.Size = new System.Drawing.Size(276, 45);
            this.bDeleteBorrow.TabIndex = 48;
            this.bDeleteBorrow.Text = "Delete Borrow";
            this.bDeleteBorrow.UseVisualStyleBackColor = true;
            // 
            // bUpdateBorrow
            // 
            this.bUpdateBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdateBorrow.Location = new System.Drawing.Point(1992, 575);
            this.bUpdateBorrow.Name = "bUpdateBorrow";
            this.bUpdateBorrow.Size = new System.Drawing.Size(246, 45);
            this.bUpdateBorrow.TabIndex = 47;
            this.bUpdateBorrow.Text = "Update Borrow";
            this.bUpdateBorrow.UseVisualStyleBackColor = true;
            // 
            // bCreateBorrow
            // 
            this.bCreateBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateBorrow.Location = new System.Drawing.Point(1992, 492);
            this.bCreateBorrow.Name = "bCreateBorrow";
            this.bCreateBorrow.Size = new System.Drawing.Size(231, 45);
            this.bCreateBorrow.TabIndex = 46;
            this.bCreateBorrow.Text = "Create Borrow";
            this.bCreateBorrow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1493, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Deadline Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1503, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Give Back";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1514, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Give Time";
            // 
            // tborrowDeadlineTime
            // 
            this.tborrowDeadlineTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborrowDeadlineTime.Location = new System.Drawing.Point(1771, 102);
            this.tborrowDeadlineTime.Name = "tborrowDeadlineTime";
            this.tborrowDeadlineTime.Size = new System.Drawing.Size(402, 35);
            this.tborrowDeadlineTime.TabIndex = 34;
            // 
            // tGiveBack
            // 
            this.tGiveBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tGiveBack.Location = new System.Drawing.Point(1710, 174);
            this.tGiveBack.Name = "tGiveBack";
            this.tGiveBack.Size = new System.Drawing.Size(402, 35);
            this.tGiveBack.TabIndex = 33;
            // 
            // tGiveTime
            // 
            this.tGiveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tGiveTime.Location = new System.Drawing.Point(1721, 258);
            this.tGiveTime.Name = "tGiveTime";
            this.tGiveTime.Size = new System.Drawing.Size(402, 35);
            this.tGiveTime.TabIndex = 32;
            // 
            // tborrowTime
            // 
            this.tborrowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborrowTime.Location = new System.Drawing.Point(456, 293);
            this.tborrowTime.Name = "tborrowTime";
            this.tborrowTime.Size = new System.Drawing.Size(402, 35);
            this.tborrowTime.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Borrow Time";
            // 
            // tborrowBookId
            // 
            this.tborrowBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborrowBookId.Location = new System.Drawing.Point(456, 180);
            this.tborrowBookId.Name = "tborrowBookId";
            this.tborrowBookId.Size = new System.Drawing.Size(402, 35);
            this.tborrowBookId.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Book";
            // 
            // read
            // 
            this.read.AutoSize = true;
            this.read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read.Location = new System.Drawing.Point(295, 87);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(93, 29);
            this.read.TabIndex = 27;
            this.read.Text = "Reader";
            // 
            // tborrowReaderId
            // 
            this.tborrowReaderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborrowReaderId.Location = new System.Drawing.Point(456, 84);
            this.tborrowReaderId.Name = "tborrowReaderId";
            this.tborrowReaderId.Size = new System.Drawing.Size(402, 35);
            this.tborrowReaderId.TabIndex = 26;
            // 
            // bborrowBack
            // 
            this.bborrowBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bborrowBack.Location = new System.Drawing.Point(2123, 1148);
            this.bborrowBack.Name = "bborrowBack";
            this.bborrowBack.Size = new System.Drawing.Size(177, 40);
            this.bborrowBack.TabIndex = 51;
            this.bborrowBack.Text = "Back to menu";
            this.bborrowBack.UseVisualStyleBackColor = true;
            this.bborrowBack.Click += new System.EventHandler(this.bborrowBack_Click);
            // 
            // bRefreshData
            // 
            this.bRefreshData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefreshData.Location = new System.Drawing.Point(2017, 760);
            this.bRefreshData.Name = "bRefreshData";
            this.bRefreshData.Size = new System.Drawing.Size(177, 40);
            this.bRefreshData.TabIndex = 52;
            this.bRefreshData.Text = "Refresh Data";
            this.bRefreshData.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.tSearchBook);
            this.groupBox3.Controls.Add(this.bSearchBook);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1022, 958);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(858, 244);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Book";
            // 
            // tSearchBook
            // 
            this.tSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSearchBook.Location = new System.Drawing.Point(329, 92);
            this.tSearchBook.Name = "tSearchBook";
            this.tSearchBook.Size = new System.Drawing.Size(402, 35);
            this.tSearchBook.TabIndex = 38;
            // 
            // bSearchBook
            // 
            this.bSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearchBook.Location = new System.Drawing.Point(75, 92);
            this.bSearchBook.Name = "bSearchBook";
            this.bSearchBook.Size = new System.Drawing.Size(177, 40);
            this.bSearchBook.TabIndex = 37;
            this.bSearchBook.Text = "Search Book";
            this.bSearchBook.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.cbFilterBookLanguage);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbFilterBookType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbFilterAuthor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bFilterBook);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 917);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 298);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Book";
            // 
            // cbFilterBookLanguage
            // 
            this.cbFilterBookLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBookLanguage.FormattingEnabled = true;
            this.cbFilterBookLanguage.Items.AddRange(new object[] {
            "Vietnamese",
            "English",
            "Chinese"});
            this.cbFilterBookLanguage.Location = new System.Drawing.Point(307, 234);
            this.cbFilterBookLanguage.Name = "cbFilterBookLanguage";
            this.cbFilterBookLanguage.Size = new System.Drawing.Size(296, 37);
            this.cbFilterBookLanguage.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 29);
            this.label11.TabIndex = 43;
            this.label11.Text = "Book Language";
            // 
            // cbFilterBookType
            // 
            this.cbFilterBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBookType.FormattingEnabled = true;
            this.cbFilterBookType.Items.AddRange(new object[] {
            "daicuong",
            "chuyennganh",
            "tieuthuyet"});
            this.cbFilterBookType.Location = new System.Drawing.Point(307, 158);
            this.cbFilterBookType.Name = "cbFilterBookType";
            this.cbFilterBookType.Size = new System.Drawing.Size(296, 37);
            this.cbFilterBookType.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 41;
            this.label10.Text = "Book Type";
            // 
            // cbFilterAuthor
            // 
            this.cbFilterAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterAuthor.FormattingEnabled = true;
            this.cbFilterAuthor.Location = new System.Drawing.Point(307, 81);
            this.cbFilterAuthor.Name = "cbFilterAuthor";
            this.cbFilterAuthor.Size = new System.Drawing.Size(296, 37);
            this.cbFilterAuthor.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 29);
            this.label9.TabIndex = 39;
            this.label9.Text = "Author";
            // 
            // bFilterBook
            // 
            this.bFilterBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFilterBook.Location = new System.Drawing.Point(683, 158);
            this.bFilterBook.Name = "bFilterBook";
            this.bFilterBook.Size = new System.Drawing.Size(177, 40);
            this.bFilterBook.TabIndex = 23;
            this.bFilterBook.Text = "Filter Book";
            this.bFilterBook.UseVisualStyleBackColor = true;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2373, 1300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bRefreshData);
            this.Controls.Add(this.bborrowBack);
            this.Controls.Add(this.dGBorrow);
            this.Controls.Add(this.bDeleteBorrow);
            this.Controls.Add(this.bUpdateBorrow);
            this.Controls.Add(this.bCreateBorrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tborrowDeadlineTime);
            this.Controls.Add(this.tGiveBack);
            this.Controls.Add(this.tGiveTime);
            this.Controls.Add(this.tborrowTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tborrowBookId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.read);
            this.Controls.Add(this.tborrowReaderId);
            this.Name = "Borrow";
            this.Text = "Quản Lý Mượn Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dGBorrow)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGBorrow;
        private System.Windows.Forms.Button bDeleteBorrow;
        private System.Windows.Forms.Button bUpdateBorrow;
        private System.Windows.Forms.Button bCreateBorrow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tborrowDeadlineTime;
        private System.Windows.Forms.TextBox tGiveBack;
        private System.Windows.Forms.TextBox tGiveTime;
        private System.Windows.Forms.TextBox tborrowTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tborrowBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label read;
        private System.Windows.Forms.TextBox tborrowReaderId;
        private System.Windows.Forms.Button bborrowBack;
        private System.Windows.Forms.Button bRefreshData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tSearchBook;
        private System.Windows.Forms.Button bSearchBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbFilterBookLanguage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbFilterBookType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFilterAuthor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bFilterBook;
    }
}