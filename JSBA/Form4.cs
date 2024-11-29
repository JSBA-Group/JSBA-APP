using System.Data.SqlClient;

namespace JSBA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnChequeRequisition_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cheque requisition display loaded.");
        }

        private void BtnConfirmPickUpTime_Click(object sender, EventArgs e)
        {
            DateTime pickUpTime = dtpPickUp.Value;
            MessageBox.Show($"Pick-up time confirmed for {pickUpTime}");
        }

        private void BtnCurrentRequestDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying current cheque request.");
        }

        private void BtnConfirmReceipt_Click(object sender, EventArgs e)
        {
            string signature = txtSignature.Text;
            if (string.IsNullOrEmpty(signature))
            {
                MessageBox.Show("Please enter a signature.");
                return;
            }

            MessageBox.Show("Signature confirmed. Cheque marked as received.");
        }

        private void BtnChequeReceivedNotification_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Notification: Cheque has been received and recorded in the database.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
        }
    }
}
