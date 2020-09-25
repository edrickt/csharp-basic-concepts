using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class UserInterface
    {
        public int counter = 0;
        /// <summary>
        /// GetUserInterface prints the menu, as well as reads
        /// the input from the user and returns that input
        /// </summary>
        /// <param name="counter">Used to determine which menu they are in,
        /// either the initial menu to load the program or options afterwards</param>
        /// <returns></returns>
        public string GetUserInput(int counter)
        {
            this.PrintMenu(counter);
            string input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Prints headers for list and search
        /// </summary>
        public void PrintHeader()
        {
            Console.WriteLine("ID".PadRight(6) + "Name".PadRight(56) + "Pack".PadRight(18) + "Price".PadRight(7) + "Active");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Prints the list of beverages
        /// </summary>
        /// <param name="outputList">String of beverages received from program.cs</param>
        public void PrintList(string outputList)
        {
            Console.WriteLine(outputList);
        }

        /// <summary>
        /// Prints the menu. Uses counter. Initially 0, will show initial menu until it adds
        /// and never shows initial menu again.
        /// </summary>
        /// <param name="counter">Counter for which menu to display</param>
        private void PrintMenu(int counter)
        {
            Console.WriteLine(Environment.NewLine + "Type number then press ENTER to enter" + Environment.NewLine);
            if (counter == 0)
            {
                Console.WriteLine("OPTIONS:");
                Console.WriteLine("1. Load CSV file");
                Console.WriteLine("9. Exit" + Environment.NewLine);

                counter++;
            }
            else
            {
                Console.WriteLine("OPTIONS:");
                Console.WriteLine("1. Print list");
                Console.WriteLine("2. Search beverage by ID");
                Console.WriteLine("3. Add beverage");
                Console.WriteLine("9. Exit" + Environment.NewLine);
            }
        }

        /// <summary>
        /// Prints instruction and receives input from user of what string
        /// to search and returns the string.
        /// </summary>
        /// <returns></returns>
        public static string SearchByID()
        {
            Console.WriteLine("Please enter beverage ID then press or type EXIT to exit" + Environment.NewLine);
            string searchIdString = Console.ReadLine();
            return searchIdString;
        }

        /// <summary>
        /// Displays the list of beverage
        /// </summary>
        /// <param name="beverages">The array of beverages</param>
        /// <param name="index">Element that needs to be printed out</param>
        public void DisplayString(Beverage[] beverages, int index)
        {
                Console.WriteLine(beverages[index].ToString() + Environment.NewLine);
        }

        public void PrintErrorMessage()
        {
            Console.WriteLine("Please enter valid input then press ENTER" + Environment.NewLine);
        }
        public void AddBeveragePrompt()
        {
            Console.WriteLine("Enter beverage id, beverage name, beverage pack, beverage price, beverage active" + Environment.NewLine + "For active, either type True or False" + Environment.NewLine
                               + "Example: 1ABC5,Gatorade,6/12oz,17.80,True" + Environment.NewLine);
        }
        // Parameterless constructor used to instantiate the class
        public UserInterface()
        {
        }
    }
}
