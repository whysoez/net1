namespace bai8
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
            this.tmau = new System.Windows.Forms.TextBox();
            this.hSr = new System.Windows.Forms.HScrollBar();
            this.hSb = new System.Windows.Forms.HScrollBar();
            this.hSg = new System.Windows.Forms.HScrollBar();
            this.tr = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.tg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tmau
            // 
            this.tmau.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmau.Location = new System.Drawing.Point(69, 52);
            this.tmau.Name = "tmau";
            this.tmau.Size = new System.Drawing.Size(155, 71);
            this.tmau.TabIndex = 0;
            // 
            // hSr
            // 
            this.hSr.Location = new System.Drawing.Point(350, 61);
            this.hSr.Maximum = 255;
            this.hSr.Name = "hSr";
            this.hSr.Size = new System.Drawing.Size(256, 26);
            this.hSr.TabIndex = 1;
            this.hSr.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSr_Scroll);
            this.hSr.ValueChanged += new System.EventHandler(this.hSr_ValueChanged);
            // 
            // hSb
            // 
            this.hSb.Location = new System.Drawing.Point(350, 178);
            this.hSb.Maximum = 255;
            this.hSb.Name = "hSb";
            this.hSb.Size = new System.Drawing.Size(256, 26);
            this.hSb.TabIndex = 2;
            this.hSb.ValueChanged += new System.EventHandler(this.hSb_ValueChanged);
            // 
            // hSg
            // 
            this.hSg.Location = new System.Drawing.Point(350, 116);
            this.hSg.Maximum = 255;
            this.hSg.Name = "hSg";
            this.hSg.Size = new System.Drawing.Size(256, 26);
            this.hSg.TabIndex = 3;
            this.hSg.ValueChanged += new System.EventHandler(this.hSg_ValueChanged);
            // 
            // tr
            // 
            this.tr.Location = new System.Drawing.Point(670, 61);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(100, 26);
            this.tr.TabIndex = 4;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(670, 159);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 26);
            this.tb.TabIndex = 5;
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(670, 107);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(100, 26);
            this.tg.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tr);
            this.Controls.Add(this.hSg);
            this.Controls.Add(this.hSb);
            this.Controls.Add(this.hSr);
            this.Controls.Add(this.tmau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tmau;
        private System.Windows.Forms.HScrollBar hSr;
        private System.Windows.Forms.HScrollBar hSb;
        private System.Windows.Forms.HScrollBar hSg;
        private System.Windows.Forms.TextBox tr;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox tg;
    }
}

