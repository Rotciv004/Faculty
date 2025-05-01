using Facultate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Facultate.Helpers
{
    internal class ChartHelper
    {
        public static void FillPieChart(Chart chart, IEnumerable<Student> students)
        {
            chart.Series.Clear();
            var series = new Series("Departments")
            {
                ChartType = SeriesChartType.Pie
            };
            var groups = students.GroupBy(s => s.Department)
                                 .Select(g => new { Dept = g.Key, Count = g.Count() });
            foreach (var g in groups)
                series.Points.AddXY(g.Dept, g.Count);
            chart.Series.Add(series);
        }
    }
}
