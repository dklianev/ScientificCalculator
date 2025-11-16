// ========================================
// Автор: Димитър Клянев
// Факултетен номер: F112194
// Проект: Научен Калкулатор
// Файл: MainForm.Designer.cs
// ========================================

using System.Drawing;
using System.Windows.Forms;

namespace ScientificCalculator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Дисплей
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblMemoryIndicator = new System.Windows.Forms.Label();

            // Цифрови бутони
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();

            // Операционни бутони
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();

            // Научни функции
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();

            // Памет
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.btnMemorySubtract = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();

            // История
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();

            // Конвертор - TabControl
            this.tabConverter = new System.Windows.Forms.TabControl();
            this.tabTemp = new System.Windows.Forms.TabPage();
            this.tabLength = new System.Windows.Forms.TabPage();
            this.tabWeight = new System.Windows.Forms.TabPage();

            // Температура
            this.lblTempFrom = new System.Windows.Forms.Label();
            this.txtTempInput = new System.Windows.Forms.TextBox();
            this.cmbFromUnitTemp = new System.Windows.Forms.ComboBox();
            this.lblTempTo = new System.Windows.Forms.Label();
            this.txtTempResult = new System.Windows.Forms.TextBox();
            this.cmbToUnitTemp = new System.Windows.Forms.ComboBox();
            this.btnConvertTemp = new System.Windows.Forms.Button();

            // Дължина
            this.lblLengthFrom = new System.Windows.Forms.Label();
            this.txtLengthInput = new System.Windows.Forms.TextBox();
            this.cmbFromUnitLength = new System.Windows.Forms.ComboBox();
            this.lblLengthTo = new System.Windows.Forms.Label();
            this.txtLengthResult = new System.Windows.Forms.TextBox();
            this.cmbToUnitLength = new System.Windows.Forms.ComboBox();
            this.btnConvertLength = new System.Windows.Forms.Button();

            // Тегло
            this.lblWeightFrom = new System.Windows.Forms.Label();
            this.txtWeightInput = new System.Windows.Forms.TextBox();
            this.cmbFromUnitWeight = new System.Windows.Forms.ComboBox();
            this.lblWeightTo = new System.Windows.Forms.Label();
            this.txtWeightResult = new System.Windows.Forms.TextBox();
            this.cmbToUnitWeight = new System.Windows.Forms.ComboBox();
            this.btnConvertWeight = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.txtDisplay.Location = new System.Drawing.Point(15, 15);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(480, 50);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.BackColor = System.Drawing.Color.White;

            // 
            // MemoryIndicator
            // 
            this.lblMemoryIndicator.AutoSize = true;
            this.lblMemoryIndicator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMemoryIndicator.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMemoryIndicator.Location = new System.Drawing.Point(15, 70);
            this.lblMemoryIndicator.Name = "lblMemoryIndicator";
            this.lblMemoryIndicator.Size = new System.Drawing.Size(50, 20);
            this.lblMemoryIndicator.TabIndex = 1;
            this.lblMemoryIndicator.Text = "M: 0";
            this.lblMemoryIndicator.Visible = false;

            // Цифрови бутони - разположение
            int btnSize = 70;
            int startX = 15;
            int startY = 100;
            int spacing = 8;

            // Ред 1: 7, 8, 9
            this.btn7.Location = new Point(startX, startY);
            this.btn7.Size = new Size(btnSize, btnSize);
            this.btn7.Text = "7";
            this.btn7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.FlatStyle = FlatStyle.Flat;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn7.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn8.Location = new Point(startX + btnSize + spacing, startY);
            this.btn8.Size = new Size(btnSize, btnSize);
            this.btn8.Text = "8";
            this.btn8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.FlatStyle = FlatStyle.Flat;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn8.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn9.Location = new Point(startX + (btnSize + spacing) * 2, startY);
            this.btn9.Size = new Size(btnSize, btnSize);
            this.btn9.Text = "9";
            this.btn9.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.FlatStyle = FlatStyle.Flat;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn9.Click += new System.EventHandler(this.NumberButton_Click);

            // Ред 2: 4, 5, 6
            this.btn4.Location = new Point(startX, startY + btnSize + spacing);
            this.btn4.Size = new Size(btnSize, btnSize);
            this.btn4.Text = "4";
            this.btn4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.FlatStyle = FlatStyle.Flat;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn4.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn5.Location = new Point(startX + btnSize + spacing, startY + btnSize + spacing);
            this.btn5.Size = new Size(btnSize, btnSize);
            this.btn5.Text = "5";
            this.btn5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.FlatStyle = FlatStyle.Flat;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn5.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn6.Location = new Point(startX + (btnSize + spacing) * 2, startY + btnSize + spacing);
            this.btn6.Size = new Size(btnSize, btnSize);
            this.btn6.Text = "6";
            this.btn6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.FlatStyle = FlatStyle.Flat;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn6.Click += new System.EventHandler(this.NumberButton_Click);

            // Ред 3: 1, 2, 3
            this.btn1.Location = new Point(startX, startY + (btnSize + spacing) * 2);
            this.btn1.Size = new Size(btnSize, btnSize);
            this.btn1.Text = "1";
            this.btn1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.FlatStyle = FlatStyle.Flat;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn1.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn2.Location = new Point(startX + btnSize + spacing, startY + (btnSize + spacing) * 2);
            this.btn2.Size = new Size(btnSize, btnSize);
            this.btn2.Text = "2";
            this.btn2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.FlatStyle = FlatStyle.Flat;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn2.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn3.Location = new Point(startX + (btnSize + spacing) * 2, startY + (btnSize + spacing) * 2);
            this.btn3.Size = new Size(btnSize, btnSize);
            this.btn3.Text = "3";
            this.btn3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.FlatStyle = FlatStyle.Flat;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn3.Click += new System.EventHandler(this.NumberButton_Click);

            // Ред 4: 0, ., +/-
            this.btn0.Location = new Point(startX, startY + (btnSize + spacing) * 3);
            this.btn0.Size = new Size(btnSize, btnSize);
            this.btn0.Text = "0";
            this.btn0.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btn0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.FlatStyle = FlatStyle.Flat;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn0.Click += new System.EventHandler(this.NumberButton_Click);

            this.btnDecimal.Location = new Point(startX + btnSize + spacing, startY + (btnSize + spacing) * 3);
            this.btnDecimal.Size = new Size(btnSize, btnSize);
            this.btnDecimal.Text = ".";
            this.btnDecimal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.btnDecimal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecimal.FlatStyle = FlatStyle.Flat;
            this.btnDecimal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);

            this.btnPlusMinus.Location = new Point(startX + (btnSize + spacing) * 2, startY + (btnSize + spacing) * 3);
            this.btnPlusMinus.Size = new Size(btnSize, btnSize);
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnPlusMinus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlusMinus.FlatStyle = FlatStyle.Flat;
            this.btnPlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPlusMinus.Click += new System.EventHandler(this.BtnPlusMinus_Click);

            // Операционни бутони - дясна колона
            int opX = startX + (btnSize + spacing) * 3;

            this.btnDivide.Location = new Point(opX, startY);
            this.btnDivide.Size = new Size(btnSize, btnSize);
            this.btnDivide.Text = "/";
            this.btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.btnDivide.BackColor = Color.FromArgb(173, 216, 230);
            this.btnDivide.FlatStyle = FlatStyle.Flat;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDivide.Click += new System.EventHandler(this.OperatorButton_Click);

            this.btnMultiply.Location = new Point(opX, startY + btnSize + spacing);
            this.btnMultiply.Size = new Size(btnSize, btnSize);
            this.btnMultiply.Text = "*";
            this.btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.btnMultiply.BackColor = Color.FromArgb(173, 216, 230);
            this.btnMultiply.FlatStyle = FlatStyle.Flat;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorButton_Click);

            this.btnSubtract.Location = new Point(opX, startY + (btnSize + spacing) * 2);
            this.btnSubtract.Size = new Size(btnSize, btnSize);
            this.btnSubtract.Text = "-";
            this.btnSubtract.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.btnSubtract.BackColor = Color.FromArgb(173, 216, 230);
            this.btnSubtract.FlatStyle = FlatStyle.Flat;
            this.btnSubtract.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSubtract.Click += new System.EventHandler(this.OperatorButton_Click);

            this.btnAdd.Location = new Point(opX, startY + (btnSize + spacing) * 3);
            this.btnAdd.Size = new Size(btnSize, btnSize);
            this.btnAdd.Text = "+";
            this.btnAdd.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.btnAdd.BackColor = Color.FromArgb(173, 216, 230);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Click += new System.EventHandler(this.OperatorButton_Click);

            this.btnEquals.Location = new Point(opX, startY + (btnSize + spacing) * 4);
            this.btnEquals.Size = new Size(btnSize, btnSize);
            this.btnEquals.Text = "=";
            this.btnEquals.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.btnEquals.BackColor = Color.FromArgb(144, 238, 144);
            this.btnEquals.FlatStyle = FlatStyle.Flat;
            this.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnEquals.Click += new System.EventHandler(this.BtnEquals_Click);

            // Clear бутони - горе
            this.btnClear.Location = new Point(opX + btnSize + spacing, startY);
            this.btnClear.Size = new Size(btnSize, btnSize);
            this.btnClear.Text = "C";
            this.btnClear.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btnClear.BackColor = Color.FromArgb(240, 128, 128);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            this.btnClearEntry.Location = new Point(opX + btnSize + spacing, startY + btnSize + spacing);
            this.btnClearEntry.Size = new Size(btnSize, btnSize);
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnClearEntry.BackColor = Color.FromArgb(240, 128, 128);
            this.btnClearEntry.FlatStyle = FlatStyle.Flat;
            this.btnClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClearEntry.ForeColor = Color.White;
            this.btnClearEntry.Click += new System.EventHandler(this.BtnClearEntry_Click);

            // Научни функции
            int sciX = opX + btnSize + spacing;
            int sciY = startY + (btnSize + spacing) * 2;
            int sciSpacing = 6;
            int sciHeight = 45;

            this.btnSin.Location = new Point(sciX, sciY);
            this.btnSin.Size = new Size(btnSize, sciHeight);
            this.btnSin.Text = "sin";
            this.btnSin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSin.BackColor = Color.FromArgb(255, 255, 224);
            this.btnSin.FlatStyle = FlatStyle.Flat;
            this.btnSin.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnSin.Click += new System.EventHandler(this.BtnSin_Click);

            this.btnCos.Location = new Point(sciX, sciY + sciHeight + sciSpacing);
            this.btnCos.Size = new Size(btnSize, sciHeight);
            this.btnCos.Text = "cos";
            this.btnCos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCos.BackColor = Color.FromArgb(255, 255, 224);
            this.btnCos.FlatStyle = FlatStyle.Flat;
            this.btnCos.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnCos.Click += new System.EventHandler(this.BtnCos_Click);

            this.btnTan.Location = new Point(sciX, sciY + (sciHeight + sciSpacing) * 2);
            this.btnTan.Size = new Size(btnSize, sciHeight);
            this.btnTan.Text = "tan";
            this.btnTan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnTan.BackColor = Color.FromArgb(255, 255, 224);
            this.btnTan.FlatStyle = FlatStyle.Flat;
            this.btnTan.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnTan.Click += new System.EventHandler(this.BtnTan_Click);

            int sci2X = sciX + btnSize + spacing;

            this.btnSqrt.Location = new Point(sci2X, sciY);
            this.btnSqrt.Size = new Size(btnSize, sciHeight);
            this.btnSqrt.Text = "√";
            this.btnSqrt.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.btnSqrt.BackColor = Color.FromArgb(255, 255, 224);
            this.btnSqrt.FlatStyle = FlatStyle.Flat;
            this.btnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);

            this.btnSquare.Location = new Point(sci2X, sciY + sciHeight + sciSpacing);
            this.btnSquare.Size = new Size(btnSize, sciHeight);
            this.btnSquare.Text = "x²";
            this.btnSquare.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSquare.BackColor = Color.FromArgb(255, 255, 224);
            this.btnSquare.FlatStyle = FlatStyle.Flat;
            this.btnSquare.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnSquare.Click += new System.EventHandler(this.BtnSquare_Click);

            this.btnPower.Location = new Point(sci2X, sciY + (sciHeight + sciSpacing) * 2);
            this.btnPower.Size = new Size(btnSize, sciHeight);
            this.btnPower.Text = "x^y";
            this.btnPower.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnPower.BackColor = Color.FromArgb(255, 255, 224);
            this.btnPower.FlatStyle = FlatStyle.Flat;
            this.btnPower.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnPower.Click += new System.EventHandler(this.BtnPower_Click);

            this.btnLog.Location = new Point(sciX, sciY + (sciHeight + sciSpacing) * 3);
            this.btnLog.Size = new Size(btnSize, sciHeight);
            this.btnLog.Text = "log";
            this.btnLog.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnLog.BackColor = Color.FromArgb(255, 255, 224);
            this.btnLog.FlatStyle = FlatStyle.Flat;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);

            this.btnLn.Location = new Point(sci2X, sciY + (sciHeight + sciSpacing) * 3);
            this.btnLn.Size = new Size(btnSize, sciHeight);
            this.btnLn.Text = "ln";
            this.btnLn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnLn.BackColor = Color.FromArgb(255, 255, 224);
            this.btnLn.FlatStyle = FlatStyle.Flat;
            this.btnLn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnLn.Click += new System.EventHandler(this.BtnLn_Click);

            // Памет бутони
            int memY = startY + (btnSize + spacing) * 4;
            int memRowSpacing = 6;
            int memY2 = memY + 45 + memRowSpacing;

            this.btnMemoryAdd.Location = new Point(startX, memY);
            this.btnMemoryAdd.Size = new Size(btnSize, 45);
            this.btnMemoryAdd.Text = "M+";
            this.btnMemoryAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnMemoryAdd.BackColor = Color.FromArgb(211, 211, 211);
            this.btnMemoryAdd.FlatStyle = FlatStyle.Flat;
            this.btnMemoryAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMemoryAdd.Click += new System.EventHandler(this.BtnMemoryAdd_Click);

            this.btnMemorySubtract.Location = new Point(startX + btnSize + spacing, memY);
            this.btnMemorySubtract.Size = new Size(btnSize, 45);
            this.btnMemorySubtract.Text = "M-";
            this.btnMemorySubtract.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnMemorySubtract.BackColor = Color.FromArgb(211, 211, 211);
            this.btnMemorySubtract.FlatStyle = FlatStyle.Flat;
            this.btnMemorySubtract.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMemorySubtract.Click += new System.EventHandler(this.BtnMemorySubtract_Click);

            this.btnMemoryRecall.Location = new Point(startX + (btnSize + spacing) * 2, memY);
            this.btnMemoryRecall.Size = new Size(btnSize, 45);
            this.btnMemoryRecall.Text = "MR";
            this.btnMemoryRecall.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnMemoryRecall.BackColor = Color.FromArgb(211, 211, 211);
            this.btnMemoryRecall.FlatStyle = FlatStyle.Flat;
            this.btnMemoryRecall.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMemoryRecall.Click += new System.EventHandler(this.BtnMemoryRecall_Click);

            this.btnMemoryClear.Location = new Point(startX + (btnSize + spacing) * 2, memY2);
            this.btnMemoryClear.Size = new Size(btnSize, 45);
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnMemoryClear.BackColor = Color.FromArgb(211, 211, 211);
            this.btnMemoryClear.FlatStyle = FlatStyle.Flat;
            this.btnMemoryClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMemoryClear.Click += new System.EventHandler(this.BtnMemoryClear_Click);

            // История
            int histX = 525;
            int histY = 15;

            this.lblHistory.Location = new Point(histX, histY);
            this.lblHistory.Size = new Size(260, 25);
            this.lblHistory.Text = "История:";
            this.lblHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblHistory.ForeColor = Color.DarkBlue;

            this.lstHistory.Location = new Point(histX, histY + 30);
            this.lstHistory.Size = new Size(260, 210);
            this.lstHistory.Font = new Font("Segoe UI", 9F);
            this.lstHistory.BackColor = Color.FromArgb(250, 250, 250);

            this.btnClearHistory.Location = new Point(histX, histY + 245);
            this.btnClearHistory.Size = new Size(260, 30);
            this.btnClearHistory.Text = "Изчисти историята";
            this.btnClearHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnClearHistory.BackColor = Color.FromArgb(240, 128, 128);
            this.btnClearHistory.ForeColor = Color.White;
            this.btnClearHistory.FlatStyle = FlatStyle.Flat;
            this.btnClearHistory.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);

            // TabControl за конвертор
            this.tabConverter.Location = new Point(525, 285);
            this.tabConverter.Size = new Size(260, 295);
            this.tabConverter.Font = new Font("Segoe UI", 9F);

            this.tabTemp.Text = "Температура";
            this.tabLength.Text = "Дължина";
            this.tabWeight.Text = "Тегло";

            this.tabConverter.Controls.Add(this.tabTemp);
            this.tabConverter.Controls.Add(this.tabLength);
            this.tabConverter.Controls.Add(this.tabWeight);

            // Температура таб
            this.lblTempFrom.Location = new Point(10, 15);
            this.lblTempFrom.Size = new Size(50, 20);
            this.lblTempFrom.Text = "От:";

            this.txtTempInput.Location = new Point(10, 35);
            this.txtTempInput.Size = new Size(220, 20);

            this.cmbFromUnitTemp.Location = new Point(10, 60);
            this.cmbFromUnitTemp.Size = new Size(220, 20);
            this.cmbFromUnitTemp.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lblTempTo.Location = new Point(10, 90);
            this.lblTempTo.Size = new Size(50, 20);
            this.lblTempTo.Text = "До:";

            this.txtTempResult.Location = new Point(10, 110);
            this.txtTempResult.Size = new Size(220, 20);
            this.txtTempResult.ReadOnly = true;

            this.cmbToUnitTemp.Location = new Point(10, 135);
            this.cmbToUnitTemp.Size = new Size(220, 20);
            this.cmbToUnitTemp.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnConvertTemp.Location = new Point(10, 165);
            this.btnConvertTemp.Size = new Size(220, 25);
            this.btnConvertTemp.Text = "Конвертирай";
            this.btnConvertTemp.Click += new System.EventHandler(this.BtnConvertTemp_Click);

            this.tabTemp.Controls.Add(this.lblTempFrom);
            this.tabTemp.Controls.Add(this.txtTempInput);
            this.tabTemp.Controls.Add(this.cmbFromUnitTemp);
            this.tabTemp.Controls.Add(this.lblTempTo);
            this.tabTemp.Controls.Add(this.txtTempResult);
            this.tabTemp.Controls.Add(this.cmbToUnitTemp);
            this.tabTemp.Controls.Add(this.btnConvertTemp);

            // Дължина таб
            this.lblLengthFrom.Location = new Point(10, 15);
            this.lblLengthFrom.Size = new Size(50, 20);
            this.lblLengthFrom.Text = "От:";

            this.txtLengthInput.Location = new Point(10, 35);
            this.txtLengthInput.Size = new Size(220, 20);

            this.cmbFromUnitLength.Location = new Point(10, 60);
            this.cmbFromUnitLength.Size = new Size(220, 20);
            this.cmbFromUnitLength.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lblLengthTo.Location = new Point(10, 90);
            this.lblLengthTo.Size = new Size(50, 20);
            this.lblLengthTo.Text = "До:";

            this.txtLengthResult.Location = new Point(10, 110);
            this.txtLengthResult.Size = new Size(220, 20);
            this.txtLengthResult.ReadOnly = true;

            this.cmbToUnitLength.Location = new Point(10, 135);
            this.cmbToUnitLength.Size = new Size(220, 20);
            this.cmbToUnitLength.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnConvertLength.Location = new Point(10, 165);
            this.btnConvertLength.Size = new Size(220, 25);
            this.btnConvertLength.Text = "Конвертирай";
            this.btnConvertLength.Click += new System.EventHandler(this.BtnConvertLength_Click);

            this.tabLength.Controls.Add(this.lblLengthFrom);
            this.tabLength.Controls.Add(this.txtLengthInput);
            this.tabLength.Controls.Add(this.cmbFromUnitLength);
            this.tabLength.Controls.Add(this.lblLengthTo);
            this.tabLength.Controls.Add(this.txtLengthResult);
            this.tabLength.Controls.Add(this.cmbToUnitLength);
            this.tabLength.Controls.Add(this.btnConvertLength);

            // Тегло таб
            this.lblWeightFrom.Location = new Point(10, 15);
            this.lblWeightFrom.Size = new Size(50, 20);
            this.lblWeightFrom.Text = "От:";

            this.txtWeightInput.Location = new Point(10, 35);
            this.txtWeightInput.Size = new Size(220, 20);

            this.cmbFromUnitWeight.Location = new Point(10, 60);
            this.cmbFromUnitWeight.Size = new Size(220, 20);
            this.cmbFromUnitWeight.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lblWeightTo.Location = new Point(10, 90);
            this.lblWeightTo.Size = new Size(50, 20);
            this.lblWeightTo.Text = "До:";

            this.txtWeightResult.Location = new Point(10, 110);
            this.txtWeightResult.Size = new Size(220, 20);
            this.txtWeightResult.ReadOnly = true;

            this.cmbToUnitWeight.Location = new Point(10, 135);
            this.cmbToUnitWeight.Size = new Size(220, 20);
            this.cmbToUnitWeight.DropDownStyle = ComboBoxStyle.DropDownList;

            this.btnConvertWeight.Location = new Point(10, 165);
            this.btnConvertWeight.Size = new Size(220, 25);
            this.btnConvertWeight.Text = "Конвертирай";
            this.btnConvertWeight.Click += new System.EventHandler(this.BtnConvertWeight_Click);

            this.tabWeight.Controls.Add(this.lblWeightFrom);
            this.tabWeight.Controls.Add(this.txtWeightInput);
            this.tabWeight.Controls.Add(this.cmbFromUnitWeight);
            this.tabWeight.Controls.Add(this.lblWeightTo);
            this.tabWeight.Controls.Add(this.txtWeightResult);
            this.tabWeight.Controls.Add(this.cmbToUnitWeight);
            this.tabWeight.Controls.Add(this.btnConvertWeight);

            // Добавяне на всички контроли към формата
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblMemoryIndicator);
            
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnPlusMinus);
            
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnLn);
            
            this.Controls.Add(this.btnMemoryAdd);
            this.Controls.Add(this.btnMemorySubtract);
            this.Controls.Add(this.btnMemoryRecall);
            this.Controls.Add(this.btnMemoryClear);
            
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnClearHistory);
            
            this.Controls.Add(this.tabConverter);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Научен Калкулатор";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Декларация на контролите
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblMemoryIndicator;
        
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnPlusMinus;
        
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnLn;
        
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Button btnMemorySubtract;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnMemoryClear;
        
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnClearHistory;
        
        private System.Windows.Forms.TabControl tabConverter;
        private System.Windows.Forms.TabPage tabTemp;
        private System.Windows.Forms.TabPage tabLength;
        private System.Windows.Forms.TabPage tabWeight;
        
        private System.Windows.Forms.Label lblTempFrom;
        private System.Windows.Forms.TextBox txtTempInput;
        private System.Windows.Forms.ComboBox cmbFromUnitTemp;
        private System.Windows.Forms.Label lblTempTo;
        private System.Windows.Forms.TextBox txtTempResult;
        private System.Windows.Forms.ComboBox cmbToUnitTemp;
        private System.Windows.Forms.Button btnConvertTemp;
        
        private System.Windows.Forms.Label lblLengthFrom;
        private System.Windows.Forms.TextBox txtLengthInput;
        private System.Windows.Forms.ComboBox cmbFromUnitLength;
        private System.Windows.Forms.Label lblLengthTo;
        private System.Windows.Forms.TextBox txtLengthResult;
        private System.Windows.Forms.ComboBox cmbToUnitLength;
        private System.Windows.Forms.Button btnConvertLength;
        
        private System.Windows.Forms.Label lblWeightFrom;
        private System.Windows.Forms.TextBox txtWeightInput;
        private System.Windows.Forms.ComboBox cmbFromUnitWeight;
        private System.Windows.Forms.Label lblWeightTo;
        private System.Windows.Forms.TextBox txtWeightResult;
        private System.Windows.Forms.ComboBox cmbToUnitWeight;
        private System.Windows.Forms.Button btnConvertWeight;
    }
}

