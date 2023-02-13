﻿namespace Lab1
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
            this.generatedNumbers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateNumbersButton = new System.Windows.Forms.Button();
            this.buildBarChartButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statisticFunctionButton = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calculateMathematicalExpectationButton = new System.Windows.Forms.Button();
            this.mathExcpectationLabel = new System.Windows.Forms.Label();
            this.calculateDispersionButton = new System.Windows.Forms.Button();
            this.dispersionLabel = new System.Windows.Forms.Label();
            this.calculateSecondInitialMomentButton = new System.Windows.Forms.Button();
            this.calculateThirdInitialMomentButton = new System.Windows.Forms.Button();
            this.secondInitialMomentLabel = new System.Windows.Forms.Label();
            this.thirdInitialMomentLabel = new System.Windows.Forms.Label();
            this.calculatePirsonsCritetionButton = new System.Windows.Forms.Button();
            this.pirsonsCriterionLabel = new System.Windows.Forms.Label();
            this.pirsonsCriterionStatusLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateKolmogorovCriterionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lambdaLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // generatedNumbers
            // 
            this.generatedNumbers.FormattingEnabled = true;
            this.generatedNumbers.ItemHeight = 16;
            this.generatedNumbers.Location = new System.Drawing.Point(54, 53);
            this.generatedNumbers.Name = "generatedNumbers";
            this.generatedNumbers.Size = new System.Drawing.Size(203, 276);
            this.generatedNumbers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сгенерированные значения";
            // 
            // generateNumbersButton
            // 
            this.generateNumbersButton.Location = new System.Drawing.Point(56, 354);
            this.generateNumbersButton.Name = "generateNumbersButton";
            this.generateNumbersButton.Size = new System.Drawing.Size(200, 49);
            this.generateNumbersButton.TabIndex = 2;
            this.generateNumbersButton.Text = "Сгенерировать";
            this.generateNumbersButton.UseVisualStyleBackColor = true;
            this.generateNumbersButton.Click += new System.EventHandler(this.generateNumbersButton_Click);
            // 
            // buildBarChartButton
            // 
            this.buildBarChartButton.Location = new System.Drawing.Point(303, 26);
            this.buildBarChartButton.Name = "buildBarChartButton";
            this.buildBarChartButton.Size = new System.Drawing.Size(194, 44);
            this.buildBarChartButton.TabIndex = 3;
            this.buildBarChartButton.Text = "Построить гистограмму";
            this.buildBarChartButton.UseVisualStyleBackColor = true;
            this.buildBarChartButton.Click += new System.EventHandler(this.buildBarChartButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(303, 90);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(816, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // statisticFunctionButton
            // 
            this.statisticFunctionButton.Location = new System.Drawing.Point(303, 438);
            this.statisticFunctionButton.Name = "statisticFunctionButton";
            this.statisticFunctionButton.Size = new System.Drawing.Size(194, 48);
            this.statisticFunctionButton.TabIndex = 5;
            this.statisticFunctionButton.Text = "Статистическая функция";
            this.statisticFunctionButton.UseVisualStyleBackColor = true;
            this.statisticFunctionButton.Click += new System.EventHandler(this.statisticFunctionButton_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(303, 505);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(816, 333);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // calculateMathematicalExpectationButton
            // 
            this.calculateMathematicalExpectationButton.Location = new System.Drawing.Point(1180, 90);
            this.calculateMathematicalExpectationButton.Name = "calculateMathematicalExpectationButton";
            this.calculateMathematicalExpectationButton.Size = new System.Drawing.Size(218, 50);
            this.calculateMathematicalExpectationButton.TabIndex = 7;
            this.calculateMathematicalExpectationButton.Text = "Математическое ожидание";
            this.calculateMathematicalExpectationButton.UseVisualStyleBackColor = true;
            this.calculateMathematicalExpectationButton.Click += new System.EventHandler(this.calculateMathematicalExpectationButton_Click);
            // 
            // mathExcpectationLabel
            // 
            this.mathExcpectationLabel.AutoSize = true;
            this.mathExcpectationLabel.Location = new System.Drawing.Point(1440, 107);
            this.mathExcpectationLabel.Name = "mathExcpectationLabel";
            this.mathExcpectationLabel.Size = new System.Drawing.Size(0, 17);
            this.mathExcpectationLabel.TabIndex = 8;
            // 
            // calculateDispersionButton
            // 
            this.calculateDispersionButton.Location = new System.Drawing.Point(1180, 178);
            this.calculateDispersionButton.Name = "calculateDispersionButton";
            this.calculateDispersionButton.Size = new System.Drawing.Size(218, 51);
            this.calculateDispersionButton.TabIndex = 9;
            this.calculateDispersionButton.Text = "Дисперсия";
            this.calculateDispersionButton.UseVisualStyleBackColor = true;
            this.calculateDispersionButton.Click += new System.EventHandler(this.calculateDispersionButton_Click);
            // 
            // dispersionLabel
            // 
            this.dispersionLabel.AutoSize = true;
            this.dispersionLabel.Location = new System.Drawing.Point(1440, 195);
            this.dispersionLabel.Name = "dispersionLabel";
            this.dispersionLabel.Size = new System.Drawing.Size(0, 17);
            this.dispersionLabel.TabIndex = 10;
            // 
            // calculateSecondInitialMomentButton
            // 
            this.calculateSecondInitialMomentButton.Location = new System.Drawing.Point(1180, 277);
            this.calculateSecondInitialMomentButton.Name = "calculateSecondInitialMomentButton";
            this.calculateSecondInitialMomentButton.Size = new System.Drawing.Size(218, 52);
            this.calculateSecondInitialMomentButton.TabIndex = 11;
            this.calculateSecondInitialMomentButton.Text = "Второй начальный момент";
            this.calculateSecondInitialMomentButton.UseVisualStyleBackColor = true;
            this.calculateSecondInitialMomentButton.Click += new System.EventHandler(this.calculateSecondInitialMomentButton_Click);
            // 
            // calculateThirdInitialMomentButton
            // 
            this.calculateThirdInitialMomentButton.Location = new System.Drawing.Point(1180, 380);
            this.calculateThirdInitialMomentButton.Name = "calculateThirdInitialMomentButton";
            this.calculateThirdInitialMomentButton.Size = new System.Drawing.Size(218, 50);
            this.calculateThirdInitialMomentButton.TabIndex = 12;
            this.calculateThirdInitialMomentButton.Text = "Третий начальный момент";
            this.calculateThirdInitialMomentButton.UseVisualStyleBackColor = true;
            this.calculateThirdInitialMomentButton.Click += new System.EventHandler(this.calculateThirdInitialMomentButton_Click);
            // 
            // secondInitialMomentLabel
            // 
            this.secondInitialMomentLabel.AutoSize = true;
            this.secondInitialMomentLabel.Location = new System.Drawing.Point(1440, 295);
            this.secondInitialMomentLabel.Name = "secondInitialMomentLabel";
            this.secondInitialMomentLabel.Size = new System.Drawing.Size(0, 17);
            this.secondInitialMomentLabel.TabIndex = 13;
            // 
            // thirdInitialMomentLabel
            // 
            this.thirdInitialMomentLabel.AutoSize = true;
            this.thirdInitialMomentLabel.Location = new System.Drawing.Point(1440, 397);
            this.thirdInitialMomentLabel.Name = "thirdInitialMomentLabel";
            this.thirdInitialMomentLabel.Size = new System.Drawing.Size(0, 17);
            this.thirdInitialMomentLabel.TabIndex = 14;
            // 
            // calculatePirsonsCritetionButton
            // 
            this.calculatePirsonsCritetionButton.Location = new System.Drawing.Point(1180, 489);
            this.calculatePirsonsCritetionButton.Name = "calculatePirsonsCritetionButton";
            this.calculatePirsonsCritetionButton.Size = new System.Drawing.Size(217, 58);
            this.calculatePirsonsCritetionButton.TabIndex = 15;
            this.calculatePirsonsCritetionButton.Text = "Критерий Пирсона";
            this.calculatePirsonsCritetionButton.UseVisualStyleBackColor = true;
            this.calculatePirsonsCritetionButton.Click += new System.EventHandler(this.calculatePirsonsCritetionButton_Click);
            // 
            // pirsonsCriterionLabel
            // 
            this.pirsonsCriterionLabel.AutoSize = true;
            this.pirsonsCriterionLabel.Location = new System.Drawing.Point(1440, 510);
            this.pirsonsCriterionLabel.Name = "pirsonsCriterionLabel";
            this.pirsonsCriterionLabel.Size = new System.Drawing.Size(0, 17);
            this.pirsonsCriterionLabel.TabIndex = 16;
            // 
            // pirsonsCriterionStatusLabel
            // 
            this.pirsonsCriterionStatusLabel.AutoSize = true;
            this.pirsonsCriterionStatusLabel.Location = new System.Drawing.Point(1440, 565);
            this.pirsonsCriterionStatusLabel.Name = "pirsonsCriterionStatusLabel";
            this.pirsonsCriterionStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.pirsonsCriterionStatusLabel.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0,99",
            "0,975",
            "0,95",
            "0,9",
            "0,8",
            "0,7",
            "0,6",
            "0,5",
            "0,4",
            "0,3"});
            this.comboBox1.Location = new System.Drawing.Point(1181, 590);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "0,7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1178, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Значение 1-a";
            // 
            // calculateKolmogorovCriterionButton
            // 
            this.calculateKolmogorovCriterionButton.Location = new System.Drawing.Point(1184, 659);
            this.calculateKolmogorovCriterionButton.Name = "calculateKolmogorovCriterionButton";
            this.calculateKolmogorovCriterionButton.Size = new System.Drawing.Size(213, 55);
            this.calculateKolmogorovCriterionButton.TabIndex = 20;
            this.calculateKolmogorovCriterionButton.Text = "Критерий Колмогорова";
            this.calculateKolmogorovCriterionButton.UseVisualStyleBackColor = true;
            this.calculateKolmogorovCriterionButton.Click += new System.EventHandler(this.calculateKolmogorovCriterionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1434, 697);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "D";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(1477, 697);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(0, 17);
            this.dLabel.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1398, 723);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "lambda";
            // 
            // lambdaLabel
            // 
            this.lambdaLabel.AutoSize = true;
            this.lambdaLabel.Location = new System.Drawing.Point(1477, 723);
            this.lambdaLabel.Name = "lambdaLabel";
            this.lambdaLabel.Size = new System.Drawing.Size(0, 17);
            this.lambdaLabel.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1379, 755);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "P(lambda)";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(1477, 755);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(0, 17);
            this.pLabel.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 863);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lambdaLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateKolmogorovCriterionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pirsonsCriterionStatusLabel);
            this.Controls.Add(this.pirsonsCriterionLabel);
            this.Controls.Add(this.calculatePirsonsCritetionButton);
            this.Controls.Add(this.thirdInitialMomentLabel);
            this.Controls.Add(this.secondInitialMomentLabel);
            this.Controls.Add(this.calculateThirdInitialMomentButton);
            this.Controls.Add(this.calculateSecondInitialMomentButton);
            this.Controls.Add(this.dispersionLabel);
            this.Controls.Add(this.calculateDispersionButton);
            this.Controls.Add(this.mathExcpectationLabel);
            this.Controls.Add(this.calculateMathematicalExpectationButton);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.statisticFunctionButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buildBarChartButton);
            this.Controls.Add(this.generateNumbersButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatedNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buildBarChartButton;

        private System.Windows.Forms.ListBox generatedNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateNumbersButton;

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button statisticFunctionButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button calculateMathematicalExpectationButton;
        private System.Windows.Forms.Label mathExcpectationLabel;
        private System.Windows.Forms.Button calculateDispersionButton;
        private System.Windows.Forms.Label dispersionLabel;
        private System.Windows.Forms.Button calculateSecondInitialMomentButton;
        private System.Windows.Forms.Button calculateThirdInitialMomentButton;
        private System.Windows.Forms.Label secondInitialMomentLabel;
        private System.Windows.Forms.Label thirdInitialMomentLabel;
        private System.Windows.Forms.Button calculatePirsonsCritetionButton;
        private System.Windows.Forms.Label pirsonsCriterionLabel;
        private System.Windows.Forms.Label pirsonsCriterionStatusLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateKolmogorovCriterionButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lambdaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pLabel;
    }
}