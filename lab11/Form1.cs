using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        int n;
        double d, m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            n = (int)expnum.Value;
            m = (double)numM.Value;
            d = (double)numD.Value;
            double[] generated = new double[n];
            double min = 100000.0;
            double max = -100000.0;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                double u1 = 1.0 - rand.NextDouble();
                double u2 = 1.0 - rand.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                             Math.Sin(2.0 * Math.PI * u2);
                double randNormal =
                             m + Math.Sqrt(d) * randStdNormal;
                if (randNormal < min)
                {
                    min = randNormal;
                }
                if (randNormal > max)
                {
                    max = randNormal;
                }
                generated[i] = randNormal; 
            }
            double errm = 0, errd = 0;

            double pos = Math.Round(min - 1);
            int step = (int)((max - pos) / 0.1) + 1;
            double[] xes = new double[step];
            double[] yes = new double[step];
            int j = 0;
            while (pos < max)
            {
                int counter = 0; 
                double x = pos;
                for (int i = 0; i < n; i++)
                {
                    if (pos + 0.1 > generated[i] & pos <= generated[i])
                    {
                        counter++; 
                    }
                }
                pos += 0.1;
                xes[j] = x;
                yes[j] = (double)counter / n * 10;
                j++; 

                errm += ((double)counter / n * 10) * x; 
                chart1.Series[0].Points.AddXY(Math.Round(x, 2), (double)counter / n * 10);
            }
            MEr.Value = (decimal)(Math.Abs(errm - m) / m);

            double chi = 0; 
            for (int i = 0; i < step; i++)
            {
                errd += Math.Pow(yes[i] - errm, 2);
                double fx = 1 / (Math.Sqrt(2 * d * Math.PI)) * Math.Exp(-Math.Pow(xes[i] - m, 2) / (2 * d));
                chi += Math.Pow(fx - yes[i], 2) / fx;
            }
            DEr.Value = (decimal)(Math.Abs(errd - d) / n / d); 
            numChi.Value = (decimal)(chi);

            for (int i = (int)Math.Round(min - 1); i < max + 1; i++)
            {
                double fx = 1 / (Math.Sqrt(2 * d * Math.PI)) * Math.Exp(-Math.Pow(i - m, 2) / (2 * d));
                chart1.Series[1].Points.AddXY(i, fx);
            }

        }
    }
}
