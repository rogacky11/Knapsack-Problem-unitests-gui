using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Problem
{
    internal class Item
    {
        public int weight;
        public int value;
        public decimal ratio;
        public int index;

        public Item(int weight, int value, int index)
        {
            this.weight = weight;
            this.value = value;
            this.ratio = value/weight;
            this.index = index;
        }




    }
}
