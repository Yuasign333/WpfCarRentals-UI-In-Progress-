using System.Windows;
using System.Windows.Controls;

namespace WpfFirst.View
{
    public partial class AdminLogin : Window
    {
        private const string AgentID = "A001";
        private const string AgentPass = "admin123";

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string id = UsernameBox.Text.Trim();
            string pass = PasswordBox.Password;

            if (string.IsNullOrEmpty(id)) { ShowError("Please enter your Agent ID."); return; }
            if (string.IsNullOrEmpty(pass)) { ShowError("Please enter your Password."); return; }

            if (id == AgentID && pass == AgentPass)
            { new AdminDashboard(id).Show(); Close(); }
            else
            { ShowError("Invalid Agent ID or password.  Hint: A001 / admin123"); }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        { new ChooseRole().Show(); Close(); }

        private void Menu_Back_Click(object sender, RoutedEventArgs e)
        { new ChooseRole().Show(); Close(); }

        private void Menu_Exit_Click(object sender, RoutedEventArgs e)
            => Application.Current.Shutdown();

        private void ShowError(string msg)
        { ErrorText.Text = msg; ErrorBanner.Visibility = Visibility.Visible; }
    }
}