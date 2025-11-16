// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: Interfaces.cs
// ========================================

using System;
using System.Collections;

namespace ScientificCalculator
{
    public interface IOperation
    {
        double Execute(double operand1, double operand2);
        string OperationName { get; }
    }

    public interface IConverter
    {
        double Convert(double value, string fromUnit, string toUnit);
    }

    public interface IHistoryManager
    {
        void AddRecord(string record);
        ArrayList GetHistory();
        void ClearHistory();
    }
}
