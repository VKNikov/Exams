using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WorkHours
{
    static void Main()
    {
        double requiredhours = double.Parse(Console.ReadLine());
        double days = double.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine());
        int result= (int)(days * 0.90 * 12 * (productivity/100));

        if (result - requiredhours < 0)
        {
            Console.WriteLine("No");
            Console.WriteLine(result - requiredhours);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(result - requiredhours);
        }
    }
}

