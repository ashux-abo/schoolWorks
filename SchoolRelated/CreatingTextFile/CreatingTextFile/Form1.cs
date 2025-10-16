using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
            FrmRegistration frmReg = new FrmRegistration();
            frmReg.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmFileName frm = new frmFileName();
            frm.ShowDialog();
            string getInput = txtInput.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, frmFileName.SetFileName))) 
            { 
                outputFile.WriteLine(getInput); 
                Console.WriteLine(getInput); 
            }
        }
    }
}
