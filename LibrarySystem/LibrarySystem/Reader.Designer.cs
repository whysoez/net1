namespace LibrarySystem
{
    partial class Reader
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
            this.dGReader = new System.Windows.Forms.DataGridView();
            this.bDeleteReader = new System.Windows.Forms.Button();
            this.bUpdateReader = new System.Windows.Forms.Button();
            this.bCreateReader = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.treaderDelete = new System.Windows.Forms.TextBox();
            this.treaderPhone = new System.Windows.Forms.TextBox();
            this.treaderPlace = new System.Windows.Forms.TextBox();
            this.treaderAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treaderLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.readerName = new System.Windows.Forms.Label();
            this.treaderName = new System.Windows.Forms.TextBox();
            this.breaderBack = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dGReader)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGReader
            // 
            this.dGReader.AllowUserToOrderColumns = true;
            this.dGReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGReader.Location = new System.Drawing.Point(29, 445);
            this.dGReader.Name = "dGReader";
            this.dGReader.RowHeadersWidth = 62;
            this.dGReader.RowTemplate.Height = 28;
            this.dGReader.Size = new System.Drawing.Size(1819, 558);
            this.dGReader.TabIndex = 50;
            this.dGReader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGReader_CellContentClick);
            // 
            // bDeleteReader
            // 
            this.bDeleteReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteReader.Location = new System.Drawing.Point(1897, 695);
            this.bDeleteReader.Name = "bDeleteReader";
            this.bDeleteReader.Size = new System.Drawing.Size(264, 45);
            this.bDeleteReader.TabIndex = 48;
            this.bDeleteReader.Text = "Delete Reader";
            this.bDeleteReader.UseVisualStyleBackColor = true;
            // 
            // bUpdateReader
            // 
            this.bUpdateReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdateReader.Location = new System.Drawing.Point(1897, 592);
            this.bUpdateReader.Name = "bUpdateReader";
            this.bUpdateReader.Size = new System.Drawing.Size(271, 45);
            this.bUpdateReader.TabIndex = 47;
            this.bUpdateReader.Text = "Update Reader";
            this.bUpdateReader.UseVisualStyleBackColor = true;
            // 
            // bCreateReader
            // 
            this.bCreateReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateReader.Location = new System.Drawing.Point(1897, 482);
            this.bCreateReader.Name = "bCreateReader";
            this.bCreateReader.Size = new System.Drawing.Size(271, 45);
            this.bCreateReader.TabIndex = 46;
            this.bCreateReader.Text = "Create Reader";
            this.bCreateReader.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1509, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Reader Delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1509, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1552, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Place";
            // 
            // treaderDelete
            // 
            this.treaderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treaderDelete.Location = new System.Drawing.Point(1759, 234);
            this.treaderDelete.Name = "treaderDelete";
            this.treaderDelete.Size = new System.Drawing.Size(402, 35);
            this.treaderDelete.TabIndex = 35;
            // 
            // treaderPhone
            // 
            this.treaderPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treaderPhone.Location = new System.Drawing.Point(1759, 133);
            this.treaderPhone.Name = "treaderPhone";
            this.treaderPhone.Size = new System.Drawing.Size(402, 35);
            this.treaderPhone.TabIndex = 34;
            // 
            // treaderPlace
            // 
            this.treaderPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treaderPlace.Location = new System.Drawing.Point(1759, 311);
            this.treaderPlace.Name = "treaderPlace";
            this.treaderPlace.Size = new System.Drawing.Size(402, 35);
            this.treaderPlace.TabIndex = 32;
            // 
            // treaderAge
            // 
            this.treaderAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treaderAge.Location = new System.Drawing.Point(444, 324);
            this.treaderAge.Name = "treaderAge";
            this.treaderAge.Size = new System.Drawing.Size(402, 35);
            this.treaderAge.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Age";
            // 
            // treaderLevel
            // 
            this.treaderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treaderLevel.Location = new System.Drawing.Point(444, 211);
            this.treaderLevel.Name = "treaderLevel";
            this.treaderLevel.Size = new System.Drawing.Size(402, 35);
            this.treaderLevel.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Reader Level";
            // 
            // readerName
            // 
            this.readerName.AutoSize = true;
            this.readerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readerName.Location = new System.Drawing.Point(267, 118);
            this.readerName.Name = "readerName";
            this.readerName.Size = new System.Drawing.Size(164, 29);
            this.readerName.TabIndex = 27;
            this.readerName.Text = "Reader Name";
            // 
            // treaderName
            // 
            this.treaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treaderName.Location = new System.Drawing.Point(444, 115);
            this.treaderName.Name = "treaderName";
            this.treaderName.Size = new System.Drawing.Size(402, 35);
            this.treaderName.TabIndex = 26;
            // 
            // breaderBack
            // 
            this.breaderBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breaderBack.Location = new System.Drawing.Point(2027, 1293);
            this.breaderBack.Name = "breaderBack";
            this.breaderBack.Size = new System.Drawing.Size(177, 40);
            this.breaderBack.TabIndex = 51;
            this.breaderBack.Text = "Back to menu";
            this.breaderBack.UseVisualStyleBackColor = true;
            this.breaderBack.Click += new System.EventHandler(this.breaderBack_Click);
            // 
            // bRefreshData
            // 
            this.bRefreshData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefreshData.Location = new System.Drawing.Point(1954, 887);
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
            this.groupBox3.Location = new System.Drawing.Point(990, 1077);
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
            this.groupBox2.Location = new System.Drawing.Point(29, 1035);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 298);
            this.groupBox2.TabIndex = 55;
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
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2310, 1389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bRefreshData);
            this.Controls.Add(this.breaderBack);
            this.Controls.Add(this.dGReader);
            this.Controls.Add(this.bDeleteReader);
            this.Controls.Add(this.bUpdateReader);
            this.Controls.Add(this.bCreateReader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treaderDelete);
            this.Controls.Add(this.treaderPhone);
            this.Controls.Add(this.treaderPlace);
            this.Controls.Add(this.treaderAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treaderLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readerName);
            this.Controls.Add(this.treaderName);
            this.Name = "Reader";
            this.Text = "Quản Lý Độc Giả";
            ((System.ComponentModel.ISupportInitialize)(this.dGReader)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGReader;
        private System.Windows.Forms.Button bDeleteReader;
        private System.Windows.Forms.Button bUpdateReader;
        private System.Windows.Forms.Button bCreateReader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox treaderDelete;
        private System.Windows.Forms.TextBox treaderPhone;
        private System.Windows.Forms.TextBox treaderPlace;
        private System.Windows.Forms.TextBox treaderAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox treaderLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label readerName;
        private System.Windows.Forms.TextBox treaderName;
        private System.Windows.Forms.Button breaderBack;
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