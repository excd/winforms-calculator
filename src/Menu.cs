namespace winforms_calculator {
    public partial class CalculatorForm : Form {
        private void ExitApplication(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ShowAboutDialog(object sender, EventArgs e) {
            MessageBox.Show(
                "This is a simple calculator application written in C# using Windows Forms.",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
            );
        }

        private void CopyDisplayText(object sender, EventArgs e) {
            Clipboard.SetText(calculatorDisplay.Text);
        }

        private void PasteDisplayText(object sender, EventArgs e) {
            if (Decimal.TryParse(Clipboard.GetText(), out decimal number) &&
                number.ToString().Length <= calculatorDisplay.MaxLength
            )
                calculatorDisplay.Text = number.ToString();
        }
    }
}
