namespace Project_2___MIchael_Feuerstein
{
    partial class FormWithdraw
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
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.textWithdrawAmount = new System.Windows.Forms.TextBox();
            this.textAccountNum = new System.Windows.Forms.TextBox();
            this.labelWithdraw = new System.Windows.Forms.Label();
            this.labelAccountNum = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(119, 203);
            this.buttonWithdraw.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(81, 52);
            this.buttonWithdraw.TabIndex = 11;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // textWithdrawAmount
            // 
            this.textWithdrawAmount.Location = new System.Drawing.Point(254, 116);
            this.textWithdrawAmount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textWithdrawAmount.Name = "textWithdrawAmount";
            this.textWithdrawAmount.Size = new System.Drawing.Size(82, 20);
            this.textWithdrawAmount.TabIndex = 10;
            // 
            // textAccountNum
            // 
            this.textAccountNum.Location = new System.Drawing.Point(254, 61);
            this.textAccountNum.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textAccountNum.MaxLength = 8;
            this.textAccountNum.Name = "textAccountNum";
            this.textAccountNum.Size = new System.Drawing.Size(82, 20);
            this.textAccountNum.TabIndex = 9;
            // 
            // labelWithdraw
            // 
            this.labelWithdraw.AutoSize = true;
            this.labelWithdraw.Location = new System.Drawing.Point(115, 116);
            this.labelWithdraw.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelWithdraw.Name = "labelWithdraw";
            this.labelWithdraw.Size = new System.Drawing.Size(99, 13);
            this.labelWithdraw.TabIndex = 8;
            this.labelWithdraw.Text = "Withdrawal Amount";
            // 
            // labelAccountNum
            // 
            this.labelAccountNum.AutoSize = true;
            this.labelAccountNum.Location = new System.Drawing.Point(116, 61);
            this.labelAccountNum.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAccountNum.Name = "labelAccountNum";
            this.labelAccountNum.Size = new System.Drawing.Size(87, 13);
            this.labelAccountNum.TabIndex = 7;
            this.labelAccountNum.Text = "Account Number";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(256, 203);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 52);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 298);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.textWithdrawAmount);
            this.Controls.Add(this.textAccountNum);
            this.Controls.Add(this.labelWithdraw);
            this.Controls.Add(this.labelAccountNum);
            this.Controls.Add(this.buttonCancel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Withdraw Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.TextBox textWithdrawAmount;
        private System.Windows.Forms.TextBox textAccountNum;
        private System.Windows.Forms.Label labelWithdraw;
        private System.Windows.Forms.Label labelAccountNum;
        private System.Windows.Forms.Button buttonCancel;
    }
}