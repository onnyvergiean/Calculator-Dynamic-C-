using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.Write("Pilih Menu Calculator");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Pembagian");
            Console.WriteLine("4. Perkalian");

            Console.WriteLine();

            Console.Write("Inputkan Nomer Menu 1 - 4 : ");

            int c = int.Parse(Console.ReadLine());

            if (c == 1)
            {
                Console.Write("Inputkan Nilai a = ");

                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
            }
            else if (c == 2)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (c == 3)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else if (c == 4)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }

            Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }
    }
}