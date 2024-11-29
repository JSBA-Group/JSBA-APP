namespace JSBA
{
    partial class Form4
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
            btnChequeRequisition = new Button();
            btnConfirmPickUpTime = new Button();
            btnCurrentRequestDisplay = new Button();
            dtpPickUp = new DateTimePicker();
            btnConfirmReceipt = new Button();
            btnChequeReceivedNotification = new Button();
            txtSignature = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnChequeRequisition
            // 
            btnChequeRequisition.Location = new Point(328, 75);
            btnChequeRequisition.Name = "btnChequeRequisition";
            btnChequeRequisition.Size = new Size(159, 22);
            btnChequeRequisition.TabIndex = 0;
            btnChequeRequisition.Text = "Cheque Requisition Display";
            btnChequeRequisition.UseVisualStyleBackColor = true;
            btnChequeRequisition.Click += BtnChequeRequisition_Click;
            // 
            // btnConfirmPickUpTime
            // 
            btnConfirmPickUpTime.Location = new Point(328, 118);
            btnConfirmPickUpTime.Name = "btnConfirmPickUpTime";
            btnConfirmPickUpTime.Size = new Size(159, 22);
            btnConfirmPickUpTime.TabIndex = 1;
            btnConfirmPickUpTime.Text = "Confirm Pick-Up Time";
            btnConfirmPickUpTime.UseVisualStyleBackColor = true;
            btnConfirmPickUpTime.Click += BtnConfirmPickUpTime_Click;
            // 
            // btnCurrentRequestDisplay
            // 
            btnCurrentRequestDisplay.Location = new Point(328, 164);
            btnCurrentRequestDisplay.Name = "btnCurrentRequestDisplay";
            btnCurrentRequestDisplay.Size = new Size(159, 22);
            btnCurrentRequestDisplay.TabIndex = 2;
            btnCurrentRequestDisplay.Text = "Current Request Display";
            btnCurrentRequestDisplay.UseVisualStyleBackColor = true;
            btnCurrentRequestDisplay.Click += BtnCurrentRequestDisplay_Click;
            // 
            // dtpPickUp
            // 
            dtpPickUp.Location = new Point(85, 73);
            dtpPickUp.Name = "dtpPickUp";
            dtpPickUp.Size = new Size(154, 23);
            dtpPickUp.TabIndex = 3;
            // 
            // btnConfirmReceipt
            // 
            btnConfirmReceipt.Location = new Point(328, 205);
            btnConfirmReceipt.Name = "btnConfirmReceipt";
            btnConfirmReceipt.Size = new Size(159, 22);
            btnConfirmReceipt.TabIndex = 4;
            btnConfirmReceipt.Text = "Confirm Receipt";
            btnConfirmReceipt.UseVisualStyleBackColor = true;
            btnConfirmReceipt.Click += BtnConfirmReceipt_Click;
            // 
            // btnChequeReceivedNotification
            // 
            btnChequeReceivedNotification.Location = new Point(328, 245);
            btnChequeReceivedNotification.Name = "btnChequeReceivedNotification";
            btnChequeReceivedNotification.Size = new Size(159, 22);
            btnChequeReceivedNotification.TabIndex = 5;
            btnChequeReceivedNotification.Text = "Confirm Cheque Pickup";
            btnChequeReceivedNotification.UseVisualStyleBackColor = true;
            btnChequeReceivedNotification.Click += BtnChequeReceivedNotification_Click1;
            // 
            // txtSignature
            // 
            txtSignature.Location = new Point(94, 143);
            txtSignature.Name = "txtSignature";
            txtSignature.Size = new Size(136, 23);
            txtSignature.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(346, 387);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 23;
            button1.Text = "Return to Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(button1);
            Controls.Add(txtSignature);
            Controls.Add(btnChequeReceivedNotification);
            Controls.Add(btnConfirmReceipt);
            Controls.Add(dtpPickUp);
            Controls.Add(btnCurrentRequestDisplay);
            Controls.Add(btnConfirmPickUpTime);
            Controls.Add(btnChequeRequisition);
            Name = "Form4";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnChequeReceivedNotification_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnChequeRequisition;
        private System.Windows.Forms.Button btnConfirmPickUpTime;
        private System.Windows.Forms.Button btnCurrentRequestDisplay;
        private System.Windows.Forms.DateTimePicker dtpPickUp;
        private System.Windows.Forms.Button btnConfirmReceipt;
        private System.Windows.Forms.Button btnChequeReceivedNotification;
        private System.Windows.Forms.TextBox txtSignature;
        private Button button1;
    }
}