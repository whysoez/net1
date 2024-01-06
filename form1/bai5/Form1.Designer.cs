namespace bai5
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
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rbnghich = new System.Windows.Forms.RadioButton();
            this.rbmu = new System.Windows.Forms.RadioButton();
            this.rbgiaithua = new System.Windows.Forms.RadioButton();
            this.tbn = new System.Windows.Forms.TextBox();
            this.tbketqua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btinh = new System.Windows.Forms.Button();
            this.btiep = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(90, 110);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(116, 24);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1+3+ (2n-1)";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rbnghich
            // 
            this.rbnghich.AutoSize = true;
            this.rbnghich.Location = new System.Drawing.Point(90, 241);
            this.rbnghich.Name = "rbnghich";
            this.rbnghich.Size = new System.Drawing.Size(74, 24);
            this.rbnghich.TabIndex = 1;
            this.rbnghich.TabStop = true;
            this.rbnghich.Text = "1+1/n";
            this.rbnghich.UseVisualStyleBackColor = true;
            // 
            // rbmu
            // 
            this.rbmu.AutoSize = true;
            this.rbmu.Location = new System.Drawing.Point(90, 175);
            this.rbmu.Name = "rbmu";
            this.rbmu.Size = new System.Drawing.Size(77, 24);
            this.rbmu.TabIndex = 2;
            this.rbmu.TabStop = true;
            this.rbmu.Text = "1+n^2";
            this.rbmu.UseVisualStyleBackColor = true;
            // 
            // rbgiaithua
            // 
            this.rbgiaithua.AutoSize = true;
            this.rbgiaithua.Location = new System.Drawing.Point(90, 313);
            this.rbgiaithua.Name = "rbgiaithua";
            this.rbgiaithua.Size = new System.Drawing.Size(78, 24);
            this.rbgiaithua.TabIndex = 3;
            this.rbgiaithua.TabStop = true;
            this.rbgiaithua.Text = "1+1/n!";
            this.rbgiaithua.UseVisualStyleBackColor = true;
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(255, 28);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(100, 26);
            this.tbn.TabIndex = 4;
            // 
            // tbketqua
            // 
            this.tbketqua.Location = new System.Drawing.Point(587, 135);
            this.tbketqua.Name = "tbketqua";
            this.tbketqua.Size = new System.Drawing.Size(100, 26);
            this.tbketqua.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "N";
            // 
            // btinh
            // 
            this.btinh.Location = new System.Drawing.Point(585, 64);
            this.btinh.Name = "btinh";
            this.btinh.Size = new System.Drawing.Size(102, 39);
            this.btinh.TabIndex = 7;
            this.btinh.Text = "tinh";
            this.btinh.UseVisualStyleBackColor = true;
            this.btinh.Click += new System.EventHandler(this.btinh_Click);
            // 
            // btiep
            // 
            this.btiep.Location = new System.Drawing.Point(504, 241);
            this.btiep.Name = "btiep";
            this.btiep.Size = new System.Drawing.Size(102, 39);
            this.btiep.TabIndex = 8;
            this.btiep.Text = "tiep tuc";
            this.btiep.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 9;
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
            this.Controls.Add(this.btiep);
            this.Controls.Add(this.btinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbketqua);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.rbgiaithua);
            this.Controls.Add(this.rbmu);
            this.Controls.Add(this.rbnghich);
            this.Controls.Add(this.rb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rbnghich;
        private System.Windows.Forms.RadioButton rbmu;
        private System.Windows.Forms.RadioButton rbgiaithua;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.TextBox tbketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btinh;
        private System.Windows.Forms.Button btiep;
        private System.Windows.Forms.Button button1;
    }
}

