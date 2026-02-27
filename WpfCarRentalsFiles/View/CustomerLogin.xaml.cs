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
                OpenWindow(new CustomerDashboard(id));
            else
                ShowError("Invalid ID or password.  Hint: C001 / customer123");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new ChooseRole());
        }

        private void ShowError(string msg)
        {
            ErrorText.Text = msg;
            ErrorBanner.Visibility = Visibility.Visible;
        }

        private void OpenWindow(Window next)
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