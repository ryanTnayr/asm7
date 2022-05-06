
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.txtDrinkNum = new System.Windows.Forms.TextBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnCheckCart = new System.Windows.Forms.Button();
            this.lboxDrinkList = new System.Windows.Forms.ListBox();
            this.cboxSweet = new System.Windows.Forms.ComboBox();
            this.cboxIce = new System.Windows.Forms.ComboBox();
            this.cboxAdd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(179, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲店訂購單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "訂購人(電話)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(36, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "冷飲品項";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(392, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "甜度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(392, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "冰塊";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(393, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "配料";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(36, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "數量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(179, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "單價";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(311, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "品項總價";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(179, 434);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 19);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "XXX元";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTotalPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(311, 434);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(67, 19);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "XXX元";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(92, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "杯";
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(40, 118);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(100, 22);
            this.txtTele.TabIndex = 12;
            this.txtTele.TextChanged += new System.EventHandler(this.txtTele_TextChanged);
            // 
            // txtDrinkNum
            // 
            this.txtDrinkNum.Location = new System.Drawing.Point(40, 431);
            this.txtDrinkNum.Name = "txtDrinkNum";
            this.txtDrinkNum.Size = new System.Drawing.Size(46, 22);
            this.txtDrinkNum.TabIndex = 13;
            this.txtDrinkNum.TextChanged += new System.EventHandler(this.txtDrinkNum_TextChanged);
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.Orange;
            this.btnAddCart.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddCart.Location = new System.Drawing.Point(375, 475);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(120, 35);
            this.btnAddCart.TabIndex = 14;
            this.btnAddCart.Text = "加入購物車";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnCheckCart
            // 
            this.btnCheckCart.BackColor = System.Drawing.Color.Wheat;
            this.btnCheckCart.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckCart.Location = new System.Drawing.Point(235, 475);
            this.btnCheckCart.Name = "btnCheckCart";
            this.btnCheckCart.Size = new System.Drawing.Size(120, 35);
            this.btnCheckCart.TabIndex = 15;
            this.btnCheckCart.Text = "查看訂購單";
            this.btnCheckCart.UseVisualStyleBackColor = false;
            this.btnCheckCart.Click += new System.EventHandler(this.btnCheckCart_Click);
            // 
            // lboxDrinkList
            // 
            this.lboxDrinkList.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxDrinkList.FormattingEnabled = true;
            this.lboxDrinkList.ItemHeight = 16;
            this.lboxDrinkList.Location = new System.Drawing.Point(40, 179);
            this.lboxDrinkList.Name = "lboxDrinkList";
            this.lboxDrinkList.Size = new System.Drawing.Size(299, 180);
            this.lboxDrinkList.TabIndex = 16;
            this.lboxDrinkList.SelectedIndexChanged += new System.EventHandler(this.lboxDrinkList_SelectedIndexChanged);
            // 
            // cboxSweet
            // 
            this.cboxSweet.FormattingEnabled = true;
            this.cboxSweet.Location = new System.Drawing.Point(395, 186);
            this.cboxSweet.Name = "cboxSweet";
            this.cboxSweet.Size = new System.Drawing.Size(100, 20);
            this.cboxSweet.TabIndex = 17;
            this.cboxSweet.SelectedIndexChanged += new System.EventHandler(this.cboxSweet_SelectedIndexChanged);
            // 
            // cboxIce
            // 
            this.cboxIce.FormattingEnabled = true;
            this.cboxIce.Location = new System.Drawing.Point(396, 250);
            this.cboxIce.Name = "cboxIce";
            this.cboxIce.Size = new System.Drawing.Size(99, 20);
            this.cboxIce.TabIndex = 18;
            this.cboxIce.SelectedIndexChanged += new System.EventHandler(this.cboxIce_SelectedIndexChanged);
            // 
            // cboxAdd
            // 
            this.cboxAdd.FormattingEnabled = true;
            this.cboxAdd.Location = new System.Drawing.Point(396, 317);
            this.cboxAdd.Name = "cboxAdd";
            this.cboxAdd.Size = new System.Drawing.Size(99, 20);
            this.cboxAdd.TabIndex = 19;
            this.cboxAdd.SelectedIndexChanged += new System.EventHandler(this.cboxAdd_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 533);
            this.Controls.Add(this.cboxAdd);
            this.Controls.Add(this.cboxIce);
            this.Controls.Add(this.cboxSweet);
            this.Controls.Add(this.lboxDrinkList);
            this.Controls.Add(this.btnCheckCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.txtDrinkNum);
            this.Controls.Add(this.txtTele);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.TextBox txtDrinkNum;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnCheckCart;
        private System.Windows.Forms.ListBox lboxDrinkList;
        private System.Windows.Forms.ComboBox cboxSweet;
        private System.Windows.Forms.ComboBox cboxIce;
        private System.Windows.Forms.ComboBox cboxAdd;
    }
}

