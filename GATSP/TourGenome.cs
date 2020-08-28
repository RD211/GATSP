using GATesting.GA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GATSP
{
    public class TourGenome : IGenome
    {
        public List<int> genome = new List<int>();
        private double? fitness = null;
        public double? Fitness { get {
                if (fitness != null)
                    return fitness;
                fitness = 0;
                for(int i = 0;i<genome.Count-1;i++)
                {
                    fitness += DataManager.Points[genome[i]].Distance(DataManager.Points[genome[i+1]]);
                }
                return fitness;
            } }

        public int Length => genome.Count;
    }
}
