using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest
{
    public static class Palindrom
    {
        public static bool CheckPalindrome(string word)
        {

            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                if (word[min] != word[max])
                {
                    return false;
                }
                min++;
                max--;
            }

        }
    }
}
