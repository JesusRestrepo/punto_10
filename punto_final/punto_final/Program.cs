using System;

namespace punto_10
{
    class Program
    {
  
        static void Main(string[] args)
        {
            int suma = 0, num = 1;
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            while (num <= n)
            {
                suma = suma + num;
                num = num + 1;
            }

            Console.WriteLine("You entered "+suma);
        }
    }
}