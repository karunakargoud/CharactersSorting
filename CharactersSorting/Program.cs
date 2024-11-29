using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            char[] charstr = str.ToCharArray();
            char temp;
            for (int i = 0; i < charstr.Length - 1; i++)
            {

                for (int j = 0; j < charstr.Length - i - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }

            }
            foreach (char k in charstr)
            {
                Console.Write(k);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
