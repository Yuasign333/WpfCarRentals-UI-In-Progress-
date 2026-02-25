using System.Windows;

namespace WpfFirst.View
{
    public partial class CustomerDashboard : Window
    {
        private readonly string _userId;
        private bool _isSidebarOpen = false;

        public CustomerDashboard(string userId)
        {
            InitializeComponent();
            _userId = userId;
            UserLabel.Text = $"Hello, {userId}";
            WelcomeText.Text = $"Welcome back, {userId}!";
        }

        // ── Hamburger toggle ─────────────────────────────────────────
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

        // ── Navigation ───────────────────────────────────────────────
        private void BrowseCarsBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new BrowseCarsWindow(_userId));
        }

        private void RentCarBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new RentCarWindow(_userId));
        }

        private void MyRentalsBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new MyRentalsWindow(_userId));
        }

        // ── Logout ───────────────────────────────────────────────────
        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
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