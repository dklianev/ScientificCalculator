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
    // Управлява списъка с изчисленията, които се показват във формата.
    public class CalculationHistory : IHistoryManager
    {
        private ArrayList historyRecords;

        public event HistoryUpdateHandler OnHistoryUpdate;

        // Създава празна история.
        public CalculationHistory()
        {
            historyRecords = new ArrayList();
        }

        // Добавя запис с час и уведомява абонатите.
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

        // Връща копие на наличните записи.
        public ArrayList GetHistory()
        {
            return (ArrayList)historyRecords.Clone();
        }

        // Изчиства историята и уведомява UI.
        public void ClearHistory()
        {
            historyRecords.Clear();
            OnHistoryUpdate?.Invoke("Историята е изчистена");
        }
    }
}
