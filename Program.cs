using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that prompts the user for an hourly pay rate. If the value entered is less than $7.50
               or greater than $49.00, display an error message, otherwise display a message indicating that the rate 
                is okay
             * 
             */

            
            string r = "y";

            while (r == "y")
            {
                Console.WriteLine("Please enter your hourly pay rate: ");
                double pay = Convert.ToDouble(Console.ReadLine());

                if ((pay < 7.50) || (pay > 49.00))
                {
                    Console.WriteLine("Sorry ocurred an error");
                }
                else
                {
                    Console.WriteLine("Thank you! We will process this information and get back to you soon!");
                    r = "n";
                }

                Console.Write("Do you wanna try again? \nPlease press 'y' to yes or press anything to no: ");
                r = Console.ReadLine();

            }
           
        }
    }
}
