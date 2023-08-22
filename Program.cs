using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//9/20/2020
namespace dropbox05
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for a number
            Console.WriteLine("Enter a whole number between 1 and 50 (0 or negative number to terminate):");
            //store number in a variable
            int number = int.Parse(Console.ReadLine());
            //start a loop until user enters value outside specifications
            while(number >= 1 && number <= 50)
            {
                for(int count = 0; count < number; count++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                Console.WriteLine("Enter a whole number between 1 and 50 (0 or negative number to terminate):");
                number = int.Parse(Console.ReadLine());
            }
            if (number > 50)
                Console.WriteLine("Number bigger than 50(press a key to terminate)");
            else
                Console.WriteLine("Number is smaller than 1(press a key to terminate)");
                Console.ReadKey();
        }
    }
}
