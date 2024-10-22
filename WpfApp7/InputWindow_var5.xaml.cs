using System;
using System.Windows;

namespace WpfApp7
{
    public partial class InputWindow_var5 : Window
    {
        public double Number1 { get; private set; }
        public double Number2 { get; private set; }
        public double Number3 { get; private set; }
        public bool CalculateSum { get; private set; }
        public bool CalculateLeastMultiple { get; private set; }

        public InputWindow_var5()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if at least one checkbox is checked
            if (!SummCheckBox.IsChecked.GetValueOrDefault(false) &&
                !LeastMultipleCheckBox.IsChecked.GetValueOrDefault(false))
            {
                MessageBox.Show("Пожалуйста, выберите хотя бы один флажок.", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Attempt to parse the input numbers
            bool isNumber1Valid = double.TryParse(Number1TextBox.Text, out double temp1);
            bool isNumber2Valid = double.TryParse(Number2TextBox.Text, out double temp2);
            bool isNumber3Valid = double.TryParse(Number3TextBox.Text, out double temp3);

            if (isNumber1Valid && isNumber2Valid && isNumber3Valid)
            {
                // Assign values if inputs are valid
                Number1 = temp1;
                Number2 = temp2;
                Number3 = temp3;
                CalculateSum = SummCheckBox.IsChecked == true;
                CalculateLeastMultiple = LeastMultipleCheckBox.IsChecked == true;

                DialogResult = true; // Close dialog and return true result
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
