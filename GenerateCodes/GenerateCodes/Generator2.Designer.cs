namespace GenerateCodes
{
    partial class Generator2
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
            this.rtbCodes = new System.Windows.Forms.RichTextBox();
            this.cboWineType = new System.Windows.Forms.ComboBox();
            this.lblWhineType = new System.Windows.Forms.Label();
            this.lblNoCodesGenerate = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtCodesToGenerate = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblIteration = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblLastChar = new System.Windows.Forms.Label();
            this.lblLastDigit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbCodes
            // 
            this.rtbCodes.Location = new System.Drawing.Point(49, 144);
            this.rtbCodes.Name = "rtbCodes";
            this.rtbCodes.Size = new System.Drawing.Size(327, 82);
            this.rtbCodes.TabIndex = 18;
            this.rtbCodes.Text = "";
            // 
            // cboWineType
            // 
            this.cboWineType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboWineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWineType.FormattingEnabled = true;
            this.cboWineType.Items.AddRange(new object[] {
            "W",
            "R"});
            this.cboWineType.Location = new System.Drawing.Point(223, 47);
            this.cboWineType.Name = "cboWineType";
            this.cboWineType.Size = new System.Drawing.Size(100, 21);
            this.cboWineType.TabIndex = 17;
            // 
            // lblWhineType
            // 
            this.lblWhineType.AutoSize = true;
            this.lblWhineType.Location = new System.Drawing.Point(44, 50);
            this.lblWhineType.Name = "lblWhineType";
            this.lblWhineType.Size = new System.Drawing.Size(60, 13);
            this.lblWhineType.TabIndex = 16;
            this.lblWhineType.Text = "White/Red";
            // 
            // lblNoCodesGenerate
            // 
            this.lblNoCodesGenerate.AutoSize = true;
            this.lblNoCodesGenerate.Location = new System.Drawing.Point(41, 24);
            this.lblNoCodesGenerate.Name = "lblNoCodesGenerate";
            this.lblNoCodesGenerate.Size = new System.Drawing.Size(145, 13);
            this.lblNoCodesGenerate.TabIndex = 15;
            this.lblNoCodesGenerate.Text = "Number of codes to generate";
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblResult2.Location = new System.Drawing.Point(104, 118);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(72, 13);
            this.lblResult2.TabIndex = 13;
            this.lblResult2.Text = "Important Info";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(248, 92);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtCodesToGenerate
            // 
            this.txtCodesToGenerate.Location = new System.Drawing.Point(223, 21);
            this.txtCodesToGenerate.Name = "txtCodesToGenerate";
            this.txtCodesToGenerate.Size = new System.Drawing.Size(100, 20);
            this.txtCodesToGenerate.TabIndex = 11;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(46, 118);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result";
            // 
            // lblIteration
            // 
            this.lblIteration.AutoSize = true;
            this.lblIteration.Location = new System.Drawing.Point(310, 118);
            this.lblIteration.Name = "lblIteration";
            this.lblIteration.Size = new System.Drawing.Size(13, 13);
            this.lblIteration.TabIndex = 20;
            this.lblIteration.Text = "0";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(194, 238);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(100, 23);
            this.btnContinue.TabIndex = 21;
            this.btnContinue.Text = "Continue from last";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblLastChar
            // 
            this.lblLastChar.AutoSize = true;
            this.lblLastChar.Location = new System.Drawing.Point(49, 243);
            this.lblLastChar.Name = "lblLastChar";
            this.lblLastChar.Size = new System.Drawing.Size(52, 13);
            this.lblLastChar.TabIndex = 22;
            this.lblLastChar.Text = "Last Char";
            // 
            // lblLastDigit
            // 
            this.lblLastDigit.AutoSize = true;
            this.lblLastDigit.Location = new System.Drawing.Point(125, 243);
            this.lblLastDigit.Name = "lblLastDigit";
            this.lblLastDigit.Size = new System.Drawing.Size(51, 13);
            this.lblLastDigit.TabIndex = 23;
            this.lblLastDigit.Text = "Last Digit";
            // 
            // Generator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 324);
            this.Controls.Add(this.lblLastDigit);
            this.Controls.Add(this.lblLastChar);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblIteration);
            this.Controls.Add(this.rtbCodes);
            this.Controls.Add(this.cboWineType);
            this.Controls.Add(this.lblWhineType);
            this.Controls.Add(this.lblNoCodesGenerate);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtCodesToGenerate);
            this.Controls.Add(this.lblResult);
            this.Name = "Generator2";
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.Generator2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbCodes;
        private System.Windows.Forms.ComboBox cboWineType;
        private System.Windows.Forms.Label lblWhineType;
        private System.Windows.Forms.Label lblNoCodesGenerate;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtCodesToGenerate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblIteration;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblLastChar;
        private System.Windows.Forms.Label lblLastDigit;
    }
}