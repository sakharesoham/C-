using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] names = new string[] { "Alex", "Stan", "Morgan", "Eddie" };
             foreach(string name in names)
             {
                 Console.WriteLine(name);
             }
             Console.ReadLine();
            */

            string zig = "I am a good boy" + " and smart too";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach(char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
