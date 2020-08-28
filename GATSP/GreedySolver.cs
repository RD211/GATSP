using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GATSP
{
    public static class GreedySolver
    {
        static Dictionary<int, bool> usedItems = new Dictionary<int, bool>();
        public static List<int> path = new List<int>();
        public static double Solve()
        {
            int node = 0;
            double sum = 0;
            while (true)
            {
                path.Add(node);
                usedItems.Add(node, true);
                double minimum = 1000000000;
                int nodeSaved = 0;
                for (int i = 0; i < DataManager.Points.Count; i++)
                {
                    if (!usedItems.ContainsKey(i))
                    {
                        var dist = DataManager.Points[i].Distance(DataManager.Points[node]);
                        if (minimum > dist)
                        {
                            minimum = dist;
                            nodeSaved = i;
                        }
                    }
                }
                if (nodeSaved == 0)
                {
                    sum += DataManager.Points[node].Distance(DataManager.Points[0]);
                    break;
                }
                sum += minimum;
                node = nodeSaved;
            }
            path.Add(0);
            return sum;
        }

    }
}
