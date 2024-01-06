namespace bai10
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
            this.lbtrai = new System.Windows.Forms.ListBox();
            this.bchuyenphai = new System.Windows.Forms.Button();
            this.bchuyenphaihet = new System.Windows.Forms.Button();
            this.bchuyentraihet = new System.Windows.Forms.Button();
            this.bchuyentrai = new System.Windows.Forms.Button();
            this.lbphai = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbtrai
            // 
            this.lbtrai.FormattingEnabled = true;
            this.lbtrai.ItemHeight = 20;
            this.lbtrai.Items.AddRange(new object[] {
            "bo kho",
            "pho bo",
            "chao",
            "bun bo",
            "mi xao"});
            this.lbtrai.Location = new System.Drawing.Point(46, 70);
            this.lbtrai.Name = "lbtrai";
            this.lbtrai.Size = new System.Drawing.Size(262, 244);
            this.lbtrai.TabIndex = 0;
            // 
            // bchuyenphai
            // 
            this.bchuyenphai.Location = new System.Drawing.Point(375, 87);
            this.bchuyenphai.Name = "bchuyenphai";
            this.bchuyenphai.Size = new System.Drawing.Size(89, 35);
            this.bchuyenphai.TabIndex = 2;
            this.bchuyenphai.Text = ">";
            this.bchuyenphai.UseVisualStyleBackColor = true;
            this.bchuyenphai.Click += new System.EventHandler(this.bchuyenphai_Click);
            // 
            // bchuyenphaihet
            // 
            this.bchuyenphaihet.Location = new System.Drawing.Point(375, 206);
            this.bchuyenphaihet.Name = "bchuyenphaihet";
            this.bchuyenphaihet.Size = new System.Drawing.Size(89, 35);
            this.bchuyenphaihet.TabIndex = 3;
            this.bchuyenphaihet.Text = ">>>";
            this.bchuyenphaihet.UseVisualStyleBackColor = true;
            this.bchuyenphaihet.Click += new System.EventHandler(this.bchuyenphaihet_Click);
            // 
            // bchuyentraihet
            // 
            this.bchuyentraihet.Location = new System.Drawing.Point(375, 263);
            this.bchuyentraihet.Name = "bchuyentraihet";
            this.bchuyentraihet.Size = new System.Drawing.Size(89, 35);
            this.bchuyentraihet.TabIndex = 4;
            this.bchuyentraihet.Text = "<<<";
            this.bchuyentraihet.UseVisualStyleBackColor = true;
            this.bchuyentraihet.Click += new System.EventHandler(this.bchuyentraihet_Click);
            // 
            // bchuyentrai
            // 
            this.bchuyentrai.Location = new System.Drawing.Point(375, 128);
            this.bchuyentrai.Name = "bchuyentrai";
            this.bchuyentrai.Size = new System.Drawing.Size(89, 35);
            this.bchuyentrai.TabIndex = 5;
            this.bchuyentrai.Text = "<";
            this.bchuyentrai.UseVisualStyleBackColor = true;
            this.bchuyentrai.Click += new System.EventHandler(this.bchuyentrai_Click);
            // 
            // lbphai
            // 
            this.lbphai.FormattingEnabled = true;
            this.lbphai.ItemHeight = 20;
            this.lbphai.Location = new System.Drawing.Point(542, 77);
            this.lbphai.Name = "lbphai";
            this.lbphai.Size = new System.Drawing.Size(228, 224);
            this.lbphai.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbphai);
            this.Controls.Add(this.bchuyentrai);
            this.Controls.Add(this.bchuyentraihet);
            this.Controls.Add(this.bchuyenphaihet);
            this.Controls.Add(this.bchuyenphai);
            this.Controls.Add(this.lbtrai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbtrai;
        private System.Windows.Forms.Button bchuyenphai;
        private System.Windows.Forms.Button bchuyenphaihet;
        private System.Windows.Forms.Button bchuyentraihet;
        private System.Windows.Forms.Button bchuyentrai;
        private System.Windows.Forms.ListBox lbphai;
    }
}

