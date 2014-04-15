using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheExplorer
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());

        int outerdash = (width - 1) / 2;
        int innerdash = 1;
        string outerDashes = new string('-', outerdash);
        string innerDashes = new string('-', innerdash);
        string star = "*";

        for (int i = 0; i < (width - 1) /2; i++)
        {
            outerDashes = new string('-', outerdash);
            innerDashes = new string('-', innerdash);

            if (i == 0)
            {
                Console.WriteLine(outerDashes + star + outerDashes);
                outerdash--;
            }
            else
            {
                Console.WriteLine(outerDashes + star + innerDashes + star + outerDashes);
                outerdash--;
                innerdash += 2;
            }
        }

        outerDashes = new string('-', outerdash);
        innerDashes = new string('-', innerdash);
        Console.WriteLine(star + innerDashes + star);
        outerdash = 1;
        innerdash -= 2;

        for (int i = 0; i < (width - 1) /2; i++)
        {
            outerDashes = new string('-', outerdash);
            innerDashes = new string('-', Math.Abs(innerdash));

            if (i < ((width - 1) /2) - 1)
            {
                Console.WriteLine(outerDashes + star + innerDashes + star + outerDashes);
                outerdash++;
                innerdash -= 2;
            }
            else
            {
                Console.WriteLine(outerDashes + star + outerDashes);
            }
        }
    }
}
