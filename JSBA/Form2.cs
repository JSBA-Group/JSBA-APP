using Cheque_Requisition_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSBA
{
    public partial class Form2 : Form
    {
        private decimal totalPurchaseCost = 0;
        private decimal totalServiceCost = 0;

        public Form2()
        {
            InitializeComponent();
        }

        public List<string> purchaseItems = new List<string>();
        public List<string> serviceItems = new List<string>();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPurchase.Text) && !string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
            {
                decimal price;
                if (decimal.TryParse(txtPurchasePrice.Text, out price))
                {
                    totalPurchaseCost += price;
                    MessageBox.Show("Purchase added!");
                    purchaseItems.Add($"{txtPurchase.Text} - {txtPurchasePrice.Text}");
                    txtPurchase.Clear();
                    txtPurchasePrice.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid price for purchase.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the purchase and price fields");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtService.Text) && !string.IsNullOrWhiteSpace(txtServicePrice.Text))
            {
                decimal price;
                if (decimal.TryParse(txtServicePrice.Text, out price))
                {
                    totalServiceCost += price;
                    MessageBox.Show("Service added!");
                    serviceItems.Add($"{txtService.Text} - {txtServicePrice.Text}");
                    txtService.Clear();
                    txtServicePrice.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid price for service.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the service and price fields.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ShowSummary();
            }
            else
            {
                MessageBox.Show("Some fields are missing. Please complete the form.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Display current items in purchases
                if (purchaseItems.Count == 0 && serviceItems.Count == 0)
                {
                    MessageBox.Show("No items to remove.");
                    return;
                }

                // Display purchase items
                StringBuilder sb = new StringBuilder("Purchase Items:\n");
                for (int i = 0; i < purchaseItems.Count; i++)
                {
                    sb.AppendLine($"{i}: {purchaseItems[i]}");
                    {
                        sb.AppendLine($"{i + purchaseItems.Count}: {serviceItems[i]}");
                    }
                    MessageBox.Show(sb.ToString(), "Current Items");

                    // Get index to remove from the user
                    if (int.TryParse(txtRemove.Text, out int indexToRemove))
                    {
                        if (indexToRemove >= 0 && indexToRemove < purchaseItems.Count)
                        {
                            // To remove from purchase items
                            totalPurchaseCost -= decimal.Parse(purchaseItems[indexToRemove].Split('-')[1].Trim());
                            purchaseItems.RemoveAt(indexToRemove);
                            MessageBox.Show("Purchase item removed successfully.");
                        }
                        else if (indexToRemove >= purchaseItems.Count && indexToRemove < purchaseItems.Count + serviceItems.Count)
                        {
                            // To remove from service items
                            int serviceIndex = indexToRemove - purchaseItems.Count;
                            totalServiceCost -= decimal.Parse(serviceItems[serviceIndex].Split('-')[1].Trim());
                            serviceItems.RemoveAt(serviceIndex);
                            MessageBox.Show("Service item removed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Invalid index. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number.");
                    }
                    txtRemove.Clear();
                }

            }
            catch (Exception ex)
            {
                // To display the exception message
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private bool ValidateForm()
        {
            bool isEventTypeSelected = rdbtnCon.Checked || rdbtnRec.Checked || rdbtnMix.Checked;
            if (string.IsNullOrWhiteSpace(txtEventName.Text) || !isEventTypeSelected)
            {
                return false;
            }

            return true;
        }

        private void ShowSummary()
        {
            string eventType = rdbtnCon.Checked ? "Conference" :
                rdbtnRec.Checked ? "Recruiting" :
                rdbtnMix.Checked ? "Mixer" : "Unknown";

            string summary = $"Event Name: {txtEventName.Text}\n" +
                $"Event Type: {eventType}\n" +
                $"Total Purchases Cost: {totalPurchaseCost:C}\n" +
                $"Total Services Cost: {totalServiceCost:C}\n\n" +
                $"Purchases:\n";

            // Add each purchase to summary
            foreach (var item in purchaseItems)
            {
                summary += $"{item}\n";
            }

            summary += "\nServices:\n";

            // Add each service to summary
            foreach (var service in serviceItems)
            {
                summary += $"{service}\n";
            }

            MessageBox.Show(summary, "Form Summary");
            new dashboard().Show();
            this.Hide();

        }

        private void txtRemove_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
        }
    }
}
