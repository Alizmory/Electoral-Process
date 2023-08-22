using System;

namespace LCuellar_Assign3Task1_Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presented by Liz Cuellar\n");

            int[] voters; //array declaration
            int quantity;
            int cA=0, cB=0, cC=0, cN=0;
            string entry;

            Console.Write("Please enter the number of voters in your region: ");
            quantity = int.Parse(Console.ReadLine());

            voters = new int[quantity]; // instantiation de array

            for ( int i = 0; i < voters.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Voter " + (i+1));
                Console.WriteLine("Enter a voting option ");
                Console.WriteLine("Abril  --> 1");
                Console.WriteLine("Bill   --> 2");
                Console.WriteLine("Claire --> 3");
                Console.Write("Option: ");
                entry = Console.ReadLine();

                if (entry == "1")
                {
                    cA++;
                    Console.WriteLine("Your vote has been recorded");
                }
                else if (entry == "2")
                {
                    cB++;
                    Console.WriteLine("Your vote has been recorded");
                }
                else if (entry == "3")
                {
                    cC++;
                    Console.WriteLine("Your vote has been recorded");
                }
                else
                {
                    cN++;
                    Console.WriteLine("Your option is not valid therefore your vote is invalid!");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Console.WriteLine("            Election results\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The total votes for the April candidate are : " + cA) ;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("The total votes for the Bill candidate are : " + cB);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("The total votes for the Claire candidate are : " + cC);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("The total number of invalid votes is: " + cN);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
