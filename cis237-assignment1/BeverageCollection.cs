using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class BeverageCollection
    {
        /// <summary>
        /// Loads the array using CSVProcessor class
        /// </summary>
        /// <param name="pathToCsv">Path to the csv file</param>
        /// <returns></returns>
        public static Beverage[] LoadArray(string pathToCsv)
        {
            Beverage[] _beveragesArray = new Beverage[4000];

            CSVProcessor csvProcessor = new CSVProcessor();

            csvProcessor.ImportCsv(pathToCsv, _beveragesArray);

            return _beveragesArray;
        }
        /// <summary>
        /// Searches for a beverage by the ID
        /// </summary>
        /// <param name="beverages">Array of beverage to be searched</param>
        /// <param name="beverageId">The beverage that is to be searched</param>
        /// <returns></returns>
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
        /// <summary>
        /// Adds new beverage to the array
        /// </summary>
        /// <param name="beverages"></param>
        /// <param name="beverageId"></param>
        /// <param name="beverageName"></param>
        /// <param name="beveragePack"></param>
        /// <param name="beveragePrice"></param>
        /// <param name="beverageActive"></param>
        /// <param name="size">Where to put the new beverage in the array</param>
        public static void AddBeverage(Beverage[] beverages, string beverageId, string beverageName,
                                       string beveragePack, decimal beveragePrice, string beverageActive, ref int size)
        {
            Beverage newBeverage = new Beverage(beverageId, beverageName, beveragePack, beveragePrice, beverageActive);
            beverages[++size] = newBeverage;
        }
        /// <summary>
        /// Getting the real length of the array where there are elements and not return null
        /// </summary>
        /// <param name="beverages">Array of beverages</param>
        /// <returns></returns>
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
