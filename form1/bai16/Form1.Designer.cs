namespace bai16
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
            this.lbten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tblop = new System.Windows.Forms.TextBox();
            this.bluu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(108, 75);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(74, 20);
            this.lbten.TabIndex = 0;
            this.lbten.Text = "ho va ten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "danh sach mon hoc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "lop";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(350, 202);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "lap trinh c";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(349, 250);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(138, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "mang may tinh";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(349, 377);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(124, 24);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "lap trinh web";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(350, 308);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(96, 24);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "xu ly anh";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // tbhoten
            // 
            this.tbhoten.Location = new System.Drawing.Point(292, 74);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(306, 26);
            this.tbhoten.TabIndex = 7;
            // 
            // tblop
            // 
            this.tblop.Location = new System.Drawing.Point(292, 130);
            this.tblop.Name = "tblop";
            this.tblop.Size = new System.Drawing.Size(306, 26);
            this.tblop.TabIndex = 8;
            // 
            // bluu
            // 
            this.bluu.Location = new System.Drawing.Point(637, 232);
            this.bluu.Name = "bluu";
            this.bluu.Size = new System.Drawing.Size(92, 34);
            this.bluu.TabIndex = 9;
            this.bluu.Text = "luu";
            this.bluu.UseVisualStyleBackColor = true;
            this.bluu.Click += new System.EventHandler(this.bluu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "thoat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bluu);
            this.Controls.Add(this.tblop);
            this.Controls.Add(this.tbhoten);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.TextBox tblop;
        private System.Windows.Forms.Button bluu;
        private System.Windows.Forms.Button button1;
    }
}

