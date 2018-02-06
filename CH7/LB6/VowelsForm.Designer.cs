namespace LB6
{
    partial class VowelsForm
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
            this.lblPhrase = new System.Windows.Forms.Label();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblVowels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Location = new System.Drawing.Point(12, 9);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(110, 13);
            this.lblPhrase.TabIndex = 0;
            this.lblPhrase.Text = "Please enter a phrase";
            // 
            // txtPhrase
            // 
            this.txtPhrase.Location = new System.Drawing.Point(15, 26);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(358, 20);
            this.txtPhrase.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(379, 18);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 35);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblVowels
            // 
            this.lblVowels.AutoSize = true;
            this.lblVowels.Location = new System.Drawing.Point(15, 63);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(40, 13);
            this.lblVowels.TabIndex = 3;
            this.lblVowels.Text = "vowels";
            // 
            // VowelsForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 130);
            this.Controls.Add(this.lblVowels);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.lblPhrase);
            this.Name = "VowelsForm";
            this.Text = "Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPhrase;
        public System.Windows.Forms.TextBox txtPhrase;
        public System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.Label lblVowels;
    }
}

