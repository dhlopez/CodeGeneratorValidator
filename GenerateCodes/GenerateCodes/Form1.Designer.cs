namespace GenerateCodes
{
    partial class frmGenerateCodes
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
            this.lblResult = new System.Windows.Forms.Label();
            this.txtCodesToGenerate = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblCodeValues = new System.Windows.Forms.Label();
            this.lblNoCodesGenerate = new System.Windows.Forms.Label();
            this.lblWhineType = new System.Windows.Forms.Label();
            this.cboWineType = new System.Windows.Forms.ComboBox();
            this.rtbCodes = new System.Windows.Forms.RichTextBox();
            this.rtbCodesValues = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(38, 109);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            // 
            // txtCodesToGenerate
            // 
            this.txtCodesToGenerate.Location = new System.Drawing.Point(142, 12);
            this.txtCodesToGenerate.Name = "txtCodesToGenerate";
            this.txtCodesToGenerate.Size = new System.Drawing.Size(100, 20);
            this.txtCodesToGenerate.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(41, 73);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblResult2.Location = new System.Drawing.Point(96, 109);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(82, 13);
            this.lblResult2.TabIndex = 3;
            this.lblResult2.Text = "CodeGenerated";
            // 
            // lblCodeValues
            // 
            this.lblCodeValues.AutoSize = true;
            this.lblCodeValues.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCodeValues.Location = new System.Drawing.Point(222, 109);
            this.lblCodeValues.Name = "lblCodeValues";
            this.lblCodeValues.Size = new System.Drawing.Size(64, 13);
            this.lblCodeValues.TabIndex = 4;
            this.lblCodeValues.Text = "CodeValues";
            // 
            // lblNoCodesGenerate
            // 
            this.lblNoCodesGenerate.AutoSize = true;
            this.lblNoCodesGenerate.Location = new System.Drawing.Point(33, 15);
            this.lblNoCodesGenerate.Name = "lblNoCodesGenerate";
            this.lblNoCodesGenerate.Size = new System.Drawing.Size(103, 13);
            this.lblNoCodesGenerate.TabIndex = 5;
            this.lblNoCodesGenerate.Text = "# codes to generate";
            // 
            // lblWhineType
            // 
            this.lblWhineType.AutoSize = true;
            this.lblWhineType.Location = new System.Drawing.Point(36, 41);
            this.lblWhineType.Name = "lblWhineType";
            this.lblWhineType.Size = new System.Drawing.Size(60, 13);
            this.lblWhineType.TabIndex = 6;
            this.lblWhineType.Text = "White/Red";
            // 
            // cboWineType
            // 
            this.cboWineType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboWineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWineType.FormattingEnabled = true;
            this.cboWineType.Items.AddRange(new object[] {
            "W",
            "R"});
            this.cboWineType.Location = new System.Drawing.Point(142, 38);
            this.cboWineType.Name = "cboWineType";
            this.cboWineType.Size = new System.Drawing.Size(100, 21);
            this.cboWineType.TabIndex = 7;
            // 
            // rtbCodes
            // 
            this.rtbCodes.Location = new System.Drawing.Point(99, 137);
            this.rtbCodes.Name = "rtbCodes";
            this.rtbCodes.Size = new System.Drawing.Size(100, 394);
            this.rtbCodes.TabIndex = 8;
            this.rtbCodes.Text = "";
            // 
            // rtbCodesValues
            // 
            this.rtbCodesValues.Location = new System.Drawing.Point(218, 137);
            this.rtbCodesValues.Name = "rtbCodesValues";
            this.rtbCodesValues.Size = new System.Drawing.Size(166, 394);
            this.rtbCodesValues.TabIndex = 9;
            this.rtbCodesValues.Text = "";
            // 
            // frmGenerateCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(396, 556);
            this.Controls.Add(this.rtbCodesValues);
            this.Controls.Add(this.rtbCodes);
            this.Controls.Add(this.cboWineType);
            this.Controls.Add(this.lblWhineType);
            this.Controls.Add(this.lblNoCodesGenerate);
            this.Controls.Add(this.lblCodeValues);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtCodesToGenerate);
            this.Controls.Add(this.lblResult);
            this.Name = "frmGenerateCodes";
            this.Text = "Generate Codes";
            this.Load += new System.EventHandler(this.frmGenerateCodes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtCodesToGenerate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblCodeValues;
        private System.Windows.Forms.Label lblNoCodesGenerate;
        private System.Windows.Forms.Label lblWhineType;
        private System.Windows.Forms.ComboBox cboWineType;
        private System.Windows.Forms.RichTextBox rtbCodes;
        private System.Windows.Forms.RichTextBox rtbCodesValues;
    }
}

