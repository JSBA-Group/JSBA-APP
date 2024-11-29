namespace Cheque_Requisition_Form
{
    partial class CRForCRD
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
            btnCheqReqForm = new Button();
            btnCheqReqFormStatus = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCheqReqForm
            // 
            btnCheqReqForm.Location = new Point(229, 79);
            btnCheqReqForm.Name = "btnCheqReqForm";
            btnCheqReqForm.Size = new Size(324, 104);
            btnCheqReqForm.TabIndex = 0;
            btnCheqReqForm.Text = "Cheque Requisition Form";
            btnCheqReqForm.UseVisualStyleBackColor = true;
            btnCheqReqForm.Click += btnCheqReqForm_Click;
            // 
            // btnCheqReqFormStatus
            // 
            btnCheqReqFormStatus.Location = new Point(229, 189);
            btnCheqReqFormStatus.Name = "btnCheqReqFormStatus";
            btnCheqReqFormStatus.Size = new Size(324, 95);
            btnCheqReqFormStatus.TabIndex = 2;
            btnCheqReqFormStatus.Text = "Cheque Requisition Form STATUS";
            btnCheqReqFormStatus.UseVisualStyleBackColor = true;
            btnCheqReqFormStatus.Click += btnCheqReqFormStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(229, 28);
            label1.Name = "label1";
            label1.Size = new Size(325, 28);
            label1.TabIndex = 3;
            label1.Text = "Cheque Requisition Functionality";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(310, 380);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 4;
            button1.Text = "Return to Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CRForCRD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnCheqReqFormStatus);
            Controls.Add(btnCheqReqForm);
            Name = "CRForCRD";
            Text = "CRF or CRD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheqReqForm;
        private Button btnCheqReqFormStatus;
        private Label label1;
        private Button button1;
    }
}