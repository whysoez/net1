namespace bai2ListBox2
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
            this.tN = new System.Windows.Forms.TextBox();
            this.bUpdate = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSum = new System.Windows.Forms.Button();
            this.bRemoveFL = new System.Windows.Forms.Button();
            this.bOdd = new System.Windows.Forms.Button();
            this.bRemoveSelected = new System.Windows.Forms.Button();
            this.bUp2 = new System.Windows.Forms.Button();
            this.bSquare = new System.Windows.Forms.Button();
            this.bEven = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bExit = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number";
            // 
            // tN
            // 
            this.tN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tN.Location = new System.Drawing.Point(235, 39);
            this.tN.Name = "tN";
            this.tN.Size = new System.Drawing.Size(363, 34);
            this.tN.TabIndex = 1;
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(635, 31);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(130, 50);
            this.bUpdate.TabIndex = 2;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 29;
            this.lb.Location = new System.Drawing.Point(35, 41);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(229, 294);
            this.lb.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 354);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class A";
            // 
            // bSum
            // 
            this.bSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSum.Location = new System.Drawing.Point(43, 34);
            this.bSum.Name = "bSum";
            this.bSum.Size = new System.Drawing.Size(240, 39);
            this.bSum.TabIndex = 5;
            this.bSum.Text = "Sum List";
            this.bSum.UseVisualStyleBackColor = true;
            this.bSum.Click += new System.EventHandler(this.bSum_Click);
            // 
            // bRemoveFL
            // 
            this.bRemoveFL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRemoveFL.Location = new System.Drawing.Point(43, 79);
            this.bRemoveFL.Name = "bRemoveFL";
            this.bRemoveFL.Size = new System.Drawing.Size(240, 39);
            this.bRemoveFL.TabIndex = 6;
            this.bRemoveFL.Text = "Remove First Last";
            this.bRemoveFL.UseVisualStyleBackColor = true;
            this.bRemoveFL.Click += new System.EventHandler(this.button1_Click);
            // 
            // bOdd
            // 
            this.bOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOdd.Location = new System.Drawing.Point(43, 304);
            this.bOdd.Name = "bOdd";
            this.bOdd.Size = new System.Drawing.Size(240, 39);
            this.bOdd.TabIndex = 7;
            this.bOdd.Text = "Select Odd";
            this.bOdd.UseVisualStyleBackColor = true;
            this.bOdd.Click += new System.EventHandler(this.bOdd_Click);
            // 
            // bRemoveSelected
            // 
            this.bRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRemoveSelected.Location = new System.Drawing.Point(43, 124);
            this.bRemoveSelected.Name = "bRemoveSelected";
            this.bRemoveSelected.Size = new System.Drawing.Size(240, 39);
            this.bRemoveSelected.TabIndex = 8;
            this.bRemoveSelected.Text = "Remove Selected";
            this.bRemoveSelected.UseVisualStyleBackColor = true;
            this.bRemoveSelected.Click += new System.EventHandler(this.bRemoveSelected_Click);
            // 
            // bUp2
            // 
            this.bUp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUp2.Location = new System.Drawing.Point(43, 169);
            this.bUp2.Name = "bUp2";
            this.bUp2.Size = new System.Drawing.Size(240, 39);
            this.bUp2.TabIndex = 9;
            this.bUp2.Text = "Up each 2";
            this.bUp2.UseVisualStyleBackColor = true;
            this.bUp2.Click += new System.EventHandler(this.bUp2_Click);
            // 
            // bSquare
            // 
            this.bSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSquare.Location = new System.Drawing.Point(43, 214);
            this.bSquare.Name = "bSquare";
            this.bSquare.Size = new System.Drawing.Size(240, 39);
            this.bSquare.TabIndex = 10;
            this.bSquare.Text = "Replace Square";
            this.bSquare.UseVisualStyleBackColor = true;
            this.bSquare.Click += new System.EventHandler(this.bSquare_Click);
            // 
            // bEven
            // 
            this.bEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEven.Location = new System.Drawing.Point(43, 259);
            this.bEven.Name = "bEven";
            this.bEven.Size = new System.Drawing.Size(240, 39);
            this.bEven.TabIndex = 11;
            this.bEven.Text = "Select Even";
            this.bEven.UseVisualStyleBackColor = true;
            this.bEven.Click += new System.EventHandler(this.bEven_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bEven);
            this.groupBox2.Controls.Add(this.bSquare);
            this.groupBox2.Controls.Add(this.bUp2);
            this.groupBox2.Controls.Add(this.bRemoveSelected);
            this.groupBox2.Controls.Add(this.bOdd);
            this.groupBox2.Controls.Add(this.bRemoveFL);
            this.groupBox2.Controls.Add(this.bSum);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(437, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 360);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Function";
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(235, 510);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(337, 39);
            this.bExit.TabIndex = 12;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(635, 510);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(110, 39);
            this.bClear.TabIndex = 12;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.tN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tN;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bSum;
        private System.Windows.Forms.Button bRemoveFL;
        private System.Windows.Forms.Button bOdd;
        private System.Windows.Forms.Button bRemoveSelected;
        private System.Windows.Forms.Button bUp2;
        private System.Windows.Forms.Button bSquare;
        private System.Windows.Forms.Button bEven;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bClear;
    }
}

