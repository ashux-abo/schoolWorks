using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace frmTrackThread
{
    public partial class TrackThread : Form
    {
        private Thread threadA, threadB, threadC, threadD;
        public TrackThread()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void TrackThread_Load(object sender, EventArgs e)
        {

        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            displayThreadListBox.Items.Clear();

            threadA = new Thread(() => MyThreadClass.Thread1(displayThreadListBox));
            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "Thread A";
            threadA.Start();

            threadB = new Thread(() => MyThreadClass.Thread2(displayThreadListBox));
            threadB.Name = "Thread B";
            threadB.Priority = ThreadPriority.Normal;
            threadB.Start();

            threadC = new Thread(() => MyThreadClass.Thread1(displayThreadListBox));
            threadC.Name = "Thread C";
            threadC.Start();
            threadC.Priority = ThreadPriority.AboveNormal;

            threadD = new Thread(() => MyThreadClass.Thread2(displayThreadListBox));
            threadD.Name = "Thread D";
            threadD.Priority = ThreadPriority.BelowNormal;
            threadD.Start();

            Thread monitorThread = new Thread(() =>
            {
                threadA.Join();
                threadB.Join();
                threadC.Join();
                threadD.Join();

                Title.Invoke(new MethodInvoker(() =>
                {
                    Title.Text = "-End of Thread-";
                }));
            });

            monitorThread.Start();


        }
    }
}
