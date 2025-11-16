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

        public MainForm()
        {
            InitializeComponent();
            InitializeCalculator();
        }

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

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            firstOperand = 0;
            currentOperator = "";
            isNewCalculation = true;
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            isNewCalculation = true;
        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            txtDisplay.Text = FormatValue(-value);
        }

        // ===== НАУЧНИ ОПЕРАЦИИ =====

        private void BtnSin_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            double result = calculator.Sin(value);
            txtDisplay.Text = FormatValue(result);
            history.AddRecord("sin(" + FormatValue(value) + ") = " + FormatValue(result));
            isNewCalculation = true;
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            double result = calculator.Cos(value);
            txtDisplay.Text = FormatValue(result);
            history.AddRecord("cos(" + FormatValue(value) + ") = " + FormatValue(result));
            isNewCalculation = true;
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            double result = calculator.Tan(value);
            txtDisplay.Text = FormatValue(result);
            history.AddRecord("tan(" + FormatValue(value) + ") = " + FormatValue(result));
            isNewCalculation = true;
        }

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

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            double result = calculator.Square(value);
            txtDisplay.Text = FormatValue(result);
            history.AddRecord(FormatValue(value) + "² = " + FormatValue(result));
            isNewCalculation = true;
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            firstOperand = GetDisplayValue();
            currentOperator = "^";
            isNewCalculation = true;
        }

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

        private void BtnMemoryAdd_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            memory.MemoryAdd(value);
            history.AddRecord("M+ " + FormatValue(value));
        }

        private void BtnMemorySubtract_Click(object sender, EventArgs e)
        {
            double value = GetDisplayValue();
            memory.MemorySubtract(value);
            history.AddRecord("M- " + FormatValue(value));
        }

        private void BtnMemoryRecall_Click(object sender, EventArgs e)
        {
            double value = memory.MemoryRecall();
            txtDisplay.Text = FormatValue(value);
            isNewCalculation = true;
        }

        private void BtnMemoryClear_Click(object sender, EventArgs e)
        {
            memory.MemoryClear();
            history.AddRecord("MC");
        }

        // ===== КОНВЕРТОР =====

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

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            history.ClearHistory();
            lstHistory.Items.Clear();
        }

        // ===== HELPER МЕТОДИ =====

        private string FormatValue(double value)
        {
            double rounded = Math.Round(value, 10);
            return rounded.ToString("0.##########", CultureInfo.InvariantCulture);
        }

        private double GetDisplayValue()
        {
            string normalized = txtDisplay.Text.Replace(',', '.');
            return double.Parse(normalized, CultureInfo.InvariantCulture);
        }

        private void UpdateDisplay(string value)
        {
            txtDisplay.Text = value;
        }

        private void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtDisplay.Text = "0";
            isNewCalculation = true;
        }

        private void AddToHistoryList(string record)
        {
            lstHistory.Items.Insert(0, record);
        }

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

