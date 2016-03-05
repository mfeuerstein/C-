namespace Project_2___MIchael_Feuerstein
{
    partial class FormAccount
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
            this.radioExit = new System.Windows.Forms.RadioButton();
            this.radioDeposit = new System.Windows.Forms.RadioButton();
            this.radioWithdraw = new System.Windows.Forms.RadioButton();
            this.radioBalance = new System.Windows.Forms.RadioButton();
            this.radioTransfer = new System.Windows.Forms.RadioButton();
            this.groupAccount = new System.Windows.Forms.GroupBox();
            this.groupAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioExit
            // 
            this.radioExit.AutoSize = true;
            this.radioExit.Location = new System.Drawing.Point(21, 189);
            this.radioExit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioExit.Name = "radioExit";
            this.radioExit.Size = new System.Drawing.Size(42, 17);
            this.radioExit.TabIndex = 0;
            this.radioExit.Text = "Exit";
            this.radioExit.UseVisualStyleBackColor = true;
            this.radioExit.CheckedChanged += new System.EventHandler(this.radioExit_CheckedChanged);
            // 
            // radioDeposit
            // 
            this.radioDeposit.AutoSize = true;
            this.radioDeposit.Location = new System.Drawing.Point(21, 39);
            this.radioDeposit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioDeposit.Name = "radioDeposit";
            this.radioDeposit.Size = new System.Drawing.Size(100, 17);
            this.radioDeposit.TabIndex = 1;
            this.radioDeposit.Text = "Make a Deposit";
            this.radioDeposit.UseVisualStyleBackColor = true;
            this.radioDeposit.CheckedChanged += new System.EventHandler(this.radioDeposit_CheckedChanged);
            // 
            // radioWithdraw
            // 
            this.radioWithdraw.AutoSize = true;
            this.radioWithdraw.Location = new System.Drawing.Point(21, 77);
            this.radioWithdraw.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioWithdraw.Name = "radioWithdraw";
            this.radioWithdraw.Size = new System.Drawing.Size(117, 17);
            this.radioWithdraw.TabIndex = 2;
            this.radioWithdraw.Text = "Make a Withdrawal";
            this.radioWithdraw.UseVisualStyleBackColor = true;
            this.radioWithdraw.CheckedChanged += new System.EventHandler(this.radioWithdraw_CheckedChanged);
            // 
            // radioBalance
            // 
            this.radioBalance.AutoSize = true;
            this.radioBalance.Location = new System.Drawing.Point(21, 116);
            this.radioBalance.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioBalance.Name = "radioBalance";
            this.radioBalance.Size = new System.Drawing.Size(98, 17);
            this.radioBalance.TabIndex = 3;
            this.radioBalance.Text = "Check Balance";
            this.radioBalance.UseVisualStyleBackColor = true;
            this.radioBalance.CheckedChanged += new System.EventHandler(this.radioBalance_CheckedChanged);
            // 
            // radioTransfer
            // 
            this.radioTransfer.AutoSize = true;
            this.radioTransfer.Location = new System.Drawing.Point(21, 153);
            this.radioTransfer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.radioTransfer.Name = "radioTransfer";
            this.radioTransfer.Size = new System.Drawing.Size(96, 17);
            this.radioTransfer.TabIndex = 4;
            this.radioTransfer.Text = "Transfer Funds";
            this.radioTransfer.UseVisualStyleBackColor = true;
            this.radioTransfer.CheckedChanged += new System.EventHandler(this.radioTransfer_CheckedChanged);
            // 
            // groupAccount
            // 
            this.groupAccount.Controls.Add(this.radioDeposit);
            this.groupAccount.Controls.Add(this.radioTransfer);
            this.groupAccount.Controls.Add(this.radioExit);
            this.groupAccount.Controls.Add(this.radioBalance);
            this.groupAccount.Controls.Add(this.radioWithdraw);
            this.groupAccount.Location = new System.Drawing.Point(134, 28);
            this.groupAccount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupAccount.Name = "groupAccount";
            this.groupAccount.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupAccount.Size = new System.Drawing.Size(140, 243);
            this.groupAccount.TabIndex = 5;
            this.groupAccount.TabStop = false;
            this.groupAccount.Text = "Account";
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 291);
            this.Controls.Add(this.groupAccount);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account";
            this.groupAccount.ResumeLayout(false);
            this.groupAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioExit;
        private System.Windows.Forms.RadioButton radioDeposit;
        private System.Windows.Forms.RadioButton radioWithdraw;
        private System.Windows.Forms.RadioButton radioBalance;
        private System.Windows.Forms.RadioButton radioTransfer;
        private System.Windows.Forms.GroupBox groupAccount;
    }
}