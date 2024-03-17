using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UniTests")]
[assembly: InternalsVisibleTo("KnapsackGUI")]

namespace Knapsack_Problem
{
    internal class Result
    {
        private int _totalValue;
        private int _totalWeight;
        public List<string> items;  
        
        public Result(List<int> ResultList, int totalValue, int totalWeight) 
        {
            _totalValue = totalValue;
            _totalWeight = totalWeight;

            items = ResultList.ConvertAll<string>(x => x.ToString());

        }
        public string TotalValue
        {
            get { return _totalValue.ToString(); }
        }

        public string TotalWeight
        {
            get { return _totalWeight.ToString(); }
        }




    }
}
