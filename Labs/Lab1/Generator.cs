using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Generator
    {
        // Количество случайных чисел, нужных для получения нового случайного числа
        private const int R = 8;
        private List<double> randomNumbers = new List<double>();

        public Generator()
        {
            InitRandomNumbers();
        }

        private void InitRandomNumbers()
        {
            Random random = new Random();
            
            for (int i = 0; i < R; i++)
            {
                randomNumbers.Add(random.NextDouble());
            }
        }

        public double Random()
        {
            double number = 0;

            for (int i = 0; i < R; i++)
            {
                number += randomNumbers[i];
            }

            for (int i = 1; i < R; i++)
            {
                randomNumbers[i - 1] = randomNumbers[i];
            }

            number -= Math.Truncate(number);
            randomNumbers[R - 1] = number;

            return number;
        }
    }
}