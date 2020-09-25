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
            bool loop = true;
            string choice = ui.GetUserInput(choiceCounter);
            while (loop == true)
            {
                if (choiceCounter == 0)
                {
                    // Outside reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch
                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            // Loads the array, passes the path of the file into method LoadArray() within BeverageCollection class
                            // and sets the object array beverages to it.
                            Beverage[] beverages = BeverageCollection.LoadArray("../../../datafiles/beverage_list.csv");
                            // Will not enter the second menu if array is not loaded
                            choiceCounter++;
                            // Receives the input from user from GetUserInput() which is in int choice
                            choice = ui.GetUserInput(choiceCounter);
                            // Bool to see if input is needed again after wrong input
                            loop = false;
                            // Receives the size of the array without null elements
                            int size = BeverageCollection.getTrueLength(beverages);
                            while (choiceCounter != 0)
                            {
                                switch (choice)
                                {
                                    case "1":
                                        Console.Clear();
                                        string outputString = "";
                                        // For each beverage in array beverages then keep adding until it
                                        // it reaches end of list
                                        foreach (Beverage beverage in beverages)
                                        {
                                            if (beverage != null)
                                            {
                                                outputString += beverage.ToString() + Environment.NewLine;
                                            }
                                        }
                                        ui.PrintHeader();
                                        // Print the list which was made in the foreach loop
                                        ui.PrintList(outputString);
                                        // Prints the menu and receives input for the menu again
                                        choice = ui.GetUserInput(choiceCounter);
                                        break;
                                    case "2":
                                        // Bool needed to see if element sought is found
                                        bool loopBool = true;
                                        // Index to compare string input and string beverageId
                                        int indexId = 0;
                                        Console.Clear();
                                        // While the loopBool is true, stay, until false
                                        while (loopBool == true)
                                        {
                                            // Input from user for the ID needed to be found
                                            string searchId = UserInterface.SearchByID();
                                            // Receives the input from user and passes the array and searchId 
                                            // to search for beverage ID
                                            indexId = BeverageCollection.SearchBeverageIDArray(beverages, searchId);
                                            // If found then enter
                                            if (indexId >= 0)
                                            {
                                                Console.Clear();
                                                ui.PrintHeader();
                                                // Passes array and index needed to print the element in that array
                                                ui.DisplayString(beverages, indexId);
                                                // Stop the loop
                                                loopBool = false;
                                            }
                                            // If it retunrs -2, then user chose to exit
                                            else if (indexId == -2)
                                            {
                                                Console.Clear();
                                                loopBool = false;
                                            }
                                            // If it returns -1, could not find
                                            else if (indexId == -1)
                                            {
                                                Console.Clear();
                                                ui.PrintErrorMessage();
                                                // Keep looping asking user for input
                                                loopBool = true;
                                            }
                                        }
                                        // Prints menu again
                                        choice = ui.GetUserInput(choiceCounter);
                                        break;
                                    case "3":
                                        bool failBool = true;
                                        while (failBool == true)
                                        {
                                            Console.Clear();
                                            // Tells user to input beverage
                                            ui.AddBeveragePrompt();
                                            // Used to read line
                                            string line = Console.ReadLine();
                                            Console.WriteLine("");
                                            // Comma delimits input
                                            string[] parts = line.Split(',');
                                       
                                            if (parts[4] == "False" || parts[4] == "True")
                                            {
                                                // Outside reference: https://webcourses.ucf.edu/courses/1249560/pages/pass-by-reference-vs-value-pass-by-object
                                                // Passes comma delimited input into respective places into array
                                                BeverageCollection.AddBeverage(beverages, parts[0], parts[1], parts[2], Convert.ToDecimal(parts[3]), parts[4], ref size);
                                                failBool = false;
                                            }
                                            else
                                            {
                                                ui.PrintErrorMessage();
                                                failBool = true;
                                            }
                                        }
                                        choice = ui.GetUserInput(choiceCounter);
                                        break;
                                    case "9":
                                        Environment.Exit(0);
                                        break;
                                    // If case does not match then output error and run menu again
                                    default:
                                        Console.Clear();
                                        ui.PrintErrorMessage();
                                        choice = ui.GetUserInput(choiceCounter);
                                        break;
                                }
                            }
                            break;
                        // Outside reference: https://stackoverflow.com/questions/36237718/c-sharp-close-console-application-when-prompted
                        // Exit program
                        case "9":
                            Environment.Exit(0);
                            break;
                        // If did not select 1 or 9 then print error and receive input again
                        default:
                            Console.Clear();
                            ui.PrintErrorMessage();
                            choice = ui.GetUserInput(choiceCounter);
                            break;
                    }
                }
            }
        }
    }
}

