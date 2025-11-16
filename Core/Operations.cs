// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: Operations.cs
// ========================================

using System;

namespace ScientificCalculator
{
    // Имплементира събирането.
    public class AdditionOperation : IOperation
    {
        public string OperationName => "Събиране";

        // Връща сумата на двете числа.
        public double Execute(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
    }

    // Имплементира изваждането.
    public class SubtractionOperation : IOperation
    {
        public string OperationName => "Изваждане";

        // Връща разликата между двете числа.
        public double Execute(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
    }

    // Имплементира умножението.
    public class MultiplicationOperation : IOperation
    {
        public string OperationName => "Умножение";

        // Връща произведението на аргументите.
        public double Execute(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
    }

    // Имплементира делението с проверка за нула.
    public class DivisionOperation : IOperation
    {
        public string OperationName => "Деление";

        // Изчислява частното и хвърля грешка при деление на нула.
        public double Execute(double operand1, double operand2)
        {
            if (operand2 == 0)
            {
                throw new DivideByZeroException("Грешка: Деление на нула!");
            }

            return operand1 / operand2;
        }
    }

    // Имплементира степенуването.
    public class PowerOperation : IOperation
    {
        public string OperationName => "Степенуване";

        // Връща резултата от operand1 ^ operand2.
        public double Execute(double operand1, double operand2)
        {
            return Math.Pow(operand1, operand2);
        }
    }
}


