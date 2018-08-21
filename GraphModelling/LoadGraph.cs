using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GraphModelling
{
    class LoadGraph
    {
        public LoadGraph(Graph<int> g , string filename)
        {

            FileStream fs = new FileStream(filename, FileMode.Open,FileAccess.Read);
            using (var reader = new StreamReader(fs, Encoding.UTF8))
            {


                string line;

                while ( (line = reader.ReadLine()) != null){
                    string[] values = line.Split(' ');
                    GraphNode<int> nodeFrom = new GraphNode<int>(int.Parse(values[0]));
                    GraphNode<int> nodeTo = new GraphNode<int>(int.Parse(values[1]));
                    double distance = double.Parse(values[2]);
                    GraphEdge<int> edge = new GraphEdge<int>(nodeFrom, nodeTo, distance);
                    g.AddVertex(nodeFrom);
                    g.AddVertex(nodeTo);
                    g.AddEdge(nodeFrom, nodeTo, distance);



                }
            } 
        }

    }
}
