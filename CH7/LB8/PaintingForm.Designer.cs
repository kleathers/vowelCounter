namespace LB8
{
    partial class PaintingForm
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalAreaHeader = new System.Windows.Forms.Label();
            this.lblTotalCostHeader = new System.Windows.Forms.Label();
            this.lblTotalArea = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(13, 13);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(55, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (ft)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(135, 13);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(50, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (ft)";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(16, 30);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(138, 30);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(253, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(74, 27);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalAreaHeader
            // 
            this.lblTotalAreaHeader.AutoSize = true;
            this.lblTotalAreaHeader.Location = new System.Drawing.Point(349, 12);
            this.lblTotalAreaHeader.Name = "lblTotalAreaHeader";
            this.lblTotalAreaHeader.Size = new System.Drawing.Size(85, 13);
            this.lblTotalAreaHeader.TabIndex = 5;
            this.lblTotalAreaHeader.Text = "Total Area (sq ft)";
            // 
            // lblTotalCostHeader
            // 
            this.lblTotalCostHeader.AutoSize = true;
            this.lblTotalCostHeader.Location = new System.Drawing.Point(456, 13);
            this.lblTotalCostHeader.Name = "lblTotalCostHeader";
            this.lblTotalCostHeader.Size = new System.Drawing.Size(70, 13);
            this.lblTotalCostHeader.TabIndex = 6;
            this.lblTotalCostHeader.Text = "Total Cost ($)";
            // 
            // lblTotalArea
            // 
            this.lblTotalArea.AutoSize = true;
            this.lblTotalArea.Location = new System.Drawing.Point(349, 35);
            this.lblTotalArea.Name = "lblTotalArea";
            this.lblTotalArea.Size = new System.Drawing.Size(16, 13);
            this.lblTotalArea.TabIndex = 7;
            this.lblTotalArea.Text = "---";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(456, 35);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(16, 13);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "---";
            // 
            // PaintingForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 156);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotalArea);
            this.Controls.Add(this.lblTotalCostHeader);
            this.Controls.Add(this.lblTotalAreaHeader);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "PaintingForm";
            this.Text = "Painting Estimate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblLength;
        public System.Windows.Forms.Label lblWidth;
        public System.Windows.Forms.TextBox txtLength;
        public System.Windows.Forms.TextBox txtWidth;
        public System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.Label lblTotalAreaHeader;
        public System.Windows.Forms.Label lblTotalCostHeader;
        public System.Windows.Forms.Label lblTotalArea;
        public System.Windows.Forms.Label lblTotalCost;
    }
}

