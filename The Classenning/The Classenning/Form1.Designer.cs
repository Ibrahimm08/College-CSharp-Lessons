namespace The_Classenning
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDisplayBalance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(126, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(126, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Initial Balance";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtName.Location = new System.Drawing.Point(131, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 32);
            this.txtName.TabIndex = 1;
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInitialBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtInitialBalance.Location = new System.Drawing.Point(131, 192);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(254, 32);
            this.txtInitialBalance.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnOpen.Location = new System.Drawing.Point(131, 320);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(188, 70);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDisplayBalance
            // 
            this.btnDisplayBalance.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDisplayBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDisplayBalance.Location = new System.Drawing.Point(387, 320);
            this.btnDisplayBalance.Name = "btnDisplayBalance";
            this.btnDisplayBalance.Size = new System.Drawing.Size(188, 70);
            this.btnDisplayBalance.TabIndex = 2;
            this.btnDisplayBalance.Text = "Display Balance";
            this.btnDisplayBalance.UseVisualStyleBackColor = false;
            this.btnDisplayBalance.Click += new System.EventHandler(this.btnDisplayBalance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(439, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Withdraw Amount";
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWithdrawAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtWithdrawAmount.Location = new System.Drawing.Point(444, 75);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(254, 32);
            this.txtWithdrawAmount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(439, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Deposit Amount";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtDepositAmount.Location = new System.Drawing.Point(444, 192);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(254, 32);
            this.txtDepositAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDeposit.Location = new System.Drawing.Point(726, 188);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(139, 36);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.YellowGreen;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnWithdraw.Location = new System.Drawing.Point(726, 71);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(139, 36);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtOutput.Location = new System.Drawing.Point(652, 320);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(254, 138);
            this.txtOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 481);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnDisplayBalance);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtInitialBalance);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "The bank acounting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDisplayBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

