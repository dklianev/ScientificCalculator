// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: MemoryManager.cs
// ========================================

using System;

namespace ScientificCalculator
{
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

        public MemoryManager()
        {
            memoryValue = 0;
        }

        public void MemoryAdd(double value)
        {
            memoryValue += value;
            OnMemoryChanged?.Invoke(memoryValue);
        }

        public void MemorySubtract(double value)
        {
            memoryValue -= value;
            OnMemoryChanged?.Invoke(memoryValue);
        }

        public double MemoryRecall()
        {
            return memoryValue;
        }

        public void MemoryClear()
        {
            memoryValue = 0;
            OnMemoryChanged?.Invoke(memoryValue);
        }
    }
}

