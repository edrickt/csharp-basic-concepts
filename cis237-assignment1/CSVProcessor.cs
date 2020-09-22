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
        string[] _beverageIdArray;
        string[] _beverageNameArray;
        string[] _beveragePackArray;
        decimal[] _beveragePriceArray;
        string[] _beverageActiveArray;

        public bool ImportCsv(string pathToCSVFile, Beverage[] beverages)
        {
            StreamReader streamReader = null;
            try
            {
                string line;

                streamReader = new StreamReader(pathToCSVFile);
                int index = 0;
                while ((line = streamReader.ReadLine()) != null)
                {
                    this.ProcessLine(line, beverages, index++);
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
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
        private void ProcessLine(string line, Beverage[] beverages, int index)
        {
            string[] parts = line.Split(',');
            string beverageID = parts[0];
            string beverageName = parts[1];
            string beveragePack = parts[2];
            decimal beveragePrice = decimal.Parse(parts[3]);
            string beverageActive = parts[4];
            beverages[index] = new Beverage(beverageID, beverageName, beveragePack, beveragePrice, beverageActive);

            ProcessArrayColumns(parts);
        }
        private void ProcessArrayColumns(string[] parts)
        {
            string line = "";

            for (int index = 0; index < parts.Length; index++)
            {
                parts = line.Split(' ');

                _beverageIdArray[index] = parts[0];
                _beverageNameArray[index] = parts[1];
                _beveragePackArray[index] = parts[2];
                _beveragePriceArray[index] = decimal.Parse(parts[3]);
                _beverageActiveArray[index] = parts[4];
            }
        }
    }
}
