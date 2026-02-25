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
            OpenWindow(new CustomerLogin());
        }

        private void AdminCard_Click(object sender, MouseButtonEventArgs e)
        {
            OpenWindow(new AdminLogin()); 
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
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
           
        }

        //if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
           
    private void OpenWindow(Window next) // full screen
        {
            next.WindowState = this.WindowState;
            next.WindowStartupLocation = WindowStartupLocation.Manual;
            next.Top = this.Top;
            next.Left = this.Left;
            next.Width = this.Width;
            next.Height = this.Height;
            next.Show();
            Close();
        }

       
    }
}