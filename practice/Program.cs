using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
       public static void Main(string[] args)
        {
            string str = "";
            string reverse= "";
            int Length;

            Console.WriteLine("Enter a name");
            str = Console.ReadLine();

            Length = str.Length-1;

            while(Length >=0)
            {
                reverse = reverse + str[Length];
                Length--;
            }

            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();

           
            



        }
    }
}
