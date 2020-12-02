using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        // Reverse a string 
       // public static void Main(string[] args)
       // {
            //string str = "";
            //string reverse= "";
            //int Length;

            //Console.WriteLine("Enter a name");
            //str = Console.ReadLine();

            //Length = str.Length-1;

            //while(Length >=0)
            //{
            //    reverse = reverse + str[Length];
            //    Length--;
            //}

            //Console.WriteLine("Reverse word is {0}", reverse);
            //Console.ReadLine();

      //  }

    public static void Main()

        {
            //reverse an array 

            int[] array = { 1, 3, 5, 15, 99 };
            foreach(int a in array)
            {
                Console.WriteLine(a);
                Console.ReadLine();
            }
            Array.Reverse(array);
            Console.WriteLine("reversed array:");
            Console.ReadLine();
            foreach(int value in array)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
    }

    }
}
