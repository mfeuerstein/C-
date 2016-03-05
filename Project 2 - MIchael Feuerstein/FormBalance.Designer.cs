namespace Project_2___MIchael_Feuerstein
{
    partial class FormBalance
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
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textAccountNum = new System.Windows.Forms.TextBox();
            this.labelAccountNum = new System.Windows.Forms.Label();
            this.buttonCheckBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(128, 135);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(89, 13);
            this.labelBalance.TabIndex = 0;
            this.labelBalance.Text = "Account Balance";
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(248, 132);
            this.textBalance.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBalance.Name = "textBalance";
            this.textBalance.ReadOnly = true;
            this.textBalance.Size = new System.Drawing.Size(100, 20);
            this.textBalance.TabIndex = 2;
            this.textBalance.TabStop = false;
            this.textBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(269, 224);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(79, 40);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textAccountNum
            // 
            this.textAccountNum.Location = new System.Drawing.Point(248, 71);
            this.textAccountNum.Margin = new System.Windows.Forms.Padding(1);
            this.textAccountNum.MaxLength = 8;
            this.textAccountNum.Name = "textAccountNum";
            this.textAccountNum.Size = new System.Drawing.Size(100, 20);
            this.textAccountNum.TabIndex = 6;
            // 
            // labelAccountNum
            // 
            this.labelAccountNum.AutoSize = true;
            this.labelAccountNum.Location = new System.Drawing.Point(128, 71);
            this.labelAccountNum.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAccountNum.Name = "labelAccountNum";
            this.labelAccountNum.Size = new System.Drawing.Size(87, 13);
            this.labelAccountNum.TabIndex = 5;
            this.labelAccountNum.Text = "Account Number";
            // 
            // buttonCheckBalance
            // 
            this.buttonCheckBalance.Location = new System.Drawing.Point(131, 224);
            this.buttonCheckBalance.Name = "buttonCheckBalance";
            this.buttonCheckBalance.Size = new System.Drawing.Size(75, 40);
            this.buttonCheckBalance.TabIndex = 7;
            this.buttonCheckBalance.Text = "Check balance";
            this.buttonCheckBalance.UseVisualStyleBackColor = true;
            this.buttonCheckBalance.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 293);
            this.Controls.Add(this.buttonCheckBalance);
            this.Controls.Add(this.textAccountNum);
            this.Controls.Add(this.labelAccountNum);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.labelBalance);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check Account Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textAccountNum;
        private System.Windows.Forms.Label labelAccountNum;
        private System.Windows.Forms.Button buttonCheckBalance;
    }
}