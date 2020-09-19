// Edrick Tamayo
// Thursday 3:30PM
// 24 September 2020

using System;
using System.Collections.Generic;
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
            //Beverage listBeverage = new Beverage();

            //listBeverage.BeverageID = "123123";
            //listBeverage.BeverageName = "Blake's Hard Cider Triple Jam";
            //listBeverage.BeveragePack = "6/12oz";
            //listBeverage.BeveragePrice = 10.00m;
            //listBeverage.BeverageActive = "True";

            Beverage[] beverages = new Beverage[4100];

            string pathToCsv = "../../../datafiles/beverage_list.csv";

            CSVProcessor csvProcessor = new CSVProcessor();

            UserInterface ui = new UserInterface();

            int choice = ui.GetUserInterface();

            int choiceCounter = 1;

            while (choice != 9)
            {
                if (choice == 1 && choiceCounter == 1)
                {
                    csvProcessor.ImportCsv(pathToCsv, beverages);

                    choiceCounter++;
                }
                else
                {
                    if (choice == 1)
                    {
                        string outputString = "";

                        foreach (Beverage beverage in beverages)
                        {
                            if (beverage != null)
                            {
                                outputString += beverage.ToString() + Environment.NewLine;
                            }
                        }

                        ui.PrintList(outputString);
                    }
                }
                choice = ui.GetUserInterface();
            }
        }
    }
}
