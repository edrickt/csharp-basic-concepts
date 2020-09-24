// Edrick Tamayo
// Thursday 3:30PM
// 24 September 2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.IO;
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
            //Beverage[] beverages;

            while (loop == true)
            {
                if (choiceCounter == 0)
                {
                    // Outside reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch
                    switch (choice)
                    {
                        case "1":

                            Console.Clear();
                            Beverage[] beverages = BeverageCollection.LoadArray("../../../datafiles/beverage_list.csv");
                            choiceCounter++;
                            choice = ui.GetUserInterface(choiceCounter);
                            loop = false;
                            int size = BeverageCollection.getTrueLength(beverages);
                            while (choiceCounter != 0)
                            {
                                switch (choice)
                                {
                                    case "1":
                                        Console.Clear();
                                        string outputString = "";
                                        foreach (Beverage beverage in beverages)
                                        {
                                            if (beverage != null)
                                            {
                                                //trueSize++;
                                                outputString += beverage.ToString() + Environment.NewLine;
                                            }
                                        }
                                        ui.PrintHeader();
                                        ui.PrintList(outputString);
                                        choice = ui.GetUserInterface(choiceCounter);
                                        break;

                                    case "2":
                                        bool loopBool = true;
                                        int indexId =  0;
                                        Console.Clear();
                                        while (loopBool == true)
                                        {
                                            string searchId = UserInterface.SearchByID();
                                            
                                            indexId = BeverageCollection.SearchBeverageIDArray(beverages, searchId);

                                            if (indexId >= 0)
                                            {
                                                Console.Clear();
                                                ui.PrintHeader();
                                                ui.DisplayString(beverages, indexId);                                           
                                                loopBool = false;
                                            }
                                            else if (indexId == -2)
                                            {
                                                Console.Clear();                                           
                                                loopBool = false;
                                            }
                                            else if (indexId == -1)
                                            {
                                                Console.Clear();
                                                ui.PrintErrorMessage();
                                                loopBool = true;
                                            }
                                        }
                                        choice = ui.GetUserInterface(choiceCounter);
                                        break;

                                    case "3":
                                        Console.Clear();
                                        ui.AddBeveragePrompt();
                                        string line = Console.ReadLine();
                                        string[] parts = line.Split(',');

                                        // Outside reference: https://webcourses.ucf.edu/courses/1249560/pages/pass-by-reference-vs-value-pass-by-object
                                        BeverageCollection.AddBeverage(beverages, parts[0], parts[1], parts[2], Convert.ToDecimal(parts[3]), parts[4], ref size);
                                        choice = ui.GetUserInterface(choiceCounter);
                                        break;

                                    case "9":
                                        Environment.Exit(0);
                                        break;

                                    default:
                                        Console.Clear();
                                        ui.PrintErrorMessage();
                                        choice = ui.GetUserInterface(choiceCounter);
                                        break;
                                }
                            }
                            break;

                        // Outside reference: https://stackoverflow.com/questions/36237718/c-sharp-close-console-application-when-prompted
                        case "9":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.Clear();
                            ui.PrintErrorMessage();
                            choice = ui.GetUserInterface(choiceCounter);
                            break;
                    }
                }
            }
        }
    }
}

