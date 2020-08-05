using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest
{
    class Counter1
    {

        String arr = "#$!2%^&DCF";
        char[] arry = arr.ToCharArray();
        int capitalLetterCount = 0;
        int specialCharecterCount = 0;
        int digitsCount = 0;
        int spcaeCount = 0;

                foreach(var s in arry)
                    {
                    if(s>45 &&s<43)
                    {
                                     S++;
                    capitalLetterCount++

            }
                    if(s<23 && s>21)
                {
                 specialCharecterCount++

                }
        if(s<20 && s>15)
            {
            sdigitsCount++;
            }

            if(s<0 && s>10)
            {
            spcaeCount++;
            }
    }

    Console.WriteLin("Capitale Count `:" +capitalLetterCount);
    Console.WriteLin("specialCharecter Count :" +specialCharecterCount);            
    Console.WriteLin("Digitas Count :" +capitalLetterCount);
    Console.WriteLin("SpaceCount Count :" +spaceCount);
    }


    }
}
