using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charts
{
    public partial class MainForm : Form
    {
        private Queue<PointDouble> points = new Queue<PointDouble>();
        static object locker = new object();
        public MainForm()
        {
            InitializeComponent();

            Thread ThreadCalcultation = new Thread(new ThreadStart(MakeCalculation));
            ThreadCalcultation.Start();

            Thread ThreadChart = new Thread(new ThreadStart(MakeChart));
            ThreadChart.Start();
        }

        private void MakeCalculation()
        {
            lock (locker)
            {
                for (double x = -10.00; x < 10.00; x += 0.01)
                    points.Enqueue(new PointDouble { X = x, Y = 23 * x * x - 33 });
            }
        }

        private void MakeChart()
        {
            lock (locker)
            {
                for (double x = -10.00; x < 10.00; x += 0.01)
                {
                    PointDouble p = points.Dequeue();
                    chart.Series[0].Points.AddXY(p.X, p.Y);
                }
            }
        }

        struct PointDouble
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
