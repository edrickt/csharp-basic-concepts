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
        public int GetUserInterface(int counter)
        {
            this.PrintMenu(counter);
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }

        public string GetUserSearch()
        {
            this.SearchByID();
            string input = Console.ReadLine();
            return input;
        }

        public void PrintList(string outputList)
        {
            Console.WriteLine(Environment.NewLine + "ID \t Name  \t Pack \t Price \t Active");
            Console.WriteLine(outputList);
        }
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
                Console.WriteLine("3. Add new beverage");
                Console.WriteLine("9. Exit" + Environment.NewLine);
            }
        }

        public void SearchByID()
        {
            Console.WriteLine("Please enter beverage ID");
        }

        public void PrintErrorMessage()
        {
            Console.WriteLine("Please enter a number and press ENTER");
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
