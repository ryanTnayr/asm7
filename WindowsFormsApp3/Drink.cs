using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Drink
    {
        public string Name = "";
        public int Price = 0;
        public int TotalPrice = 0;
        public int Cup = 0;
        public string Sweet = "";
        public string Ice = "";
        public string[] Add = new string[3];
        public int[] AddPrice = new int [3];
        
        
        
        public bool IsSame(Drink b)
        {
                if (this.Name == b.Name && 
                    this.Price == b.Price && 
                    this.Sweet == b.Sweet && 
                    this.Ice == b.Ice ) 
                {  return true; }
                else
                {
                    return false;
                }
            //&&this.Add.Union(b.Add).Contains("null")
        }
    }   


    
}
