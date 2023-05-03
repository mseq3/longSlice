using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        int max = 0;
        char[] c = digits.ToCharArray();

        if (span == 0)
            return 1;

        if(span<0 || digits=="")
           throw new ArgumentException();

        for (int i = 0; i < digits.Length; i++)
        {
            if( Char.IsLetter(c[i]))
            {
                throw new ArgumentException();
            }
        }

        for (int i = 0; i <= digits.Length - span; i++)
        {
            int prodotto = 1;
            for (int x = i; x < i + span; x++)
            {
                int digit = digits[x] - '0';
                prodotto *= digit;
            }

            if( prodotto > max)
            {
                max = prodotto;
            }
        }
        return max;
    }


}