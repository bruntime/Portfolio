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
        public List<string> personalIncomeTax = new List<string>();
        public List<string> personalIncomeTaxRank = new List<string>();
        public List<string> salesTax = new List<string>();
        public List<string> salesTaxRank = new List<string>();
        public List<string> totalTax = new List<string>();
        public List<string> totalTaxRank = new List<string>();
    }
}