// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: Delegates.cs
// ========================================

using System;

namespace ScientificCalculator
{
    public delegate void DisplayUpdateHandler(string value);
    public delegate void HistoryUpdateHandler(string record);
    public delegate void MemoryChangedHandler(double memoryValue);
}
