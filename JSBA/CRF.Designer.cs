namespace Cheque_Requisition_Form
{
    partial class CRF
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
            lblCasaTransactionRF = new Label();
            lblContactInfo = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblContactEmail = new Label();
            lblContactPhone = new Label();
            lblStudentID = new Label();
            lblReceiptInfo = new Label();
            lblDateReceipt = new Label();
            lblTransactionAmount = new Label();
            lblTransactionDesc = new Label();
            txtBoxStudentId = new TextBox();
            txtBoxLastN = new TextBox();
            txtBoxFirstN = new TextBox();
            txtBoxContactMail = new TextBox();
            txtBoxContactNumber = new TextBox();
            txtBoxDateReceipt = new TextBox();
            txtBoxTransactionAmount = new TextBox();
            richTextBoxTransDesc = new RichTextBox();
            lblDateSub = new Label();
            txtBoxDateSub = new TextBox();
            btnSubmit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblCasaTransactionRF
            // 
            lblCasaTransactionRF.AutoSize = true;
            lblCasaTransactionRF.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCasaTransactionRF.Location = new Point(191, 19);
            lblCasaTransactionRF.Name = "lblCasaTransactionRF";
            lblCasaTransactionRF.Size = new Size(440, 32);
            lblCasaTransactionRF.TabIndex = 0;
            lblCasaTransactionRF.Text = "CASA TRANSACTION REQUEST FORM";
            // 
            // lblContactInfo
            // 
            lblContactInfo.AutoSize = true;
            lblContactInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblContactInfo.Location = new Point(58, 62);
            lblContactInfo.Name = "lblContactInfo";
            lblContactInfo.Size = new Size(96, 15);
            lblContactInfo.TabIndex = 1;
            lblContactInfo.Text = "CONTACT INFO";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(58, 114);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(58, 140);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // lblContactEmail
            // 
            lblContactEmail.AutoSize = true;
            lblContactEmail.Location = new Point(58, 165);
            lblContactEmail.Name = "lblContactEmail";
            lblContactEmail.Size = new Size(89, 15);
            lblContactEmail.TabIndex = 4;
            lblContactEmail.Text = "Contact E-Mail:";
            // 
            // lblContactPhone
            // 
            lblContactPhone.AutoSize = true;
            lblContactPhone.Location = new Point(58, 189);
            lblContactPhone.Name = "lblContactPhone";
            lblContactPhone.Size = new Size(136, 15);
            lblContactPhone.TabIndex = 5;
            lblContactPhone.Text = "Contact Phone Number:";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(58, 89);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(65, 15);
            lblStudentID.TabIndex = 6;
            lblStudentID.Text = "Student ID:";
            // 
            // lblReceiptInfo
            // 
            lblReceiptInfo.AutoSize = true;
            lblReceiptInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblReceiptInfo.Location = new Point(58, 229);
            lblReceiptInfo.Name = "lblReceiptInfo";
            lblReceiptInfo.Size = new Size(86, 15);
            lblReceiptInfo.TabIndex = 7;
            lblReceiptInfo.Text = "RECEIPT INFO";
            // 
            // lblDateReceipt
            // 
            lblDateReceipt.AutoSize = true;
            lblDateReceipt.Location = new Point(58, 258);
            lblDateReceipt.Name = "lblDateReceipt";
            lblDateReceipt.Size = new Size(174, 15);
            lblDateReceipt.TabIndex = 8;
            lblDateReceipt.Text = "Date of receipt (YYYY-MM-DD):";
            lblDateReceipt.Click += lblDateReceipt_Click;
            // 
            // lblTransactionAmount
            // 
            lblTransactionAmount.AutoSize = true;
            lblTransactionAmount.Location = new Point(58, 282);
            lblTransactionAmount.Name = "lblTransactionAmount";
            lblTransactionAmount.Size = new Size(117, 15);
            lblTransactionAmount.TabIndex = 9;
            lblTransactionAmount.Text = "Transaction Amount:";
            // 
            // lblTransactionDesc
            // 
            lblTransactionDesc.AutoSize = true;
            lblTransactionDesc.Location = new Point(58, 306);
            lblTransactionDesc.Name = "lblTransactionDesc";
            lblTransactionDesc.Size = new Size(133, 15);
            lblTransactionDesc.TabIndex = 10;
            lblTransactionDesc.Text = "Transaction Description:";
            // 
            // txtBoxStudentId
            // 
            txtBoxStudentId.Location = new Point(129, 81);
            txtBoxStudentId.Name = "txtBoxStudentId";
            txtBoxStudentId.Size = new Size(308, 23);
            txtBoxStudentId.TabIndex = 11;
            // 
            // txtBoxLastN
            // 
            txtBoxLastN.Location = new Point(129, 106);
            txtBoxLastN.Name = "txtBoxLastN";
            txtBoxLastN.Size = new Size(308, 23);
            txtBoxLastN.TabIndex = 12;
            // 
            // txtBoxFirstN
            // 
            txtBoxFirstN.Location = new Point(129, 132);
            txtBoxFirstN.Name = "txtBoxFirstN";
            txtBoxFirstN.Size = new Size(308, 23);
            txtBoxFirstN.TabIndex = 13;
            // 
            // txtBoxContactMail
            // 
            txtBoxContactMail.Location = new Point(153, 157);
            txtBoxContactMail.Name = "txtBoxContactMail";
            txtBoxContactMail.Size = new Size(284, 23);
            txtBoxContactMail.TabIndex = 14;
            // 
            // txtBoxContactNumber
            // 
            txtBoxContactNumber.Location = new Point(200, 181);
            txtBoxContactNumber.Name = "txtBoxContactNumber";
            txtBoxContactNumber.Size = new Size(237, 23);
            txtBoxContactNumber.TabIndex = 15;
            // 
            // txtBoxDateReceipt
            // 
            txtBoxDateReceipt.Location = new Point(238, 250);
            txtBoxDateReceipt.Name = "txtBoxDateReceipt";
            txtBoxDateReceipt.Size = new Size(199, 23);
            txtBoxDateReceipt.TabIndex = 16;
            // 
            // txtBoxTransactionAmount
            // 
            txtBoxTransactionAmount.Location = new Point(181, 274);
            txtBoxTransactionAmount.Name = "txtBoxTransactionAmount";
            txtBoxTransactionAmount.Size = new Size(256, 23);
            txtBoxTransactionAmount.TabIndex = 17;
            // 
            // richTextBoxTransDesc
            // 
            richTextBoxTransDesc.Location = new Point(65, 327);
            richTextBoxTransDesc.Name = "richTextBoxTransDesc";
            richTextBoxTransDesc.Size = new Size(372, 87);
            richTextBoxTransDesc.TabIndex = 18;
            richTextBoxTransDesc.Text = "";
            // 
            // lblDateSub
            // 
            lblDateSub.AutoSize = true;
            lblDateSub.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblDateSub.Location = new Point(568, 62);
            lblDateSub.Name = "lblDateSub";
            lblDateSub.Size = new Size(220, 15);
            lblDateSub.TabIndex = 19;
            lblDateSub.Text = "DATE OF SUBMISSION (YYYY-MM-DD):";
            // 
            // txtBoxDateSub
            // 
            txtBoxDateSub.Location = new Point(568, 81);
            txtBoxDateSub.Name = "txtBoxDateSub";
            txtBoxDateSub.Size = new Size(220, 23);
            txtBoxDateSub.TabIndex = 20;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(65, 451);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(372, 38);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(568, 459);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 22;
            button1.Text = "Return to Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CRF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(button1);
            Controls.Add(btnSubmit);
            Controls.Add(txtBoxDateSub);
            Controls.Add(lblDateSub);
            Controls.Add(richTextBoxTransDesc);
            Controls.Add(txtBoxTransactionAmount);
            Controls.Add(txtBoxDateReceipt);
            Controls.Add(txtBoxContactNumber);
            Controls.Add(txtBoxContactMail);
            Controls.Add(txtBoxFirstN);
            Controls.Add(txtBoxLastN);
            Controls.Add(txtBoxStudentId);
            Controls.Add(lblTransactionDesc);
            Controls.Add(lblTransactionAmount);
            Controls.Add(lblDateReceipt);
            Controls.Add(lblReceiptInfo);
            Controls.Add(lblStudentID);
            Controls.Add(lblContactPhone);
            Controls.Add(lblContactEmail);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblContactInfo);
            Controls.Add(lblCasaTransactionRF);
            Name = "CRF";
            Text = "CRF";
            Load += CRF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCasaTransactionRF;
        private Label lblContactInfo;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblContactEmail;
        private Label lblContactPhone;
        private Label lblStudentID;
        private Label lblReceiptInfo;
        private Label lblDateReceipt;
        private Label lblTransactionAmount;
        private Label lblTransactionDesc;
        private TextBox txtBoxStudentId;
        private TextBox txtBoxLastN;
        private TextBox txtBoxFirstN;
        private TextBox txtBoxContactMail;
        private TextBox txtBoxContactNumber;
        private TextBox txtBoxDateReceipt;
        private TextBox txtBoxTransactionAmount;
        private RichTextBox richTextBoxTransDesc;
        private Label lblDateSub;
        private TextBox txtBoxDateSub;
        private Button btnSubmit;
        private Button button1;
    }
}