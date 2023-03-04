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

namespace Lab1
{
    public partial class Form1 : Form
    {
        private const int SampleSize = 6000;
        private const int SplitSectionNumbers = 26;
        private const double separatingElement = 0.6;
        private static List<double> randomNumbers = new List<double>();
        private readonly Generator _generator = new Generator();
        private double[] occurencesToSection = new double[SplitSectionNumbers];
        private static double[] statisticFunctionProbability = new double[SampleSize];

        private readonly List<Tuple<double, double>> criticalValues = new List<Tuple<double, double>> 
        { new Tuple<double, double>(0.99, 11.52), 
            new Tuple<double, double>(0.975, 13.12),
            new Tuple<double, double>(0.95, 14.61), 
            new Tuple<double, double>(0.9, 16.47), 
            new Tuple<double, double>(0.8, 18.94), 
            new Tuple<double, double>(0.7, 20.87), 
            new Tuple<double, double>(0.6, 22.62),
            new Tuple<double, double>(0.5, 24.34),
            new Tuple<double, double>(0.4, 26.14),
            new Tuple<double, double>(0.3, 28.17) };

        private static readonly List<Tuple<double, double>> 
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

        private List<Tuple<double, double>> quantileValues = new List<Tuple<double, double>>()
        {
            new Tuple<double, double>(0.1, 1.65),
            new Tuple<double, double>(0.05, 1.96),
            new Tuple<double, double>(0.04, 2.06),
            new Tuple<double, double>(0.03, 2.18),
            new Tuple<double, double>(0.02, 2.33),
            new Tuple<double, double>(0.01, 2.58),
            new Tuple<double, double>(0.001, 3.3),
        };

        private double _mathDelay;

        public Form1()
        {
            InitializeComponent();
            DenyButtonsAccess();
        }

        private void DenyButtonsAccess()
        {
            buildBarChartButton.Enabled = false;
            statisticFunctionButton.Enabled = false;
            calculateMathematicalExpectationButton.Enabled = false;
            calculateDispersionButton.Enabled = false;
            calculateSecondInitialMomentButton.Enabled = false;
            calculateThirdInitialMomentButton.Enabled = false;
            calculatePirsonsCritetionButton.Enabled = false;
            calculateKolmogorovCriterionButton.Enabled = false;
            seriesCriterionButton.Enabled = false;
        }

        private void generateNumbersButton_Click(object sender, EventArgs e)
        {
            generatedNumbers.Items.Clear();
            
            for (int i = 0; i < SampleSize; i++)
            {
                randomNumbers.Add(_generator.Random());
                generatedNumbers.Items.Add(randomNumbers[i]);
            }

            AllowButtonsAccess();
        }

        private void AllowButtonsAccess()
        {
            buildBarChartButton.Enabled = true;
            statisticFunctionButton.Enabled = true;
            calculateMathematicalExpectationButton.Enabled = true;
            calculateSecondInitialMomentButton.Enabled = true;
            calculateThirdInitialMomentButton.Enabled = true;
            seriesCriterionButton.Enabled = true;
        }

        private void buildBarChartButton_Click(object sender, EventArgs e)
        {
            double[] barChartXData = new double[SplitSectionNumbers];
            double[] barChartYData = new double[SplitSectionNumbers];

            for (int i = 0; i < SplitSectionNumbers; i++)
            {
                occurencesToSection[i] = 0;
            }

            for (int i = 0; i < SampleSize; i++)
            {
                int sectionNumber = (int)Math.Truncate(randomNumbers[i] * SplitSectionNumbers);
                occurencesToSection[sectionNumber] += 1;
                barChartXData[sectionNumber] = sectionNumber * ((double)1 / SplitSectionNumbers);
                barChartYData[sectionNumber] = 
                    (occurencesToSection[sectionNumber] / (SampleSize * ((double) 1 / SplitSectionNumbers)));
            }

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 1;

            chart1.Series[0].Points.DataBindXY(barChartXData, barChartYData);
            calculatePirsonsCritetionButton.Enabled = true;
        }

        private void statisticFunctionButton_Click(object sender, EventArgs e)
        {
            double[] barChartXData = new double[SplitSectionNumbers];
            double[] barChartYData = new double[SplitSectionNumbers];
            double[] occurences = new double[SplitSectionNumbers];

            for (int i = 0; i < SplitSectionNumbers; i++)
            {
                occurences[i] = 0;
            }

            for (int i = 0; i < SampleSize; i++)
            {
                int sectionNumber = (int)Math.Truncate(randomNumbers[i] * SplitSectionNumbers);
                for(int j = sectionNumber; j < SplitSectionNumbers; j++)
                {
                    occurences[j] += 1;
                }
                barChartXData[sectionNumber] = sectionNumber * ((double)1 / SplitSectionNumbers);
                barChartYData[sectionNumber] =
                    occurences[sectionNumber] / SampleSize;
            }

            getStatisticFunctionProbability();

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 1;

            chart2.Series[0].Points.DataBindXY(barChartXData, barChartYData);
        }

        private void getStatisticFunctionProbability()
        {
            double[] occurences = new double[SampleSize];

            for (int i = 0; i < SampleSize; i++)
            {
                occurences[i] = 0;
            }

            for (int i = 0; i < SampleSize; i++)
            {
                for (int j = 0; j < SampleSize; j++)
                {
                    if (randomNumbers[j] < randomNumbers[i])
                    {
                        occurences[i] += 1;
                    }
                }
            }
            for (int i = 0; i < SampleSize; i++)
            {
                statisticFunctionProbability[i] = i / SampleSize;
            }
            calculateKolmogorovCriterionButton.Enabled = true;
        }

        private void calculateMathematicalExpectationButton_Click(object sender, EventArgs e)
        {
            mathExcpectationLabel.Text = CalculateMathDelay().ToString();
            calculateDispersionButton.Enabled = true;
        }

        private double CalculateMathDelay()
        {
            double sum = 0;

            for (int i = 0; i < SampleSize; i++)
            {
                sum += randomNumbers[i];
            }

            _mathDelay = sum / SampleSize;
            return _mathDelay;
        }

        private void calculateDispersionButton_Click(object sender, EventArgs e)
        {
            dispersionLabel.Text = CalculateDispersion().ToString();
        }

        private double CalculateDispersion()
        {
            double sum = 0;

            for (int i = 0; i < SampleSize; i++)
            {
                sum += (Math.Pow(randomNumbers[i], 2) - Math.Pow(_mathDelay, 2));
            }

            return sum / SampleSize;
        }

        private void calculateSecondInitialMomentButton_Click(object sender, EventArgs e)
        {
            secondInitialMomentLabel.Text = CalculateInitialMoment(2).ToString();
        }

        private void calculateThirdInitialMomentButton_Click(object sender, EventArgs e)
        {
            thirdInitialMomentLabel.Text = CalculateInitialMoment(3).ToString();
        }

        private double CalculateInitialMoment(int degree)
        {
            double sum = 0;

            for (int i = 0; i < SampleSize; i++)
            {
                sum += Math.Pow(randomNumbers[i], degree);
            }

            return sum / SampleSize;
        }

        private void calculatePirsonsCritetionButton_Click(object sender, EventArgs e)
        {
            double pirsonsCriterion = calculatePirsonsCriterion();
            pirsonsCriterionLabel.Text = pirsonsCriterion.ToString();
            pirsonsCriterionStatusLabel.Text = checkPirsonCriterion(pirsonsCriterion);
        }

        private double calculatePirsonsCriterion()
        {
            double numberToSectionProbability = (double) 1 / SplitSectionNumbers;
            double xi = 0;

            for (int i = 0; i < SplitSectionNumbers; i++)
            {
                xi += Math.Pow(occurencesToSection[i] / SampleSize -
                    numberToSectionProbability, 2)
                    / (numberToSectionProbability);
            }
            return xi * SampleSize;
        }

        private string checkPirsonCriterion(double pirsonsCriterion)
        {
            double a = Double.Parse(comboBox1.SelectedItem.ToString());
            double criticalValue = 0;
            foreach(Tuple<double, double> pair in criticalValues)
            {
                if (pair.Item1 == a)
                {
                    criticalValue = pair.Item2;
                }
            }

            if (pirsonsCriterion < criticalValue)
            {
                return "Гипотеза принимается";
            } else
            {
                return "Гипотеза не принимается";
            }
        }

        private void calculateKolmogorovCriterionButton_Click(object sender, EventArgs e)
        {
            double[] theoreticalFunction = getTheoreticalFunction();
            double d = calculateD(theoreticalFunction, statisticFunctionProbability);
            dLabel.Text = d.ToString();
            double l = Math.Round(calculateLambda(d, SampleSize), 1);
            lambdaLabel.Text = l.ToString();
            double P = getP(l);
            pLabel.Text = P.ToString();
        }

        private static double getP(double l)
        {
            foreach (var value in kolmogorovCriterionProbabilityValues)
            {
                if (l == value.Item1)
                {
                    return value.Item2;
                }
            }

            return 0;
        }

        private static double calculateLambda(double d, double sampleSize)
        {
            return d * Math.Sqrt(sampleSize);
        }

        private static double[] getTheoreticalFunction()
        {
            double[] theoreticalFunction = new double[SampleSize];

            for (int i = 0; i < SampleSize; i++)
            {
                theoreticalFunction[i] = randomNumbers[i];
            }
            Array.Sort(theoreticalFunction);
            return theoreticalFunction;
        }

        private static double calculateD(double[] theoreticalFunction,
                                            double[] realFunction)
        {
            double max = 0;

            for (int i = 0; i < SampleSize; i++)
            {
                double value = Math.Abs(realFunction[i] - theoreticalFunction[i]);
                if (value > max)
                {
                    max = value;
                }
            }

            return max/100;
        }

        private void seriesCriterionButton_Click(object sender, EventArgs e)
        {
            int[] newSequence = CreateNewSequence();
            int r = CountSeries(newSequence);
            rLabel.Text = r.ToString();
            double mathDelay = CalculateRMathDelay();
            criterionMathDelayLabel.Text = mathDelay.ToString();
            double dispersion = CalculateRDispersion();
            criterionDispersionLabel.Text = dispersion.ToString();
            double standartDeviation = CalculateStandartDeviation(dispersion);
            criterionStandartDeviationLabel.Text = standartDeviation.ToString();
            double importanceLevel = Double.Parse(comboBox2.SelectedItem.ToString());
            double quantile = getQuantileValue(importanceLevel);
            quantileLabel.Text = quantile.ToString();
            double rh = GetCriticalValurRH(quantile, mathDelay, standartDeviation);
            rhLabel.Text = rh.ToString();
            double rb = GetCriticalValurRB(quantile, mathDelay, standartDeviation);
            rbLabel.Text = rb.ToString();
            seriesCriterionResultValue.Text = CheckSeriesCriterion(r, rh, rb);
        }

        private int[] CreateNewSequence()
        {
            int[] newSequence = new int[SampleSize];

            for (int i = 0; i < SampleSize; i++)
            {
                if (randomNumbers[i] < separatingElement)
                {
                    newSequence[i] = 0;
                } else
                {
                    newSequence[i] = 1;
                }
            }

            return newSequence;
        }

        private int CountSeries(int[] sequence)
        {
            int value = sequence[0];
            int r = 1;

            foreach (int element in sequence)
            {
                if (element != value)
                {
                    value = element;
                    r++;
                }
            }

            return r;
        }

        private double CalculateRMathDelay()
        {
            return 2 * SampleSize * separatingElement * (1 - separatingElement)
                + Math.Pow(separatingElement, 2) + Math.Pow(1 - separatingElement, 2);
        }

        private double CalculateRDispersion()
        {
            return 4 * SampleSize * separatingElement * (1 - separatingElement)
                * (1 - 3 * separatingElement * (1 - separatingElement))
                - 2 * separatingElement * (1 - separatingElement)
                * (3 - 10 * separatingElement * (1 - separatingElement));
        }

        private double CalculateStandartDeviation(double dispersion)
        {
            return Math.Sqrt(dispersion);
        }

        private double getQuantileValue(double importanceLevel)
        {
            foreach (var value in quantileValues)
            {
                if (importanceLevel == value.Item1)
                {
                    return value.Item2;
                }
            }

            return 0;
        } 

        private double GetCriticalValurRH(double quantileValue, double mathDelay, double standartDeviation)
        {
            return mathDelay - quantileValue * standartDeviation;
        }

        private double GetCriticalValurRB(double quantileValue, double mathDelay, double standartDeviation)
        {
            return mathDelay + quantileValue * standartDeviation;
        }

        private string CheckSeriesCriterion(double r, double rh, double rb)
        {
            if (rh <= r && rh <= rb)
            {
                return "Гипотеза принята";
            }

            return "Гипотеза отвергнута";
        }

    }
}