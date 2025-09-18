namespace frmBasicThread
{
    partial class FrmBasicThread
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
            this.lblThread = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.displayThread = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread.Location = new System.Drawing.Point(67, 70);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(243, 25);
            this.lblThread.TabIndex = 0;
            this.lblThread.Text = "-Before Starting Thread-";
            // 
            // runBtn
            // 
            this.runBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBtn.Location = new System.Drawing.Point(104, 174);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(169, 68);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // displayThread
            // 
            this.displayThread.FormattingEnabled = true;
            this.displayThread.Location = new System.Drawing.Point(350, 12);
            this.displayThread.Name = "displayThread";
            this.displayThread.Size = new System.Drawing.Size(280, 303);
            this.displayThread.TabIndex = 2;
            // 
            // FrmBasicThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 332);
            this.Controls.Add(this.displayThread);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.lblThread);
            this.Name = "FrmBasicThread";
            this.Text = "BasicThread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.ListBox displayThread;
    }
}

