namespace Dulay_03LaboratoryExercise1
{
    partial class frmRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegister = new Button();
            datePickerBirthday = new DateTimePicker();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            txtMI = new TextBox();
            txtContactNo = new TextBox();
            txtFirstName = new TextBox();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            txtStudentNo = new TextBox();
            lbl9 = new Label();
            lbl4 = new Label();
            lbl8 = new Label();
            lbl3 = new Label();
            lbl7 = new Label();
            lbl6 = new Label();
            lbl2 = new Label();
            lbl5 = new Label();
            lbl1 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(268, 218);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 39;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(125, 175);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(200, 23);
            datePickerBirthday.TabIndex = 38;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(357, 75);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(204, 23);
            cbProgram.TabIndex = 37;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(357, 141);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(204, 23);
            cbGender.TabIndex = 36;
            // 
            // txtMI
            // 
            txtMI.BorderStyle = BorderStyle.FixedSingle;
            txtMI.Location = new Point(517, 109);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(44, 23);
            txtMI.TabIndex = 35;
            // 
            // txtContactNo
            // 
            txtContactNo.BorderStyle = BorderStyle.FixedSingle;
            txtContactNo.Location = new Point(411, 175);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(150, 23);
            txtContactNo.TabIndex = 34;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(357, 109);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(121, 23);
            txtFirstName.TabIndex = 33;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(125, 141);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(136, 23);
            txtAge.TabIndex = 32;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(125, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(136, 23);
            txtLastName.TabIndex = 31;
            // 
            // txtStudentNo
            // 
            txtStudentNo.BorderStyle = BorderStyle.FixedSingle;
            txtStudentNo.Location = new Point(125, 76);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(136, 23);
            txtStudentNo.TabIndex = 30;
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Location = new Point(334, 181);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(71, 15);
            lbl9.TabIndex = 29;
            lbl9.Text = "Contact No.";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(49, 179);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(51, 15);
            lbl4.TabIndex = 28;
            lbl4.Text = "Birthday";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Location = new Point(287, 149);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(48, 15);
            lbl8.TabIndex = 27;
            lbl8.Text = "Gender:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(49, 149);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(28, 15);
            lbl3.TabIndex = 26;
            lbl3.Text = "Age";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new Point(484, 117);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(27, 15);
            lbl7.TabIndex = 25;
            lbl7.Text = "M.I.";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(287, 117);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(64, 15);
            lbl6.TabIndex = 24;
            lbl6.Text = "First Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(49, 117);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(63, 15);
            lbl2.TabIndex = 23;
            lbl2.Text = "Last Name";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(287, 83);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(53, 15);
            lbl5.TabIndex = 22;
            lbl5.Text = "Program";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(49, 84);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(70, 15);
            lbl1.TabIndex = 21;
            lbl1.Text = "Student No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 20;
            label1.Text = "Registration";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 296);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbProgram);
            Controls.Add(cbGender);
            Controls.Add(txtMI);
            Controls.Add(txtContactNo);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(lbl9);
            Controls.Add(lbl4);
            Controls.Add(lbl8);
            Controls.Add(lbl3);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(lbl2);
            Controls.Add(lbl5);
            Controls.Add(lbl1);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "OrganizationProfile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private DateTimePicker datePickerBirthday;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private TextBox txtMI;
        private TextBox txtContactNo;
        private TextBox txtFirstName;
        private TextBox txtAge;
        private TextBox txtLastName;
        private TextBox txtStudentNo;
        private Label lbl9;
        private Label lbl4;
        private Label lbl8;
        private Label lbl3;
        private Label lbl7;
        private Label lbl6;
        private Label lbl2;
        private Label lbl5;
        private Label lbl1;
        private Label label1;
    }
}