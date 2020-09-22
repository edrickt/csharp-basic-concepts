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

        private void SearchArrayByID()
        {

        }

        public BeverageCollection()
        {
        }
    }
}
