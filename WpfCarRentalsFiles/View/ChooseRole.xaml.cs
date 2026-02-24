using System.Windows;
using System.Windows.Input;

namespace WpfFirst.View
{
    public partial class ChooseRole : Window
    {
        public ChooseRole()
        {
            InitializeComponent();
        }

        private void CustomerCard_Click(object sender, MouseButtonEventArgs e)
        {
            new CustomerLogin().Show(); Close();
        }

        private void AdminCard_Click(object sender, MouseButtonEventArgs e)
        {
            new AdminLogin().Show(); Close();
        }

        private void Menu_Exit_Click(object sender, RoutedEventArgs e)

        {
            Application.Current.Shutdown();
        }

        private void Menu_About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rental Rev.\nCar Rental Management System\n\nMade by Yuan",
            "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}