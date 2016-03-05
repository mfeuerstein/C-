namespace Project_2___MIchael_Feuerstein
{
    partial class FormTransfer
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
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.textTransferAmount = new System.Windows.Forms.TextBox();
            this.textAccountFrom = new System.Windows.Forms.TextBox();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.labelAccountFrom = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textAccountTo = new System.Windows.Forms.TextBox();
            this.labelAccountTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(106, 164);
            this.buttonDeposit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(81, 52);
            this.buttonDeposit.TabIndex = 11;
            this.buttonDeposit.Text = "Transfer";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // textTransferAmount
            // 
            this.textTransferAmount.Location = new System.Drawing.Point(243, 108);
            this.textTransferAmount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textTransferAmount.Name = "textTransferAmount";
            this.textTransferAmount.Size = new System.Drawing.Size(82, 20);
            this.textTransferAmount.TabIndex = 10;
            // 
            // textAccountFrom
            // 
            this.textAccountFrom.Location = new System.Drawing.Point(243, 36);
            this.textAccountFrom.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textAccountFrom.MaxLength = 8;
            this.textAccountFrom.Name = "textAccountFrom";
            this.textAccountFrom.Size = new System.Drawing.Size(82, 20);
            this.textAccountFrom.TabIndex = 9;
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Location = new System.Drawing.Point(103, 109);
            this.labelDeposit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(85, 13);
            this.labelDeposit.TabIndex = 8;
            this.labelDeposit.Text = "Transfer Amount";
            // 
            // labelAccountFrom
            // 
            this.labelAccountFrom.AutoSize = true;
            this.labelAccountFrom.Location = new System.Drawing.Point(103, 36);
            this.labelAccountFrom.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAccountFrom.Name = "labelAccountFrom";
            this.labelAccountFrom.Size = new System.Drawing.Size(113, 13);
            this.labelAccountFrom.TabIndex = 7;
            this.labelAccountFrom.Text = "Account Number From";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(243, 164);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 52);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textAccountTo
            // 
            this.textAccountTo.Location = new System.Drawing.Point(243, 73);
            this.textAccountTo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textAccountTo.MaxLength = 8;
            this.textAccountTo.Name = "textAccountTo";
            this.textAccountTo.Size = new System.Drawing.Size(82, 20);
            this.textAccountTo.TabIndex = 13;
            this.textAccountTo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelAccountTo
            // 
            this.labelAccountTo.AutoSize = true;
            this.labelAccountTo.Location = new System.Drawing.Point(103, 73);
            this.labelAccountTo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAccountTo.Name = "labelAccountTo";
            this.labelAccountTo.Size = new System.Drawing.Size(103, 13);
            this.labelAccountTo.TabIndex = 12;
            this.labelAccountTo.Text = "Account Number To";
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 239);
            this.Controls.Add(this.textAccountTo);
            this.Controls.Add(this.labelAccountTo);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.textTransferAmount);
            this.Controls.Add(this.textAccountFrom);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.labelAccountFrom);
            this.Controls.Add(this.buttonCancel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transfer Funds";
            this.Load += new System.EventHandler(this.FormTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.TextBox textTransferAmount;
        private System.Windows.Forms.TextBox textAccountFrom;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Label labelAccountFrom;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textAccountTo;
        private System.Windows.Forms.Label labelAccountTo;
    }
}