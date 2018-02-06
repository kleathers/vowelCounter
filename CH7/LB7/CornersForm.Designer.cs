namespace LB7
{
    partial class CornersForm
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
            this.lblCorners = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCorners
            // 
            this.lblCorners.AutoSize = true;
            this.lblCorners.Location = new System.Drawing.Point(12, 66);
            this.lblCorners.Name = "lblCorners";
            this.lblCorners.Size = new System.Drawing.Size(42, 13);
            this.lblCorners.TabIndex = 7;
            this.lblCorners.Text = "corners";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(376, 21);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 35);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtPhrase
            // 
            this.txtPhrase.Location = new System.Drawing.Point(12, 29);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(358, 20);
            this.txtPhrase.TabIndex = 5;
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Location = new System.Drawing.Point(9, 12);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(113, 13);
            this.lblPhrase.TabIndex = 4;
            this.lblPhrase.Text = "Please enter a number";
            // 
            // CornersForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 156);
            this.Controls.Add(this.lblCorners);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.lblPhrase);
            this.Name = "CornersForm";
            this.Text = "Corners";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCorners;
        public System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.TextBox txtPhrase;
        public System.Windows.Forms.Label lblPhrase;
    }
}