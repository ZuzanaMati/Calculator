namespace Kalkulacka
{
    public partial class CalculatorWindow : Form
    {
        private Calculator calculator;
        bool newNumber = true;
        bool equalSignPressed = false;
        bool firstEntry = true;
        bool performCalcu = true;
        string oper;
        double vysledek;
        double number;

        public CalculatorWindow()
        {
            calculator = new Calculator(0);

            InitializeComponent();
        }

        private void numberClick(object sender, EventArgs e)
        {
            Button tlacitko = (Button)sender;
            if (newNumber)
            {
                entry.Text = "";
                newNumber = false;

                if (equalSignPressed)
                {
                    trackInputsLabel.Text = null;
                    calculator.ResetResult();
                    equalSignPressed = false;
                    firstEntry = true;
                    del.Enabled = true;
                    decimalPoint.Enabled = true;
                }
            }
            entry.Text += tlacitko.Text;
            number = double.Parse(entry.Text);
            trackInputsLabel.Text += tlacitko.Text;
        }


        private void operandClick(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;

            if (!firstEntry && !equalSignPressed)
            {
                if (performCalcu)
                {
                    PerformCalculation(number);
                }
            }

            if (firstEntry)
            {
                calculator.SetResult(number);
                firstEntry = false;
            }

            if (equalSignPressed)
            {
                trackInputsLabel.Text = null;
                trackInputsLabel.Text += $"{vysledek}";
                equalSignPressed = false;
                del.Enabled = true;
            }

            trackInputsLabel.Text = AddParenthesesIfNeeded(trackInputsLabel.Text, btnOperator.Text) + btnOperator.Text;
            newNumber = true;
            oper = btnOperator.Text;
            performCalcu = true;
            entry.Text = oper;
            UpdateDecimalButtonState();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number = double.Parse(entry.Text);
            PerformCalculation(number);

            vysledek = calculator.GetResult();
            entry.Text = vysledek.ToString();
            trackInputsLabel.Text += " = " + vysledek.ToString();
            newNumber = true;
            equalSignPressed = true;
            del.Enabled = false;
        }

        private void PerformCalculation(double number)
        {
            switch (oper)
            {
                case "+":
                    calculator.Add(number);
                    break;
                case "-":
                    calculator.Subtract(number);
                    break;
                case "*":
                    calculator.Multiply(number);
                    break;
                case "/":
                    calculator.Divide(number);
                    break;
            }
        }

        private string AddParenthesesIfNeeded(string expression, string currentOperator)
        {
            // Check if the expression already contains + or - and the current operator is * or /
            if ((expression.Contains("+") || expression.Contains("-")) && (currentOperator == "*" || currentOperator == "/"))
            {
                // Wrap the entire expression in parentheses
                return $"({expression})";
            }
            return expression;
        }

        private void UpdateDecimalButtonState()
        {
            // Enable the decimal button if there's no decimal point in the current input
            decimalPoint.Enabled = !entry.Text.Contains(".");
        }

        private void AC_Click(object sender, EventArgs e)
        {
            newNumber = true;
            equalSignPressed = false;
            firstEntry = true;
            calculator.ResetResult();
            trackInputsLabel.Text = null;
            entry.Text = null;
            del.Enabled = true;
            decimalPoint.Enabled = true;
        }

        private void del_Click(object sender, EventArgs e)
        {

            // Check if the entry box has any text
            if (!string.IsNullOrEmpty(entry.Text))
            {
                char lastCharacter = entry.Text[^1];
                string input = entry.Text;

                if (input == "+" || input == "-" || input == "*" || input == "/")
                {
                    performCalcu = false;

                    if (input == "*" || input == "/")
                    {
                        trackInputsLabel.Text = trackInputsLabel.Text.Substring(1, trackInputsLabel.Text.Length - 2);
                    }
                }

                // Remove the last character
                entry.Text = entry.Text.Substring(0, entry.Text.Length - 1);
                UpdateDecimalButtonState();

                // Also update the trackInputsLabel if needed
                if (!string.IsNullOrEmpty(trackInputsLabel.Text))
                {
                    trackInputsLabel.Text = trackInputsLabel.Text.Substring(0, trackInputsLabel.Text.Length - 1);
                }
            }
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            Button decimalPoint = (Button)sender;

            {
                if (newNumber)
                {
                    entry.Text = "0"; // Start with 0 if new input
                    trackInputsLabel.Text += "0";
                    newNumber = false;
                }

                // Add the decimal point to the input and label
                entry.Text += decimalPoint.Text;
                trackInputsLabel.Text += decimalPoint.Text;

                UpdateDecimalButtonState();

            }
        }
    }
}