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
        /// <summary>
        /// Imports csv file from specified path. Returns a bool so it can catch
        /// exceptions if file is not found.
        /// </summary>
        /// <param name="pathToCSVFile">The specified path that was passed from Program.cs
        ///                             into BeverageCollection.cs and into here to use with
        ///                             StreamReader</param>
        /// <param name="beverages">The array of beverages</param>
        /// <returns></returns>
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
        /// <summary>
        /// New beverage object created based on the line read on csv file 
        /// that is comma delimited and passed into Beverage object array.
        /// </summary>
        /// <param name="line">Used to read the csv file line by line</param>
        /// <param name="beverages">Array for beverages</param>
        /// <param name="index">Element of the array</param>
        private void ProcessLine(string line, Beverage[] beverages, int index)
        {   
            string[] parts = line.Split(',');
            string beverageID = parts[0];
            string beverageName = parts[1];
            string beveragePack = parts[2];
            decimal beveragePrice = decimal.Parse(parts[3]);
            string beverageActive = parts[4];
            beverages[index] = new Beverage(beverageID, beverageName, beveragePack, beveragePrice, beverageActive);
        }
    }
}
