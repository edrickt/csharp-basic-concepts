using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class BeverageCollection
    {
        //private Array _beveragesArray;

        //public Array BeverageArray
        //{
        //    get { return _beveragesArray; }
        //    set { _beveragesArray = value; }
        //}

        //    private int SearchBeverageByID(Array[] array, string beverageId)
        //    {
        //        bool found = false;
        //        int max = array.Length - 1;
        //        int index = 0;

        //        do
        //        {
        //            if (array[index] == beverageId)
        //            {
        //                found = true;
        //            }
        //            else
        //            {
        //                index = index + 1;
        //            }
        //        }
        //        while (!(found == true || index > max));

        //        if (found == true)
        //        {
        //            return index;
        //        }
        //        else
        //        {
        //            return -1;
        //        }
        //    }

        public Array LoadArray()
        {
            Beverage[] _beveragesArray = new Beverage[4100];

            string pathToCsv = "../../../datafiles/beverage_list.csv";

            CSVProcessor csvProcessor = new CSVProcessor();

            csvProcessor.ImportCsv(pathToCsv, _beveragesArray);

            return _beveragesArray;
        }

        public BeverageCollection()
        {

        }
    }
}
