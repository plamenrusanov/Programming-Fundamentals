using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int num1 = 0;
                int numberCount = 0;
                bool number;
                do
                {
                    string num = Console.ReadLine();
                    number = int.TryParse(num, out num1);
                    numberCount++;

                }
                while (number);
                Console.WriteLine(numberCount - 1);


            
        }
    }
}
