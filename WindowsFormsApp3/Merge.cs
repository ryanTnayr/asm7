using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Merge
    {
    }
    public static class ListExtensions
    {
        public static List<T> Merge<T>(this List<T> source, List<T> target)
        {
            List<T> mergedList = new List<T>(source);

            mergedList.AddRange(target.Except(source));

            return mergedList;
        }
    }
}
