using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            string Continue = "y";
            do 
            {
            long userNum, b;
            Console.WriteLine("Please enter a number between 1 and 10.");
            userNum = long.Parse(Console.ReadLine());
            b = userNum;
            for (long a = (userNum - 1); a >= 1; a--)
              {
                b = b * a;
              }
            Console.WriteLine($"The factorial: {userNum}! = {b}\n");
            Console.WriteLine("Would you like to continue? y/n");
            Continue = Console.ReadLine();
             
             } while (Continue == "y");
            
             
            {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();

            }


          
            
           }
        

        
    }
}
