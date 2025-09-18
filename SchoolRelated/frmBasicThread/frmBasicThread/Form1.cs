using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBasicThread
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;
        public FrmBasicThread()
        {
            InitializeComponent();
            
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            displayThread.Items.Clear();

            MyThreadClass threadA = new MyThreadClass(displayThread, "ThreadA");
            MyThreadClass threadB = new MyThreadClass(displayThread, "ThreadB");

            ThreadA = new Thread(new ThreadStart(threadA.Thread1));
            ThreadB = new Thread(new ThreadStart(threadB.Thread1));

            ThreadA.Start();
            ThreadB.Start();

         
            Thread monitorThread = new Thread(() =>
            {
                ThreadA.Join();
                ThreadB.Join();

                lblThread.Invoke(new MethodInvoker(() =>
                {
                    lblThread.Text = "-End of Thread-";
                }));
            });

            monitorThread.Start();
        }
    }
}
