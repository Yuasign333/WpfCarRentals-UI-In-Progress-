using System.Windows;
using System.Windows.Input;
namespace WpfFirst.View
{
    public partial class FleetStatusWindow : Window
    {
        private readonly string _userId;
        public FleetStatusWindow(string userId)
        {
            InitializeComponent();
            _userId = userId;
            UserLabel.Text = userId;
        }
        private void BackBtn_Click(object sender, MouseButtonEventArgs e)
        {
            OpenWindow(new AdminDashboard(_userId));
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