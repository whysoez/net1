namespace LibrarySystem
{
    partial class QuanLySach
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
            this.tBookName = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tPushliserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bCreateBook = new System.Windows.Forms.Button();
            this.bUpdateBook = new System.Windows.Forms.Button();
            this.bDeleteBook = new System.Windows.Forms.Button();
            this.bFilterBook = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dGBook = new System.Windows.Forms.DataGridView();
            this.bBookBack = new System.Windows.Forms.Button();
            this.dtPublisherTime = new System.Windows.Forms.DateTimePicker();
            this.bRefreshData = new System.Windows.Forms.Button();
            this.cbBookType = new System.Windows.Forms.ComboBox();
            this.cbBookLanguge = new System.Windows.Forms.ComboBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.nDeadlineTime = new System.Windows.Forms.NumericUpDown();
            this.nBookCount = new System.Windows.Forms.NumericUpDown();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.bSearchBook = new System.Windows.Forms.Button();
            this.tSearchBook = new System.Windows.Forms.TextBox();
            this.cbFilterAuthor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFilterBookType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFilterBookLanguage = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDeadlineTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBookCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBookName
            // 
            this.tBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBookName.Location = new System.Drawing.Point(364, 95);
            this.tBookName.Name = "tBookName";
            this.tBookName.Size = new System.Drawing.Size(402, 35);
            this.tBookName.TabIndex = 0;
            this.tBookName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(157, 101);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(140, 29);
            this.bookName.TabIndex = 1;
            this.bookName.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Publisher Name";
            // 
            // tPushliserName
            // 
            this.tPushliserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPushliserName.Location = new System.Drawing.Point(364, 191);
            this.tPushliserName.Name = "tPushliserName";
            this.tPushliserName.Size = new System.Drawing.Size(402, 35);
            this.tPushliserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Publisher Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1416, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Book Language";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1416, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1416, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Deadline Time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1416, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Book Count";
            // 
            // bCreateBook
            // 
            this.bCreateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateBook.Location = new System.Drawing.Point(2165, 720);
            this.bCreateBook.Name = "bCreateBook";
            this.bCreateBook.Size = new System.Drawing.Size(175, 45);
            this.bCreateBook.TabIndex = 20;
            this.bCreateBook.Text = "Create Book";
            this.bCreateBook.UseVisualStyleBackColor = true;
            this.bCreateBook.Click += new System.EventHandler(this.bCreateBook_Click);
            // 
            // bUpdateBook
            // 
            this.bUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdateBook.Location = new System.Drawing.Point(2165, 810);
            this.bUpdateBook.Name = "bUpdateBook";
            this.bUpdateBook.Size = new System.Drawing.Size(175, 45);
            this.bUpdateBook.TabIndex = 21;
            this.bUpdateBook.Text = "Update Book";
            this.bUpdateBook.UseVisualStyleBackColor = true;
            this.bUpdateBook.Click += new System.EventHandler(this.bUpdateBook_Click);
            // 
            // bDeleteBook
            // 
            this.bDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteBook.Location = new System.Drawing.Point(2165, 899);
            this.bDeleteBook.Name = "bDeleteBook";
            this.bDeleteBook.Size = new System.Drawing.Size(175, 45);
            this.bDeleteBook.TabIndex = 22;
            this.bDeleteBook.Text = "Delete Book";
            this.bDeleteBook.UseVisualStyleBackColor = true;
            this.bDeleteBook.Click += new System.EventHandler(this.bDeleteBook_Click);
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
            this.bFilterBook.Click += new System.EventHandler(this.bFilterBook_Click);
            // 
            // dGBook
            // 
            this.dGBook.AllowUserToOrderColumns = true;
            this.dGBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGBook.Location = new System.Drawing.Point(71, 675);
            this.dGBook.Name = "dGBook";
            this.dGBook.RowHeadersWidth = 62;
            this.dGBook.RowTemplate.Height = 28;
            this.dGBook.Size = new System.Drawing.Size(2063, 378);
            this.dGBook.TabIndex = 25;
            this.dGBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGBook_CellContentClick);
            // 
            // bBookBack
            // 
            this.bBookBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBookBack.Location = new System.Drawing.Point(2266, 1328);
            this.bBookBack.Name = "bBookBack";
            this.bBookBack.Size = new System.Drawing.Size(177, 40);
            this.bBookBack.TabIndex = 26;
            this.bBookBack.Text = "Back to menu";
            this.bBookBack.UseVisualStyleBackColor = true;
            this.bBookBack.Click += new System.EventHandler(this.bBookBack_Click);
            // 
            // dtPublisherTime
            // 
            this.dtPublisherTime.CustomFormat = "";
            this.dtPublisherTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPublisherTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPublisherTime.Location = new System.Drawing.Point(364, 466);
            this.dtPublisherTime.Name = "dtPublisherTime";
            this.dtPublisherTime.Size = new System.Drawing.Size(402, 35);
            this.dtPublisherTime.TabIndex = 0;
            // 
            // bRefreshData
            // 
            this.bRefreshData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefreshData.Location = new System.Drawing.Point(2163, 989);
            this.bRefreshData.Name = "bRefreshData";
            this.bRefreshData.Size = new System.Drawing.Size(177, 40);
            this.bRefreshData.TabIndex = 28;
            this.bRefreshData.Text = "Refresh Data";
            this.bRefreshData.UseVisualStyleBackColor = true;
            this.bRefreshData.Click += new System.EventHandler(this.bRefreshData_Click);
            // 
            // cbBookType
            // 
            this.cbBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookType.FormattingEnabled = true;
            this.cbBookType.Items.AddRange(new object[] {
            "daicuong",
            "chuyennganh",
            "tieuthuyet"});
            this.cbBookType.Location = new System.Drawing.Point(364, 277);
            this.cbBookType.Name = "cbBookType";
            this.cbBookType.Size = new System.Drawing.Size(402, 37);
            this.cbBookType.TabIndex = 29;
            // 
            // cbBookLanguge
            // 
            this.cbBookLanguge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookLanguge.FormattingEnabled = true;
            this.cbBookLanguge.Items.AddRange(new object[] {
            "Vietnamese",
            "English",
            "Chinese"});
            this.cbBookLanguge.Location = new System.Drawing.Point(1695, 98);
            this.cbBookLanguge.Name = "cbBookLanguge";
            this.cbBookLanguge.Size = new System.Drawing.Size(367, 37);
            this.cbBookLanguge.TabIndex = 30;
            // 
            // cbAuthor
            // 
            this.cbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(1695, 191);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(367, 37);
            this.cbAuthor.TabIndex = 31;
            this.cbAuthor.SelectedIndexChanged += new System.EventHandler(this.cbAuthor_SelectedIndexChanged);
            // 
            // nDeadlineTime
            // 
            this.nDeadlineTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nDeadlineTime.Location = new System.Drawing.Point(1695, 274);
            this.nDeadlineTime.Name = "nDeadlineTime";
            this.nDeadlineTime.Size = new System.Drawing.Size(180, 35);
            this.nDeadlineTime.TabIndex = 34;
            // 
            // nBookCount
            // 
            this.nBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBookCount.Location = new System.Drawing.Point(1695, 374);
            this.nBookCount.Name = "nBookCount";
            this.nBookCount.Size = new System.Drawing.Size(180, 35);
            this.nBookCount.TabIndex = 35;
            // 
            // nPrice
            // 
            this.nPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPrice.Location = new System.Drawing.Point(364, 380);
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(180, 35);
            this.nPrice.TabIndex = 36;
            this.nPrice.ValueChanged += new System.EventHandler(this.nPrice_ValueChanged);
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
            this.bSearchBook.Click += new System.EventHandler(this.bSearchBook_Click);
            // 
            // tSearchBook
            // 
            this.tSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSearchBook.Location = new System.Drawing.Point(329, 92);
            this.tSearchBook.Name = "tSearchBook";
            this.tSearchBook.Size = new System.Drawing.Size(402, 35);
            this.tSearchBook.TabIndex = 38;
            // 
            // cbFilterAuthor
            // 
            this.cbFilterAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterAuthor.FormattingEnabled = true;
            this.cbFilterAuthor.Location = new System.Drawing.Point(307, 81);
            this.cbFilterAuthor.Name = "cbFilterAuthor";
            this.cbFilterAuthor.Size = new System.Drawing.Size(296, 37);
            this.cbFilterAuthor.TabIndex = 40;
            this.cbFilterAuthor.SelectedIndexChanged += new System.EventHandler(this.cbFilterAuthor_SelectedIndexChanged);
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
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.nPrice);
            this.groupBox1.Controls.Add(this.nBookCount);
            this.groupBox1.Controls.Add(this.nDeadlineTime);
            this.groupBox1.Controls.Add(this.cbAuthor);
            this.groupBox1.Controls.Add(this.cbBookLanguge);
            this.groupBox1.Controls.Add(this.cbBookType);
            this.groupBox1.Controls.Add(this.dtPublisherTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tPushliserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bookName);
            this.groupBox1.Controls.Add(this.tBookName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2269, 552);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Book";
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
            this.groupBox2.Location = new System.Drawing.Point(71, 1086);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 298);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Book";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.tSearchBook);
            this.groupBox3.Controls.Add(this.bSearchBook);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1276, 1102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(858, 244);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Book";
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2500, 1516);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bRefreshData);
            this.Controls.Add(this.bBookBack);
            this.Controls.Add(this.dGBook);
            this.Controls.Add(this.bDeleteBook);
            this.Controls.Add(this.bUpdateBook);
            this.Controls.Add(this.bCreateBook);
            this.Name = "QuanLySach";
            this.Text = "QuanLySach";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDeadlineTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBookCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBookName;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPushliserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bCreateBook;
        private System.Windows.Forms.Button bUpdateBook;
        private System.Windows.Forms.Button bDeleteBook;
        private System.Windows.Forms.Button bFilterBook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dGBook;
        private System.Windows.Forms.Button bBookBack;
        private System.Windows.Forms.DateTimePicker dtPublisherTime;
        private System.Windows.Forms.Button bRefreshData;
        private System.Windows.Forms.ComboBox cbBookType;
        private System.Windows.Forms.ComboBox cbBookLanguge;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.NumericUpDown nDeadlineTime;
        private System.Windows.Forms.NumericUpDown nBookCount;
        private System.Windows.Forms.NumericUpDown nPrice;
        private System.Windows.Forms.Button bSearchBook;
        private System.Windows.Forms.TextBox tSearchBook;
        private System.Windows.Forms.ComboBox cbFilterAuthor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFilterBookType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFilterBookLanguage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

