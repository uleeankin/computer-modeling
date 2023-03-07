using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private int SampleSize;
        private List<double> randomValues = new List<double>();
        private double startBound = 0;
        private double middleBound = 0.25;
        private double endBound = 2.25;
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

            int splitSectionNumber = getSplitSectionNumber();
            buildFrequencyHistogram(splitSectionNumber, randomValues, SampleSize);
            buildStatisticFunction(splitSectionNumber, randomValues, SampleSize);

            double mathDelay = calculateMathDelay(randomValues, SampleSize);
            showMathDelay(mathDelay);
            double dispersion = сalculateDispersion(randomValues, SampleSize, mathDelay);
            showDispersion(dispersion);

            calculateKolmogorovsCriterion(randomValues, SampleSize);
        }

        private void calculateKolmogorovsCriterion(List<double> randomNumbers, int sampleSize)
        {
            double d = getD(randomNumbers.ToArray(), sampleSize);
            showD(d);

            double lambda = getLambda(d, sampleSize);
            showLambda(lambda);

            double p = getP(lambda);
            showP(p);
        }

        private void showP(double p)
        {
            pLabel.Text = p.ToString();
        }

        private double getP(double lambda)
        {
            foreach (var value in kolmogorovCriterionProbabilityValues)
            {
                if (lambda == value.Item1)
                {
                    return value.Item2;
                }
            }

            return 0;
        }

        private void showLambda(double lambda)
        {
            lambdaLabel.Text = lambda.ToString();
        }

        private double getLambda(double d, double sampleSize)
        {
            return Math.Round(d * Math.Sqrt(sampleSize), 1);
        }

        private void showD(double d)
        {
            dLabel.Text = d.ToString();
        }

        private double getD(double[] randomNumbers, int sampleSize)
        {
            double d = 0;

            Array.Sort(randomNumbers);

            for (int i = 1; i < sampleSize; i++)
            {
                double dPlus = 0;
                double dMinus = 0;

                if (randomNumbers[i] < 0.25 && randomNumbers[i] >= 0)
                {
                    dPlus = Math.Abs(((double)i / sampleSize) - Ft1(randomNumbers[i]));
                    dMinus = Math.Abs(Ft1(randomNumbers[i]) - ((double)(i - 1) / sampleSize));
                } else if (randomNumbers[i] < 2.25 && randomNumbers[i] >= 0.25)
                {
                    dPlus = Math.Abs(((double)i / sampleSize) - Ft2(randomNumbers[i]));
                    dMinus = Math.Abs(Ft2(randomNumbers[i]) - ((double)(i - 1) / sampleSize));
                }

                if (dPlus > d)
                {
                    d = dPlus;
                }

                if (dMinus > d)
                {
                    d = dMinus;
                }
            }

            return d;
        }

        private double Ft1(double x)
        {
            return (double)Math.Sqrt(x);
        }

        private double Ft2(double x)
        {
            return (double) (0.25 * x + 0.4375);
        }

        private void showMathDelay(double mathDelay)
        {
            mathDelayLabel.Text = mathDelay.ToString();
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

        private void showDispersion(double dispersion)
        {
            dispersionLabel.Text = dispersion.ToString();
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

        private void buildFrequencyHistogram(int splitSectionNumbers, List<double> randomNumbers, int sampleSize)
        {
            double[] barChartYData = new double[splitSectionNumbers];
            double[] barChartXData = new double[splitSectionNumbers];
            double[] occurences = new double[splitSectionNumbers];

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
                //barChartYData[i] = occurences[i] / (SampleSize * ((double)endBound / splitSectionNumbers));
                barChartYData[i] = (double) occurences[i] / SampleSize;
            }

            frequencyHistogram.ChartAreas[0].AxisX.Minimum = startBound;
            frequencyHistogram.ChartAreas[0].AxisX.Maximum = endBound;

            frequencyHistogram.Series[0].Points.DataBindXY(barChartXData, barChartYData);
        }

        private void buildStatisticFunction(int splitSectionNumbers, List<double> randomNumbers, int sampleSize)
        {
            double[] barChartYData = new double[splitSectionNumbers];
            double[] barChartXData = new double[splitSectionNumbers];
            double[] occurences = new double[splitSectionNumbers];

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
                //barChartYData[i] = occurences[i] / (SampleSize * ((double)endBound / splitSectionNumbers));
                barChartYData[i] = (double)occurences[i] / SampleSize;
            }

            statisticalDistributionFunction.ChartAreas[0].AxisX.Minimum = startBound;
            statisticalDistributionFunction.ChartAreas[0].AxisX.Maximum = endBound;

            statisticalDistributionFunction.Series[0].Points.DataBindXY(barChartXData, barChartYData);
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
            double x;
            double r;

            while (randomValues.Count != sampleSize)
            {
                r = random.NextDouble();
                x = Math.Pow(r, 2);
                if (x < middleBound
                    && x >= 0)
                {
                    randomValues.Add(x);
                } else
                {
                    x = (r - 0.4375) / 0.25;

                    if (x >= middleBound
                        && x < endBound)
                    {
                        randomValues.Add(x);
                    }
                }
            }

            return randomValues;
        }

        private int getSampleSize()
        {
            return int.Parse(sampleSizeTextBox.Text);
        }


    }
}