namespace form1
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
            this.bthanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ttenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tsoLuong = new System.Windows.Forms.TextBox();
            this.tdonGia = new System.Windows.Forms.TextBox();
            this.btiep = new System.Windows.Forms.Button();
            this.bketThuc = new System.Windows.Forms.Button();
            this.tthanhTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edonGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.esoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.edonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // bthanhToan
            // 
            this.bthanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthanhToan.ForeColor = System.Drawing.Color.DarkRed;
            this.bthanhToan.Location = new System.Drawing.Point(88, 458);
            this.bthanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bthanhToan.Name = "bthanhToan";
            this.bthanhToan.Size = new System.Drawing.Size(220, 69);
            this.bthanhToan.TabIndex = 4;
            this.bthanhToan.Text = "Thanh Toán";
            this.bthanhToan.UseMnemonic = false;
            this.bthanhToan.UseVisualStyleBackColor = true;
            this.bthanhToan.Click += new System.EventHandler(this.but1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Hàng";
            // 
            // ttenHang
            // 
            this.ttenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttenHang.Location = new System.Drawing.Point(394, 78);
            this.ttenHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ttenHang.Name = "ttenHang";
            this.ttenHang.Size = new System.Drawing.Size(352, 44);
            this.ttenHang.TabIndex = 0;
            this.ttenHang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 57);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng";
            // 
            // tsoLuong
            // 
            this.tsoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsoLuong.Location = new System.Drawing.Point(394, 155);
            this.tsoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tsoLuong.Name = "tsoLuong";
            this.tsoLuong.Size = new System.Drawing.Size(352, 44);
            this.tsoLuong.TabIndex = 1;
            this.tsoLuong.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tsoLuong.Validating += new System.ComponentModel.CancelEventHandler(this.numeric_valid);
            // 
            // tdonGia
            // 
            this.tdonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdonGia.Location = new System.Drawing.Point(394, 231);
            this.tdonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tdonGia.Name = "tdonGia";
            this.tdonGia.Size = new System.Drawing.Size(352, 44);
            this.tdonGia.TabIndex = 2;
            this.tdonGia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tdonGia.Validating += new System.ComponentModel.CancelEventHandler(this.edongia_valid);
            // 
            // btiep
            // 
            this.btiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btiep.ForeColor = System.Drawing.Color.Brown;
            this.btiep.Location = new System.Drawing.Point(409, 458);
            this.btiep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btiep.Name = "btiep";
            this.btiep.Size = new System.Drawing.Size(173, 69);
            this.btiep.TabIndex = 5;
            this.btiep.Text = "Tiếp";
            this.btiep.UseVisualStyleBackColor = true;
            this.btiep.Click += new System.EventHandler(this.btn2_Click);
            // 
            // bketThuc
            // 
            this.bketThuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bketThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bketThuc.ForeColor = System.Drawing.Color.Brown;
            this.bketThuc.Location = new System.Drawing.Point(673, 458);
            this.bketThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bketThuc.Name = "bketThuc";
            this.bketThuc.Size = new System.Drawing.Size(173, 69);
            this.bketThuc.TabIndex = 6;
            this.bketThuc.Text = "Kết Thúc";
            this.bketThuc.UseVisualStyleBackColor = true;
            this.bketThuc.Click += new System.EventHandler(this.btn3_Click);
            // 
            // tthanhTien
            // 
            this.tthanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tthanhTien.Location = new System.Drawing.Point(394, 312);
            this.tthanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tthanhTien.Name = "tthanhTien";
            this.tthanhTien.Size = new System.Drawing.Size(352, 44);
            this.tthanhTien.TabIndex = 3;
            this.tthanhTien.TextChanged += new System.EventHandler(this.tthanhTien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thành Tiền";
            // 
            // edonGia
            // 
            this.edonGia.ContainerControl = this;
            // 
            // esoLuong
            // 
            this.esoLuong.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.bthanhToan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.bketThuc;
            this.ClientSize = new System.Drawing.Size(938, 626);
            this.Controls.Add(this.tthanhTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bketThuc);
            this.Controls.Add(this.btiep);
            this.Controls.Add(this.tdonGia);
            this.Controls.Add(this.tsoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttenHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bthanhToan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Program example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tsoLuong;
        private System.Windows.Forms.TextBox tdonGia;
        private System.Windows.Forms.Button btiep;
        private System.Windows.Forms.Button bketThuc;
        private System.Windows.Forms.TextBox tthanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider edonGia;
        private System.Windows.Forms.ErrorProvider esoLuong;
    }
}

