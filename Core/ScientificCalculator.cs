// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: ScientificCalculator.cs
// ========================================

using System;

namespace ScientificCalculator
{
    // Разширява базовия калкулатор с научни функции.
    public class ScientificCalculator : Calculator
    {
        // Конструктор по подразбиране.
        public ScientificCalculator() : base()
        {
        }

        // Позволява стартиране със зададена стойност.
        public ScientificCalculator(double initialValue) : base(initialValue)
        {
        }

        // Пресмята синус в градуси.
        public double Sin(double angle)
        {
            // Конвертиране от градуси в радиани
            double radians = angle * Math.PI / 180.0;
            return Math.Sin(radians);
        }

        // Пресмята косинус в градуси.
        public double Cos(double angle)
        {
            // Конвертиране от градуси в радиани
            double radians = angle * Math.PI / 180.0;
            return Math.Cos(radians);
        }

        // Пресмята тангенс в градуси.
        public double Tan(double angle)
        {
            // Конвертиране от градуси в радиани
            double radians = angle * Math.PI / 180.0;
            return Math.Tan(radians);
        }

        // Взема квадратен корен със защита за отрицателни стойности.
        public double SquareRoot(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Грешка: Корен от отрицателно число!");
            }
            return Math.Sqrt(value);
        }

        // Връща квадрата на подаденото число.
        public double Square(double value)
        {
            return value * value;
        }

        // Вдига число на степен.
        public double Power(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }

        // Изчислява десетичен логаритъм с проверка за положителни стойности.
        public double Log(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Грешка: Логаритъм може да се взема само от положителни числа!");
            }
            return Math.Log10(value);
        }

        // Изчислява натурален логаритъм с проверка за положителни стойности.
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

