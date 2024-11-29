namespace JSBA
{
    partial class dashboard
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnBudgeting = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 0, 64);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnBudgeting);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(676, 464);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(0, 356);
            button3.Name = "button3";
            button3.Padding = new Padding(12, 0, 0, 0);
            button3.Size = new Size(676, 80);
            button3.TabIndex = 5;
            button3.Text = "Verify Outstanding Balances";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += label8_Click;

            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(0, 264);
            button2.Name = "button2";
            button2.Padding = new Padding(12, 0, 0, 0);
            button2.Size = new Size(676, 92);
            button2.TabIndex = 4;
            button2.Text = "Refund and Signature";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += label9_Click;

            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(0, 161);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(676, 103);
            button1.TabIndex = 3;
            button1.Text = "Cheque Requisition";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += label7_Click;
            // 
            // btnBudgeting
            // 
            btnBudgeting.Dock = DockStyle.Top;
            btnBudgeting.FlatAppearance.BorderSize = 0;
            btnBudgeting.FlatStyle = FlatStyle.Flat;
            btnBudgeting.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBudgeting.ForeColor = Color.Gainsboro;
            btnBudgeting.Location = new Point(0, 75);
            btnBudgeting.Name = "btnBudgeting";
            btnBudgeting.Padding = new Padding(12, 0, 0, 0);
            btnBudgeting.Size = new Size(676, 86);
            btnBudgeting.TabIndex = 2;
            btnBudgeting.Text = "Event Budgeting";
            btnBudgeting.TextAlign = ContentAlignment.MiddleLeft;
            btnBudgeting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBudgeting.UseVisualStyleBackColor = true;
            btnBudgeting.Click += label6_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(676, 75);
            panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 54);
            label1.TabIndex = 0;
            label1.Text = "JSBA";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 464);
            Controls.Add(panelMenu);
            Name = "dashboard";
            Text = "dashboard";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnBudgeting;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}