// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: Delegates.cs
// ========================================

using System;

namespace ScientificCalculator
{
    // Делегат за обновяване на дисплея, когато има нов резултат.
    public delegate void DisplayUpdateHandler(string value);
    // Делегат, който уведомява UI за нов запис в историята.
    public delegate void HistoryUpdateHandler(string record);
    // Делегат за известяване при промяна в стойността на паметта.
    public delegate void MemoryChangedHandler(double memoryValue);
}
