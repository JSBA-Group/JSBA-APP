using MySql.Data.MySqlClient;

namespace JSBA
{
    public partial class frmRegister : Form
    {
        private string firstName;
        private string lastName;
        private string email;
        private string username;
        private string password;
        private string confirmPassword;
        private string accountType;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstName = textFirstName.Text;
            lastName = textLastName.Text;
            email = textEmail.Text;
            username = textUsername.Text;
            password = textPassword.Text;
            confirmPassword = textConfirmPassword.Text;

            if (radioButton1.Checked)
            {
                accountType = "JSBA";
            }
            else if (radioButton2.Checked)
            {
                accountType = "CASA";
            }
            else
            {
                MessageBox.Show("Please select an account type.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields must be filled.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InsertUser(firstName, lastName, email, accountType, username, password))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InsertUser(string firstName, string lastName, string email, string accountType, string username, string password)
        {
            string connectionString = "Server=localhost;Database=mydb;Uid=root;Pwd=root;";
            string query = "INSERT INTO users (first_name, last_name, email, accountType, username, password) " +
                           "VALUES (@FirstName, @LastName, @Email, @AccountType, @Username, @Password)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@AccountType", accountType);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                textPassword.PasswordChar = '\0';
                textConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
                textConfirmPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textFirstName.Text = string.Empty;
            textLastName.Text = string.Empty;
            textEmail.Text = string.Empty;
            textUsername.Text = string.Empty;
            textPassword.Text = string.Empty;
            textConfirmPassword.Text = string.Empty;

        }
    }
}