namespace JSBA
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            textFirstName = new TextBox();
            textPassword = new TextBox();
            label3 = new Label();
            textConfirmPassword = new TextBox();
            label4 = new Label();
            chkShowPassword = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            textEmail = new TextBox();
            label7 = new Label();
            textLastName = new TextBox();
            label8 = new Label();
            textUsername = new TextBox();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._302148529_494508352684327_6852562574363010791_n;
            pictureBox1.Location = new Point(128, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(9, 33, 82);
            label2.Location = new Point(31, 179);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 2;
            label2.Text = "Create a new account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 217);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // textFirstName
            // 
            textFirstName.BackColor = Color.FromArgb(230, 231, 233);
            textFirstName.BorderStyle = BorderStyle.None;
            textFirstName.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textFirstName.Location = new Point(31, 237);
            textFirstName.Multiline = true;
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(216, 28);
            textFirstName.TabIndex = 4;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(230, 231, 233);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(321, 298);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '•';
            textPassword.Size = new Size(216, 28);
            textPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 278);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.BackColor = Color.FromArgb(230, 231, 233);
            textConfirmPassword.BorderStyle = BorderStyle.None;
            textConfirmPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textConfirmPassword.Location = new Point(321, 359);
            textConfirmPassword.Multiline = true;
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.PasswordChar = '•';
            textConfirmPassword.Size = new Size(216, 28);
            textConfirmPassword.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 339);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.FlatStyle = FlatStyle.Flat;
            chkShowPassword.Location = new Point(428, 390);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(119, 21);
            chkShowPassword.TabIndex = 9;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(9, 33, 82);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(195, 437);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 10;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(9, 33, 82);
            button2.Location = new Point(195, 490);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 11;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 554);
            label5.Name = "label5";
            label5.Size = new Size(159, 17);
            label5.TabIndex = 12;
            label5.Text = "Already have an account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(9, 33, 82);
            label6.Location = new Point(251, 580);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 13;
            label6.Text = "Back to LOGIN";
            label6.Click += label6_Click;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.FromArgb(230, 231, 233);
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(31, 359);
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(216, 28);
            textEmail.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 339);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // textLastName
            // 
            textLastName.BackColor = Color.FromArgb(230, 231, 233);
            textLastName.BorderStyle = BorderStyle.None;
            textLastName.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLastName.Location = new Point(31, 298);
            textLastName.Multiline = true;
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(216, 28);
            textLastName.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 278);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 16;
            label8.Text = "Last Name";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 233);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(321, 237);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(216, 28);
            textUsername.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 217);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 14;
            label9.Text = "First Name";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(195, 177);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 21);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "JSBA";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(257, 177);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 21);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "CASA";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(577, 620);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textEmail);
            Controls.Add(label7);
            Controls.Add(textLastName);
            Controls.Add(label8);
            Controls.Add(textUsername);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkShowPassword);
            Controls.Add(textConfirmPassword);
            Controls.Add(label4);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(textFirstName);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox textFirstName;
        private TextBox textPassword;
        private Label label3;
        private TextBox textConfirmPassword;
        private Label label4;
        private CheckBox chkShowPassword;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox textEmail;
        private Label label7;
        private TextBox textLastName;
        private Label label8;
        private TextBox textUsername;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
