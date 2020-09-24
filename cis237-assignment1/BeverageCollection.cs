using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class BeverageCollection
    {
        public static Beverage[] LoadArray(string pathToCsv)
        {
            Beverage[] _beveragesArray = new Beverage[4000];

            CSVProcessor csvProcessor = new CSVProcessor();

            csvProcessor.ImportCsv(pathToCsv, ref _beveragesArray);

            return _beveragesArray;
        }
        // Outside reference: Linear search program from first C# class
        public static int SearchBeverageIDArray(Beverage[] beverages, string beverageId)
        {
            int index = -1;

            for (int i = 0; i < beverages.Length; i++)
            {
                if (beverages[i] == null)
                {
                    return index;
                }
                else if (beverages[i].BeverageID == beverageId)
                {
                    return i;
                }
                // Outside referece: https://stackoverflow.com/questions/55750996/how-to-make-string-inputs-case-insensitive-in-c
                else if (beverageId.ToUpper() == "EXIT")
                {
                    index = -2;
                    return index;
                }
            }
            return index;
        }
        public static void AddBeverage(Beverage[] beverages, string beverageId, string beverageName,
                                       string beveragePack, decimal beveragePrice, string beverageActive, ref int size)
        {
            Beverage newBeverage = new Beverage(beverageId, beverageName, beveragePack, beveragePrice, beverageActive);

            beverages[++size] = newBeverage;
        }

        public static int getTrueLength(Beverage[] beverages)
        {
            int count = 0;
            while  (beverages[count]  != null)
            {
                count++;
            }
            return count;
        }
    }
}
