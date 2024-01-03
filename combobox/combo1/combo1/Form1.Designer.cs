namespace combo1
{
    partial class tResult
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bResult = new System.Windows.Forms.Button();
            this.tA = new System.Windows.Forms.TextBox();
            this.tB = new System.Windows.Forms.TextBox();
            this.cOperator = new System.Windows.Forms.ComboBox();
            this.tRe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "B";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phép tính";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết quả";
            // 
            // bResult
            // 
            this.bResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResult.Location = new System.Drawing.Point(292, 355);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(175, 52);
            this.bResult.TabIndex = 5;
            this.bResult.Text = "Thực hiện";
            this.bResult.UseVisualStyleBackColor = true;
            this.bResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // tA
            // 
            this.tA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tA.Location = new System.Drawing.Point(100, 72);
            this.tA.Name = "tA";
            this.tA.Size = new System.Drawing.Size(281, 38);
            this.tA.TabIndex = 6;
            // 
            // tB
            // 
            this.tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB.Location = new System.Drawing.Point(486, 72);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(281, 38);
            this.tB.TabIndex = 7;
            // 
            // cOperator
            // 
            this.cOperator.AutoCompleteCustomSource.AddRange(new string[] {
            "+",
            "-",
            "*",
            "/"});
            this.cOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOperator.FormattingEnabled = true;
            this.cOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cOperator.Location = new System.Drawing.Point(159, 222);
            this.cOperator.Name = "cOperator";
            this.cOperator.Size = new System.Drawing.Size(164, 33);
            this.cOperator.TabIndex = 8;
            this.cOperator.SelectedIndexChanged += new System.EventHandler(this.cOperator_SelectedIndexChanged);
            // 
            // tRe
            // 
            this.tRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRe.Location = new System.Drawing.Point(540, 222);
            this.tRe.Name = "tRe";
            this.tRe.Size = new System.Drawing.Size(168, 30);
            this.tRe.TabIndex = 9;
            this.tRe.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tRe);
            this.Controls.Add(this.cOperator);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.tA);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "tResult";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.TextBox tA;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.ComboBox cOperator;
        private System.Windows.Forms.TextBox tRe;
    }
}

