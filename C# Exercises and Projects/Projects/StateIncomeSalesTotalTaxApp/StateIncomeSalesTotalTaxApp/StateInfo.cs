using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateIncomeSalesTotalTaxApp
{
    public class StateInfo
    {
        public List<string> states = new List<string>();
        public List<double> personalIncomeTax = new List<double>();
        public List<int> personalIncomeTaxRank = new List<int>();
        public List<double> salesTax = new List<double>();
        public List<int> salesTaxRank = new List<int>();
        public List<double> totalTax = new List<double>();
        public List<int> totalTaxRank = new List<int>();

        public StateInfo()
        {
        }
    }
}