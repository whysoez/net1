namespace Bai3UCLN
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tA = new System.Windows.Forms.TextBox();
            this.tUcln = new System.Windows.Forms.TextBox();
            this.tBcnn = new System.Windows.Forms.TextBox();
            this.tB = new System.Windows.Forms.TextBox();
            this.bRun = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "BCNN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "UCLN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập số b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(308, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "UCLN và BCNN";
            // 
            // tA
            // 
            this.tA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tA.Location = new System.Drawing.Point(348, 104);
            this.tA.Name = "tA";
            this.tA.Size = new System.Drawing.Size(243, 38);
            this.tA.TabIndex = 5;
            // 
            // tUcln
            // 
            this.tUcln.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUcln.Location = new System.Drawing.Point(348, 217);
            this.tUcln.Name = "tUcln";
            this.tUcln.Size = new System.Drawing.Size(56, 38);
            this.tUcln.TabIndex = 6;
            // 
            // tBcnn
            // 
            this.tBcnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBcnn.Location = new System.Drawing.Point(348, 268);
            this.tBcnn.Name = "tBcnn";
            this.tBcnn.Size = new System.Drawing.Size(56, 38);
            this.tBcnn.TabIndex = 7;
            // 
            // tB
            // 
            this.tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB.Location = new System.Drawing.Point(348, 161);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(243, 38);
            this.tB.TabIndex = 8;
            // 
            // bRun
            // 
            this.bRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRun.Location = new System.Drawing.Point(81, 362);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(165, 41);
            this.bRun.TabIndex = 9;
            this.bRun.Text = "Thực hiện";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(558, 362);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(165, 41);
            this.bExit.TabIndex = 10;
            this.bExit.Text = "Thoát";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bContinue
            // 
            this.bContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bContinue.Location = new System.Drawing.Point(318, 362);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(165, 41);
            this.bContinue.TabIndex = 11;
            this.bContinue.Text = "Tiếp tục";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bContinue);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.tBcnn);
            this.Controls.Add(this.tUcln);
            this.Controls.Add(this.tA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tA;
        private System.Windows.Forms.TextBox tUcln;
        private System.Windows.Forms.TextBox tBcnn;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bContinue;
    }
}

