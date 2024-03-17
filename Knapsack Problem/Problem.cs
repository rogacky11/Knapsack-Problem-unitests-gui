using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UniTests")]
[assembly: InternalsVisibleTo("KnapsackGUI")]
namespace Knapsack_Problem
{
    internal class Problem
    {
        private int _n;
        private int _seed;
        private int _capasity;
        public List<Item> Items = new List<Item>();
        public List<int> ResultList = new List<int>();
        
        

        public Problem(int n, int seed)
        {          
            _n = n;
            
            _seed = seed;
            int index = 0;
            Random random = new Random(seed);

            for (int i = 1; i <= n; i++)
            {
                
                int weight = random.Next(9);
                int value = random.Next(9);
                weight++; value++;
                var item = new Item(weight, value, index);

                
               // Console.WriteLine("no.: " + index + "    Weight: " + weight + " Value: " + value, "\n");

                Items.Add(item);
                index++;
                
            }

        }

        public List<string> GetStrings()
        {
            List<string> results = new List<string>();
            foreach(var item in Items) 
            {
                results.Add(string.Join("   ", $"no.:  {item.index}, Value: {item.value}, Weight: {item.weight}"));
            }
            return results;
        }
            
        
        public Result Solve(int capasity)
        {
            
            _capasity = capasity;
            int totalWeight = 0;
            int totalValue = 0;
            int tempCapasity = capasity;


            List<Item> SortedList = Items.OrderByDescending(item => item.ratio).ToList();

            foreach (Item i in SortedList)
            {
               
                if (capasity == 0)
                {
                    break;
                }
                
                if (i.weight <= tempCapasity) 
                {

                    ResultList.Add(i.index);
                    totalWeight += i.weight;
                    totalValue += i.value;
                    tempCapasity -= i.weight;

                }

            }

            Console.WriteLine("Items: " + string.Join(", ", ResultList));
            Console.WriteLine("TotalWeight: " + totalWeight + " TotalValue: " + totalValue);
            

            return new Result(ResultList, totalValue, totalWeight);


        }

       



    }
}
