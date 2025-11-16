// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: Operations.cs
// ========================================

using System;

namespace ScientificCalculator
{
    public class AdditionOperation : IOperation
    {
        public string OperationName => "Събиране";

        public double Execute(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
    }

    public class SubtractionOperation : IOperation
    {
        public string OperationName => "Изваждане";

        public double Execute(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
    }

    public class MultiplicationOperation : IOperation
    {
        public string OperationName => "Умножение";

        public double Execute(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
    }

    public class DivisionOperation : IOperation
    {
        public string OperationName => "Деление";

        public double Execute(double operand1, double operand2)
        {
            if (operand2 == 0)
            {
                throw new DivideByZeroException("Грешка: Деление на нула!");
            }

            return operand1 / operand2;
        }
    }

    public class PowerOperation : IOperation
    {
        public string OperationName => "Степенуване";

        public double Execute(double operand1, double operand2)
        {
            return Math.Pow(operand1, operand2);
        }
    }
}


