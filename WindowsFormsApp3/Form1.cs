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
    public partial class Form1 : Form
    {
        //為了寫入清單而設的變數，傳遞訂單資訊時也需要
        List<string> listName = new List<string>();
        List<int> listPrice = new List<int>();
        List<string> listSweet = new List<string>();
        List<string> listIce = new List<string>();
        List<string> listAdd = new List<string>();
        List<int> listAddPrice = new List<int>();

        //為了方便傳遞訂單資訊，而不是用物件的屬性傳遞
        int intCup =0;
        int intPrice= 0;
        int intTotalPrice = 0;
        string strName = "";
        string strSweet = "";
        string strIce = "";
        string strAdd = "";
        int intAddPrice = 0;


        public Form1()
        {
            InitializeComponent();
            btnAddCart.Cursor = Cursors.Hand;
            btnCheckCart.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] strTemp = new string[]
            { "紅茶", "綠茶", "奶茶" }; 
            listName.AddRange(strTemp);
            lboxDrinkList.Items.AddRange(strTemp);

            int[] intTemp = new int[] { 30, 30, 40 };
            listPrice.AddRange(intTemp);           

            string[] strSweetTemp = new string[] { "正常", "半糖", "少糖", "微糖","無糖"};
            listSweet.AddRange(strSweetTemp);
            cboxSweet.Items.AddRange(strSweetTemp);

            intCup = 1;     //預設至少一杯
            txtDrinkNum.Text = intCup.ToString();

        }

        private void lboxDrinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lboxDrinkList.SelectedIndex;
            strName = listName[selIndex];
            intPrice = listPrice[selIndex];
            lblPrice.Text = intPrice.ToString() +"元";
            intTotalPrice = intPrice * intCup;
            lblTotalPrice.Text = intTotalPrice.ToString() + "元";

        }

        private void cboxSweet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cboxSweet.SelectedIndex;
            strSweet = listSweet[selIndex];
        }

        private void cboxIce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTele_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDrinkNum_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(txtDrinkNum.Text,out intCup);
            //intCup = Convert.ToInt32(txtDrinkNum.Text);  修改數字時，會先清除，這時會報錯，回報內容為空字串
            intTotalPrice = intPrice * intCup;
            lblTotalPrice.Text = intTotalPrice.ToString() + "元";
        }

        private void btnCheckCart_Click(object sender, EventArgs e)
        {
            GlobalVar.formMenu = this;
            FormCart formCart = new FormCart();
            GlobalVar.formCart = formCart;
            formCart.Show();
            this.Hide(); // Hide();也可以
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            ArrayList drinkInformation = new ArrayList();
            drinkInformation.Add(strName);
            drinkInformation.Add(intPrice);
            drinkInformation.Add(intCup);
            drinkInformation.Add(intTotalPrice);
            drinkInformation.Add(strSweet);
            drinkInformation.Add(strIce);
            drinkInformation.Add(strAdd);
            drinkInformation.Add(intAddPrice);
            GlobalVar.listOrderInformation.Add(drinkInformation);
            GlobalVar.orderPeople = txtTele.Text;

            MessageBox.Show("已加入購物車");
        }
    }
}
