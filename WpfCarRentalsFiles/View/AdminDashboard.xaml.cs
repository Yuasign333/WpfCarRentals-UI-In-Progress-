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
            new FleetStatusWindow(_userId).Show(); Close();
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            new ProcessReturnWindow(_userId).Show();  //  _userId must be passed here
            Close();
        }

        private void AddCarBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddCarWindow(_userId).Show(); Close();
        }

        private void MaintenanceBtn_Click(object sender, RoutedEventArgs e)
        {
            new MaintenanceWindow(_userId).Show(); Close();
        }


        private void RevenueBtn_Click(object sender, RoutedEventArgs e)
        {
            new RevenueWindow(_userId).Show(); Close();
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
                new ChooseRole().Show(); Close();
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
    }
}