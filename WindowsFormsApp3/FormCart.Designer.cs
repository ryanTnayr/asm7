
namespace WindowsFormsApp3
{
    partial class FormCart
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lboxOrderList = new System.Windows.Forms.ListBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkTax = new System.Windows.Forms.CheckBox();
            this.radioDiscount1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotalPriceSum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(131, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲訂購品項列表";
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPeople.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPeople.Location = new System.Drawing.Point(280, 68);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(88, 16);
            this.lblPeople.TabIndex = 1;
            this.lblPeople.Text = "訂購人資料";
            // 
            // lboxOrderList
            // 
            this.lboxOrderList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lboxOrderList.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxOrderList.FormattingEnabled = true;
            this.lboxOrderList.ItemHeight = 15;
            this.lboxOrderList.Location = new System.Drawing.Point(12, 99);
            this.lboxOrderList.Name = "lboxOrderList";
            this.lboxOrderList.Size = new System.Drawing.Size(356, 259);
            this.lboxOrderList.TabIndex = 2;
            this.lboxOrderList.SelectedIndexChanged += new System.EventHandler(this.lboxOrderList_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl.Location = new System.Drawing.Point(240, 482);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(88, 16);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "訂單總價：";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(12, 378);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 38);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "移除選擇品項";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(12, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清除所有品項";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkTax
            // 
            this.chkTax.AutoSize = true;
            this.chkTax.Location = new System.Drawing.Point(150, 380);
            this.chkTax.Name = "chkTax";
            this.chkTax.Size = new System.Drawing.Size(87, 16);
            this.chkTax.TabIndex = 6;
            this.chkTax.Text = "加入5%稅金";
            this.chkTax.UseVisualStyleBackColor = true;
            this.chkTax.CheckedChanged += new System.EventHandler(this.chkTax_CheckedChanged);
            // 
            // radioDiscount1
            // 
            this.radioDiscount1.AutoSize = true;
            this.radioDiscount1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount1.Location = new System.Drawing.Point(8, 21);
            this.radioDiscount1.Name = "radioDiscount1";
            this.radioDiscount1.Size = new System.Drawing.Size(77, 17);
            this.radioDiscount1.TabIndex = 7;
            this.radioDiscount1.TabStop = true;
            this.radioDiscount1.Text = "買二送一";
            this.radioDiscount1.UseVisualStyleBackColor = true;
            this.radioDiscount1.CheckedChanged += new System.EventHandler(this.radioDiscount1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Salmon;
            this.groupBox1.Controls.Add(this.radioDiscount1);
            this.groupBox1.Location = new System.Drawing.Point(243, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "折扣活動";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "←回到選單";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(12, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "儲存訂單TXT";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotalPriceSum
            // 
            this.lblTotalPriceSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalPriceSum.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPriceSum.Location = new System.Drawing.Point(321, 482);
            this.lblTotalPriceSum.Name = "lblTotalPriceSum";
            this.lblTotalPriceSum.Size = new System.Drawing.Size(60, 16);
            this.lblTotalPriceSum.TabIndex = 13;
            this.lblTotalPriceSum.Text = "-元";
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(393, 523);
            this.Controls.Add(this.lblTotalPriceSum);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTax);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lboxOrderList);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.label1);
            this.Name = "FormCart";
            this.Text = "結帳單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCart_FormClosing);
            this.Load += new System.EventHandler(this.FormCart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.ListBox lboxOrderList;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkTax;
        private System.Windows.Forms.RadioButton radioDiscount1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalPriceSum;
    }
}