namespace bai18
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thodem = new System.Windows.Forms.TextBox();
            this.tten = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ehodem = new System.Windows.Forms.ErrorProvider(this.components);
            this.eten = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbsdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ehodem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eten)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ten,
            this.soluong,
            this.sdt});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 216);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Đệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // thodem
            // 
            this.thodem.Location = new System.Drawing.Point(698, 122);
            this.thodem.Name = "thodem";
            this.thodem.Size = new System.Drawing.Size(168, 26);
            this.thodem.TabIndex = 3;
            this.thodem.Validating += new System.ComponentModel.CancelEventHandler(this.thodem_Validating);
            // 
            // tten
            // 
            this.tten.Location = new System.Drawing.Point(698, 180);
            this.tten.Name = "tten";
            this.tten.Size = new System.Drawing.Size(168, 26);
            this.tten.TabIndex = 4;
            this.tten.Validating += new System.ComponentModel.CancelEventHandler(this.tten_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ten
            // 
            this.ten.Text = "Họ Đệm";
            this.ten.Width = 102;
            // 
            // soluong
            // 
            this.soluong.Text = "Tên";
            this.soluong.Width = 139;
            // 
            // sdt
            // 
            this.sdt.Text = "Số điện thoại";
            // 
            // ehodem
            // 
            this.ehodem.ContainerControl = this;
            // 
            // eten
            // 
            this.eten.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại";
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(698, 241);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(168, 26);
            this.tbsdt.TabIndex = 7;
            this.tbsdt.TextChanged += new System.EventHandler(this.tbsdt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tten);
            this.Controls.Add(this.thodem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ehodem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox thodem;
        private System.Windows.Forms.TextBox tten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.ColumnHeader sdt;
        private System.Windows.Forms.ErrorProvider ehodem;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider eten;
    }
}

