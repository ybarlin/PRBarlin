using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRLogic01
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu:
            Console.Write("----------------------EXAM EXPLORE-------------------------\n \n");
            Console.Write("Soal ke : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (n <= 5)
            {
                switch (n)
                {
                    case 1:
                        Soal01 s01 = new Soal01();
                        break;
                    case 2:
                        Soal02 s02 = new Soal02();
                        break;
                    case 3:
                        Soal03 s03 = new Soal03();
                        break;
                    case 4:
                        Soal04 s04 = new Soal04();
                        break;
                    case 5:
                        Soal05 s05 = new Soal05();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tidak ada di pilihan, Press any key to Exit...");
                //goto menu:
                Console.ReadKey();
            }
        }
    }
}
