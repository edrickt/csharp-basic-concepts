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
            Beverage listBeverage = new Beverage();

            listBeverage.BeverageID = 12345;
            listBeverage.BeverageName = "Blake's Hard Cider Triple Jam";
            listBeverage.BeveragePack = "6/12oz";
            listBeverage.BeveragePrice = 10.00m;
            listBeverage.BeverageActive = "True";

            Beverage[] beverages = new Beverage[4100];

            string pathToCsv = "../../../datafiles/beverage_list.csv";

            CSVProcessor csvProcessor = new CSVProcessor();

            csvProcessor.ImportCsv(pathToCsv, beverages);

            UserInterface ui = new UserInterface();

            int choice = ui.GetUserInterface();

            while (choice != 2)
            {
                if (choice == 1)
                {
                    Console.WriteLine(Environment.NewLine + listBeverage.ToString() + Environment.NewLine);

                    choice++;
                }

                choice = ui.GetUserInterface();
            }
        }
    }
}
