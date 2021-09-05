using System;

namespace BasicATM
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int money;
            do
            {
                Console.Write("Input Money = ");
                int.TryParse(Console.ReadLine(), out money);
            } while (money % 100 != 0); //verify money x or xx
            Console.WriteLine("Money = {0}", money);
            Console.WriteLine("Bank 1000 Baht= {0}", money / 1000);
            Console.WriteLine("Bank 500 Baht= {0}", money / 500);
            Console.WriteLine("Bank 100 Baht= {0}", money / 100);
            Console.ReadKey();
        }
    }
}
