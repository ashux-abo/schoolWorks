using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBasicThread
{
    internal class MyThreadClass
    {
        private ListBox _listBox;
        private string _threadLabel;

        public MyThreadClass(ListBox listBox, string threadLabel)
        {
            _listBox = listBox;
            _threadLabel = threadLabel;
        }

        public void Thread1()
        {
            for (int i = 0; i <= 5; i++)
            {
                string message = $"Name of Thread: {_threadLabel} = {i}";
                UpdateListBox(message);
                Thread.Sleep(1500);
            }
        }

        private void UpdateListBox(string message)
        {
            if (_listBox.InvokeRequired)
            {
                _listBox.Invoke(new MethodInvoker(() => _listBox.Items.Add(message)));
            }
            else
            {
                _listBox.Items.Add(message);
            }
        }
    }
}
