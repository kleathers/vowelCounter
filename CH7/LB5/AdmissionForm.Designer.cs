namespace LB5
{
    partial class AdmissionForm
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
            this.btnAdmit = new System.Windows.Forms.Button();
            this.lblGpa = new System.Windows.Forms.Label();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.lblTestScore = new System.Windows.Forms.Label();
            this.txtTestScore = new System.Windows.Forms.TextBox();
            this.lblAccepted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(8, 58);
            this.btnAdmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(69, 32);
            this.btnAdmit.TabIndex = 0;
            this.btnAdmit.Text = "Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Location = new System.Drawing.Point(8, 6);
            this.lblGpa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(29, 13);
            this.lblGpa.TabIndex = 1;
            this.lblGpa.Text = "GPA";
            // 
            // txtGpa
            // 
            this.txtGpa.Location = new System.Drawing.Point(11, 21);
            this.txtGpa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(89, 20);
            this.txtGpa.TabIndex = 2;
            // 
            // lblTestScore
            // 
            this.lblTestScore.AutoSize = true;
            this.lblTestScore.Location = new System.Drawing.Point(119, 5);
            this.lblTestScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestScore.Name = "lblTestScore";
            this.lblTestScore.Size = new System.Drawing.Size(109, 13);
            this.lblTestScore.TabIndex = 3;
            this.lblTestScore.Text = "Admission Test Score";
            // 
            // txtTestScore
            // 
            this.txtTestScore.Location = new System.Drawing.Point(121, 21);
            this.txtTestScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTestScore.Name = "txtTestScore";
            this.txtTestScore.Size = new System.Drawing.Size(107, 20);
            this.txtTestScore.TabIndex = 4;
            // 
            // lblAccepted
            // 
            this.lblAccepted.AutoSize = true;
            this.lblAccepted.Location = new System.Drawing.Point(101, 67);
            this.lblAccepted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccepted.Name = "lblAccepted";
            this.lblAccepted.Size = new System.Drawing.Size(41, 13);
            this.lblAccepted.TabIndex = 5;
            this.lblAccepted.Text = "Accept";
            // 
            // AdmissionForm
            // 
            this.AcceptButton = this.btnAdmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 119);
            this.Controls.Add(this.lblAccepted);
            this.Controls.Add(this.txtTestScore);
            this.Controls.Add(this.lblTestScore);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.lblGpa);
            this.Controls.Add(this.btnAdmit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdmissionForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAdmit;
        public System.Windows.Forms.Label lblGpa;
        public System.Windows.Forms.TextBox txtGpa;
        public System.Windows.Forms.Label lblTestScore;
        public System.Windows.Forms.TextBox txtTestScore;
        public System.Windows.Forms.Label lblAccepted;
    }
}

