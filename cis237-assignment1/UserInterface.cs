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

        public string GetUserSearch()
        {
            this.SearchByID();
            string input = Console.ReadLine();
            return input;
        }

        public void PrintList(string outputList)
        {
            Console.WriteLine(Environment.NewLine + "ID".PadRight(6) + "Name".PadRight(56) + "Pack".PadRight(18) + "Price".PadRight(7) + "Active");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
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
                Console.WriteLine("3. Search beverage by Name");
                Console.WriteLine("4. Add beverage");
                Console.WriteLine("9. Exit" + Environment.NewLine);
            }
        }

        public void SearchByID()
        {
            Console.WriteLine("Please enter beverage ID");
        }

        public void PrintErrorMessage()
        {
            Console.WriteLine("Please enter a number (1,2,3, NOT one, two, three) and press ENTER" + Environment.NewLine);
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
