using System;

namespace TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task:
            //    Display a table of powers.

            //What will the application do?  
            //● The application prompts the user to enter an integer.  
            //● The application displays a table of squares and cubes from 1 to the value entered.   
            //● The application prompts the   user to   continue.     

            //Build Speciﬁcations  
            //1.Assume that the user will enter valid data.  
            //2.The application should continue only if the user agrees to.

            //Hints:   ● Don’t mess up the diﬀerence between squares and cubes!
            Console.WriteLine("Welcome to the Table of Powers!");
            Console.WriteLine("================================\n");
            string more = "y";
            do
            {
                Console.WriteLine("Enter a number");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Number      Squared      Cubed");
                Console.WriteLine("======      =======      =====");
                for (int i = 1; i <= input; i++)
                {
                    Console.WriteLine($"{i,-12}{(i * i),-13}{(i * i * i)}");
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? (y/n)");
                more = YesOrNoValidation(Console.ReadLine());
            } while (more == "y");

            Console.WriteLine("Thank you for using the Table of Powers!");
        }

        public static string YesOrNoValidation(string input)
        {
            string go = "y";

            do
            {
                if (input == "y" || input == "n")
                {
                    go = "n";
                }
                else
                {
                    Console.WriteLine("Please enter valid input (y/n)");
                    input = Console.ReadLine();
                }
            } while (go == "y");

            return input;
        }
    }
}
