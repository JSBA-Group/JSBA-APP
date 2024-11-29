using JSBA;
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
    public partial class CRForCRD : Form
    {
        public CRForCRD()
        {
            InitializeComponent();
        }

        private void btnCheqReqForm_Click(object sender, EventArgs e)
        {
            var newform = new CRF();
            this.Hide();
            newform.ShowDialog();
        }

        private void btnCheqReqFormStatus_Click(object sender, EventArgs e)
        {
            var newform = new Form_STATUS();
            this.Hide();
            newform.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Hide();
         
        }
    }
}
