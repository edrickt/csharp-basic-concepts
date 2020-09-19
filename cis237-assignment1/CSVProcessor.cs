using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class CSVProcessor
    {
        public bool ImportCsv(string pathToCSVFile, Beverage[] beverages)
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    this.ProcessLine(line, beverages, counter++);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
        }

        private void ProcessLine(string line, Beverage[] beverages, int index)
        {
            string[] parts = line.Split(',');

            string bevarageID = parts[0];
            string bevarageName = parts[1];
            string bevaragePack = parts[2];
            string bevaragePrice = parts[3];
            string bevarageActive = parts[4];
        }
    }
}
