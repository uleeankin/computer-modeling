namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.sampleSizeTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.generatedValuesListBox = new System.Windows.Forms.ListBox();
            this.frequencyHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statisticalDistributionFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.mathDelayLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dispersionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitIntervalsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.lambdaLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.statisticalFunctionAppr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frequencyHistogramAppr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.generatedValuesApprListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pAppr = new System.Windows.Forms.Label();
            this.lambdaAppr = new System.Windows.Forms.Label();
            this.dAppr = new System.Windows.Forms.Label();
            this.dispersionAppr = new System.Windows.Forms.Label();
            this.mathDelayAppr = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticalDistributionFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticalFunctionAppr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyHistogramAppr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число случайных величин";
            // 
            // sampleSizeTextBox
            // 
            this.sampleSizeTextBox.Location = new System.Drawing.Point(24, 33);
            this.sampleSizeTextBox.Name = "sampleSizeTextBox";
            this.sampleSizeTextBox.Size = new System.Drawing.Size(168, 22);
            this.sampleSizeTextBox.TabIndex = 1;
            this.sampleSizeTextBox.Text = "3000";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(494, 24);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(168, 42);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // generatedValuesListBox
            // 
            this.generatedValuesListBox.FormattingEnabled = true;
            this.generatedValuesListBox.ItemHeight = 16;
            this.generatedValuesListBox.Location = new System.Drawing.Point(1411, 347);
            this.generatedValuesListBox.Name = "generatedValuesListBox";
            this.generatedValuesListBox.Size = new System.Drawing.Size(202, 388);
            this.generatedValuesListBox.TabIndex = 3;
            // 
            // frequencyHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.frequencyHistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.frequencyHistogram.Legends.Add(legend1);
            this.frequencyHistogram.Location = new System.Drawing.Point(15, 82);
            this.frequencyHistogram.Name = "frequencyHistogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.frequencyHistogram.Series.Add(series1);
            this.frequencyHistogram.Size = new System.Drawing.Size(564, 300);
            this.frequencyHistogram.TabIndex = 4;
            this.frequencyHistogram.Text = "chart1";
            // 
            // statisticalDistributionFunction
            // 
            chartArea2.Name = "ChartArea1";
            this.statisticalDistributionFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.statisticalDistributionFunction.Legends.Add(legend2);
            this.statisticalDistributionFunction.Location = new System.Drawing.Point(15, 403);
            this.statisticalDistributionFunction.Name = "statisticalDistributionFunction";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.statisticalDistributionFunction.Series.Add(series2);
            this.statisticalDistributionFunction.Size = new System.Drawing.Size(564, 300);
            this.statisticalDistributionFunction.TabIndex = 5;
            this.statisticalDistributionFunction.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1218, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Математическое ожидание";
            // 
            // mathDelayLabel
            // 
            this.mathDelayLabel.AutoSize = true;
            this.mathDelayLabel.Location = new System.Drawing.Point(1446, 68);
            this.mathDelayLabel.Name = "mathDelayLabel";
            this.mathDelayLabel.Size = new System.Drawing.Size(0, 17);
            this.mathDelayLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1326, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дисперсия";
            // 
            // dispersionLabel
            // 
            this.dispersionLabel.AutoSize = true;
            this.dispersionLabel.Location = new System.Drawing.Point(1446, 110);
            this.dispersionLabel.Name = "dispersionLabel";
            this.dispersionLabel.Size = new System.Drawing.Size(0, 17);
            this.dispersionLabel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1245, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Критерий Колмогорова";
            // 
            // splitIntervalsComboBox
            // 
            this.splitIntervalsComboBox.FormattingEnabled = true;
            this.splitIntervalsComboBox.Items.AddRange(new object[] {
            "15",
            "25"});
            this.splitIntervalsComboBox.Location = new System.Drawing.Point(240, 34);
            this.splitIntervalsComboBox.Name = "splitIntervalsComboBox";
            this.splitIntervalsComboBox.Size = new System.Drawing.Size(121, 24);
            this.splitIntervalsComboBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Число интервалов разбиения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1374, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "D";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1338, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "lambda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1319, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "P(lambda)";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(1446, 206);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(0, 17);
            this.dLabel.TabIndex = 21;
            // 
            // lambdaLabel
            // 
            this.lambdaLabel.AutoSize = true;
            this.lambdaLabel.Location = new System.Drawing.Point(1443, 240);
            this.lambdaLabel.Name = "lambdaLabel";
            this.lambdaLabel.Size = new System.Drawing.Size(0, 17);
            this.lambdaLabel.TabIndex = 22;
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(1446, 281);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(0, 17);
            this.pLabel.TabIndex = 23;
            // 
            // statisticalFunctionAppr
            // 
            chartArea3.Name = "ChartArea1";
            this.statisticalFunctionAppr.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.statisticalFunctionAppr.Legends.Add(legend3);
            this.statisticalFunctionAppr.Location = new System.Drawing.Point(613, 403);
            this.statisticalFunctionAppr.Name = "statisticalFunctionAppr";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.statisticalFunctionAppr.Series.Add(series3);
            this.statisticalFunctionAppr.Size = new System.Drawing.Size(564, 300);
            this.statisticalFunctionAppr.TabIndex = 25;
            this.statisticalFunctionAppr.Text = "chart2";
            // 
            // frequencyHistogramAppr
            // 
            chartArea4.Name = "ChartArea1";
            this.frequencyHistogramAppr.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.frequencyHistogramAppr.Legends.Add(legend4);
            this.frequencyHistogramAppr.Location = new System.Drawing.Point(613, 82);
            this.frequencyHistogramAppr.Name = "frequencyHistogramAppr";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.frequencyHistogramAppr.Series.Add(series4);
            this.frequencyHistogramAppr.Size = new System.Drawing.Size(564, 300);
            this.frequencyHistogramAppr.TabIndex = 24;
            this.frequencyHistogramAppr.Text = "chart1";
            // 
            // generatedValuesApprListBox
            // 
            this.generatedValuesApprListBox.FormattingEnabled = true;
            this.generatedValuesApprListBox.ItemHeight = 16;
            this.generatedValuesApprListBox.Location = new System.Drawing.Point(1645, 347);
            this.generatedValuesApprListBox.Name = "generatedValuesApprListBox";
            this.generatedValuesApprListBox.Size = new System.Drawing.Size(202, 388);
            this.generatedValuesApprListBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1443, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Центр. пред. теор.";
            // 
            // pAppr
            // 
            this.pAppr.AutoSize = true;
            this.pAppr.Location = new System.Drawing.Point(1642, 285);
            this.pAppr.Name = "pAppr";
            this.pAppr.Size = new System.Drawing.Size(0, 17);
            this.pAppr.TabIndex = 32;
            // 
            // lambdaAppr
            // 
            this.lambdaAppr.AutoSize = true;
            this.lambdaAppr.Location = new System.Drawing.Point(1639, 244);
            this.lambdaAppr.Name = "lambdaAppr";
            this.lambdaAppr.Size = new System.Drawing.Size(0, 17);
            this.lambdaAppr.TabIndex = 31;
            // 
            // dAppr
            // 
            this.dAppr.AutoSize = true;
            this.dAppr.Location = new System.Drawing.Point(1642, 210);
            this.dAppr.Name = "dAppr";
            this.dAppr.Size = new System.Drawing.Size(0, 17);
            this.dAppr.TabIndex = 30;
            // 
            // dispersionAppr
            // 
            this.dispersionAppr.AutoSize = true;
            this.dispersionAppr.Location = new System.Drawing.Point(1642, 114);
            this.dispersionAppr.Name = "dispersionAppr";
            this.dispersionAppr.Size = new System.Drawing.Size(0, 17);
            this.dispersionAppr.TabIndex = 29;
            // 
            // mathDelayAppr
            // 
            this.mathDelayAppr.AutoSize = true;
            this.mathDelayAppr.Location = new System.Drawing.Point(1642, 72);
            this.mathDelayAppr.Name = "mathDelayAppr";
            this.mathDelayAppr.Size = new System.Drawing.Size(0, 17);
            this.mathDelayAppr.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1627, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Аппроксимация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 763);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pAppr);
            this.Controls.Add(this.lambdaAppr);
            this.Controls.Add(this.dAppr);
            this.Controls.Add(this.dispersionAppr);
            this.Controls.Add(this.mathDelayAppr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.generatedValuesApprListBox);
            this.Controls.Add(this.statisticalFunctionAppr);
            this.Controls.Add(this.frequencyHistogramAppr);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.lambdaLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.splitIntervalsComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dispersionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mathDelayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statisticalDistributionFunction);
            this.Controls.Add(this.frequencyHistogram);
            this.Controls.Add(this.generatedValuesListBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.sampleSizeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.frequencyHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticalDistributionFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticalFunctionAppr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyHistogramAppr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sampleSizeTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ListBox generatedValuesListBox;

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart frequencyHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticalDistributionFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mathDelayLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dispersionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox splitIntervalsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label lambdaLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticalFunctionAppr;
        private System.Windows.Forms.DataVisualization.Charting.Chart frequencyHistogramAppr;
        private System.Windows.Forms.ListBox generatedValuesApprListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pAppr;
        private System.Windows.Forms.Label lambdaAppr;
        private System.Windows.Forms.Label dAppr;
        private System.Windows.Forms.Label dispersionAppr;
        private System.Windows.Forms.Label mathDelayAppr;
        private System.Windows.Forms.Label label15;
    }
}