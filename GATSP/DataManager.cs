using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace GATSP
{
    public static class DataManager
    {
        public static List<PointF> Points = new List<PointF>();
        public static void InitializePointsTSPFormat(string path)
        {
            Points.Clear();
            var lines = File.ReadAllLines(path).ToList();
            lines.FindIndex((s) => s == "NODE_COORD_SECTION");
            lines.Skip(lines.FindIndex((s) => s == "NODE_COORD_SECTION") + 1).ToList().ForEach((point) => {
                if (point != "EOF")
                {
                    Points.Add(new PointF(float.Parse(point.Split(' ')[1]), float.Parse(point.Split(' ')[2])));
                }
            });
        }
        public static void InitializePointsNormalFormat(string path)
        {
            Points.Clear();
            var lines = File.ReadAllLines(path).ToList();
            lines.Skip(1).ToList().ForEach((point) => {
                if (point != "EOF")
                {
                    Points.Add(new PointF(float.Parse(point.Split(' ')[1]), float.Parse(point.Split(' ')[2])));
                }
            });
        }


    }

}
