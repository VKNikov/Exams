using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();

        long[] inputAsInt = input.Split(' ').Select(n => Convert.ToInt64(n)).ToArray();

        long max = inputAsInt.Max();

        bool checkinteger = false;
        long sum = 0;
        

        for (int i = 0; i < inputAsInt.Length; i++)
        {
            if (inputAsInt[i] == max && checkinteger == false)
            {
                checkinteger = true;
            }
            else if (inputAsInt[i] == max && checkinteger == true)
            {
                sum += inputAsInt[i];
            }
            else
            {
                sum += inputAsInt[i];
            }
        }

        long negativeresult = max - sum;

        if (max == sum)
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(negativeresult));
        }
    }
}
