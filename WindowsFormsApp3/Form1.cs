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
        int intCup = 0;
        int intPrice = 0;
        int intTotalPrice = 0;
        string strName = "";
        string strSweet = "";
        string strIce = "";
        string[] strAdd = new string[3];
        int[] intAddPrice = new int[3];
        string strTel = "";

        string[] strNameTemp = new string[] { "紅茶", "綠茶", "奶茶" };
        int[] intPriceTemp = new int[] { 30, 30, 40 };
        string[] strSweetTemp = new string[] { "全糖", "半糖", "少糖", "微糖", "無糖" };
        string[] strIceTemp = new string[] { "正常冰", "少冰", "微冰", "去冰" };
        string[] strAddTemp = new string[] { "波霸", "珍珠", "椰果", "燕麥", "布丁", };
        int[] intAddPriceTemp = new int[] { 10, 10, 10, 15, 20 };

        Button btn = new Button();
        Button btn1 = new Button();
        ComboBox cboxAdd2 = new ComboBox();
        ComboBox cboxAdd3 = new ComboBox();
        public Form1()
        {
            InitializeComponent();
            btnAddCart.Cursor = Cursors.Hand;
            btnCheckCart.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //載入清單內容  
            listName.AddRange(strNameTemp);
            lboxDrinkList.Items.AddRange(strNameTemp);
           
            listPrice.AddRange(intPriceTemp);           
          
            listSweet.AddRange(strSweetTemp);
            cboxSweet.Items.AddRange(strSweetTemp);

            listIce.AddRange(strIceTemp);
            cboxIce.Items.AddRange(strIceTemp);
            
            listAdd.AddRange(strAddTemp);
            cboxAdd.Items.AddRange(strAddTemp);

            listAddPrice.AddRange(intAddPriceTemp);

            intCup = 1;     //預設至少一杯
            txtDrinkNum.Text = intCup.ToString();

        }

        private void lboxDrinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //把配料選單隱藏，int[] intAddPrice 清空歸零 
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
            int selIndex = cboxIce.SelectedIndex;
            strIce = listIce[selIndex];
        }

        //▼▼▼▼▼以下龐大程式碼需簡化▼▼▼▼▼▼

        private void cboxAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cboxAdd.SelectedIndex;
            strAdd[0] = listAdd[selIndex];
            intAddPrice[0] = listAddPrice[selIndex];

            intPrice = listPrice[lboxDrinkList.SelectedIndex];
            for (int i = 0; i < intAddPrice.Length; i++)
            {
                 intPrice += intAddPrice[i];
            }
            intTotalPrice = intPrice * intCup;

            lblTotalPrice.Text = intTotalPrice.ToString() + "元";

            btn.Location = new Point(385, 345);
            btn.Size = new Size(35, 25);
            btn.Text = "+";
            btn.BackColor = Color.Cyan;
            btn.Click += Btn_Click;
            Controls.Add(btn);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            btn.Hide();
            
            cboxAdd2.Location = new Point(385,345);
            cboxAdd2.Size = new Size(99,20);
            cboxAdd2.Items.AddRange(strAddTemp);
            cboxAdd2.SelectedIndexChanged += cboxAdd2_SelectedIndexChanged;
            Controls.Add(cboxAdd2);
        }

        private void cboxAdd2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cboxAdd2.SelectedIndex;
            strAdd[1] = listAdd[selIndex];
            intAddPrice[1] = listAddPrice[selIndex];

            intPrice = listPrice[lboxDrinkList.SelectedIndex];
            for (int i = 0; i < intAddPrice.Length; i++)
            {
                intPrice += intAddPrice[i];
            }
            intTotalPrice = intPrice * intCup;

            lblTotalPrice.Text = intTotalPrice.ToString() + "元";

            btn1.Location = new Point(385, 370);
            btn1.Size = new Size(35, 25);
            btn1.Text = "+";
            btn1.BackColor = Color.Cyan;
            btn1.Click += Btn1_Click;
            Controls.Add(btn1);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            btn1.Hide();
            
            cboxAdd3.Location = new Point(385, 370);
            cboxAdd3.Size = new Size(99, 20);
            cboxAdd3.Items.AddRange(strAddTemp);
            cboxAdd3.SelectedIndexChanged +=cboxAdd3_SelectedIndexChanged;
            Controls.Add(cboxAdd3);
        }

        private void cboxAdd3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cboxAdd3.SelectedIndex;
            strAdd[2] = listAdd[selIndex];
            intAddPrice[2] = listAddPrice[selIndex];

            intPrice = listPrice[lboxDrinkList.SelectedIndex];
            for (int i = 0; i < intAddPrice.Length; i++)
            {
                intPrice += intAddPrice[i];
            }
            intTotalPrice = intPrice * intCup;

            lblTotalPrice.Text = intTotalPrice.ToString() + "元";
        }

        //▲▲▲▲▲▲▲▲▲▲▲▲以上龐大程式碼需簡化▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

        private void txtTele_TextChanged(object sender, EventArgs e)
        {
            strTel = txtTele.Text;
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
            Drink drinkInformation = new Drink();
            drinkInformation.Name = strName;
            drinkInformation.Price = intPrice;
            drinkInformation.Cup = intCup;
            drinkInformation.Sweet = strSweet;
            drinkInformation.Ice = strIce;
            strAdd.CopyTo(drinkInformation.Add,0);  //用原本方法會有call by ref 的問題，因為資料型態是string[]
            intAddPrice.CopyTo(drinkInformation.AddPrice,0);
            drinkInformation.TotalPrice = intTotalPrice;
            GlobalVar.listOrderInformation.Add(drinkInformation);
            GlobalVar.orderPeople = txtTele.Text;

            MessageBox.Show("已加入購物車");
        }
    }
}
