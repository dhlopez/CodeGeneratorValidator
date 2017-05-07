namespace CodeValidator
{
    partial class frmCodeValidator
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
            this.lblWhiteRed = new System.Windows.Forms.Label();
            this.cboWineType = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWhiteRed
            // 
            this.lblWhiteRed.AutoSize = true;
            this.lblWhiteRed.Location = new System.Drawing.Point(33, 28);
            this.lblWhiteRed.Name = "lblWhiteRed";
            this.lblWhiteRed.Size = new System.Drawing.Size(60, 13);
            this.lblWhiteRed.TabIndex = 0;
            this.lblWhiteRed.Text = "White/Red";
            // 
            // cboWineType
            // 
            this.cboWineType.FormattingEnabled = true;
            this.cboWineType.Items.AddRange(new object[] {
            "W",
            "R"});
            this.cboWineType.Location = new System.Drawing.Point(99, 25);
            this.cboWineType.Name = "cboWineType";
            this.cboWineType.Size = new System.Drawing.Size(52, 21);
            this.cboWineType.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(63, 86);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(33, 53);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(99, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(121, 20);
            this.txtCode.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(63, 116);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // frmCodeValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.cboWineType);
            this.Controls.Add(this.lblWhiteRed);
            this.Name = "frmCodeValidator";
            this.Text = "Code Validator";
            this.Load += new System.EventHandler(this.frmCodeValidator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhiteRed;
        private System.Windows.Forms.ComboBox cboWineType;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblResult;
    }
}

