// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: Calculator.cs
// ========================================

using System;
using System.Collections;

namespace ScientificCalculator
{
    public class Calculator
    {
        private double currentValue;
        private double previousValue;
        private string currentOperation;
        private SortedList operations;

        public double CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        public double PreviousValue
        {
            get { return previousValue; }
            set { previousValue = value; }
        }

        public string CurrentOperation
        {
            get { return currentOperation; }
            set { currentOperation = value; }
        }

        public event DisplayUpdateHandler OnDisplayUpdate;

        public Calculator()
        {
            currentValue = 0;
            previousValue = 0;
            currentOperation = "";
            InitializeOperations();
        }

        public Calculator(double initialValue)
        {
            currentValue = initialValue;
            previousValue = 0;
            currentOperation = "";
            InitializeOperations();
        }

        public virtual void Clear()
        {
            currentValue = 0;
            previousValue = 0;
            currentOperation = "";
            OnDisplayUpdate?.Invoke("0");
        }

        public virtual double ExecuteOperation(double a, double b, string operation)
        {
            if (!operations.ContainsKey(operation))
            {
                throw new InvalidOperationException("Неизвестна операция!");
            }

            IOperation selectedOperation = (IOperation)operations[operation];
            return selectedOperation.Execute(a, b);
        }

        private void InitializeOperations()
        {
            operations = new SortedList();
            operations.Add("+", new AdditionOperation());
            operations.Add("-", new SubtractionOperation());
            operations.Add("*", new MultiplicationOperation());
            operations.Add("/", new DivisionOperation());
            operations.Add("^", new PowerOperation());
        }
    }
}
