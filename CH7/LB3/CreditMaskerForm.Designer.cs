namespace LB3
{
    partial class CreditMaskerForm
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
            this.btnMask = new System.Windows.Forms.Button();
            this.lblMasked = new System.Windows.Forms.Label();
            this.txtRaw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMask
            // 
            this.btnMask.Location = new System.Drawing.Point(260, 18);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(90, 42);
            this.btnMask.TabIndex = 5;
            this.btnMask.Text = "Mask";
            this.btnMask.UseVisualStyleBackColor = true;
            this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
            // 
            // lblMasked
            // 
            this.lblMasked.AutoSize = true;
            this.lblMasked.Location = new System.Drawing.Point(24, 74);
            this.lblMasked.Name = "lblMasked";
            this.lblMasked.Size = new System.Drawing.Size(65, 20);
            this.lblMasked.TabIndex = 4;
            this.lblMasked.Text = "masked";
            // 
            // txtRaw
            // 
            this.txtRaw.Location = new System.Drawing.Point(24, 26);
            this.txtRaw.Name = "txtRaw";
            this.txtRaw.Size = new System.Drawing.Size(216, 26);
            this.txtRaw.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 277);
            this.Controls.Add(this.btnMask);
            this.Controls.Add(this.lblMasked);
            this.Controls.Add(this.txtRaw);
            this.Name = "Form1";
            this.Text = "Credit Card Masker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnMask;
        public System.Windows.Forms.Label lblMasked;
        public System.Windows.Forms.TextBox txtRaw;
    }
}

