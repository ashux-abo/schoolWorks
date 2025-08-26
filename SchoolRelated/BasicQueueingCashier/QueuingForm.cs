using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueueingCashier
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        CashierWindowQueueForm form = new CashierWindowQueueForm();
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            form.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CahsierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }
    }
}
