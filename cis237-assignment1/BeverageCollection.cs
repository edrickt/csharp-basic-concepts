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
            Beverage[] _beveragesArray = new Beverage[4100];

            CSVProcessor csvProcessor = new CSVProcessor();

            csvProcessor.ImportCsv(pathToCsv, _beveragesArray);

            return _beveragesArray;
        }
        // Outside reference: Linear search program from first C# class
        public static int SearchBeverageIDArray(Beverage[] beverages, string beverageId)
        {
            int index = -1;

            for (int i = 0; i < beverages.Length; i++)
            { 
                if (beverages[i].BeverageID == beverageId)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int SearchBeverageNameArray(Beverage[] beverages, string beverageName)
        {
            int index = -1;

            for (int i = 0; i < beverages.Length; i++)
            {
                if (beverages[i].BeverageName == beverageName)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
