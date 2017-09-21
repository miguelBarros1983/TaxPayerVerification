namespace ValidationTaxPayerCard
{
    partial class FormMain
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblTaxPayer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxResultColor = new System.Windows.Forms.TextBox();
            this.linkLblMiguelBarros = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(202, 28);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(157, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // lblTaxPayer
            // 
            this.lblTaxPayer.AutoSize = true;
            this.lblTaxPayer.Location = new System.Drawing.Point(24, 31);
            this.lblTaxPayer.Name = "lblTaxPayer";
            this.lblTaxPayer.Size = new System.Drawing.Size(161, 13);
            this.lblTaxPayer.TabIndex = 1;
            this.lblTaxPayer.Text = "Tax Payer Number (Portuguese):";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(145, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result:";
            // 
            // tbxResultColor
            // 
            this.tbxResultColor.Enabled = false;
            this.tbxResultColor.Location = new System.Drawing.Point(202, 60);
            this.tbxResultColor.Name = "tbxResultColor";
            this.tbxResultColor.Size = new System.Drawing.Size(157, 20);
            this.tbxResultColor.TabIndex = 3;
            // 
            // linkLblMiguelBarros
            // 
            this.linkLblMiguelBarros.AutoSize = true;
            this.linkLblMiguelBarros.Location = new System.Drawing.Point(279, 130);
            this.linkLblMiguelBarros.Name = "linkLblMiguelBarros";
            this.linkLblMiguelBarros.Size = new System.Drawing.Size(200, 13);
            this.linkLblMiguelBarros.TabIndex = 4;
            this.linkLblMiguelBarros.TabStop = true;
            this.linkLblMiguelBarros.Text = "Miguel Barros - Junir Consultant Engineer";
            this.linkLblMiguelBarros.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 152);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLblMiguelBarros);
            this.Controls.Add(this.tbxResultColor);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTaxPayer);
            this.Controls.Add(this.txtNumber);
            this.Name = "FormMain";
            this.Text = "Validation of Portuguese Tax Payer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblTaxPayer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxResultColor;
        private System.Windows.Forms.LinkLabel linkLblMiguelBarros;
        private System.Windows.Forms.Button button1;
    }
}

