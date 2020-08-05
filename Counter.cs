using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest
{
    class Counter
    {

        public void Count()
        {
            string s = "THIS ThaT 12546 !@#$%^&";
            int number = 0;
            int capitalLetter = 0;
            int smallletter = 0;
            int space = 0;
            int SpecialSymbol = 0;
            char[] a = s.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 48 && a[i] <= 58)
                {
                    number += 1;
                }
                else if (a[i] >= 65 && a[i] <= 90)
                {
                    capitalLetter += 1;
                }
                else if (a[i] >= 97 && a[i] <= 122)
                {
                    smallletter += 1;
                }
                else if (a[i] == 32)
                {
                    space += 1;
                }
                else
                {
                    SpecialSymbol += 1;
                }
            }
            Console.Write("Capital Letter              " + capitalLetter);
            Console.Write("\nsmall letter              " + smallletter);
            Console.Write("\nnumber are                " + number);
            Console.Write("\nTotal Spaces              " + space);
            Console.Write("\nTotal Special Symbol are  " + SpecialSymbol);
        }
    }
}
