﻿using System;
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
    }
}
