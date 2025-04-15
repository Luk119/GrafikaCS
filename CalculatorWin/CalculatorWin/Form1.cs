using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatorWin
{
    public partial class Form1 : Form
    {
        private double currentNumber = 0;
        private double storedNumber = 0;
        private string operation = "";
        private bool isNewNumber = true;
        private bool errorState = false;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (errorState) return;

            Button button = (Button)sender;

            if (isNewNumber)
            {
                textBox1.Text = "";
                isNewNumber = false;
            }

            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else
            {
                textBox1.Text += button.Text;
            }

            if (!double.TryParse(textBox1.Text, out currentNumber))
            {
                SetErrorState();
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (errorState) return;

            Button button = (Button)sender;

            if (!isNewNumber)
            {
                if (!Calculate())
                {
                    return;
                }
                isNewNumber = true;
            }

            operation = button.Text;
            storedNumber = currentNumber;
            label1.Text = $"{storedNumber} {operation}";
        }

        private bool Calculate()
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        currentNumber = storedNumber + currentNumber;
                        break;
                    case "-":
                        currentNumber = storedNumber - currentNumber;
                        break;
                    case "×":
                        currentNumber = storedNumber * currentNumber;
                        break;
                    case "÷":
                        if (currentNumber == 0)
                        {
                            SetErrorState("Error");
                            return false;
                        }
                        currentNumber = storedNumber / currentNumber;
                        break;
                }

                textBox1.Text = currentNumber.ToString();
                return true;
            }
            catch (Exception ex)
            {
                SetErrorState("Błąd obliczeń");
                return false;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (errorState) return;

            if (!Calculate())
            {
                return;
            }
            operation = "";
            label1.Text = "";
            isNewNumber = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentNumber = 0;
            storedNumber = 0;
            operation = "";
            textBox1.Text = "0";
            label1.Text = "";
            isNewNumber = true;
            errorState = false;
            textBox1.ForeColor = SystemColors.ControlText;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (errorState) return;

            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                if (!double.TryParse(textBox1.Text, out currentNumber))
                {
                    SetErrorState();
                }
            }
            else
            {
                textBox1.Text = "0";
                currentNumber = 0;
                isNewNumber = true;
            }
        }

        private void SetErrorState(string message = "Błąd")
        {
            textBox1.Text = message;
            errorState = true;
            textBox1.ForeColor = Color.Red;
        }

        // Pozostałe metody
        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void btn0_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btn1_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btn2_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btn3_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btn4_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btn5_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btn6_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btn7_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btn8_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btn9_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void btnDot_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);

        private void btnAdd_Click(object sender, EventArgs e) => OperationButton_Click(sender, e);
        private void btnSubstract_Click(object sender, EventArgs e) => OperationButton_Click(sender, e);
        private void btnMultiply_Click(object sender, EventArgs e) => OperationButton_Click(sender, e);
        private void btnDivide_Click(object sender, EventArgs e) => OperationButton_Click(sender, e);
    }
}