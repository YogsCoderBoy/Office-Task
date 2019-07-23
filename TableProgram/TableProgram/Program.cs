using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableProgram
{
    class Program
    {
        

        static void Main(string[] args)
        {
                int userInput;
               string userCanContinue;
            do
            {

                Console.Write("Enter Your Table Number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
               

                for (int i = 1; i <= 10; i++)
                {

                    Console.WriteLine(userInput + "* " + i + " = " + userInput * i);

                }
                Console.Write("Do You Want To Continue(Y / N)");
                userCanContinue = Console.ReadLine();
                Console.ReadKey();

            } while (userCanContinue != "Y" && userCanContinue != "n");
               
            
        }
    }
}
