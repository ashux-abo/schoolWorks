namespace BasicQueueingCashier
{
    partial class QueuingForm
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
            btnCashier = new Button();
            label1 = new Label();
            label2 = new Label();
            lblQueue = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(12, 39);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(142, 123);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(21, 165);
            label1.Name = "label1";
            label1.Size = new Size(122, 13);
            label1.TabIndex = 1;
            label1.Text = "*Click to get a number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 53);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 2;
            label2.Text = "Position In Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(173, 87);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(0, 65);
            lblQueue.TabIndex = 3;
            lblQueue.Click += lblQueue_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 212);
            Controls.Add(lblQueue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label label2;
        private Label lblQueue;
    }
}