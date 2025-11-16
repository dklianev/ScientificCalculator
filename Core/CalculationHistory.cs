// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: CalculationHistory.cs
// ========================================

using System;
using System.Collections;

namespace ScientificCalculator
{
    public class CalculationHistory : IHistoryManager
    {
        private ArrayList historyRecords;

        public event HistoryUpdateHandler OnHistoryUpdate;

        public CalculationHistory()
        {
            historyRecords = new ArrayList();
        }

        public void AddRecord(string record)
        {
            if (string.IsNullOrEmpty(record))
            {
                return;
            }

            string timestampedRecord = DateTime.Now.ToString("HH:mm:ss") + " - " + record;
            historyRecords.Add(timestampedRecord);
            OnHistoryUpdate?.Invoke(timestampedRecord);
        }

        public ArrayList GetHistory()
        {
            return (ArrayList)historyRecords.Clone();
        }

        public void ClearHistory()
        {
            historyRecords.Clear();
            OnHistoryUpdate?.Invoke("Историята е изчистена");
        }
    }
}
