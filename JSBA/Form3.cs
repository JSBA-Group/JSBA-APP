using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSBA
{
    public partial class Form3 : Form
    {
        private string connectionString = "Server=localhost;Database=mydb;Uid=root;Pwd=root;";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CalculateAndDisplayTotals();
        }

        //private void CalculateAndDisplayTotals()
        //{
        //    try
        //    {
        //        using (MySqlConnection conn = new MySqlConnection(connectionString))
        //        {
        //            conn.Open();

        //            // Query to calculate total amount of requests
        //            string query = "SELECT SUM(TransactionAmount) AS TotalAmount FROM CasaTransactionRequest";

        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                object result = cmd.ExecuteScalar();
        //                decimal totalAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

        //                // Update JSBA Event Purchases and Balance fields
        //                txtJSBAEventPurchases.Text = totalAmount.ToString("C2");
        //                txtJSBABalance.Text = totalAmount.ToString("C2");
        //            }
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void CalculateAndDisplayTotals()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to calculate total amount of approved requests for JSBA
                    string queryJSBA = "SELECT SUM(TransactionAmount) AS TotalAmount FROM CasaTransactionRequest WHERE Status = 'Pending'";

                    // Query to calculate total amount of approved requests for CASA
                    string queryCASA = "SELECT SUM(TransactionAmount) AS TotalAmount FROM CasaTransactionRequest WHERE Status = 'Approved'";

                    decimal jsbaTotal = 0;
                    decimal casaTotal = 0;

                    // Execute the JSBA query
                    using (MySqlCommand cmd = new MySqlCommand(queryJSBA, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        jsbaTotal = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }

                    // Execute the CASA query
                    using (MySqlCommand cmd = new MySqlCommand(queryCASA, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        casaTotal = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }

                    decimal balence = jsbaTotal - casaTotal;

                    // Update fields
                    txtJSBAEventPurchases.Text = jsbaTotal.ToString("C2");
                    txtJSBABalance.Text = jsbaTotal.ToString("C2");

                    txtCASAEventPurchases.Text = casaTotal.ToString("C2");
                    txtCASABalance.Text = casaTotal.ToString("C2");

                    txtPurchasesVariance.Text = balence.ToString("C2");
                    txtTotalVariance.Text = balence.ToString("C2");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
        }
    }
}
