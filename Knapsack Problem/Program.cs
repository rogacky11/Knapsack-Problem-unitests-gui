// See https://aka.ms/new-console-template for more information
using Knapsack_Problem;

Console.WriteLine("Enter the number of items: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the seed: ");
int seed = int.Parse(Console.ReadLine());
Problem problem = new Problem(n, seed);
Console.WriteLine("Enter the capasity: ");
int capasity = int.Parse(Console.ReadLine());
problem.Solve(capasity);

