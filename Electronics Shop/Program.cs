using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Shop
{
    class Program
    {
        /*
           * Complete the getMoneySpent function below.
           * 10 2 3
            3 1
            5 2 8
        ***************************
        *5 1 1
        4
        5
           */
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            /*
             * Write your code here.
             */
            int maxValue = 0;
            List<int> possiblePurchaes = new List<int>();
            foreach (var keyboard in keyboards)
            {
                foreach (var driver in drives)
                {
                    if (keyboard == b || driver == b) { possiblePurchaes.Add(0); break; }
                    possiblePurchaes.Add ((keyboard + driver) <= b ? (keyboard + driver) : 0);
                }
            }
          maxValue  = possiblePurchaes.Max();
            return maxValue == 0 ? -1 : maxValue;

        }


        static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);


        }
    }
}
