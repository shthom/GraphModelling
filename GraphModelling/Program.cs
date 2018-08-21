using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphModelling
{
    class Program
    {
        static void Main(string[] args)
        {

            //BellmanFordTestMethod();
            //FloydWarshallFunction();
            JohnsonFunction();

           

           



            Console.ReadLine();

        }

        private static void JohnsonFunction()
        {
            Graph<int> g = new Graph<int>();
            LoadGraph loader = new LoadGraph(g, @"data\GraphWithNoNegativeCycle.txt");
            var alg = new GraphTraversal();
            var result = alg.JohnsonFunction(g);
            if (result != null)
            {
                foreach (var item in result)
                {
                    Tuple<GraphNode<int>, GraphNode<int>> keyset = item.Key;
                    GraphNode<int> nodeFrom = keyset.Item1;
                    GraphNode<int> nodeTo = keyset.Item2;
                    Console.WriteLine("Shortest distance from Node: " + nodeFrom.Value + " To: " + nodeTo.Value + " = " + item.Value);

                }

            }
            Console.WriteLine("Path found: ");
        }

        private static void FloydWarshallFunction()
        {
            Graph<int> g = new Graph<int>();
            LoadGraph loader = new LoadGraph(g, @"data\SimpleGraphWithNegativeWeights.txt");
            GraphNode<int> start = g.GetVertex(new GraphNode<int>(0));
            var alg = new GraphTraversal();
            var result = alg.FloydWarshallFunction(g);

            if( result != null)
            {
                foreach(var item in result)
                {
                    Tuple<GraphNode<int>, GraphNode<int>> keyset = item.Key;
                    GraphNode<int> nodeFrom = keyset.Item1;
                    GraphNode<int> nodeTo = keyset.Item2;
                    Console.WriteLine("Shortest distance from Node: " + nodeFrom.Value + " To: " + nodeTo.Value + " = " + item.Value);

                }
                
            }
            Console.WriteLine("Path found: ");
        }

        static void BellmanFordTestMethod()
        {
            Graph<int> g = new Graph<int>();
            LoadGraph loader = new LoadGraph(g, @"data\SimpleGraphWithNegativeWeights.txt");
            GraphNode<int> start = g.GetVertex(new GraphNode<int>(0));
            var alg = new GraphTraversal();
            var result = alg.BellmanFordFunction(g, start);
            Console.WriteLine("Negative Cycle found: " + result.Item1);


            
        }
    }
}
