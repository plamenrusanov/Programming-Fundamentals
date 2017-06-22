using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Phone
    {
        static int sumNumber(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int n = (int)number[i];
                if (n >= 48 && n <= 57)
                {
                    n -= 48;
                    sum += n;
                }
            }
            return sum;
        }
        static bool OddEvenNumber(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int n = (int)number[i];
                if (n >= 48 && n <= 57)
                {
                    n -= 48;
                    sum += n;
                }
            }
            if (sum % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {

            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            string[] inputName = new string[2];

            do
            {
                inputName = Console.ReadLine().Split();
                if (inputName[0] == "call")
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (phoneNumbers[i] == inputName[1])
                        {
                            Console.WriteLine($"calling {names[i]}...");
                            if (OddEvenNumber(phoneNumbers[i]))
                            {
                                Console.WriteLine("call ended. duration: {0:d2}:{1:d2}"
                                    , sumNumber(phoneNumbers[i]) / 60, sumNumber(phoneNumbers[i]) % 60);
                            }
                            else
                            {
                                Console.WriteLine("no answer");
                            }
                        }
                    }
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == inputName[1])
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");
                            if (OddEvenNumber(phoneNumbers[i]))
                            {
                                Console.WriteLine("call ended. duration: {0:d2}:{1:d2}"
                                    , sumNumber(phoneNumbers[i]) / 60, sumNumber(phoneNumbers[i]) % 60);
                            }
                            else
                            {
                                Console.WriteLine("no answer");
                            }
                        }
                    }
                }
                else if (inputName[0] == "message")
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (phoneNumbers[i] == inputName[1])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");
                            if (OddEvenNumber(phoneNumbers[i]))
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                        }
                    }
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == inputName[1])
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                            if (OddEvenNumber(phoneNumbers[i]))
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                        }
                    }
                }
            } while (inputName[0] != "done");
        }
    }
}
