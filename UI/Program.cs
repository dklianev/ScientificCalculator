// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: Program.cs
// ========================================

using System;
using System.Windows.Forms;

namespace ScientificCalculator
{
    // Основна входна точка на приложението.
    static class Program
    {
        [STAThread]
        // Настройва WinForms средата и стартира главната форма.
        static void Main()
        {
            // Активиране на визуалните стилове
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Стартиране на главната форма
            Application.Run(new MainForm());
        }
    }
}

