using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private int SampleSize;
        private List<double> randomValues = new List<double>();
        private double m = 4.7;
        private double g = 0.6;
        private readonly List<Tuple<double, double>>
            kolmogorovCriterionProbabilityValues = new List<Tuple<double, double>>
        { new Tuple<double, double>(0.0, 1.0), new Tuple<double, double>(0.1, 1.0),
            new Tuple<double, double>(0.2, 1.0), new Tuple<double, double>(0.3, 1.0),
            new Tuple<double, double>(0.4, 0.997), new Tuple<double, double>(0.5, 0.964),
            new Tuple<double, double>(0.6, 0.864), new Tuple<double, double>(0.7, 0.711),
            new Tuple<double, double>(0.8, 0.544), new Tuple<double, double>(0.9, 0.393),
            new Tuple<double, double>(1.0, 0.27), new Tuple<double, double>(1.1, 0.178),
            new Tuple<double, double>(1.2, 0.112), new Tuple<double, double>(1.3, 0.068),
            new Tuple<double, double>(1.4, 0.04), new Tuple<double, double>(1.5, 0.022),
            new Tuple<double, double>(1.6, 0.012), new Tuple<double, double>(1.7, 0.006),
            new Tuple<double, double>(1.8, 0.003), new Tuple<double, double>(1.9, 0.002),
            new Tuple<double, double>(2.0, 0.001),
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            SampleSize = getSampleSize();
            randomValues = generateRandomValues(SampleSize);
            showGeneratedValues(randomValues);

            List<double> approximatedRandomValues = 
                generateApproximatedRandomValues(SampleSize);

            showApproximatedRandomValues(approximatedRandomValues);

            int splitSectionNumber = getSplitSectionNumber();
            buildFrequencyHistogram(splitSectionNumber, randomValues, 
                SampleSize, frequencyHistogram);
            buildStatisticFunction(splitSectionNumber, randomValues, 
                SampleSize, statisticalDistributionFunction);

            buildFrequencyHistogram(splitSectionNumber, approximatedRandomValues,
                SampleSize, frequencyHistogramAppr);
            buildStatisticFunction(splitSectionNumber, approximatedRandomValues,
                SampleSize, statisticalFunctionAppr);

            double mathDelay = calculateMathDelay(randomValues, SampleSize);
            showValue(mathDelay, mathDelayLabel);

            double approximatedMathDelay = 
                calculateMathDelay(approximatedRandomValues, SampleSize);
            showValue(approximatedMathDelay, mathDelayAppr);

            double dispersion = сalculateDispersion(randomValues, SampleSize, mathDelay);
            showValue(dispersion, dispersionLabel);

            double approximatedDispersion = сalculateDispersion(
                approximatedRandomValues, SampleSize, approximatedMathDelay);
            showValue(approximatedDispersion, dispersionAppr);

        }

        private double Ft(double x)
        {
            double degree = -1.0 * Math.Pow(x - m, 2.0) / (2.0 * Math.Pow(g, 2.0));
            double a = (double) 1.0 / (g * Math.Sqrt(2.0 * Math.PI));
            double e = (double)Math.Exp(degree);
            return (double) a * e;
        }

        private double calculateMathDelay(List<double> randomNumbers, int sampleSize)
        {
            double sum = 0;

            for (int i = 0; i < SampleSize; i++)
            {
                sum += randomNumbers[i];
            }

            double mathDelay = sum / sampleSize;
            return mathDelay;
        }

        private void showValue(double value, Label label)
        {
            label.Text = value.ToString();
        }

        private double сalculateDispersion(List<double> randomNumbers, int sampleSize, double mathDelay)
        {
            double sum = 0;

            for (int i = 0; i < sampleSize; i++)
            {
                sum += (Math.Pow(randomNumbers[i], 2) - Math.Pow(mathDelay, 2));
            }

            return sum / SampleSize;
        }

        private int getSplitSectionNumber()
        {
            return int.Parse(splitIntervalsComboBox.SelectedItem.ToString());
        }

        private void buildFrequencyHistogram(int splitSectionNumbers, List<double> numbers, 
            int sampleSize, Chart chart)
        {
            double[] barChartYData = new double[splitSectionNumbers];
            double[] barChartXData = new double[splitSectionNumbers];
            double[] occurences = new double[splitSectionNumbers];

            double[] randomNumbers = numbers.ToArray();
            Array.Sort(randomNumbers);
            double endBound = randomNumbers[sampleSize - 1];

            for (int i = 0; i < splitSectionNumbers; i++)
            {
                occurences[i] = 0;
            }

            for (int i = 0; i < splitSectionNumbers; i++)
            {
                for (int j = 0; j < sampleSize; j++)
                {
                    if (randomNumbers[j] > (i * ((double)endBound / splitSectionNumbers)) 
                        && randomNumbers[j] < ((i + 1) * ((double)endBound / splitSectionNumbers)))
                    {
                        occurences[i] += 1;
                    }

                }
                barChartXData[i] = i * ((double)endBound / splitSectionNumbers);
                barChartYData[i] = ((double) occurences[i] / SampleSize);
            }

            chart.ChartAreas[0].AxisX.Minimum = randomNumbers[0];
            chart.ChartAreas[0].AxisX.Maximum = endBound;

            chart.Series[0].Points.DataBindXY(barChartXData, barChartYData);
        }

        private void buildStatisticFunction(int splitSectionNumbers, List<double> numbers, 
            int sampleSize, Chart chart)
        {
            double[] barChartYData = new double[splitSectionNumbers];
            double[] barChartXData = new double[splitSectionNumbers];
            double[] occurences = new double[splitSectionNumbers];

            double[] randomNumbers = numbers.ToArray();
            Array.Sort(randomNumbers);
            double endBound = randomNumbers[sampleSize - 1];
            double startBound = randomNumbers[0];

            for (int i = 0; i < splitSectionNumbers; i++)
            {
                occurences[i] = 0;
            }

            for (int i = 0; i < splitSectionNumbers; i++)
            {
                for (int j = 0; j < sampleSize; j++)
                {
                    if (randomNumbers[j] > startBound
                        && randomNumbers[j] < ((i + 1) * ((double)endBound / splitSectionNumbers)))
                    {
                        occurences[i] += 1;
                    }

                }
                barChartXData[i] = i * ((double)endBound / splitSectionNumbers);
                barChartYData[i] = ((double)occurences[i] / SampleSize);
            }

            chart.ChartAreas[0].AxisX.Minimum = startBound;
            chart.ChartAreas[0].AxisX.Maximum = endBound;

            chart.Series[0].Points.DataBindXY(barChartXData, barChartYData);
        }

        private void showGeneratedValues(List<double> generatedValues)
        {
            generatedValuesListBox.Items.Clear();
            foreach (double value in generatedValues)
            {
                generatedValuesListBox.Items.Add(value);
            }
        }

        private List<double> generateRandomValues(int sampleSize)
        {
            List<double> randomValues = new List<double>();
            Random random = new Random();
            double s;
            double r;

            for (int i = 0; i < sampleSize; i++)
            {
                s = 0;
                for (int j = 0; j < 12; j++)
                {
                    r = random.NextDouble();
                    s += r;
                }
                double x = s - 6;
                x = m + x * Math.Sqrt(g);
                randomValues.Add(x);
            }

            return randomValues;
        }

        private void showApproximatedRandomValues(List<double> randomValues)
        {
            generatedValuesApprListBox.Items.Clear();
            foreach (double value in randomValues)
            {
                generatedValuesApprListBox.Items.Add(value);
            }
        }

        private List<double> generateApproximatedRandomValues(int sampleSize)
        {
            List<double> randomValues = new List<double>();
            Random random = new Random();
            double x;
            double r;
            double k = (double)Math.Sqrt(8.0 / Math.PI);

            for (int i = 0; i < sampleSize; i++)
            {
                r = random.NextDouble();
                x = Math.Log((1 + r) / (1 - r)) / k;
                r = random.NextDouble();
                if (r < 0.5) x = -x;
                x = m + x * Math.Sqrt(g);
                randomValues.Add(x);
            }

            return randomValues;
        }

        private int getSampleSize()
        {
            return int.Parse(sampleSizeTextBox.Text);
        }
    }
}