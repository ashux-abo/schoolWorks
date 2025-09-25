namespace frmTrackThread
{
    partial class TrackThread
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
            this.Title = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.displayThreadListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(91, 80);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(232, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "-Thread Starts-";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // runBtn
            // 
            this.runBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBtn.Location = new System.Drawing.Point(151, 175);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(113, 48);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "RUN";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // displayThreadListBox
            // 
            this.displayThreadListBox.FormattingEnabled = true;
            this.displayThreadListBox.Location = new System.Drawing.Point(411, 17);
            this.displayThreadListBox.Name = "displayThreadListBox";
            this.displayThreadListBox.Size = new System.Drawing.Size(309, 251);
            this.displayThreadListBox.TabIndex = 2;
            // 
            // TrackThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 280);
            this.Controls.Add(this.displayThreadListBox);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.Title);
            this.Name = "TrackThread";
            this.Text = "frmTrackThread";
            this.Load += new System.EventHandler(this.TrackThread_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.ListBox displayThreadListBox;
    }
}

