namespace JSBA
{
    partial class Form3
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
            label1 = new Label();
            lblJSBABalance = new Label();
            lblCASABalance = new Label();
            lblVariance = new Label();
            lblEventPurchases = new Label();
            lblEventServices = new Label();
            lblTotalBalance = new Label();
            txtJSBAEventPurchases = new TextBox();
            txtCASAEventPurchases = new TextBox();
            txtPurchasesVariance = new TextBox();
            txtJSBABalance = new TextBox();
            txtCASABalance = new TextBox();
            txtTotalVariance = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(279, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 28);
            label1.TabIndex = 0;
            label1.Text = "Event Financial Summary";
            // 
            // lblJSBABalance
            // 
            lblJSBABalance.AutoSize = true;
            lblJSBABalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblJSBABalance.Location = new Point(279, 103);
            lblJSBABalance.Margin = new Padding(4, 0, 4, 0);
            lblJSBABalance.Name = "lblJSBABalance";
            lblJSBABalance.Size = new Size(81, 15);
            lblJSBABalance.TabIndex = 1;
            lblJSBABalance.Text = "JSBA Balance";
            // 
            // lblCASABalance
            // 
            lblCASABalance.AutoSize = true;
            lblCASABalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCASABalance.Location = new Point(499, 103);
            lblCASABalance.Margin = new Padding(4, 0, 4, 0);
            lblCASABalance.Name = "lblCASABalance";
            lblCASABalance.Size = new Size(83, 15);
            lblCASABalance.TabIndex = 2;
            lblCASABalance.Text = "CASA Balance";
            // 
            // lblVariance
            // 
            lblVariance.AutoSize = true;
            lblVariance.Location = new Point(730, 103);
            lblVariance.Margin = new Padding(4, 0, 4, 0);
            lblVariance.Name = "lblVariance";
            lblVariance.Size = new Size(51, 15);
            lblVariance.TabIndex = 3;
            lblVariance.Text = "Variance";
            // 
            // lblEventPurchases
            // 
            lblEventPurchases.AutoSize = true;
            lblEventPurchases.Location = new Point(78, 160);
            lblEventPurchases.Margin = new Padding(4, 0, 4, 0);
            lblEventPurchases.Name = "lblEventPurchases";
            lblEventPurchases.Size = new Size(92, 15);
            lblEventPurchases.TabIndex = 4;
            lblEventPurchases.Text = "Event Purchases";
            // 
            // lblEventServices
            // 
            lblEventServices.Location = new Point(0, 0);
            lblEventServices.Margin = new Padding(4, 0, 4, 0);
            lblEventServices.Name = "lblEventServices";
            lblEventServices.Size = new Size(117, 27);
            lblEventServices.TabIndex = 16;
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.Location = new Point(82, 343);
            lblTotalBalance.Margin = new Padding(4, 0, 4, 0);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(76, 15);
            lblTotalBalance.TabIndex = 6;
            lblTotalBalance.Text = "Total Balance";
            // 
            // txtJSBAEventPurchases
            // 
            txtJSBAEventPurchases.Location = new Point(261, 157);
            txtJSBAEventPurchases.Margin = new Padding(4, 3, 4, 3);
            txtJSBAEventPurchases.Name = "txtJSBAEventPurchases";
            txtJSBAEventPurchases.ReadOnly = true;
            txtJSBAEventPurchases.Size = new Size(116, 23);
            txtJSBAEventPurchases.TabIndex = 7;
            // 
            // txtCASAEventPurchases
            // 
            txtCASAEventPurchases.Location = new Point(486, 157);
            txtCASAEventPurchases.Margin = new Padding(4, 3, 4, 3);
            txtCASAEventPurchases.Name = "txtCASAEventPurchases";
            txtCASAEventPurchases.ReadOnly = true;
            txtCASAEventPurchases.Size = new Size(116, 23);
            txtCASAEventPurchases.TabIndex = 8;
            // 
            // txtPurchasesVariance
            // 
            txtPurchasesVariance.Location = new Point(705, 157);
            txtPurchasesVariance.Margin = new Padding(4, 3, 4, 3);
            txtPurchasesVariance.Name = "txtPurchasesVariance";
            txtPurchasesVariance.ReadOnly = true;
            txtPurchasesVariance.Size = new Size(116, 23);
            txtPurchasesVariance.TabIndex = 12;
            // 
            // txtJSBABalance
            // 
            txtJSBABalance.Location = new Point(258, 339);
            txtJSBABalance.Margin = new Padding(4, 3, 4, 3);
            txtJSBABalance.Name = "txtJSBABalance";
            txtJSBABalance.ReadOnly = true;
            txtJSBABalance.Size = new Size(116, 23);
            txtJSBABalance.TabIndex = 13;
            // 
            // txtCASABalance
            // 
            txtCASABalance.Location = new Point(483, 339);
            txtCASABalance.Margin = new Padding(4, 3, 4, 3);
            txtCASABalance.Name = "txtCASABalance";
            txtCASABalance.ReadOnly = true;
            txtCASABalance.Size = new Size(116, 23);
            txtCASABalance.TabIndex = 14;
            // 
            // txtTotalVariance
            // 
            txtTotalVariance.Location = new Point(701, 339);
            txtTotalVariance.Margin = new Padding(4, 3, 4, 3);
            txtTotalVariance.Name = "txtTotalVariance";
            txtTotalVariance.ReadOnly = true;
            txtTotalVariance.Size = new Size(116, 23);
            txtTotalVariance.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point(362, 458);
            button4.Name = "button4";
            button4.Size = new Size(141, 23);
            button4.TabIndex = 42;
            button4.Text = "Return to Dashboard";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(button4);
            Controls.Add(txtTotalVariance);
            Controls.Add(txtCASABalance);
            Controls.Add(txtJSBABalance);
            Controls.Add(txtPurchasesVariance);
            Controls.Add(txtCASAEventPurchases);
            Controls.Add(txtJSBAEventPurchases);
            Controls.Add(lblTotalBalance);
            Controls.Add(lblEventServices);
            Controls.Add(lblEventPurchases);
            Controls.Add(lblVariance);
            Controls.Add(lblCASABalance);
            Controls.Add(lblJSBABalance);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            Text = "EventSummary";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJSBABalance;
        private System.Windows.Forms.Label lblCASABalance;
        private System.Windows.Forms.Label lblVariance;
        private System.Windows.Forms.Label lblEventPurchases;
        private System.Windows.Forms.Label lblEventServices;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.TextBox txtJSBAEventPurchases;
        private System.Windows.Forms.TextBox txtCASAEventPurchases;
        private System.Windows.Forms.TextBox txtPurchasesVariance;
        private System.Windows.Forms.TextBox txtJSBABalance;
        private System.Windows.Forms.TextBox txtCASABalance;
        private System.Windows.Forms.TextBox txtTotalVariance;
        private Button button4;
    }
}