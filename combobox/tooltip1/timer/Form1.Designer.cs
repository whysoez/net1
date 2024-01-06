namespace timer
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
            this.tbb = new System.Windows.Forms.TextBox();
            this.tba = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.tbnghiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bluu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(326, 129);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(306, 26);
            this.tbb.TabIndex = 12;
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(326, 73);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(306, 26);
            this.tba.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "b";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(142, 74);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(18, 20);
            this.lbten.TabIndex = 9;
            this.lbten.Text = "a";
            // 
            // tbnghiem
            // 
            this.tbnghiem.Location = new System.Drawing.Point(326, 187);
            this.tbnghiem.Name = "tbnghiem";
            this.tbnghiem.Size = new System.Drawing.Size(306, 26);
            this.tbnghiem.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "nghiem";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "thoat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bluu
            // 
            this.bluu.Location = new System.Drawing.Point(284, 253);
            this.bluu.Name = "bluu";
            this.bluu.Size = new System.Drawing.Size(92, 34);
            this.bluu.TabIndex = 15;
            this.bluu.Text = "kiem tra";
            this.bluu.UseVisualStyleBackColor = true;
            this.bluu.Click += new System.EventHandler(this.bluu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ax + b =0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bluu);
            this.Controls.Add(this.tbnghiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.TextBox tbnghiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bluu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

