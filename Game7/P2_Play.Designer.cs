﻿namespace Game7
{
    partial class P2_Play
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
            // P2_Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 474);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "P2_Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P2_Play_Time";
            this.Load += new System.EventHandler(this.P2_Play_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.P2_Play_Time_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.P2_Play_Time_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}