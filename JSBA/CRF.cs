using JSBA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheque_Requisition_Form
{
    public partial class CRF : Form
    {
        public CRF()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the data from the form fields
            string studentId = txtBoxStudentId.Text;
            string lastName = txtBoxLastN.Text;
            string firstName = txtBoxFirstN.Text;
            string contactEmail = txtBoxContactMail.Text;
            string contactPhone = txtBoxContactNumber.Text;
            string dateReceipt = txtBoxDateReceipt.Text;
            string transactionAmount = txtBoxTransactionAmount.Text;
            string transactionDesc = richTextBoxTransDesc.Text;
            string dateSub = txtBoxDateSub.Text;

            // Check if any required fields are empty
            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(contactEmail) ||
                string.IsNullOrWhiteSpace(contactPhone) || string.IsNullOrWhiteSpace(dateReceipt) ||
                string.IsNullOrWhiteSpace(transactionAmount) || string.IsNullOrWhiteSpace(transactionDesc) ||
                string.IsNullOrWhiteSpace(dateSub))
            {
                MessageBox.Show("Please fill out all required fields.", "Form Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert the data into the database
            string connectionString = "Server=localhost;Database=mydb;Uid=root;Pwd=root;"; // Adjust connection string as needed
            string query = @"INSERT INTO CasaTransactionRequest 
                             (StudentID, LastName, FirstName, ContactEmail, ContactPhoneNumber, DateOfSubmission, DateOfReceipt, TransactionAmount, TransactionDescription)
                             VALUES 
                             (@StudentID, @LastName, @FirstName, @ContactEmail, @ContactPhone, @DateOfSubmission, @DateOfReceipt, @TransactionAmount, @TransactionDescription)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@StudentID", studentId);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@ContactEmail", contactEmail);
                        cmd.Parameters.AddWithValue("@ContactPhone", contactPhone);
                        cmd.Parameters.AddWithValue("@DateOfSubmission", dateSub); // Ensure correct date format (e.g., YYYY-MM-DD)
                        cmd.Parameters.AddWithValue("@DateOfReceipt", dateReceipt); // Ensure correct date format (e.g., YYYY-MM-DD)
                        cmd.Parameters.AddWithValue("@TransactionAmount", Convert.ToDecimal(transactionAmount)); // Convert string to decimal
                        cmd.Parameters.AddWithValue("@TransactionDescription", transactionDesc);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }

                // Show success message
                MessageBox.Show("Transaction request submitted successfully!", "Form Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, you can redirect to another form or clear the form
                new dashboard().Show();
                this.Hide();
            }
            catch (MySqlException ex)
            {
                // Handle any database-related errors
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                // Handle any format errors (e.g., incorrect date or amount format)
                MessageBox.Show("Invalid data format. Please check the entered values.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
        }

        private void lblDateReceipt_Click(object sender, EventArgs e)
        {

        }

        private void CRF_Load(object sender, EventArgs e)
        {

        }
    }
}
