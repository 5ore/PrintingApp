namespace PrintingStatus
{
    partial class Tips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tips));
            this.btnNext = new System.Windows.Forms.Button();
            this.pbHint = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(66, 120);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 32);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next hint";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pbHint
            // 
            this.pbHint.Image = global::PrintingStatus.Properties.Resources.tips;
            this.pbHint.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbHint.InitialImage")));
            this.pbHint.Location = new System.Drawing.Point(13, 13);
            this.pbHint.Name = "pbHint";
            this.pbHint.Size = new System.Drawing.Size(81, 76);
            this.pbHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHint.TabIndex = 1;
            this.pbHint.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(221, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbHint
            // 
            this.lbHint.Location = new System.Drawing.Point(100, 25);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(188, 76);
            this.lbHint.TabIndex = 3;
            // 
            // Tips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 177);
            this.Controls.Add(this.lbHint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbHint);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tips";
            this.Text = "Tips";
            this.Load += new System.EventHandler(this.Tips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pbHint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbHint;
    }
}