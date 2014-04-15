using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());

        Dictionary<string, int> results1 = new Dictionary<string,int>();
        Dictionary<string, int> results2 = new Dictionary<string, int>();

        bool match = false;
        string[] letters = {"k", "n", "p", "s"};
        int[] value = {1, 4, 5, 3};


        for (int i = 0; i < letters.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                for (int k = 0; k < letters.Length; k++)
                {
                    for (int r = 0; r < letters.Length; r++)
                    {
                        results1.Add((letters[i] + letters[j] + letters[k] + letters[r]), value[i] + value[j] + value[k] + value[r]);
                        results2.Add((letters[i] + letters[j] + letters[k] + letters[r]), value[i] + value[j] + value[k] + value[r]);
                    }
                }
            }
            
        }

        foreach (var letter in results1)
        {
            foreach (var val in results2)
            {
                if (Math.Abs(letter.Value - val.Value) == diff)
                {
                    Console.WriteLine("{0}{1}", letter.Key, val.Key);
                    match = true;
                }
            }
        }

        if (!match)
        {
            Console.WriteLine("No");
        }
        
    }
}
