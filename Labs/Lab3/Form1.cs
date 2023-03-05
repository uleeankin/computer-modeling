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
        private List<double> occurencesToSection = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void bComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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