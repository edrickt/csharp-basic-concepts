// Edrick Tamayo
// Thursday 3:30PM
// 24 September 2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            int choiceCounter = 0;
            string choice = ui.GetUserInterface(choiceCounter);
            bool loop = true;
            Beverage[] beverages;

            while (choice != "9")
            {
                while (loop == true)
                {
                    if (choice == "1" && choiceCounter == 0)
                    {
                        Console.Clear();
                        beverages = BeverageCollection.LoadArray("../../../datafiles/beverage_list.csv");
                        choiceCounter++;
                        choice = ui.GetUserInterface(choiceCounter);
                        loop = false;
                    }
                    else if (choice != "2" || choice != "9")
                    {
                        Console.Clear();
                        ui.PrintErrorMessage();
                        choice = ui.GetUserInterface(choiceCounter);
                    }
                }
                if (choice == "1")
                {
                    Console.Clear();
                    beverages = BeverageCollection.LoadArray("../../../datafiles/beverage_list.csv");
                    string outputString = "";
                    foreach (Beverage beverage in beverages)
                    {
                        if (beverage != null)
                        {
                            outputString += beverage.ToString() + Environment.NewLine;
                        }
                    }
                    ui.PrintList(outputString);
                    choice = ui.GetUserInterface(choiceCounter);
                }
                else if (choice == "2")
                {
                    Console.Clear();

                }
                else if (choice == "3")
                {
                }
                else if (choice == "4")
                {
                }
                else if (choice != "9")
                {
                    Console.Clear();
                    ui.PrintErrorMessage();
                    choice = ui.GetUserInterface(choiceCounter);
                }
            }
        }
    }
}
