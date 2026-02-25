using System.Windows;

namespace WpfFirst.View
{
    public partial class AdminDashboard : Window
    {
        private readonly string _userId;

        public AdminDashboard(string userId)
        {
            InitializeComponent();
            _userId = userId;
            UserLabel.Text = $"Hello, {userId}";
            WelcomeText.Text = $"Welcome, {userId}!";
        }

        private void FleetBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new FleetStatusWindow(_userId));
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new ProcessReturnWindow(_userId));
           
        }

        private void AddCarBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow (new AddCarWindow(_userId));
        }

        private void MaintenanceBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new MaintenanceWindow(_userId));
        }


        private void RevenueBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new RevenueWindow(_userId));
        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }
        private void Menu_Logout_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                OpenWindow(new ChooseRole());
            }
        }

        private void Menu_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private bool _isSidebarOpen = false;

        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
            if (_isSidebarOpen)
            {
                SidebarColumn.Width = new GridLength(0);
                _isSidebarOpen = false;
            }
            else
            {
                SidebarColumn.Width = new GridLength(220);
                _isSidebarOpen = true;
            }
        }
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