using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            int LastNumber = 9;

            //Goes through the number 1 - 9
            for (int i = 1; i <= LastNumber; i++)
            {
                //Forms the pattern 1, 22, 333
                for (int x = 1; x <= i; x++)
                {
                    //Write() instead of WriteLine() because
                    //WriteLine prints each number under each other 
                    Console.Write(i); 
                }
                //Prints all the number patterns from 1 - 9
                Console.WriteLine();
            }
           
        Console.ReadLine();
        }
    }
}
