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
    public partial class FrmRegistration : Form
    {
        public static string SetFileName;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] availableProgram = { "BS Information Technology", "BS Computer Engineering", "BS Computer Science" };
            foreach (string program in availableProgram)
            {
                programComboBox.Items.Add(program);
            }

            string[] chooseGender = { "Male", "Female" };
            foreach (string gender in chooseGender)
            {
                genderComboBox.Items.Add(gender);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            int studentNo = Convert.ToInt32(studentNoText.Text);
            string fullName = firstNameText.Text + ", " + lastNameText.Text + ", " + middleInitial.Text;
            string program = programComboBox.SelectedItem.ToString();
            string gender = genderComboBox.SelectedItem.ToString();
            int age = Convert.ToInt32(ageText.Text);
            string birthday = birthdayTimePicker.Value.ToString("MM-dd-yyyy");
            long contactNo = long.Parse(contactNoText.Text);

            SetFileName = studentNo.ToString() + ".txt";

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, SetFileName)))
            {
                string[] displayInfo = {
                    "Student No." + fullName,
                    "Full Name: " + program,
                    "Gender: " + gender,
                    "Age: " + age.ToString(),
                    "Birthday: " + birthday,
                    "Contact No.: " + contactNo.ToString() 
                };
                foreach (string display in displayInfo)
                {
                    outputFile.WriteLine(display);
                }
            }
        }

    }
}
