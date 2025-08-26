﻿namespace BasicQueueingCashier
{
    partial class CashierWindowQueueForm
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
            components = new System.ComponentModel.Container();
            btnRefresh = new Button();
            btnNext = new Button();
            listCashierQueue = new ListView();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.System;
            btnRefresh.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(12, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(138, 51);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.FlatStyle = FlatStyle.System;
            btnNext.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(12, 69);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(138, 51);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.Alignment = ListViewAlignment.Left;
            listCashierQueue.AutoArrange = false;
            listCashierQueue.Location = new Point(156, 12);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(246, 369);
            listCashierQueue.TabIndex = 2;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 393);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnNext;
        private ListView listCashierQueue;
        private System.Windows.Forms.Timer timer1;
    }
}