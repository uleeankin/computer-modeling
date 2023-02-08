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
        private List<double> randomNumbers = new List<double>();
        private readonly Generator _generator = new Generator();

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
                double occurences = 0;

                for (int j = 0; j < SampleSize; j++)
                {
                    if (randomNumbers[j] >= i * ((double)1 / SplitSectionNumbers)
                        && randomNumbers[j] < (i + 1) * ((double)1 / SplitSectionNumbers))
                    {
                        occurences += 1;
                    }
                }

                barChartXData[i] = i * ((double) 1 / SplitSectionNumbers);
                barChartYData[i] = occurences / SampleSize;
            }

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 1;

            chart1.Series[0].Points.DataBindXY(barChartXData, barChartYData);
        }

        private void statisticFunctionButton_Click(object sender, EventArgs e)
        {
            double[] barChartXData = new double[SplitSectionNumbers];
            double[] barChartYData = new double[SplitSectionNumbers];

            for (int i = 0; i < SplitSectionNumbers; i++)
            {
                double occurences = 0;

                for (int j = 0; j < SampleSize; j++)
                {
                    if (randomNumbers[j] > 0
                        && randomNumbers[j] < (i + 1) * ((double)1 / SplitSectionNumbers))
                    {
                        occurences += 1;
                    }
                }

                barChartXData[i] = i * ((double)1 / SplitSectionNumbers);
                barChartYData[i] = occurences / SampleSize;
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
    }
}