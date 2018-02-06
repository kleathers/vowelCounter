namespace LB9
{
    partial class DeskForm
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
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblWoodCost = new System.Windows.Forms.Label();
            this.lblTotalCostHeader = new System.Windows.Forms.Label();
            this.lblWoodCostHeader = new System.Windows.Forms.Label();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.txtDrawerCount = new System.Windows.Forms.TextBox();
            this.txtWoodType = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDrawerCost = new System.Windows.Forms.Label();
            this.lblDrawerCostHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(245, 129);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(16, 13);
            this.lblTotalCost.TabIndex = 17;
            this.lblTotalCost.Text = "---";
            // 
            // lblWoodCost
            // 
            this.lblWoodCost.AutoSize = true;
            this.lblWoodCost.Location = new System.Drawing.Point(12, 129);
            this.lblWoodCost.Name = "lblWoodCost";
            this.lblWoodCost.Size = new System.Drawing.Size(16, 13);
            this.lblWoodCost.TabIndex = 16;
            this.lblWoodCost.Text = "---";
            // 
            // lblTotalCostHeader
            // 
            this.lblTotalCostHeader.AutoSize = true;
            this.lblTotalCostHeader.Location = new System.Drawing.Point(245, 107);
            this.lblTotalCostHeader.Name = "lblTotalCostHeader";
            this.lblTotalCostHeader.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCostHeader.TabIndex = 15;
            this.lblTotalCostHeader.Text = "Total Cost";
            // 
            // lblWoodCostHeader
            // 
            this.lblWoodCostHeader.AutoSize = true;
            this.lblWoodCostHeader.Location = new System.Drawing.Point(9, 107);
            this.lblWoodCostHeader.Name = "lblWoodCostHeader";
            this.lblWoodCostHeader.Size = new System.Drawing.Size(72, 13);
            this.lblWoodCostHeader.TabIndex = 14;
            this.lblWoodCostHeader.Text = "Cost of Wood";
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(12, 62);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(74, 27);
            this.btnEstimate.TabIndex = 13;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // txtDrawerCount
            // 
            this.txtDrawerCount.Location = new System.Drawing.Point(134, 27);
            this.txtDrawerCount.Name = "txtDrawerCount";
            this.txtDrawerCount.Size = new System.Drawing.Size(100, 20);
            this.txtDrawerCount.TabIndex = 12;
            // 
            // txtWoodType
            // 
            this.txtWoodType.Location = new System.Drawing.Point(12, 27);
            this.txtWoodType.Name = "txtWoodType";
            this.txtWoodType.Size = new System.Drawing.Size(100, 20);
            this.txtWoodType.TabIndex = 11;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(131, 10);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(98, 13);
            this.lblWidth.TabIndex = 10;
            this.lblWidth.Text = "Number of Drawers";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(9, 10);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(75, 13);
            this.lblLength.TabIndex = 9;
            this.lblLength.Text = "Type of Wood";
            // 
            // lblDrawerCost
            // 
            this.lblDrawerCost.AutoSize = true;
            this.lblDrawerCost.Location = new System.Drawing.Point(122, 129);
            this.lblDrawerCost.Name = "lblDrawerCost";
            this.lblDrawerCost.Size = new System.Drawing.Size(16, 13);
            this.lblDrawerCost.TabIndex = 19;
            this.lblDrawerCost.Text = "---";
            // 
            // lblDrawerCostHeader
            // 
            this.lblDrawerCostHeader.AutoSize = true;
            this.lblDrawerCostHeader.Location = new System.Drawing.Point(119, 107);
            this.lblDrawerCostHeader.Name = "lblDrawerCostHeader";
            this.lblDrawerCostHeader.Size = new System.Drawing.Size(82, 13);
            this.lblDrawerCostHeader.TabIndex = 18;
            this.lblDrawerCostHeader.Text = "Cost of Drawers";
            // 
            // DeskForm
            // 
            this.AcceptButton = this.btnEstimate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 213);
            this.Controls.Add(this.lblDrawerCost);
            this.Controls.Add(this.lblDrawerCostHeader);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblWoodCost);
            this.Controls.Add(this.lblTotalCostHeader);
            this.Controls.Add(this.lblWoodCostHeader);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.txtDrawerCount);
            this.Controls.Add(this.txtWoodType);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "DeskForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTotalCost;
        public System.Windows.Forms.Label lblWoodCost;
        public System.Windows.Forms.Label lblTotalCostHeader;
        public System.Windows.Forms.Label lblWoodCostHeader;
        public System.Windows.Forms.Button btnEstimate;
        public System.Windows.Forms.TextBox txtDrawerCount;
        public System.Windows.Forms.TextBox txtWoodType;
        public System.Windows.Forms.Label lblWidth;
        public System.Windows.Forms.Label lblLength;
        public System.Windows.Forms.Label lblDrawerCost;
        public System.Windows.Forms.Label lblDrawerCostHeader;
    }
}

