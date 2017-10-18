using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> nameInput = new Dictionary<string, List<string>>();
            Dictionary<string, int> nameResult = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
            string[] cards;
            int powerOfCard;
            while (input[0] != "JOKER")
            {

                cards = input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (!nameInput.ContainsKey(input[0]))
                {
                    nameInput.Add(input[0], new List<string>());
                    nameResult.Add(input[0], 0);
                }
                for (int i = 0; i < cards.Length; i++)
                {
                    if (nameInput[input[0]].Contains(cards[i]))
                    {
                        continue;
                    }
                    else
                    {
                        nameInput[input[0]].Add(cards[i]);
                        powerOfCard = PowerOfCard(cards[i]);
                        nameResult[input[0]] += powerOfCard;
                        
                    }
                    
                }

                input = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var player in nameResult)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }

        private static int PowerOfCard(string card)
        {
            char[] arr = card.ToCharArray();
            int multiply = 0;
            int result = 0;
            switch (arr[arr.Length - 1])
            {
                case 'S':multiply = 4;break;
                case 'H':multiply = 3;break;
                case 'D':multiply = 2;break;
                case 'C':multiply = 1;break; 
            }
            if (arr.Length == 3)
            {
                result = 10 * multiply;
            }
            else if (Char.IsDigit(arr[0]))
            {
                result = multiply * (arr[0] - 48);
            }
            else if (Char.IsLetter(arr[0]))
            {
                switch (arr[0])
                {
                    case 'J':result = 11 * multiply;break;
                    case 'Q':result = 12 * multiply;break;
                    case 'K':result = 13 * multiply;break;
                    case 'A':result = 14 * multiply;break;
                }
            }
            return result;          
        }
    }
}