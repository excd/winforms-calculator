namespace winforms_calculator {
    public partial class CalculatorForm : Form {
        decimal numberCache, lastInput;
        char operatorCache;

        public CalculatorForm() {
            InitializeComponent();
        }

        private void InputNumber(object sender, EventArgs e) {
            if (calculatorDisplay.TextLength < calculatorDisplay.MaxLength) {
                if ((
                    Decimal.TryParse(calculatorDisplay.Text, out decimal number) &&
                    number == 0 &&
                    !calculatorDisplay.Text.Contains(".")
                ) ||
                    !Decimal.TryParse(calculatorDisplay.Text, out _)
                )
                    calculatorDisplay.Text = "";

                calculatorDisplay.Text += ((Button)sender).Text;
            }

            CalculatorForm.ActiveForm.ActiveControl = null;
        }

        private void InputOperator(object sender, EventArgs e) {
            if (Decimal.TryParse(calculatorDisplay.Text, out decimal number)) {
                try {
                    if (numberCache == 0)
                        numberCache = number;
                    else
                        PerformOperation(number);

                    operatorCache = ((Button)sender).Text[0];
                    calculatorDisplay.Text = "";
                }
                catch (OverflowException) {
                    calculatorDisplay.Text = "Error";
                }
            }

            CalculatorForm.ActiveForm.ActiveControl = null;
        }

        private void Evaluate(object sender, EventArgs e) {
            if (Decimal.TryParse(calculatorDisplay.Text, out decimal number)) {
                try {
                    if (numberCache == 0) {
                        numberCache = number;
                        PerformOperation(lastInput);
                    }
                    else {
                        PerformOperation(lastInput = number);
                    }

                    calculatorDisplay.Text = numberCache.ToString().Length > calculatorDisplay.MaxLength
                        ? Decimal.Round(numberCache, calculatorDisplay.MaxLength).ToString()
                        : numberCache.ToString();

                    numberCache = 0;
                }
                catch (OverflowException) {
                    calculatorDisplay.Text = "Error";
                }
            }

            CalculatorForm.ActiveForm.ActiveControl = null;
        }

        private void Backspace(object sender, EventArgs e) {
            if (calculatorDisplay.TextLength > 0)
                calculatorDisplay.Text = calculatorDisplay.Text.Remove(calculatorDisplay.TextLength - 1);
            if (calculatorDisplay.Text == "-")
                Backspace(sender, e);
            CalculatorForm.ActiveForm.ActiveControl = null;
        }

        private void ClearEntry(object sender, EventArgs e) {
            calculatorDisplay.Text = "";
            CalculatorForm.ActiveForm.ActiveControl = null;
        }

        private void ClearAll(object sender, EventArgs e) {
            numberCache = lastInput = 0;
            calculatorDisplay.Text = "";
            CalculatorForm.ActiveForm.ActiveControl = null;
        }

        private void Negate(object sender, EventArgs e) {
            if (Decimal.TryParse(calculatorDisplay.Text, out decimal number) &&
                number != 0 &&
                calculatorDisplay.TextLength < calculatorDisplay.MaxLength
            )
                calculatorDisplay.Text = Decimal.Negate(number).ToString();

            CalculatorForm.ActiveForm.ActiveControl = null;
        }

        private void DecimalPoint(object sender, EventArgs e) {
            if (!calculatorDisplay.Text.Contains("."))
                calculatorDisplay.Text += calculatorDisplay.Text != "" ? "." : "0.";
            CalculatorForm.ActiveForm.ActiveControl = null;
        }

        private void PerformOperation(decimal number) {
            try {
                switch (operatorCache) {
                    case '+':
                        numberCache += number;
                        break;
                    case '-':
                        numberCache -= number;
                        break;
                    case '*':
                        numberCache *= number;
                        break;
                    case '/':
                        numberCache /= number;
                        break;
                }
            }
            catch (OverflowException) {
                numberCache = lastInput = 0;
                throw;
            }
        }
    }
}
