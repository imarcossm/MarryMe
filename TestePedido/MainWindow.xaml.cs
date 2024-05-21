using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MarryMe
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ela disse SIM! 🎉💍");
        }

        private void NoButton_MouseEnter(object sender, MouseEventArgs e)
        {
            // Mover o botão "Não" para uma nova posição aleatória
            double newX = random.Next(0, (int)(MainGrid.ActualWidth - NoButton.Width));
            double newY = random.Next(0, (int)(MainGrid.ActualHeight - NoButton.Height));

            NoButton.Margin = new Thickness(newX, newY, 0, 0);
        }
    }
}
