namespace JSBA
{
    partial class frmLogin
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
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            checkBxShowPas = new CheckBox();
            textPassword = new TextBox();
            label3 = new Label();
            textUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(9, 33, 82);
            label6.Location = new Point(101, 483);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 26;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 466);
            label5.Name = "label5";
            label5.Size = new Size(147, 17);
            label5.TabIndex = 25;
            label5.Text = "Don’t have an account";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(9, 33, 82);
            button2.Location = new Point(42, 398);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 24;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(9, 33, 82);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(42, 347);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 23;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBxShowPas
            // 
            checkBxShowPas.AutoSize = true;
            checkBxShowPas.Cursor = Cursors.Hand;
            checkBxShowPas.FlatStyle = FlatStyle.Flat;
            checkBxShowPas.Location = new Point(149, 306);
            checkBxShowPas.Name = "checkBxShowPas";
            checkBxShowPas.Size = new Size(119, 21);
            checkBxShowPas.TabIndex = 22;
            checkBxShowPas.Text = "Show Password";
            checkBxShowPas.UseVisualStyleBackColor = true;
            checkBxShowPas.CheckedChanged += checkBxShowPas_CheckedChanged;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(230, 231, 233);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(42, 269);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '•';
            textPassword.Size = new Size(216, 28);
            textPassword.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 249);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 233);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(42, 208);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(216, 28);
            textUsername.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 188);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 16;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(9, 33, 82);
            label2.Location = new Point(109, 146);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 15;
            label2.Text = "Get Started";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._302148529_494508352684327_6852562574363010791_n;
            pictureBox1.Location = new Point(79, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(317, 541);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBxShowPas);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private CheckBox checkBxShowPas;
        private TextBox textPassword;
        private Label label3;
        private TextBox textUsername;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}