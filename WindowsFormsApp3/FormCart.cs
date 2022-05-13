using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp3
{
    public partial class FormCart : Form
    {
        bool isTax = false;
        int intDiscountNum = 0;
        int intTotalPriceSum = 0;
        int intDiscountCup = 0;
        public FormCart()
        {
            InitializeComponent();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            calTotal();
            lblPeople.Text = GlobalVar.orderPeople;
            GlobalVar.printList(GlobalVar.listOrderInformation, lboxOrderList.Items);
            GlobalVar.printList(GlobalVar.listMinPriceInfomation, lboxOrderList.Items);
        }
        void calTotal()
        {//計算訂單總價
            intTotalPriceSum = 0;
            for (int i = 0; i < GlobalVar.listOrderInformation.Count; i++)
            {
                intTotalPriceSum += GlobalVar.listOrderInformation[i].TotalPrice;
            }
            lblTotalPriceSum.Text = intTotalPriceSum.ToString() + "元";
        }


        private void lboxOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lboxOrderList.SelectedIndex >= 0)
            {
                if(lboxOrderList.SelectedIndex < GlobalVar.listOrderInformation.Count)
                {
                    int selIndex = lboxOrderList.SelectedIndex;
                    lboxOrderList.Items.RemoveAt(selIndex);
                    GlobalVar.listOrderInformation.RemoveAt(selIndex);
                    calTotal();
                    radioDiscount1.Checked = false;
                }
                else
                {
                    lboxOrderList.Items.RemoveAt(lboxOrderList.SelectedIndex);
                    GlobalVar.listMinPriceInfomation.RemoveAt(lboxOrderList.SelectedIndex- GlobalVar.listOrderInformation.Count);
                    calTotal();
                    radioDiscount1.Checked = false;
                }

            }
            else
            {
                MessageBox.Show("請選擇要移除的項目");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確定要移除所有項目","移除購物車",MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {
                lboxOrderList.Items.Clear();
                GlobalVar.listOrderInformation.Clear();
                calTotal();
                radioDiscount1.Checked = false;
            }    
        }



        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            double tax = 1.05;
            if (chkTax.Checked)
            {//計算稅金
                isTax = true;
                intTotalPriceSum = Convert.ToInt32(intTotalPriceSum * tax);
                lblTotalPriceSum.Text = intTotalPriceSum.ToString() + "元";     
            }
            else
            {//不計算稅金
                isTax = false;
                calTotal();
            }
        }

        void calMinPrice()
        {
            List<int> priceList = new List<int>();
            List<int> minIndex = new List<int>();
            GlobalVar.listMinPriceInfomation.Clear();
            //儲存所有單價
            for(int i = 0; i < GlobalVar.listOrderInformation.Count; i++)
            {
                priceList.Add(GlobalVar.listOrderInformation[i].Price); 
            }
            //取得最低價格Index，儲存進list，且避免重複項目
           
            for (int i = 0; i < GlobalVar.listOrderInformation.Count; i++)
            {
                if(priceList.Min() == GlobalVar.listOrderInformation[i].Price)
                {
                    if (GlobalVar.listMinPriceInfomation.Count==0)
                    {
                        Drink mindrink = new Drink();
                        mindrink.Name = GlobalVar.listOrderInformation[i].Name;
                        mindrink.Price = GlobalVar.listOrderInformation[i].Price;
                        mindrink.Ice = GlobalVar.listOrderInformation[i].Ice;
                        mindrink.Sweet = GlobalVar.listOrderInformation[i].Sweet;
                        mindrink.Add = GlobalVar.listOrderInformation[i].Add.ToArray<string>();
                        //mindrink.Add.CopyTo(GlobalVar.listOrderInformation[i].Add,0);
                        GlobalVar.listMinPriceInfomation.Add(mindrink);
                    }
                    for (int j = 0;j< GlobalVar.listMinPriceInfomation.Count; j++)
                    {
                        if (GlobalVar.listMinPriceInfomation[j].IsSame(GlobalVar.listOrderInformation[i]))
                        {
                            break;
                        }
                        if(j == GlobalVar.listMinPriceInfomation.Count - 1)
                        {
                            Drink mindrink = new Drink();
                            mindrink.Name = GlobalVar.listOrderInformation[i].Name;
                            mindrink.Price = GlobalVar.listOrderInformation[i].Price;
                            mindrink.Ice = GlobalVar.listOrderInformation[i].Ice;
                            mindrink.Sweet = GlobalVar.listOrderInformation[i].Sweet;
                            mindrink.Add = GlobalVar.listOrderInformation[i].Add.ToArray<string>();
                            //mindrink.Add.CopyTo(GlobalVar.listOrderInformation[i].Add,0);
                            GlobalVar.listMinPriceInfomation.Add(mindrink);
                        }
                    }    
                }
            }
             
        }
        private void radioDiscount1_CheckedChanged(object sender, EventArgs e)
        {
            if (GlobalVar.calDiscountCup(2) > 0 && radioDiscount1.Checked == true)
            {
                FormDiscountCup formDiscountCup = new FormDiscountCup();
                GlobalVar.FormDiscountCupVar = formDiscountCup;
                calMinPrice();
                formDiscountCup.Show();
                this.Hide();
            }
            else if (GlobalVar.calDiscountCup(2) == 0 && radioDiscount1.Checked == true)
            {  
                MessageBox.Show("您的杯數未符合折扣條件");
                radioDiscount1.Checked = false;
            }

            //TODO：FormDicountCup要做的事
            //排序價格，取得最低價格飲料之索引值(min > indexof)
            //傳遞資訊：最低價格飲料資訊、折扣杯數
            //for 顯示所有符合的飲料
            //lbl 顯示 名稱 + 冰 + 甜 + 配料 + 單價
            //預設折購杯數，讓使用者分配，儲存杯數，總價為零
            //回傳飲料資訊，列印在listbox
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void FormCart_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.formMenu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePlace = @"C:\rt\C#";
            Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 10000);
            string strFileName = DateTime.Now.ToString("yy-MM-ddHHmmss") + myNum + "訂購單.txt";
            string strCompFilePlace = strFilePlace + @"\" + strFileName;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = strFilePlace;
            sfd.FileName = strFileName;
            sfd.Filter = "Text File | *.txt";

            DialogResult R = sfd.ShowDialog();

            if (R == DialogResult.OK)
            {
                strCompFilePlace = sfd.FileName;
            }
            else
            {
                return;
            }

            //訂單內容列印
            List<string> listOrderInfo = new List<string>();
            listOrderInfo.Add("**********冷飲店訂購單***********");
            listOrderInfo.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            listOrderInfo.Add("訂購時間：" + DateTime.Now.ToString() + "訂購人：" + GlobalVar.orderPeople);
            listOrderInfo.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            listOrderInfo.Add("************訂購品項*************");
            //foreach 可以寫成方法
            GlobalVar.printList(GlobalVar.listOrderInformation, listOrderInfo);

            listOrderInfo.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            listOrderInfo.Add("折扣：" + "稅金：");
            listOrderInfo.Add("總價：" + intTotalPriceSum);
            listOrderInfo.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            listOrderInfo.Add("************謝謝惠顧*************");

            System.IO.File.WriteAllLines(strCompFilePlace, listOrderInfo, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }
        
    }
}
