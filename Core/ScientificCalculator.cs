// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: ScientificCalculator.cs
// ========================================

using System;

namespace ScientificCalculator
{
    public class ScientificCalculator : Calculator
    {
        public ScientificCalculator() : base()
        {
        }

        public ScientificCalculator(double initialValue) : base(initialValue)
        {
        }

        public double Sin(double angle)
        {
            // Конвертиране от градуси в радиани
            double radians = angle * Math.PI / 180.0;
            return Math.Sin(radians);
        }

        public double Cos(double angle)
        {
            // Конвертиране от градуси в радиани
            double radians = angle * Math.PI / 180.0;
            return Math.Cos(radians);
        }

        public double Tan(double angle)
        {
            // Конвертиране от градуси в радиани
            double radians = angle * Math.PI / 180.0;
            return Math.Tan(radians);
        }

        public double SquareRoot(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Грешка: Корен от отрицателно число!");
            }
            return Math.Sqrt(value);
        }

        public double Square(double value)
        {
            return value * value;
        }

        public double Power(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }

        public double Log(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Грешка: Логаритъм може да се взема само от положителни числа!");
            }
            return Math.Log10(value);
        }

        public double Ln(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Грешка: Натурален логаритъм може да се взема само от положителни числа!");
            }
            return Math.Log(value);
        }
    }
}

