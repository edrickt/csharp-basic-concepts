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

        public int GetUserInterface()
        {
            this.PrintMenu();

            string input = Console.ReadLine();

            return Int32.Parse(input);
        }

        public void PrintList(string outputList)
        {
            Console.WriteLine(Environment.NewLine + "ID \t Name  \t Pack \t Price \t Active");
            Console.WriteLine(outputList);
        }

        private void PrintMenu()
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

        public void PrintErrorMessage()
        {
        }
    }
}
