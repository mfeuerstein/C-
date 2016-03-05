namespace Project_2___MIchael_Feuerstein
{
    partial class FormDeposit
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAccountNum = new System.Windows.Forms.Label();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.textAccountNum = new System.Windows.Forms.TextBox();
            this.textDepositAmount = new System.Windows.Forms.TextBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(254, 204);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 52);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelAccountNum
            // 
            this.labelAccountNum.AutoSize = true;
            this.labelAccountNum.Location = new System.Drawing.Point(114, 62);
            this.labelAccountNum.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAccountNum.Name = "labelAccountNum";
            this.labelAccountNum.Size = new System.Drawing.Size(87, 13);
            this.labelAccountNum.TabIndex = 1;
            this.labelAccountNum.Text = "Account Number";
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Location = new System.Drawing.Point(112, 117);
            this.labelDeposit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(82, 13);
            this.labelDeposit.TabIndex = 2;
            this.labelDeposit.Text = "Deposit Amount";
            // 
            // textAccountNum
            // 
            this.textAccountNum.Location = new System.Drawing.Point(252, 62);
            this.textAccountNum.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textAccountNum.MaxLength = 8;
            this.textAccountNum.Name = "textAccountNum";
            this.textAccountNum.Size = new System.Drawing.Size(82, 20);
            this.textAccountNum.TabIndex = 3;
            // 
            // textDepositAmount
            // 
            this.textDepositAmount.Location = new System.Drawing.Point(252, 117);
            this.textDepositAmount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textDepositAmount.Name = "textDepositAmount";
            this.textDepositAmount.Size = new System.Drawing.Size(82, 20);
            this.textDepositAmount.TabIndex = 4;
            this.textDepositAmount.TextChanged += new System.EventHandler(this.textDepositAmount_TextChanged);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(117, 204);
            this.buttonDeposit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(81, 52);
            this.buttonDeposit.TabIndex = 5;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // FormDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 293);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.textDepositAmount);
            this.Controls.Add(this.textAccountNum);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.labelAccountNum);
            this.Controls.Add(this.buttonCancel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDeposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelAccountNum;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.TextBox textAccountNum;
        private System.Windows.Forms.TextBox textDepositAmount;
        private System.Windows.Forms.Button buttonDeposit;
    }
}