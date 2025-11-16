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
    // Интерфейсът описва общия договор за всяка аритметична операция.
    public interface IOperation
    {
        // Изпълнява операцията върху двата аргумента и връща резултата.
        double Execute(double operand1, double operand2);
        // Връща удобно име, което може да се визуализира в UI.
        string OperationName { get; }
    }

    // Интерфейс за всички конвертори на мерни единици.
    public interface IConverter
    {
        // Преобразува стойност от една мерна единица в друга.
        double Convert(double value, string fromUnit, string toUnit);
    }

    // Интерфейсът описва управлението на историята.
    public interface IHistoryManager
    {
        // Добавя нов запис в историята.
        void AddRecord(string record);
        // Връща копие на наличните записи.
        ArrayList GetHistory();
        // Изчиства всички записи.
        void ClearHistory();
    }
}
