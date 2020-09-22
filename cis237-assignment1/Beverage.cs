using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class Beverage
    {
        private string _beverageId;
        private string _beverageName;
        private string _beveragePack;
        private decimal _beveragePrice;
        private string _beverageActive;
        public string BeverageID
        {
            get { return _beverageId; }
            set { _beverageId = value; }
        }
        public string BeverageName
        {
            get { return _beverageName; }
            set { _beverageName = value; }
        }
        public string BeveragePack
        {
            get { return _beveragePack; }
            set { _beveragePack = value; }
        }
        public decimal BeveragePrice
        {
            get { return _beveragePrice; }
            set { _beveragePrice = value; }
        }
        public string BeverageActive
        {
            get { return _beverageActive; }
            set { _beverageActive = value; }
        }

        public override string ToString()
        {
            return _beverageId.PadRight(5) + " " + _beverageName.PadRight(55) + " " + _beveragePack.PadRight(17) +
                   " " + _beveragePrice.ToString().PadRight(6) + " " + _beverageActive;
        }
        public Beverage(string BeverageID, string BeverageName, string BeveragePack,
                        decimal BeveragePrice, string BeverageActive)
        {
            this._beverageId = BeverageID;
            this._beverageName = BeverageName;
            this._beveragePack = BeveragePack;
            this._beveragePrice = BeveragePrice;
            this._beverageActive = BeverageActive;
        }
        public Beverage()
        {
        }
    }
}
