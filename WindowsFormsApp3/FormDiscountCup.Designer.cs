﻿
namespace WindowsFormsApp3
{
    partial class FormDiscountCup
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblFreeCup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblFreeCup
            // 
            this.lblFreeCup.Location = new System.Drawing.Point(222, 203);
            this.lblFreeCup.Name = "lblFreeCup";
            this.lblFreeCup.Size = new System.Drawing.Size(100, 23);
            this.lblFreeCup.TabIndex = 2;
            this.lblFreeCup.Text = "--------";
            this.lblFreeCup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDiscountCup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 411);
            this.Controls.Add(this.lblFreeCup);
            this.Controls.Add(this.button1);
            this.Name = "FormDiscountCup";
            this.Text = "FormDiscountCup";
            this.Load += new System.EventHandler(this.FormDiscountCup_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFreeCup;
    }
}