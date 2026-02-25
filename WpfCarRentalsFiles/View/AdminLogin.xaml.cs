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

            if (string.IsNullOrEmpty(id))

            { ShowError("Please enter your Agent ID."); 
              return;
            }
            if (string.IsNullOrEmpty(pass)) { ShowError("Please enter your Password."); return; }

            if (id == AgentID && pass == AgentPass)
            {
                OpenWindow(new AdminDashboard(id));
            }
            else
            { ShowError("Invalid Agent ID or password.  Hint: A001 / admin123"); }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new ChooseRole());
        }

        private void Menu_Back_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new ChooseRole());
        }

        private void Menu_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ShowError(string msg)
        { ErrorText.Text = msg; ErrorBanner.Visibility = Visibility.Visible; }

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

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow( new ChooseRole());
        }
    }
}