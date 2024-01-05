namespace LibrarySystem
{
    partial class Menu
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
            this.bmenuLogin = new System.Windows.Forms.Button();
            this.bBookManager = new System.Windows.Forms.Button();
            this.bBorrowManager = new System.Windows.Forms.Button();
            this.bmenuExit = new System.Windows.Forms.Button();
            this.breaderManager = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bmenuLogin
            // 
            this.bmenuLogin.BackColor = System.Drawing.Color.Khaki;
            this.bmenuLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmenuLogin.Location = new System.Drawing.Point(1246, 49);
            this.bmenuLogin.Name = "bmenuLogin";
            this.bmenuLogin.Size = new System.Drawing.Size(175, 45);
            this.bmenuLogin.TabIndex = 47;
            this.bmenuLogin.Text = "Login";
            this.bmenuLogin.UseVisualStyleBackColor = false;
            this.bmenuLogin.Click += new System.EventHandler(this.bmenuLogin_Click);
            // 
            // bBookManager
            // 
            this.bBookManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBookManager.Location = new System.Drawing.Point(485, 495);
            this.bBookManager.Name = "bBookManager";
            this.bBookManager.Size = new System.Drawing.Size(398, 45);
            this.bBookManager.TabIndex = 48;
            this.bBookManager.Text = "Book Management";
            this.bBookManager.UseVisualStyleBackColor = true;
            this.bBookManager.Click += new System.EventHandler(this.bBookManager_Click);
            // 
            // bBorrowManager
            // 
            this.bBorrowManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrowManager.Location = new System.Drawing.Point(485, 591);
            this.bBorrowManager.Name = "bBorrowManager";
            this.bBorrowManager.Size = new System.Drawing.Size(398, 45);
            this.bBorrowManager.TabIndex = 49;
            this.bBorrowManager.Text = "Borrow Management";
            this.bBorrowManager.UseVisualStyleBackColor = true;
            this.bBorrowManager.Click += new System.EventHandler(this.bBorrowManager_Click);
            // 
            // bmenuExit
            // 
            this.bmenuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bmenuExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmenuExit.Location = new System.Drawing.Point(605, 800);
            this.bmenuExit.Name = "bmenuExit";
            this.bmenuExit.Size = new System.Drawing.Size(175, 57);
            this.bmenuExit.TabIndex = 50;
            this.bmenuExit.Text = "Exit";
            this.bmenuExit.UseVisualStyleBackColor = false;
            this.bmenuExit.Click += new System.EventHandler(this.bmenuExit_Click);
            // 
            // breaderManager
            // 
            this.breaderManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breaderManager.Location = new System.Drawing.Point(485, 396);
            this.breaderManager.Name = "breaderManager";
            this.breaderManager.Size = new System.Drawing.Size(398, 45);
            this.breaderManager.TabIndex = 51;
            this.breaderManager.Text = "Reader Management";
            this.breaderManager.UseVisualStyleBackColor = true;
            this.breaderManager.Click += new System.EventHandler(this.breaderManager_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(170, 200);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(1049, 46);
            this.username.TabIndex = 52;
            this.username.Text = "QUẢN LÝ THƯ VIỆN TRƯỜNG ĐẠI HỌC MỎ - ĐỊA CHẤT";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 1075);
            this.Controls.Add(this.username);
            this.Controls.Add(this.breaderManager);
            this.Controls.Add(this.bmenuExit);
            this.Controls.Add(this.bBorrowManager);
            this.Controls.Add(this.bBookManager);
            this.Controls.Add(this.bmenuLogin);
            this.Name = "Menu";
            this.Text = "Menu Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bmenuLogin;
        private System.Windows.Forms.Button bBookManager;
        private System.Windows.Forms.Button bBorrowManager;
        private System.Windows.Forms.Button bmenuExit;
        private System.Windows.Forms.Button breaderManager;
        private System.Windows.Forms.Label username;

    }
}