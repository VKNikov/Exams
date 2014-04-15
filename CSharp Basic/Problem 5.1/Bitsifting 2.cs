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

        int sieves = int.Parse(Console.ReadLine());
        int counter = 0;

        ulong[] sievesArray = new ulong[sieves];

        ulong mask1 = 1;


        for (int i = 0; i < sievesArray.Length; i++)
        {
            sievesArray[i] = ulong.Parse(Console.ReadLine());
        }

        for (int i = 0; i < sieves; i++)
        {
                mask1 = input & sievesArray[i];
                if (mask1 != 0)
                {
                    input -= mask1;
                }
        }

        while (input > 0)
        {

            mask1 = input & (ulong)(1);
            if (mask1 != 0)
            {
                counter++;
            }
            input >>= 1;
        }

        Console.WriteLine(counter);
    }
}
