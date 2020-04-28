using System;

namespace PRG2_20192_P1_3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N;
            Console.WriteLine(" PROGRAM ANAK AYAM");
            Console.Write(" Masukkan batasan : ");
            N = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" ----------------------------------------");

            for (i = N; i > 0; i--)
            {
                if(i>1)
                {
                    Console.WriteLine(" Anak ayam turun {0}, mati satu tinggal {1}", i, i-1);
                }
                else if(i == 1)
                {
                    Console.WriteLine(" Anak ayam turun {0}, mati satu tinggal induknya", i);
                }
            }
        }
    }
}
