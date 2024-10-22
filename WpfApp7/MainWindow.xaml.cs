using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.IO;

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
            InputWindow inputWindow = new InputWindow();
            if (inputWindow.ShowDialog() == true)
            {
                radius = inputWindow.Radius;
            }
        }

        private void miCalc_Click(object sender, RoutedEventArgs e)
        {
            if (radius > 0)
            {
                double area = Math.PI * Math.Pow(radius, 2);
                double length = 2 * Math.PI * radius;
                MessageBox.Show($"Область: {area}\nДлина: {length}", "Расчеты",MessageBoxButton.OK, MessageBoxImage.Information);
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
                if (name != null)
                {
                    Grid parentGrid = (Grid)name.Parent; // Получаем родительский контейнер
                    parentGrid.Children.Remove(name); // Удаляем Label
                }

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

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void var5_Click(object sender, RoutedEventArgs e)
        {
            var5 inputWindow = new var5();
            inputWindow.Show();
            this.Close();
        }
    }
}
