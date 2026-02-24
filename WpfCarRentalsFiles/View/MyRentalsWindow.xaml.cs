using System.Windows;
using System.Windows.Input;

namespace WpfFirst.View
{
    public partial class MyRentalsWindow: Window
    {
        private readonly string _userId;

        public MyRentalsWindow(string userId)
        {
            InitializeComponent();
            _userId = userId;
            UserLabel.Text = userId;  // shows the logged-in admin ID in top right
        }

        private void BackBtn_Click(object sender, MouseButtonEventArgs e)
        {
            new AdminDashboard(_userId).Show();  // ← was CustomerDashboard, now AdminDashboard
            Close();
        }
    }
}