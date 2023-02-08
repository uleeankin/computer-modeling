namespace Lab1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(303, 90);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
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
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(303, 505);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 863);
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
    }
}