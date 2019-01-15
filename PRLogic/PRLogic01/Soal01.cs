using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRLogic01
{
    class Soal01
    {
        // ctor tab2x
        public Soal01()
        {
            Console.Write("Input n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            //baris

            for (int b = 0; b < n; b++) //tab2x b to default
            {
                // System.Diagnostics.Debugger.Break();
                //kolom
                //Console.Write("\t"+b);
                for (int k = 0; k < n; k++)
                {
                    // pindah kolom                
                    if (b == 0)
                        Console.Write(k);
                    else if (b == k)
                    {
                        Console.Write("*");
                        //Console.Write("\t{0}|{1}", b, k);
                    }

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
