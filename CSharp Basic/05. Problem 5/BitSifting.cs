using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitSifting
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        ulong copyofInput = input;

        int sieves = int.Parse(Console.ReadLine());
        int counter = 0;

        ulong[] sievesArray = new ulong[sieves];

        ulong mask1 = 1;
        ulong mask2 = 1;
        ulong intermediateResult = input;


        for (int i = 0; i < sievesArray.Length; i++)
        {
            sievesArray[i] = ulong.Parse(Console.ReadLine());
        }

        for (int i = 0; i < sieves; i++)
        {
            copyofInput = intermediateResult;
            intermediateResult = 0;

            for (int j = 0; j < 64; j++)
            {
                mask1 = copyofInput & (ulong)(1);
                if (mask1 != 0)
                {
                    mask2 = sievesArray[i] & (ulong)(1);
                    if (mask2 != 0)
                    {
                        copyofInput = copyofInput & ~(ulong)(1);
                    }
                    else
                    {
                        intermediateResult += (ulong)Math.Pow(2, j);
                    }
                }
                copyofInput >>= 1;
                sievesArray[i] >>= 1;
            }
        }

            while (intermediateResult > 0)
            {

                mask1 = intermediateResult & (ulong)(1);
                if (mask1 != 0)
                {
                    counter++;
                }
                intermediateResult >>= 1;
            }

        Console.WriteLine(counter);
    }
}
