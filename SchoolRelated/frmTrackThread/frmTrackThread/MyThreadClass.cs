using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace frmTrackThread
{
    internal class MyThreadClass
    {


        public MyThreadClass()
        {
        }

        public static void Thread1(ListBox listBox)
        {
            for(int i = 0; i <= 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                string message = "Name of Thread: " + thread.Name + " Process = " + i;
                if (listBox.InvokeRequired)
                {
                    listBox.Invoke(new MethodInvoker(() => listBox.Items.Add(message)));
                }
                else
                {
                    listBox.Items.Add(message);
                }
                Console.WriteLine(message);
                Thread.Sleep(500);
            }
        }
         public static void Thread2(ListBox listBox)
        {
            for (int i = 0; i < 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                string message = "Name of Thread: " + thread.Name + " Process = " + i;
                if (listBox.InvokeRequired)
                {
                    listBox.Invoke(new MethodInvoker(() => listBox.Items.Add(message)));
                }
                else
                {
                    listBox.Items.Add(message);
                }
                Console.WriteLine(message);
                Thread.Sleep(1500);
            }  
        }
    }
}
