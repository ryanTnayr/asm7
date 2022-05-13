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
    class GlobalVar
    {

        public static string orderPeople = "";
        public static List<Drink> listOrderInformation = new List<Drink>();
        public static List<Drink> listMinPriceInfomation = new List<Drink>();

        //作業規格：品項資訊要由ArrayList 改成自訂類別Class OK
        public static Form1 formMenu;
        public static FormCart formCartVar;
        public static FormDiscountCup FormDiscountCupVar;

        public static int intDiscountCup = 0;
        public static int calDiscountCup(int getOneFreeCup)
        {
            int intTotalCup = 0;
            for (int i = 0; i < listOrderInformation.Count; i++)
            {
                intTotalCup += listOrderInformation[i].Cup;
            }
            return intDiscountCup = intTotalCup / getOneFreeCup;
        }

        public static  List<Drink> CopyFrom(List<Drink> target)
        {
            List<Drink> _mylist = new List<Drink>();
            foreach (Drink item in target)
            {
                _mylist.Add(item);
            }
            return _mylist;
        }

        public static void printList(List<Drink> mylist, List<string> listInfo)
        {
            foreach (Drink arrOrderInfo in mylist)
            {
                string strName = arrOrderInfo.Name;
                int intPrice = arrOrderInfo.Price;
                int intCup = arrOrderInfo.Cup;
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
                listInfo.Add(strOneInfo);
            }
        }
        public static void printList(List<Drink> mylist, ListBox.ObjectCollection listInfo)
        {
            foreach (Drink arrOrderInfo in mylist)
            {
                if (arrOrderInfo.Cup>0)
                {
                    string strName = arrOrderInfo.Name;
                    int intPrice = arrOrderInfo.Price;
                    int intCup = arrOrderInfo.Cup;
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
                    listInfo.Add(strOneInfo);
                }
            }
        }
    }
}
