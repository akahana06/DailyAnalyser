using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot.WinForms; // .NET 8 doesn't support System.Windows.Forms.Datavisualization
using ClosedXML.Excel;
using System.Collections;

namespace DailyAnalyser
{
    public static class GraphBuilder
    {
        public static ScottPlot.WinForms.FormsPlot buildLineGraph(Dictionary<DateTime, double> data)
        {
            FormsPlot result = new FormsPlot() { Dock = DockStyle.Fill };

            var dates = data.Keys.OrderBy(x => x).ToArray();
            var values = dates.Select(d => data[d]).ToArray();

            double[] xs = dates.Select(d => d.ToOADate()).ToArray();
            double[] ys = values;

            result.Plot.Clear();
            result.Plot.Add.Scatter(xs, ys);
            result.Plot.Axes.DateTimeTicksBottom();
            result.Plot.XLabel("Date");
            result.Plot.YLabel("Answers");
            result.Refresh();
            return result;
        }

        public static ScottPlot.WinForms.FormsPlot buildNumBarGraph(Dictionary<DateTime, double> data)
        {
            FormsPlot result = new FormsPlot() { Dock = DockStyle.Fill };

            var dates = data.Keys.OrderBy(x => x).ToArray();
            var values = dates.Select(d => data[d]).ToArray();

            double[] xs = dates.Select(d => d.ToOADate()).ToArray();
            double[] ys = values;

            result.Plot.Clear();

            result.Plot.Add.Bars(xs, ys);
            result.Plot.Axes.DateTimeTicksBottom();
            result.Plot.XLabel("Date");
            result.Plot.YLabel("Answers");

            result.Refresh();
            return result;
        }

        public static ScottPlot.WinForms.FormsPlot buildStringBarGraph(Dictionary<DateTime, string> data, ArrayList bounds)
        {
            FormsPlot result = new FormsPlot() { Dock = DockStyle.Fill };

            var dates = data.Keys.OrderBy(x => x).ToArray();
            var values = dates.Select(d => data[d]).ToArray();

            var boundsArray = bounds.Cast<string>().ToArray();
            int[] ys = values.Cast<string>().Select(a =>
            {
                int index = Array.IndexOf(boundsArray, a);
                return index >= 0 ? index + 1 : 0;
            }).ToArray();

            double[] xs = dates.Select(d => d.ToOADate()).ToArray();
            

            result.Plot.Clear();

            result.Plot.Add.Bars(xs, ys);
            result.Plot.Axes.DateTimeTicksBottom();
            result.Plot.XLabel("Date");
            result.Plot.YLabel("Answers");

            result.Refresh();
            return result;
        }
    }
}
