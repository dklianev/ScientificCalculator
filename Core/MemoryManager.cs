// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: MemoryManager.cs
// ========================================

using System;

namespace ScientificCalculator
{
    // Управлява стойността, записана в паметта на калкулатора.
    public class MemoryManager
    {
        // Private поле за стойността в паметта
        private double memoryValue;

        // Събитие за промяна в паметта
        public event MemoryChangedHandler OnMemoryChanged;

        public double MemoryValue
        {
            get { return memoryValue; }
        }

        // Нулира паметта при създаване.
        public MemoryManager()
        {
            memoryValue = 0;
        }

        // Добавя текущата стойност към паметта и известява UI.
        public void MemoryAdd(double value)
        {
            memoryValue += value;
            OnMemoryChanged?.Invoke(memoryValue);
        }

        // Изважда стойност от паметта.
        public void MemorySubtract(double value)
        {
            memoryValue -= value;
            OnMemoryChanged?.Invoke(memoryValue);
        }

        // Връща текущата стойност в паметта.
        public double MemoryRecall()
        {
            return memoryValue;
        }

        // Нулира паметта и уведомява UI.
        public void MemoryClear()
        {
            memoryValue = 0;
            OnMemoryChanged?.Invoke(memoryValue);
        }
    }
}