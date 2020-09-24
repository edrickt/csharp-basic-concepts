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
        public string GetUserInterface(int counter)
        {
            this.PrintMenu(counter);
            string input = Console.ReadLine();
            return input;
        }

        public void PrintHeader()
        {
            Console.WriteLine("ID".PadRight(6) + "Name".PadRight(56) + "Pack".PadRight(18) + "Price".PadRight(7) + "Active");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }

        public void PrintList(string outputList)
        {
            Console.WriteLine(outputList);
        }

        private void PrintMenu(int counter)
        {
            Console.WriteLine("Type number then press ENTER to enter" + Environment.NewLine);
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

        public static string SearchByID()
        {
            Console.WriteLine("Please enter beverage ID then press or type EXIT to exit" + Environment.NewLine);
            string searchIdString = Console.ReadLine();
            return searchIdString;
        }

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
            Console.WriteLine("Enter beverage id, beverage name, beverage pack, beverage price, beverage active" + Environment.NewLine
                               + "Example: 1ABC5,Gatorade,6/12oz,17.80,True");
        }

        public UserInterface()
        {

        }

        public UserInterface(int counter)
        {
            counter = 0;
            PrintMenu(counter);
        }

    }
}
