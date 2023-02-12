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
        private const int R = SplitSectionNumbers - 1;
        private List<double> randomNumbers = new List<double>();
        private readonly Generator _generator = new Generator();
        private double[] occurencesToSection = new double[SplitSectionNumbers];
        private double a;
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

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 1;

            chart2.Series[0].Points.DataBindXY(barChartXData, barChartYData);
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
    }
}