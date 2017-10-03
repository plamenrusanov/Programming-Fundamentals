using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            MatchCollection MachedNames = Regex.Matches(input, pattern);
            foreach (Match m in MachedNames)
            {
                Console.Write("{0} ", m.Value);
            }
            Console.WriteLine();



            string HexadesimalNumbers = @"\b(?:0x)?[0-9A-F]+\b";
            string FirstLastName = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string FixBegining = @"(^|(?<=\s))"; // ^ начало на стринга | или (?<=\s) празно поле в началото
            string FixEnd = @"($|(?=\s))"; // $ край на стринга или (?=\s) празно поле в края
            string numbers = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
           // \n nov red
           //  \d число //    \D vsichko bez chislo
          // .* хваща всичко
           
        }
    }

}


