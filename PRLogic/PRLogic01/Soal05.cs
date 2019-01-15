using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRLogic01
{
    class Soal05
    {
        public Soal05()
        {
            Console.Write("Input n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k < n; k++)
                {

                    if (b == 0 || b == n - 1)
                    {
                        Console.Write("*");
                    }

                    else if (k == 0)
                        Console.Write("*");
                    else if (b == k || b + k == n - 1 || k == n - 1)
                    {
                        Console.Write("*");
                        //Console.Write("\t{0}|{1}", b, k);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
