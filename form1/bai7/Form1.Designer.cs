namespace bai7
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
            this.tbten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbdiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbngaysinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.engaysinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.ediem = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.engaysinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ediem)).BeginInit();
            this.SuspendLayout();
            // 
            // tbten
            // 
            this.tbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbten.Location = new System.Drawing.Point(325, 122);
            this.tbten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(310, 35);
            this.tbten.TabIndex = 7;
            this.tbten.TextChanged += new System.EventHandler(this.tbten_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 542);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "dang ky";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Validated += new System.EventHandler(this.button1_Validated);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(605, 542);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbdiem
            // 
            this.tbdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdiem.Location = new System.Drawing.Point(325, 316);
            this.tbdiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbdiem.Name = "tbdiem";
            this.tbdiem.Size = new System.Drawing.Size(310, 35);
            this.tbdiem.TabIndex = 11;
            this.tbdiem.TextChanged += new System.EventHandler(this.tbdiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "diem trung binh";
            // 
            // tbngaysinh
            // 
            this.tbngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbngaysinh.Location = new System.Drawing.Point(325, 218);
            this.tbngaysinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbngaysinh.Name = "tbngaysinh";
            this.tbngaysinh.Size = new System.Drawing.Size(310, 35);
            this.tbngaysinh.TabIndex = 13;
            this.tbngaysinh.Validating += new System.ComponentModel.CancelEventHandler(this.tbngaysinh_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "ngay sinh";
            // 
            // engaysinh
            // 
            this.engaysinh.ContainerControl = this;
            // 
            // ediem
            // 
            this.ediem.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 697);
            this.Controls.Add(this.tbngaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbdiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.engaysinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ediem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbdiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbngaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider engaysinh;
        private System.Windows.Forms.ErrorProvider ediem;
    }
}

