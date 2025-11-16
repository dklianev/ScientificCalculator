// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: MainForm.cs
// ========================================

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ScientificCalculator
{
    // Главната форма, която свързва потребителския интерфейс с логиката.
    public partial class MainForm : Form
    {
        // Private полета за компонентите на калкулатора
        private ScientificCalculator calculator;
        private CalculationHistory history;
        private MemoryManager memory;
        private UnitConverter converter;

        // Променливи за работа на калкулатора
        private bool isNewCalculation;
        private string currentOperator;
        private double firstOperand;

        // Конструкторът настройва формата и инициализира компонентите.
        public MainForm()
        {
            InitializeComponent();
            InitializeCalculator();
        }

        // Създава основните обекти и подготвя началното състояние.
        private void InitializeCalculator()
        {
            // Създаване на обектите
            calculator = new ScientificCalculator();
            history = new CalculationHistory();
            memory = new MemoryManager();
            converter = new UnitConverter();

            // Абониране за събитията
            calculator.OnDisplayUpdate += UpdateDisplay;
            history.OnHistoryUpdate += AddToHistoryList;
            memory.OnMemoryChanged += UpdateMemoryIndicator;

            // Инициализация на променливите
            isNewCalculation = true;
            currentOperator = "";
            firstOperand = 0;

            // Инициализация на ComboBox-овете за конвертора
            InitializeConverterUnits();
        }

        // Зарежда списъците с мерни единици в комбобоксовете.
        private void InitializeConverterUnits()
        {
            // Температура
            cmbFromUnitTemp.Items.AddRange(converter.GetTemperatureUnits());
            cmbToUnitTemp.Items.AddRange(converter.GetTemperatureUnits());

            // Дължина
            cmbFromUnitLength.Items.AddRange(converter.GetLengthUnits());
            cmbToUnitLength.Items.AddRange(converter.GetLengthUnits());

            // Тегло
            cmbFromUnitWeight.Items.AddRange(converter.GetWeightUnits());
            cmbToUnitWeight.Items.AddRange(converter.GetWeightUnits());

            // Избор на стойности по подразбиране
            if (cmbFromUnitTemp.Items.Count > 0) cmbFromUnitTemp.SelectedIndex = 0;
            if (cmbToUnitTemp.Items.Count > 0) cmbToUnitTemp.SelectedIndex = 1;
            if (cmbFromUnitLength.Items.Count > 0) cmbFromUnitLength.SelectedIndex = 0;
            if (cmbToUnitLength.Items.Count > 0) cmbToUnitLength.SelectedIndex = 1;
            if (cmbFromUnitWeight.Items.Count > 0) cmbFromUnitWeight.SelectedIndex = 0;
            if (cmbToUnitWeight.Items.Count > 0) cmbToUnitWeight.SelectedIndex = 1;
        }

        // Обработва натискането на номер и го добавя към дисплея.
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (isNewCalculation || txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
                isNewCalculation = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        // Добавя десетична точка към текущия вход.
        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (isNewCalculation)
            {
                txtDisplay.Text = "0.";
                isNewCalculation = false;
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        // Запазва състоянието при избор на оператор (+, -, *, /, ^).
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (currentOperator != "" && !isNewCalculation)
            {
                CalculateResult();
            }
            
            firstOperand = GetDisplayValue();
            currentOperator = btn.Text;
            isNewCalculation = true;
        }

        // Изчислява резултата при натиснато "=".
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

        // Извършва текущо избраната операция и обновява историята.
        private void CalculateResult()
        {
            if (currentOperator == "")
            {
                return;
            }

            double secondOperand = GetDisplayValue();
            double result = 0;

            try
            {
                result = calculator.ExecuteOperation(firstOperand, secondOperand, currentOperator);
                
                // Добавяне в историята
                string record = FormatValue(firstOperand) + " " + currentOperator + " " + FormatValue(secondOperand) + " = " + FormatValue(result);
                history.AddRecord(record);
                
                // Показване на резултата
                txtDisplay.Text = FormatValue(result);
                isNewCalculation = true;
                currentOperator = "";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Нулира калкулатора и дисплея.
        private void BtnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            firstOperand = 0;
            currentOperator = "";
            isNewCalculation = true;
        }

        // Изчиства само текущия вход.
        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            isNewCalculation = true;
        }

        // Смяна на знака на текущата стойност.
        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            txtDisplay.Text = FormatValue(-value);
        }

        // ===== НАУЧНИ ОПЕРАЦИИ =====

        // Пресмята синуса на текущата стойност (в градуси).
        private void BtnSin_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            double result = calculator.Sin(value);
            txtDisplay.Text = FormatValue(result);
            history.AddRecord("sin(" + FormatValue(value) + ") = " + FormatValue(result));
            isNewCalculation = true;
        }

        // Пресмята косинуса на текущата стойност.
        private void BtnCos_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            double result = calculator.Cos(value);
            txtDisplay.Text = FormatValue(result);
            history.AddRecord("cos(" + FormatValue(value) + ") = " + FormatValue(result));
            isNewCalculation = true;
        }

        // Пресмята тангенса на текущата стойност.
        private void BtnTan_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            double result = calculator.Tan(value);
            txtDisplay.Text = FormatValue(result);
            history.AddRecord("tan(" + FormatValue(value) + ") = " + FormatValue(result));
            isNewCalculation = true;
        }

        // Пресмята квадратен корен с обработка на грешки.
        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double value = GetDisplayValue();
                double result = calculator.SquareRoot(value);
                txtDisplay.Text = FormatValue(result);
                history.AddRecord("√(" + FormatValue(value) + ") = " + FormatValue(result));
                isNewCalculation = true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Вдига стойността на квадрат.
        private void BtnSquare_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            double result = calculator.Square(value);
            txtDisplay.Text = FormatValue(result);
            history.AddRecord(FormatValue(value) + "² = " + FormatValue(result));
            isNewCalculation = true;
        }

        // Подготвя калкулатора за операция x^y.
        private void BtnPower_Click(object sender, EventArgs e)
        {
            firstOperand = GetDisplayValue();
            currentOperator = "^";
            isNewCalculation = true;
        }

        // Пресмята десетичния логаритъм на стойността.
        private void BtnLog_Click(object sender, EventArgs e)
        {
            try
            {
                double value = GetDisplayValue();
                double result = calculator.Log(value);
                txtDisplay.Text = FormatValue(result);
                history.AddRecord("log(" + FormatValue(value) + ") = " + FormatValue(result));
                isNewCalculation = true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Пресмята натуралния логаритъм на стойността.
        private void BtnLn_Click(object sender, EventArgs e)
        {
            try
            {
                double value = GetDisplayValue();
                double result = calculator.Ln(value);
                txtDisplay.Text = FormatValue(result);
                history.AddRecord("ln(" + FormatValue(value) + ") = " + FormatValue(result));
                isNewCalculation = true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // ===== ПАМЕТ =====

        // Добавя текущата стойност в паметта (M+).
        private void BtnMemoryAdd_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            memory.MemoryAdd(value);
            history.AddRecord("M+ " + FormatValue(value));
        }

        // Изважда стойността от паметта (M-).
        private void BtnMemorySubtract_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            memory.MemorySubtract(value);
            history.AddRecord("M- " + FormatValue(value));
        }

        // Визуализира записаната стойност (MR).
        private void BtnMemoryRecall_Click(object sender, EventArgs e)
        {
            double value = memory.MemoryRecall();
            txtDisplay.Text = FormatValue(value);
            isNewCalculation = true;
        }

        // Нулира паметта (MC).
        private void BtnMemoryClear_Click(object sender, EventArgs e)
        {
            memory.MemoryClear();
            history.AddRecord("MC");
        }

        // ===== КОНВЕРТОР =====

        // Конвертира температура между избраните единици.
        private void BtnConvertTemp_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(txtTempInput.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                string fromUnit = cmbFromUnitTemp.SelectedItem.ToString();
                string toUnit = cmbToUnitTemp.SelectedItem.ToString();
                
                double result = converter.Convert(value, fromUnit, toUnit);
                string formattedResult = result.ToString("F2", CultureInfo.InvariantCulture);
                txtTempResult.Text = formattedResult;
                
                history.AddRecord(FormatValue(value) + " " + fromUnit + " = " + formattedResult + " " + toUnit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при конвертиране: " + ex.Message, "Грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Конвертира дължина между избраните единици.
        private void BtnConvertLength_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(txtLengthInput.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                string fromUnit = cmbFromUnitLength.SelectedItem.ToString();
                string toUnit = cmbToUnitLength.SelectedItem.ToString();
                
                double result = converter.Convert(value, fromUnit, toUnit);
                string formattedResult = result.ToString("F4", CultureInfo.InvariantCulture);
                txtLengthResult.Text = formattedResult;
                
                history.AddRecord(FormatValue(value) + " " + fromUnit + " = " + formattedResult + " " + toUnit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при конвертиране: " + ex.Message, "Грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Конвертира тегло между избраните единици.
        private void BtnConvertWeight_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(txtWeightInput.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                string fromUnit = cmbFromUnitWeight.SelectedItem.ToString();
                string toUnit = cmbToUnitWeight.SelectedItem.ToString();
                
                double result = converter.Convert(value, fromUnit, toUnit);
                string formattedResult = result.ToString("F4", CultureInfo.InvariantCulture);
                txtWeightResult.Text = formattedResult;
                
                history.AddRecord(FormatValue(value) + " " + fromUnit + " = " + formattedResult + " " + toUnit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при конвертиране: " + ex.Message, "Грешка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Изчиства визуалната история в списъка.
        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            history.ClearHistory();
            lstHistory.Items.Clear();
        }

        // ===== HELPER МЕТОДИ =====

        // Форматира числата така, че да изглеждат еднакво в UI.
        private string FormatValue(double value)
        {
            double rounded = Math.Round(value, 10);
            return rounded.ToString("0.##########", CultureInfo.InvariantCulture);
        }

        // Чете стойността от дисплея и я превръща към double.
        private double GetDisplayValue()
        {
            string normalized = txtDisplay.Text.Replace(',', '.');
            return double.Parse(normalized, CultureInfo.InvariantCulture);
        }

        // Обновява съдържанието на дисплея при събитие.
        private void UpdateDisplay(string value)
        {
            txtDisplay.Text = value;
        }

        // Показва съобщение за грешка и нулира дисплея.
        private void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtDisplay.Text = "0";
            isNewCalculation = true;
        }

        // Добавя отримания запис към визуалния списък.
        private void AddToHistoryList(string record)
        {
            lstHistory.Items.Insert(0, record);
        }

        // Показва или скрива индикатора за памет според стойността.
        private void UpdateMemoryIndicator(double memoryValue)
        {
            if (memoryValue != 0)
            {
                lblMemoryIndicator.Text = "M: " + FormatValue(memoryValue);
                lblMemoryIndicator.Visible = true;
            }
            else
            {
                lblMemoryIndicator.Visible = false;
            }
        }
    }
}

