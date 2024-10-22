using System;
using System.Linq;
using System.Windows;

namespace WpfApp7
{
    public partial class var5 : Window
    {
        private double number1;
        private double number2;
        private double number3;
        private bool calculateSum;
        private bool calculateLeastMultiple;

        public var5()
        {
            InitializeComponent();
        }

        private void miInput_Click(object sender, RoutedEventArgs e)
        {
            InputWindow_var5 inputWindow = new InputWindow_var5();
            if (inputWindow.ShowDialog() == true)
            {
                // Store values from the input window
                number1 = inputWindow.Number1;
                number2 = inputWindow.Number2;
                number3 = inputWindow.Number3;
                calculateSum = inputWindow.CalculateSum;
                calculateLeastMultiple = inputWindow.CalculateLeastMultiple;
            }
        }

        private void miCalc_Click(object sender, RoutedEventArgs e)
        {
            if (calculateSum == false && calculateLeastMultiple == false)
            {
                MessageBox.Show("Сначала введите значения.", "Ошибка");
                return;
            }

            double resultSum = 0;
            double resultLeastMultiple = 0;

            if (calculateSum)
            {
                resultSum = number1 + number2 + number3;
            }

            if (calculateLeastMultiple)
            {
                resultLeastMultiple = LeastCommonMultipleOfThree(number1, number2, number3);
            }

            string resultMessage = "";
            if (calculateSum)
            {
                resultMessage += $"Сумма: {resultSum}\n";
            }
            if (calculateLeastMultiple)
            {
                resultMessage += $"Наименьшее общее кратное: {resultLeastMultiple}\n";
            }

            MessageBox.Show(resultMessage, "Результаты");
        }


        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Гарипов Камиль", "About");
        }

        private void var4_Click(object sender, RoutedEventArgs e)
        {
           
            MainWindow inputWindow = new MainWindow();
            inputWindow.Show();
            this.Close();
        }

        private double LeastCommonMultiple(double a, double b)
        {
            if (a == 0 || b == 0) // Проверка на ноль
                return 0; // НОК для нуля обычно рассматривается как 0

            return Math.Abs(a * b) / GCD(a, b);
        }
        private double GCD(double a, double b)
        {
            while (b != 0)
            {
                double temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public double LeastCommonMultipleOfThree(double a, double b, double c)
        {
            return LeastCommonMultiple(LeastCommonMultiple(a, b), c);
        }



    }
}
