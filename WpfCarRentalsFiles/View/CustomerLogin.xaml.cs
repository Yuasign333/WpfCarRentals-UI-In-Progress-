using System.Windows;

namespace WpfFirst.View
{
    public partial class CustomerLogin : Window
    {
        private const string CustID = "C001";
        private const string CustPass = "customer123";

        public CustomerLogin()
        {
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string id = UsernameBox.Text.Trim();
            string pass = PasswordBox.Password;

            if (string.IsNullOrEmpty(id))
            {
                ShowError("Please enter your Customer ID."); return;
            }

            if (string.IsNullOrEmpty(pass))
            {
                ShowError("Please enter your Password."); return;
            }

            if (id == CustID && pass == CustPass)
            {
                new CustomerDashboard(id).Show(); Close();
            }

            else
            { ShowError("Invalid ID or password.  Hint: C001 / customer123"); }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new ChooseRole().Show(); Close();
        }

        private void Menu_Back_Click(object sender, RoutedEventArgs e)
        {
            new ChooseRole().Show(); Close();
        }

        private void Menu_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ShowError(string msg)
        {
            ErrorText.Text = msg; ErrorBanner.Visibility = Visibility.Visible;
        }
    }
}