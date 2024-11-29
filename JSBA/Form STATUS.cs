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
    public partial class Form_STATUS : Form
    {
        private string connectionString = "Server=localhost;Database=mydb;Uid=root;Pwd=root;";

        public Form_STATUS()
        {
            InitializeComponent();
            LoadRequests();
            listViewFormsAwaiting.SelectedIndexChanged += ListViewFormsAwaiting_SelectedIndexChanged;
        }

        private void buttonConfirmApproval_Click(object sender, EventArgs e)
        {
            if (AreAllCheckboxesChecked())
            {
                if (listViewFormsAwaiting.SelectedItems.Count > 0)
                {
                    string transactionId = listViewFormsAwaiting.SelectedItems[0].Text;
                    ApproveRequest(transactionId);
                }
                else
                {
                    MessageBox.Show("No request selected.", "Approval Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please ensure all approvals are checked.", "Approval Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool AreAllCheckboxesChecked()
        {
            return checkBoxApp1.Checked && checkBoxApp2.Checked && checkBoxApp3.Checked && checkBoxApp4.Checked && checkBoxApp5.Checked;
        }

        private void ApproveRequest(string transactionId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE CasaTransactionRequest SET Status = 'Approved' WHERE TransactionID = @TransactionID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TransactionID", transactionId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Request approved successfully!", "Approval Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRequests(); // Refresh the list
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Approval registred !");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
        }


        private void LoadRequests()
        {
            listViewFormsAwaiting.Items.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TransactionID, LastName, FirstName, DateOfSubmission, TransactionAmount, Status " +
                                   "FROM CasaTransactionRequest WHERE Status = 'Pending'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listViewFormsAwaiting.Columns.Clear();
                        listViewFormsAwaiting.Columns.Add("Transaction ID", 100);
                        listViewFormsAwaiting.Columns.Add("Last Name", 150);
                        listViewFormsAwaiting.Columns.Add("First Name", 150);
                        listViewFormsAwaiting.Columns.Add("Submission Date", 150);
                        listViewFormsAwaiting.Columns.Add("Amount", 100);

                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["TransactionID"].ToString());
                            item.SubItems.Add(reader["LastName"].ToString());
                            item.SubItems.Add(reader["FirstName"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["DateOfSubmission"]).ToString("yyyy-MM-dd"));
                            item.SubItems.Add(Convert.ToDecimal(reader["TransactionAmount"]).ToString("C2"));

                            listViewFormsAwaiting.Items.Add(item);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display selected request details in the richTextBox
        private void ListViewFormsAwaiting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFormsAwaiting.SelectedItems.Count > 0)
            {
                string transactionId = listViewFormsAwaiting.SelectedItems[0].Text;
                LoadRequestDetails(transactionId);
            }
        }

        private void LoadRequestDetails(string transactionId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM CasaTransactionRequest WHERE TransactionID = @TransactionID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TransactionID", transactionId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                richTextBoxSelectedForm.Text =
                                    $"Transaction ID: {reader["TransactionID"]}\n" +
                                    $"Student ID: {reader["StudentID"]}\n" +
                                    $"Last Name: {reader["LastName"]}\n" +
                                    $"First Name: {reader["FirstName"]}\n" +
                                    $"Email: {reader["ContactEmail"]}\n" +
                                    $"Phone Number: {reader["ContactPhoneNumber"]}\n" +
                                    $"Date of Submission: {Convert.ToDateTime(reader["DateOfSubmission"]).ToString("yyyy-MM-dd")}\n" +
                                    $"Date of Receipt: {reader["DateOfReceipt"]}\n" +
                                    $"Amount: {Convert.ToDecimal(reader["TransactionAmount"]).ToString("C2")}\n" +
                                    $"Description: {reader["TransactionDescription"]}\n" +
                                    $"Status: {reader["Status"]}";
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
