using GA;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GATSP
{
    public partial class Form1 : Form
    {
        float mutation = 0.3f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar_mutation.Value = (int)(mutation * 100);
            trackBar_reproduction.Value = 50;
            trackBar_top.Value = 10;
        }

        private void btn_changeData_Click(object sender, EventArgs e)
        {
            var dia = new OpenFileDialog();
            if(dia.ShowDialog()==DialogResult.OK)
            {
                DataManager.InitializePoints(dia.FileName);
            }
        }
        public static TourGenome Mate(TourGenome a, TourGenome b)
        {
            Dictionary<int, bool> used = new Dictionary<int, bool>();
            TourGenome child = new TourGenome();
            used.Add(0, true);
            child.genome.Add(0);
            for(int i = 1;i<a.Length-1;i++)
            {
                bool usedA, usedB;
                usedA = used.ContainsKey(a.genome[i]);
                usedB = used.ContainsKey(b.genome[i]);
                if (!usedA && !usedB)
                {
                    int res = StaticRandom.Rand(2);
                    child.genome.Add((res==0 ? a.genome[i] : b.genome[i]));
                    used.Add((res == 0 ? a.genome[i] : b.genome[i]), true);
                }
                else if (!usedB)
                {
                    child.genome.Add(b.genome[i]);
                    used.Add(b.genome[i], true);
                }
                else if(!usedA)
                {
                    child.genome.Add(a.genome[i]);
                    used.Add(a.genome[i], true);
                }
                else
                {
                    int res = StaticRandom.Rand(DataManager.Points.Count - 1) + 1;
                    while (used.ContainsKey(res))
                        res = StaticRandom.Rand(DataManager.Points.Count - 1) + 1;
                    child.genome.Add(res);
                    used.Add(res, true);
                }
            }
            child.genome.Add(0);
            var dasd = child.Fitness;
            return child;
        }
        public static TourGenome Create()
        {
            TourGenome child = new TourGenome();
            Enumerable.Range(1, DataManager.Points.Count - 1).ToList().ForEach((num) => child.genome.Add(num));
            child.genome.Shuffle();
            child.genome = child.genome.Prepend(0).ToList();
            child.genome.Add(0);
            var dasd = child.Fitness;
            return child;
        }
        GA<TourGenome> ga;
        private void btn_start_Click(object sender, EventArgs e)
        {
            ga = new GA<TourGenome>(50000, Mate, Create, 0.5f, 0.1f);
            timer_evolve.Start();
            chart_evolution.Series.Clear();
            //chart_derivative.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Scores")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 3
            };
            var increasingSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Increase")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                Color = Color.DarkRed,
                BorderWidth = 3
            };
            chart_evolution.Series.Add(series);
        }
        int generations = 0;
        private async void Advance()
        {
            ga.Eval();
        }
        bool working = false;
        private void timer_evolve_Tick(object sender, EventArgs e)
        {

            if (!working)
            {

                working = true;
                Task.Run(Advance).GetAwaiter().OnCompleted(() => {
                    working = false;
                    generations++;
                    lock (ga)
                    {
                        chart_evolution.Series.Last().Points.AddY(ga.GetBestContender().Fitness);
                        /*
                        if (chart_evolution.Series.Last().Points.Count >= 2)
                        {
                            chart_derivative.Series.Last().Points.AddY(
                                chart_evolution.Series.Last().Points.Last().YValues[0] -
                                chart_evolution.Series.Last().Points[chart_evolution.Series.Last().Points.Count - 2].YValues[0]
                                );
                        }
                        */
                        lbl_min.Text = $"Generation:{generations}\nScore:{ga.GetBestContender().Fitness}";
                    }
                });
            }
        }

        private void lbl_min_Click(object sender, EventArgs e)
        {

        }
        private void trackBar_mutation_Scroll(object sender, EventArgs e)
        {
            mutation = (float)trackBar_mutation.Value / (float)100f;
        }

        private void trackBar_top_Scroll(object sender, EventArgs e)
        {
            lock (ga)
            {
                ga.top = (float)trackBar_top.Value / (float)100f;
            }
        }

        private void trackBar_reproduction_Scroll(object sender, EventArgs e)
        {
            lock (ga)
            {
                ga.top = (float)trackBar_top.Value / (float)100f;
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            File.WriteAllText("path.txt", string.Join(" ", ga.GetBestContender().genome));
        }
    }
}
