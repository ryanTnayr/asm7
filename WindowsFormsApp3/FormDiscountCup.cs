
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormDiscountCup : Form
    {
        //類別參數宣告
        List<NumericUpDown> listnumUD = new List<NumericUpDown>();
        int intFreeCup = 0;

        public FormDiscountCup()
        {
            InitializeComponent();
        }

        private void FormDiscountCup_Load(object sender, EventArgs e)
        {
            intFreeCup = GlobalVar.calDiscountCup(2);
            lblFreeCup.Text = "您總共有"+intFreeCup + "杯免費可選";

            string strAddTemp = "";
            //顯示lbl
            for (int i = 0; i < GlobalVar.listMinPriceInfomation.Count;i++)
            {
                Label lbl = new Label();
                //轉換Add成字串
                strAddTemp = "";
                for (int j = 0; j < GlobalVar.listMinPriceInfomation[i].Add.Length; j++)
                {
                    if (GlobalVar.listMinPriceInfomation[i].Add[j] != null)
                    {
                        strAddTemp += GlobalVar.listMinPriceInfomation[i].Add[j] + " ,";
                    }
                }
                //顯示飲料資料
                //名稱 + 冰 + 甜 + 配料 + 單價
                lbl.Text = string.Format("名：{0}, 冰：{1}, 甜：{2} , 配：{3} 單：{4}", 
                    GlobalVar.listMinPriceInfomation[i].Name, 
                    GlobalVar.listMinPriceInfomation[i].Ice, 
                    GlobalVar.listMinPriceInfomation[i].Sweet,
                    strAddTemp, 
                    GlobalVar.listMinPriceInfomation[i].Price);
                //宣告飲料位置資訊
                lbl.Size = new Size(300,30);
                lbl.Location = new Point(30, 60 + i * 60);
                Controls.Add(lbl);
            }
            //顯示numeric
            for (int i = 0; i < GlobalVar.listMinPriceInfomation.Count; i++)
            {
                NumericUpDown numUD = new NumericUpDown();
                numUD.Name = "numUD"+i;
                numUD.Location = new Point(380, 60 + 60 * i);
                numUD.Size = new Size(50, 30);
                numUD.ValueChanged += NumUD_ValueChanged;
                Controls.Add(numUD);
                listnumUD.Add(numUD);
            }
            //贈送杯數自動填入
            listnumUD[0].Value = intFreeCup;

        }

        private void NumUD_ValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();   這行系統幫我加的 不知道甚麼意思

            //取得自己的控制權
            NumericUpDown num = (NumericUpDown)sender;
            //NumericUpDown num = sender as NumericUpDown; 也行
            decimal sumCup = 0;
            for (int i = 0; i < listnumUD.Count; i++)
            {
                sumCup += listnumUD[i].Value;
            }
            if (sumCup > intFreeCup)
            {
                MessageBox.Show("您總共有" + intFreeCup + "杯免費可選");
                num.Value -= 1;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //foreach (Drink i in GlobalVar.listMinPriceInfomation)
            //{
            //    _mylist.Add(i);
            //}
            //GlobalVar.test();
            for (int i = 0; i < GlobalVar.listMinPriceInfomation.Count; i++)
            {
                GlobalVar.listMinPriceInfomation[i].Name += "(送)";
                GlobalVar.listMinPriceInfomation[i].Cup = (int)listnumUD[i].Value;
                GlobalVar.listMinPriceInfomation[i].TotalPrice = 0;
            }

            

            FormCart formCart = new FormCart();
            formCart.Show();
            this.Hide();
        }
        
    }
}
