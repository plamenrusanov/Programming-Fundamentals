using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class WordInPlural
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();


            if (word.EndsWith("y"))
            {
                word = word.TrimEnd('y');
                Console.WriteLine("{0}"+"ies",word);
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                Console.WriteLine("{0}"+"es",word);
            }
            else
            {
                Console.WriteLine("{0}"+"s",word);
            }
        }
    }
}
