using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp7
{
    public partial class MainWindow : Window
    {
        private double radius = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void miInput_Click(object sender, RoutedEventArgs e)
        {
            // Скрыть картинку и текст Label, показать панель для ввода
            canvas.Visibility = Visibility.Hidden;
            name.Visibility = Visibility.Hidden;
            inputPanel.Visibility = Visibility.Visible;
        }

        private void miCalc_Click(object sender, RoutedEventArgs e)
        {
            if (radius > 0)
            {
                string resultMessage = "Результаты:\n";

                if (SquareCheckBox.IsChecked == true)
                {
                    double area = Math.PI * Math.Pow(radius, 2);
                    resultMessage += $"Площадь: {area}\n";
                }

                if (LengthCheckBox.IsChecked == true)
                {
                    double length = 2 * Math.PI * radius;
                    resultMessage += $"Длина: {length}\n";
                }

                MessageBox.Show(resultMessage, "Расчеты", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, сначала введите допустимый радиус", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void miDraw_Click(object sender, RoutedEventArgs e)
        {
            if (radius > 0 && radius * 2 <= canvas.ActualWidth && radius * 2 <= canvas.ActualHeight)
            {
                // Скрываем Label, вместо его удаления
                name.Visibility = Visibility.Collapsed;

                canvas.Children.Clear();
                Ellipse circle = new Ellipse
                {
                    Width = radius * 2,
                    Height = radius * 2,
                    Stroke = Brushes.Black,
                    Fill = Brushes.White
                };
                Canvas.SetLeft(circle, (canvas.ActualWidth - circle.Width) / 2);
                Canvas.SetTop(circle, (canvas.ActualHeight - circle.Height) / 2);
                canvas.Children.Add(circle);
            }
            else
            {
                MessageBox.Show("Отрисовка невозможна: слишком большой радиус", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(RadiusTextBox.Text, out double r) && r > 0)
            {
                radius = r;
            
                inputPanel.Visibility = Visibility.Hidden;
                canvas.Visibility = Visibility.Visible;
                name.Visibility = Visibility.Visible; 
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите допустимый радиус.", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    

    private void var5_Click(object sender, RoutedEventArgs e)
        {
            var5 inputWindow = new var5();
            inputWindow.Show();
            this.Close();
        }
    }
}
