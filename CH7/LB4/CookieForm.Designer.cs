namespace LB4
{
    partial class CookieForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFortunes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 8);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(65, 27);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblFortunes
            // 
            this.lblFortunes.AutoSize = true;
            this.lblFortunes.Location = new System.Drawing.Point(15, 47);
            this.lblFortunes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFortunes.Name = "lblFortunes";
            this.lblFortunes.Size = new System.Drawing.Size(113, 13);
            this.lblFortunes.TabIndex = 1;
            this.lblFortunes.Text = "What could be inside?";
            // 
            // CookieForm
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 213);
            this.Controls.Add(this.lblFortunes);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CookieForm";
            this.Text = "Fortune Cookie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.Label lblFortunes;
    }
}

