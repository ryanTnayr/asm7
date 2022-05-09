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
            lboxOrderList.Items.Clear();
            GlobalVar.listOrderInformation.Clear();
            calTotal();
        }



        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTax.Checked)
            {
                isTax = true;

                //計算稅金
            }
            else
            {
                isTax = false;
                //不計算稅金
            }
        }

        private void radioDiscount1_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountNum = 101;
        }

        private void radioDiscount2_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountNum = 102;
        }

        private void radioDiscount3_CheckedChanged(object sender, EventArgs e)
        {
            intDiscountNum = 103;
        }
        void calTotal()
        {
            //作業：計算訂單總價
            for (int i = 0; i < GlobalVar.listOrderInformation.Count; i ++)
            {
                intTotalPriceSum += GlobalVar.listOrderInformation[i].TotalPrice;
            }
            lblTotalPriceSum.Text = intTotalPriceSum.ToString() + "元";
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
