using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameCenter.Projects.Calculator
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {


        private string currentInput = string.Empty;
        private char currentOperator;
        private double result = 0;
        public Calculator()
        {
            InitializeComponent();

        }
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Content.ToString();
            resultTextBox.Text = currentInput;
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (currentOperator != '\0')
                {
                    // If an operator is already selected, perform the previous operation
                    PerformOperation();
                }

                currentOperator = button.Content.ToString()[0];
                result = double.Parse(currentInput);
                currentInput = string.Empty;
            }
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && currentOperator != '\0')
            {
                PerformOperation();
                currentOperator = '\0';
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            currentInput = string.Empty;
            currentOperator = '\0';
            result = 0;
            resultTextBox.Text = "0";
        }

        private void PerformOperation()
        {
            double inputValue = double.Parse(currentInput);
            switch (currentOperator)
            {
                case '+':
                    result += inputValue;
                    break;
                case '-':
                    result -= inputValue;
                    break;
                case '*':
                    result *= inputValue;
                    break;
                case '/':
                    if (inputValue != 0)
                        result /= inputValue;
                    else
                        MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
            resultTextBox.Text = result.ToString();
            currentInput = string.Empty;
        }
    }
}
    

