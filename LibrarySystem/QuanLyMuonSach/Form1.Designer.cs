namespace QuanLyMuonSach
{
    partial class QuanLyMuonSach
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
            this.dGBorrow = new System.Windows.Forms.DataGridView();
            this.bFilterBorrow = new System.Windows.Forms.Button();
            this.bDeleteBorrow = new System.Windows.Forms.Button();
            this.bUpdateBorrow = new System.Windows.Forms.Button();
            this.bCreateBorrow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tborrowDeadlineTime = new System.Windows.Forms.TextBox();
            this.tGiveBack = new System.Windows.Forms.TextBox();
            this.tGiveTime = new System.Windows.Forms.TextBox();
            this.tborrowTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tborrowBookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.read = new System.Windows.Forms.Label();
            this.tborrowReaderId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dGBorrow
            // 
            this.dGBorrow.AllowUserToOrderColumns = true;
            this.dGBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGBorrow.Location = new System.Drawing.Point(161, 704);
            this.dGBorrow.Name = "dGBorrow";
            this.dGBorrow.RowHeadersWidth = 62;
            this.dGBorrow.RowTemplate.Height = 28;
            this.dGBorrow.Size = new System.Drawing.Size(1851, 378);
            this.dGBorrow.TabIndex = 50;
            this.dGBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGBorrow_CellContentClick);
            // 
            // bFilterBorrow
            // 
            this.bFilterBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFilterBorrow.Location = new System.Drawing.Point(1436, 1194);
            this.bFilterBorrow.Name = "bFilterBorrow";
            this.bFilterBorrow.Size = new System.Drawing.Size(177, 40);
            this.bFilterBorrow.TabIndex = 49;
            this.bFilterBorrow.Text = "Filter Borrow";
            this.bFilterBorrow.UseVisualStyleBackColor = true;
            // 
            // bDeleteBorrow
            // 
            this.bDeleteBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteBorrow.Location = new System.Drawing.Point(830, 1192);
            this.bDeleteBorrow.Name = "bDeleteBorrow";
            this.bDeleteBorrow.Size = new System.Drawing.Size(276, 45);
            this.bDeleteBorrow.TabIndex = 48;
            this.bDeleteBorrow.Text = "Delete Borrow";
            this.bDeleteBorrow.UseVisualStyleBackColor = true;
            // 
            // bUpdateBorrow
            // 
            this.bUpdateBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdateBorrow.Location = new System.Drawing.Point(502, 1192);
            this.bUpdateBorrow.Name = "bUpdateBorrow";
            this.bUpdateBorrow.Size = new System.Drawing.Size(246, 45);
            this.bUpdateBorrow.TabIndex = 47;
            this.bUpdateBorrow.Text = "Update Borrow";
            this.bUpdateBorrow.UseVisualStyleBackColor = true;
            // 
            // bCreateBorrow
            // 
            this.bCreateBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateBorrow.Location = new System.Drawing.Point(204, 1192);
            this.bCreateBorrow.Name = "bCreateBorrow";
            this.bCreateBorrow.Size = new System.Drawing.Size(231, 45);
            this.bCreateBorrow.TabIndex = 46;
            this.bCreateBorrow.Text = "Create Borrow";
            this.bCreateBorrow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1493, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Deadline Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 44);
            this.label4.TabIndex = 40;
            this.label4.Text = "Give Back";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 44);
            this.label3.TabIndex = 39;
            this.label3.Text = "Give Time";
            // 
            // tborrowDeadlineTime
            // 
            this.tborrowDeadlineTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborrowDeadlineTime.Location = new System.Drawing.Point(1771, 102);
            this.tborrowDeadlineTime.Name = "tborrowDeadlineTime";
            this.tborrowDeadlineTime.Size = new System.Drawing.Size(402, 35);
            this.tborrowDeadlineTime.TabIndex = 34;
            // 
            // tGiveBack
            // 
            this.tGiveBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tGiveBack.Location = new System.Drawing.Point(456, 570);
            this.tGiveBack.Name = "tGiveBack";
            this.tGiveBack.Size = new System.Drawing.Size(402, 35);
            this.tGiveBack.TabIndex = 33;
            // 
            // tGiveTime
            // 
            this.tGiveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tGiveTime.Location = new System.Drawing.Point(456, 423);
            this.tGiveTime.Name = "tGiveTime";
            this.tGiveTime.Size = new System.Drawing.Size(402, 35);
            this.tGiveTime.TabIndex = 32;
            // 
            // tborrowTime
            // 
            this.tborrowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborrowTime.Location = new System.Drawing.Point(456, 293);
            this.tborrowTime.Name = "tborrowTime";
            this.tborrowTime.Size = new System.Drawing.Size(402, 35);
            this.tborrowTime.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 44);
            this.label2.TabIndex = 30;
            this.label2.Text = "Borrow Time";
            // 
            // tborrowBookId
            // 
            this.tborrowBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborrowBookId.Location = new System.Drawing.Point(456, 180);
            this.tborrowBookId.Name = "tborrowBookId";
            this.tborrowBookId.Size = new System.Drawing.Size(402, 35);
            this.tborrowBookId.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "Book";
            // 
            // read
            // 
            this.read.AutoSize = true;
            this.read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read.Location = new System.Drawing.Point(295, 87);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(140, 44);
            this.read.TabIndex = 27;
            this.read.Text = "Reader";
            // 
            // tborrowReaderId
            // 
            this.tborrowReaderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tborrowReaderId.Location = new System.Drawing.Point(456, 84);
            this.tborrowReaderId.Name = "tborrowReaderId";
            this.tborrowReaderId.Size = new System.Drawing.Size(402, 35);
            this.tborrowReaderId.TabIndex = 26;
            // 
            // QuanLyMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2373, 1300);
            this.Controls.Add(this.dGBorrow);
            this.Controls.Add(this.bFilterBorrow);
            this.Controls.Add(this.bDeleteBorrow);
            this.Controls.Add(this.bUpdateBorrow);
            this.Controls.Add(this.bCreateBorrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tborrowDeadlineTime);
            this.Controls.Add(this.tGiveBack);
            this.Controls.Add(this.tGiveTime);
            this.Controls.Add(this.tborrowTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tborrowBookId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.read);
            this.Controls.Add(this.tborrowReaderId);
            this.Name = "QuanLyMuonSach";
            this.Text = "Quản Lý Mượn Sách";
            this.Load += new System.EventHandler(this.QuanLyMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGBorrow;
        private System.Windows.Forms.Button bFilterBorrow;
        private System.Windows.Forms.Button bDeleteBorrow;
        private System.Windows.Forms.Button bUpdateBorrow;
        private System.Windows.Forms.Button bCreateBorrow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tborrowDeadlineTime;
        private System.Windows.Forms.TextBox tGiveBack;
        private System.Windows.Forms.TextBox tGiveTime;
        private System.Windows.Forms.TextBox tborrowTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tborrowBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label read;
        private System.Windows.Forms.TextBox tborrowReaderId;
    }
}

