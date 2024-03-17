using System;
using System.Security.Cryptography.X509Certificates;
using Knapsack_Problem;
using System.Linq;
using System.Collections.Generic;

namespace UniTests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]

        public void TestOneElementReturned()
        {

            Problem problem = new Problem(2, 1);

            foreach(var item in problem.Items)
            {
                item.weight = 1;
            }

            var result = problem.Solve(1);

            Assert.IsTrue(result.items.Count == 1);

        }

        [TestMethod]
        public void TestZeroFittingElement() 
        {
            Problem problem = new Problem(2, 1);

            foreach (var item in problem.Items)
            {
                item.weight = 5;
                
            }

            var result = problem.Solve(1);

            Assert.IsTrue(result.items.Count == 0);

        }
        [TestMethod]
        public void TestIfOrderMatters() 
        
        {
            Problem problem1 = new Problem (5,1);
            
            Result result1 = problem1.Solve(10);

            Problem problem2 = new Problem(5, 1);

            problem1.ResultList.Reverse();

            Result result2 = problem1.Solve(10);

            Assert.AreEqual (result2.TotalValue, result1.TotalValue);
            Assert.AreEqual(result2.TotalWeight, result1.TotalWeight);
            //Assert.AreEqual(result2.items, result1.items);
        }

        [TestMethod]
        public void TestSpecificResult() 
        {

            // Arrange
            Problem problem = new Problem(10, 1); 
            foreach (var item in problem.Items) 
            {
                item.weight = 1; 
                item.value = 1; 
            }

            var result = problem.Solve(50); 

            Assert.AreEqual(10, result.items.Count);
            Assert.AreEqual("10", result.TotalValue);
            Assert.AreEqual("10", result.TotalWeight);

        }

        [TestMethod]
        public void TestZeroElements()
        {
            //Testing 0 elements

            Problem problem = new Problem(0, 1);

            Result result = problem.Solve(10);

            Assert.AreEqual(0, result.items.Count);
        }

        [TestMethod]
        public void TestMinusNumberOfElements()
        {
            //Testing 0 elements

            Problem problem = new Problem(-1, 1);

            Result result = problem.Solve(10);

            Assert.AreEqual(0, result.items.Count);
        }

        [TestMethod]
        public void TestIfReturnAllWIthZeroWeight()
        {
            Problem problem = new Problem(10, 1);

            foreach(var item in problem.Items)
            {
                item.weight = 0;
            }

            var result = problem.Solve(10);

            Assert.AreEqual(10, result.items.Count);
        }

        [TestMethod]
        public void TestZeroCapasity()
        {

            Problem problem = new Problem(10, 1);

                var result = problem.Solve(0);

                Assert.IsTrue(result.items.Count == 0);

            }

        [TestMethod]
        public void TestMInusCapasity()
        {

            Problem problem = new Problem(10, 1);

            var result = problem.Solve(-5);

            Assert.IsTrue(result.items.Count == 0);

        }





    }
}