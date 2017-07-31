using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Program
    {
        static List<Dog> Dogs = new List<Dog>();
        static List<Cat> Cats = new List<Cat>();
        static List<Snake> Snakes = new List<Snake>();
        static void Main(string[] args)
        {                               
            string input = Console.ReadLine();
            while (input != "I'm your Huckleberry")
            {
                string[] inputToken = input.Split();
                string animal = inputToken[0];
                if (animal == "talk")
                {
                    if (IsEqualsDog(inputToken[1]))
                    {
                        Dog.ProduceSound();
                    }
                    else if (IsEqualsCat(inputToken[1]))
                    {
                        Cat.ProduceSound();
                    }
                    else if (IsEqualsSnake(inputToken[1]))
                    {
                        Snake.ProduceSound();
                    }
                }          
                else if (animal == "Dog")
                {
                    Dogs.Add(new Dog(inputToken[1], int.Parse(inputToken[2]), int.Parse(inputToken[3])));
                }
                else if (animal == "Cat")
                {
                    Cats.Add(new Cat(inputToken[1], int.Parse(inputToken[2]), int.Parse(inputToken[3])));
                }
                else if (animal == "Snake")
                {
                    Snakes.Add(new Snake(inputToken[1], int.Parse(inputToken[2]), int.Parse(inputToken[3])));
                }
                input = Console.ReadLine();
            }
            foreach (var item in Dogs)
            {
                Console.WriteLine($"Dog: {item.Name}, Age: {item.Age}, Number Of Legs: {item.NumbersOfLegs}");
            }
            foreach (var item in Cats)
            {
                Console.WriteLine($"Cat: {item.Name}, Age: {item.Age}, IQ: {item.IntelligenceQuotient}");
            }
            foreach (var item in Snakes)
            {
                Console.WriteLine($"Snake: {item.Name}, Age: {item.Age}, Cruelty: {item.CrueltyCoefficient}");
            }
        }
        private static bool IsEqualsSnake(string v)
        {
            foreach (var item in Snakes)
            {
                if (item.Name == v)
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsEqualsCat(string v)
        {
            foreach (var item in Cats)
            {
                if (item.Name == v)
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsEqualsDog(string v)
        {
            foreach (var item in Dogs)
            {
                if (item.Name == v)
                {
                    return true;
                }               
            }
            return false;
        }
    }
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumbersOfLegs { get; set; }
        public Dog(string name, int age, int third)
        {
            Name = name;
            this.Age = age;
            this.NumbersOfLegs = third; 
        }
         static public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }

        internal static bool ReferenceEquals(bool v)
        {
            throw new NotImplementedException();
        }
    }
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }
        public Cat(string name, int age, int third)
        {
            Name = name;
            this.Age = age;
            this.IntelligenceQuotient = third;
        }
        static public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }
        public Snake(string name, int age, int third)
        {
            Name = name;
            this.Age = age;
            this.CrueltyCoefficient = third;
        }
        static public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
      
    }
}
