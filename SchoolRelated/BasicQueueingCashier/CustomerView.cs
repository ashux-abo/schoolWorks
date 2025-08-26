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
    public partial class CustomerView : Form
    {
        private CashierClass cashier;
        private System.Windows.Forms.Timer timer;
        public CustomerView()
        {
            InitializeComponent(); 
            cashier = new CashierClass();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadQueue(string CurrentQueue)
        {
            lblQueue.Text = CurrentQueue;
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }
    }
}
