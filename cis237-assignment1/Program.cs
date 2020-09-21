// Edrick Tamayo
// Thursday 3:30PM
// 24 September 2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            BeverageCollection beverageCollection = new BeverageCollection();
            int choice = ui.GetUserInterface();
            int choiceCounter = 1;

            while (choice != 9)
            {
                if (choice == 1 && choiceCounter == 1)
                {
                    Console.Clear();
                    beverageCollection.LoadArray();
                    choiceCounter++;
                    choice = ui.GetUserInterface();
                }
                else
                {
                    if (choice == 1)
                    {
                        Console.Clear();
                        Array _returnArray = beverageCollection.LoadArray();
                        string outputString = "";
                        foreach (Beverage beverage in _returnArray)
                        {
                            if (beverage != null)
                            {
                                outputString += beverage.ToString() + Environment.NewLine;
                            }
                        }
                        ui.PrintList(outputString);
                        choice = ui.GetUserInterface();
                    }
                    else if (choice == 2)
                    {
                    }
                    else if (choice == 3)
                    {
                    }
                    else if (choice >= 4 && choice != 9)
                    {
                        Console.Clear();
                        ui.PrintErrorMessage();
                        choice = ui.GetUserInterface();
                    }
                }
            }
        }
    }
}
