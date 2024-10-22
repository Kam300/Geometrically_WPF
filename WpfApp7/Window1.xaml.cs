using System;
using System.Windows;

namespace WpfApp7
{
    public partial class InputWindow : Window
    {
        public double Radius { get; private set; }

        public InputWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(RadiusTextBox.Text, out double r) && r > 0)
            {
                Radius = r;
                DialogResult = true; // Закрываем окно с успехом
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите допустимый радиус.", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
