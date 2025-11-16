// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: UnitConverter.cs
// ========================================

using System;

namespace ScientificCalculator
{
    public class UnitConverter : IConverter
    {
        private readonly string[] temperatureUnits;
        private readonly string[] lengthUnits;
        private readonly string[] weightUnits;

        public UnitConverter()
        {
            temperatureUnits = new string[] { "Celsius", "Fahrenheit", "Kelvin" };
            lengthUnits = new string[] { "Метри", "Километри", "Сантиметри", "Милиметри", "Мили", "Ярдове", "Футове", "Инчове" };
            weightUnits = new string[] { "Килограми", "Грамове", "Тонове", "Милиграми", "Фунтове", "Унции" };
        }

        public double Convert(double value, string fromUnit, string toUnit)
        {
            if (IsUnitOf(temperatureUnits, fromUnit) && IsUnitOf(temperatureUnits, toUnit))
            {
                return ConvertTemperature(value, fromUnit, toUnit);
            }

            if (IsUnitOf(lengthUnits, fromUnit) && IsUnitOf(lengthUnits, toUnit))
            {
                return ConvertLength(value, fromUnit, toUnit);
            }

            if (IsUnitOf(weightUnits, fromUnit) && IsUnitOf(weightUnits, toUnit))
            {
                return ConvertWeight(value, fromUnit, toUnit);
            }

            throw new ArgumentException("Неподдържани мерни единици");
        }

        private bool IsUnitOf(string[] units, string value)
        {
            return Array.IndexOf(units, value) >= 0;
        }

        private double ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            double celsius;

            if (fromUnit == "Celsius")
            {
                celsius = value;
            }
            else if (fromUnit == "Fahrenheit")
            {
                celsius = (value - 32) * 5 / 9;
            }
            else if (fromUnit == "Kelvin")
            {
                celsius = value - 273.15;
            }
            else
            {
                throw new ArgumentException("Непозната температурна единица");
            }

            if (toUnit == "Celsius")
            {
                return celsius;
            }
            else if (toUnit == "Fahrenheit")
            {
                return celsius * 9 / 5 + 32;
            }
            else if (toUnit == "Kelvin")
            {
                return celsius + 273.15;
            }

            throw new ArgumentException("Непозната температурна единица");
        }

        private double ConvertLength(double value, string fromUnit, string toUnit)
        {
            double meters = value * GetLengthFactor(fromUnit);
            return meters / GetLengthFactor(toUnit);
        }

        private double ConvertWeight(double value, string fromUnit, string toUnit)
        {
            double kilograms = value * GetWeightFactor(fromUnit);
            return kilograms / GetWeightFactor(toUnit);
        }

        private double GetLengthFactor(string unit)
        {
            switch (unit)
            {
                case "Метри": return 1.0;
                case "Километри": return 1000.0;
                case "Сантиметри": return 0.01;
                case "Милиметри": return 0.001;
                case "Мили": return 1609.34;
                case "Ярдове": return 0.9144;
                case "Футове": return 0.3048;
                case "Инчове": return 0.0254;
                default: throw new ArgumentException("Непозната единица за дължина");
            }
        }

        private double GetWeightFactor(string unit)
        {
            switch (unit)
            {
                case "Килограми": return 1.0;
                case "Грамове": return 0.001;
                case "Тонове": return 1000.0;
                case "Милиграми": return 0.000001;
                case "Фунтове": return 0.453592;
                case "Унции": return 0.0283495;
                default: throw new ArgumentException("Непозната единица за тегло");
            }
        }

        public string[] GetTemperatureUnits()
        {
            return (string[])temperatureUnits.Clone();
        }

        public string[] GetLengthUnits()
        {
            return (string[])lengthUnits.Clone();
        }

        public string[] GetWeightUnits()
        {
            return (string[])weightUnits.Clone();
        }
    }
}
