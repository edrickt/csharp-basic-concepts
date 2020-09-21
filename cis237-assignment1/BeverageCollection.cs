using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class BeverageCollection
    {
        Beverage[] _beveragesArray = new Beverage[4100];

        public Array LoadArray()
        {
            string pathToCsv = "../../../datafiles/beverage_list.csv";

            CSVProcessor csvProcessor = new CSVProcessor();

            csvProcessor.ImportCsv(pathToCsv, _beveragesArray);

            return _beveragesArray;
        }

        public int Search(string[] list, string elementSought)
        {
            bool found = false;
            int max = list.Length - 1;
            int currentElement = 0;

            //do
            //{
            //    if (_beveragesArray[currentElement] == elementSought)
            //    {
            //        found = true;
            //    }
            //    else
            //    {
            //        currentElement = currentElement + 1;
            //    }
            //} while (!(found == true || currentElement > max));

            if (found == true)
            {
                return currentElement;
            }
            else
            {
                return -1;
            }
        }

        public BeverageCollection()
        {
        }
    }
}
