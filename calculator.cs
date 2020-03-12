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
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
			
			Console.WriteLine();
			
            Console.Write("Inputkan Nomer Menu 1 - 4 : ");
            int c = int.Parse(Console.ReadLine());
			
            Console.Write("Inputkan Nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai b = ");
            int b = int.Parse(Console.ReadLine());
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