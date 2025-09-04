namespace Dulay_03LaboratoryExercise1
{
    partial class frmConfirmation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblStudentNo = new Label();
            lblName = new Label();
            lblProgram = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblGender = new Label();
            lblContactNo = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 58);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 89);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Program:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 120);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 151);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Birthday:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 182);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 213);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 6;
            label7.Text = "Contact No.:";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(123, 27);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(38, 15);
            lblStudentNo.TabIndex = 7;
            lblStudentNo.Text = "label8";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(123, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 8;
            lblName.Text = "label9";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(123, 89);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(44, 15);
            lblProgram.TabIndex = 9;
            lblProgram.Text = "label10";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(123, 120);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 15);
            lblAge.TabIndex = 10;
            lblAge.Text = "label11";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(123, 151);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(44, 15);
            lblBirthday.TabIndex = 11;
            lblBirthday.Text = "label12";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(123, 182);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(44, 15);
            lblGender.TabIndex = 12;
            lblGender.Text = "label13";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(123, 213);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(44, 15);
            lblContactNo.TabIndex = 13;
            lblContactNo.Text = "label14";
            // 
            // btnSubmit
            // 
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Location = new Point(98, 264);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 323);
            Controls.Add(btnSubmit);
            Controls.Add(lblContactNo);
            Controls.Add(lblGender);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblProgram);
            Controls.Add(lblName);
            Controls.Add(lblStudentNo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConfirmation";
            Text = "frmConfirmation";
            Load += frmConfirmation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblStudentNo;
        private Label lblName;
        private Label lblProgram;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblGender;
        private Label lblContactNo;
        private Button btnSubmit;
    }
}