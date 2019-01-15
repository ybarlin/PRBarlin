using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRLogic01
{
    class Soal03
    {
        public Soal03()
        {
            //System.Diagnostics.Debugger.Break();
            Console.Write("Input n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            //baris

            for (int b = 0; b < n; b++) //tab2x b to default
            {
                //kolom
                //Console.Write("\t"+b);
                // System.Diagnostics.Debugger.Break();

                for (int k = 0; k < n; k++)
                {
                    // pindah kolom
                    if (b == k || b + k == n - 1)
                    {
                        Console.Write("*");
                        //Console.Write("\t{0}|{1}", b, k);
                    }
                    else if (b == 0)
                        Console.Write(k);

                    else if (k == 0)
                        Console.Write(b);
                    else
                    {
                        Console.Write(" ");
                    }

                }
                //pindah baris
                Console.WriteLine(" ");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}