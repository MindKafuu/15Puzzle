﻿namespace Game7
{
    partial class P1_Score
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
            this.SuspendLayout();
            // 
            // P1_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Name = "P1_Score";
            this.Text = "P1_Score";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.P1_Score_FormClosed);
            this.Load += new System.EventHandler(this.P1_Score_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.P1_Score_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}