using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            function toTitleCase(str) {
                let convertToLower = str.replace(/\w +/ g, lower)
       let result = convertToLower.replace(/\b\w / g, upper);
                console.log(result);
                function lower(str) {
                    return str.toLowerCase();
                }
                function upper(str) {
                    return str.toUpperCase();
                }
            }
        }
    }
}
