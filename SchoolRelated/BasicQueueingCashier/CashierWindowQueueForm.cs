using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        private System.Windows.Forms.Timer timer;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = (1 * 1000);

            this.timer.Tick += new EventHandler(this.timer1_Tick);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
            timer.Start();
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
