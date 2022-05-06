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
        public static List<ArrayList> listOrderInformation = new List<ArrayList>();
        //作業規格：品項資訊要由ArrayList 改成自訂類別Class
        public static Form1 formMenu;
        public static FormCart formCart;
    }
}
