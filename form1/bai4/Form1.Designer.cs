namespace bai4
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
            this.cdam = new System.Windows.Forms.CheckBox();
            this.cgach = new System.Windows.Forms.CheckBox();
            this.cnghieng = new System.Windows.Forms.CheckBox();
            this.rbdo = new System.Windows.Forms.RadioButton();
            this.rbDen = new System.Windows.Forms.RadioButton();
            this.rbxanh = new System.Windows.Forms.RadioButton();
            this.bhien = new System.Windows.Forms.Button();
            this.bxoa = new System.Windows.Forms.Button();
            this.bthoat = new System.Windows.Forms.Button();
            this.tbcontent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cdam
            // 
            this.cdam.AutoSize = true;
            this.cdam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdam.Location = new System.Drawing.Point(568, 12);
            this.cdam.Name = "cdam";
            this.cdam.Size = new System.Drawing.Size(89, 33);
            this.cdam.TabIndex = 0;
            this.cdam.Text = "Đậm";
            this.cdam.UseVisualStyleBackColor = true;
            // 
            // cgach
            // 
            this.cgach.AutoSize = true;
            this.cgach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgach.Location = new System.Drawing.Point(568, 184);
            this.cgach.Name = "cgach";
            this.cgach.Size = new System.Drawing.Size(148, 33);
            this.cgach.TabIndex = 1;
            this.cgach.Text = "Gạch dưới";
            this.cgach.UseVisualStyleBackColor = true;
            // 
            // cnghieng
            // 
            this.cnghieng.AutoSize = true;
            this.cnghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnghieng.Location = new System.Drawing.Point(568, 89);
            this.cnghieng.Name = "cnghieng";
            this.cnghieng.Size = new System.Drawing.Size(131, 33);
            this.cnghieng.TabIndex = 2;
            this.cnghieng.Text = "Nghiêng";
            this.cnghieng.UseVisualStyleBackColor = true;
            // 
            // rbdo
            // 
            this.rbdo.AutoSize = true;
            this.rbdo.Location = new System.Drawing.Point(234, 21);
            this.rbdo.Name = "rbdo";
            this.rbdo.Size = new System.Drawing.Size(55, 24);
            this.rbdo.TabIndex = 3;
            this.rbdo.TabStop = true;
            this.rbdo.Text = "Đỏ";
            this.rbdo.UseVisualStyleBackColor = true;
            // 
            // rbDen
            // 
            this.rbDen.AutoSize = true;
            this.rbDen.Location = new System.Drawing.Point(234, 137);
            this.rbDen.Name = "rbDen";
            this.rbDen.Size = new System.Drawing.Size(64, 24);
            this.rbDen.TabIndex = 4;
            this.rbDen.TabStop = true;
            this.rbDen.Text = "Đen";
            this.rbDen.UseVisualStyleBackColor = true;
            // 
            // rbxanh
            // 
            this.rbxanh.AutoSize = true;
            this.rbxanh.Location = new System.Drawing.Point(234, 76);
            this.rbxanh.Name = "rbxanh";
            this.rbxanh.Size = new System.Drawing.Size(72, 24);
            this.rbxanh.TabIndex = 5;
            this.rbxanh.TabStop = true;
            this.rbxanh.Text = "Xanh";
            this.rbxanh.UseVisualStyleBackColor = true;
            // 
            // bhien
            // 
            this.bhien.Location = new System.Drawing.Point(134, 625);
            this.bhien.Name = "bhien";
            this.bhien.Size = new System.Drawing.Size(155, 48);
            this.bhien.TabIndex = 6;
            this.bhien.Text = "Hiện";
            this.bhien.UseVisualStyleBackColor = true;
            this.bhien.Click += new System.EventHandler(this.bhien_Click);
            // 
            // bxoa
            // 
            this.bxoa.Location = new System.Drawing.Point(442, 625);
            this.bxoa.Name = "bxoa";
            this.bxoa.Size = new System.Drawing.Size(155, 48);
            this.bxoa.TabIndex = 7;
            this.bxoa.Text = "Xóa";
            this.bxoa.UseVisualStyleBackColor = true;
            this.bxoa.Click += new System.EventHandler(this.bxoa_Click);
            // 
            // bthoat
            // 
            this.bthoat.Location = new System.Drawing.Point(721, 625);
            this.bthoat.Name = "bthoat";
            this.bthoat.Size = new System.Drawing.Size(155, 48);
            this.bthoat.TabIndex = 8;
            this.bthoat.Text = "Kết thúc";
            this.bthoat.UseVisualStyleBackColor = true;
            this.bthoat.Click += new System.EventHandler(this.bthoat_Click);
            // 
            // tbcontent
            // 
            this.tbcontent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontent.Location = new System.Drawing.Point(99, 281);
            this.tbcontent.Name = "tbcontent";
            this.tbcontent.Size = new System.Drawing.Size(808, 39);
            this.tbcontent.TabIndex = 9;
            this.tbcontent.Text = "Trường đại học mỏ địa chất";
            this.tbcontent.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 775);
            this.Controls.Add(this.tbcontent);
            this.Controls.Add(this.bthoat);
            this.Controls.Add(this.bxoa);
            this.Controls.Add(this.bhien);
            this.Controls.Add(this.rbxanh);
            this.Controls.Add(this.rbDen);
            this.Controls.Add(this.rbdo);
            this.Controls.Add(this.cnghieng);
            this.Controls.Add(this.cgach);
            this.Controls.Add(this.cdam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cdam;
        private System.Windows.Forms.CheckBox cgach;
        private System.Windows.Forms.CheckBox cnghieng;
        private System.Windows.Forms.RadioButton rbdo;
        private System.Windows.Forms.RadioButton rbDen;
        private System.Windows.Forms.RadioButton rbxanh;
        private System.Windows.Forms.Button bhien;
        private System.Windows.Forms.Button bxoa;
        private System.Windows.Forms.Button bthoat;
        private System.Windows.Forms.TextBox tbcontent;
    }
}

