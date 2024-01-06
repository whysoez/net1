namespace bai4Prime
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tN = new System.Windows.Forms.TextBox();
            this.tSmallN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(313, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm số nguyên tố";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số NT nhỏ hơn N";
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(89, 432);
            this.bSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(148, 52);
            this.bSearch.TabIndex = 3;
            this.bSearch.Text = "Tìm";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(530, 432);
            this.bExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(187, 52);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Thoát";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tN
            // 
            this.tN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tN.Location = new System.Drawing.Point(386, 182);
            this.tN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tN.Name = "tN";
            this.tN.Size = new System.Drawing.Size(227, 44);
            this.tN.TabIndex = 5;
            // 
            // tSmallN
            // 
            this.tSmallN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSmallN.Location = new System.Drawing.Point(386, 274);
            this.tSmallN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tSmallN.Name = "tSmallN";
            this.tSmallN.Size = new System.Drawing.Size(474, 44);
            this.tSmallN.TabIndex = 6;
            this.tSmallN.TextChanged += new System.EventHandler(this.tSmallN_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tSmallN);
            this.Controls.Add(this.tN);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox tN;
        private System.Windows.Forms.TextBox tSmallN;
    }
}

