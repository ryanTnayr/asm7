
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblFreeCup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(360, 26);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "確認";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblFreeCup
            // 
            this.lblFreeCup.Location = new System.Drawing.Point(211, 26);
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
            this.Controls.Add(this.btnEnter);
            this.Name = "FormDiscountCup";
            this.Text = "FormDiscountCup";
            this.Load += new System.EventHandler(this.FormDiscountCup_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblFreeCup;
    }
}