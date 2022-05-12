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
            foreach (Drink arrOrderInfo in GlobalVar.listOrderInformation)
            {
                string strName = arrOrderInfo.Name;
                int intPrice =arrOrderInfo.Price;
                int intCup =arrOrderInfo.Cup;
                int intTotalPrice = arrOrderInfo.TotalPrice;
                string strSweet = arrOrderInfo.Sweet;
                string strIce = arrOrderInfo.Ice;
                string strAdd = "";
                int intAddPrice = 0;
                for (int i = 0; i < arrOrderInfo.Add.Length; i++)
                {
                    if (arrOrderInfo.Add[i] != null)
                    {
                        strAdd += arrOrderInfo.Add[i] + " ,";
                        intAddPrice += arrOrderInfo.AddPrice[i];
                    }  
                }

                string strOneInfo = string.Format($"{strName},{intPrice},{intCup},{intTotalPrice},{strSweet},{strIce},{strAdd}{intAddPrice}");
                //可以用格式化輸出，變成類excel
                lboxOrderList.Items.Add(strOneInfo);
            }

        }
        void calTotal()
        {
            //作業：計算訂單總價
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
                int selIndex = lboxOrderList.SelectedIndex;
                lboxOrderList.Items.RemoveAt(selIndex);
                GlobalVar.listOrderInformation.RemoveAt(selIndex);
                calTotal();
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
            }
            else
            {

            }
            
        }



        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            double tax = 1.05;
            if (chkTax.Checked)
            {
                //計算稅金
                isTax = true;
                intTotalPriceSum = Convert.ToInt32(intTotalPriceSum * tax);
                lblTotalPriceSum.Text = intTotalPriceSum.ToString() + "元";     
            }
            else
            {
                //不計算稅金
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
            //取得最低價格Index，儲存進list
           
            for (int i = 0; i < GlobalVar.listOrderInformation.Count; i++)
            {
                if(priceList.Min() == GlobalVar.listOrderInformation[i].Price)
                {
                    if (GlobalVar.listMinPriceInfomation.Count==0)
                    {
                        GlobalVar.listMinPriceInfomation.Add(GlobalVar.listOrderInformation[i]);
                    }
                    for (int j = 0;j< GlobalVar.listMinPriceInfomation.Count; j++)
                    {
                        if (GlobalVar.listMinPriceInfomation[j].IsSame(GlobalVar.listOrderInformation[i]))
                        {
                            break;
                        }
                        if(j == GlobalVar.listMinPriceInfomation.Count - 1)
                        {
                            GlobalVar.listMinPriceInfomation.Add(GlobalVar.listOrderInformation[i]);
                        }
                        
                    }
                    
                }
            }
             
        }
        private void radioDiscount1_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountNum = 101;
            if(GlobalVar.calDiscountCup(2) == 0 && radioDiscount1.Checked == true)
            {
                radioDiscount1.Checked = false;
                MessageBox.Show("您的杯數未符合折扣條件");
            }
            else
            {
                FormDiscountCup formDiscountCup = new FormDiscountCup();
                GlobalVar.FormDiscountCupVar = formDiscountCup;
                calMinPrice();
                formDiscountCup.Show();
                
            }
            //TODO：排序價格，取得最低價格飲料之索引值(min > indexof)
            //傳遞資訊：最低價格飲料資訊、折扣杯數
            //for 顯示所有符合的飲料
            //lbl 顯示 名稱 + 冰 + 甜 + 配料 + 單價
            //預設折購杯數，讓使用者分配，儲存杯數，總價為零
            //回傳飲料資訊，列印在listbox
        }

        private void radioDiscount2_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountNum = 102;
        }

        private void radioDiscount3_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountNum = 103;
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
            foreach (Drink arrOrderInfo in GlobalVar.listOrderInformation)
            {
                string strName = arrOrderInfo.Name;
                int intPrice = arrOrderInfo.Price;
                int intCup = arrOrderInfo.Cup;
                int intTotalPrice = arrOrderInfo.TotalPrice;
                string strSweet = arrOrderInfo.Sweet;
                string strIce = arrOrderInfo.Ice;
                string[] strAdd = arrOrderInfo.Add;
                int[] intAddPrice = arrOrderInfo.AddPrice;

                string strOneInfo = string.Format($"{strName},{intPrice},{intCup},{intTotalPrice},{strSweet},{strIce},{strAdd},{intAddPrice}");
                //可以用格式化輸出，變成類excel
                listOrderInfo.Add(strOneInfo);
            }
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
