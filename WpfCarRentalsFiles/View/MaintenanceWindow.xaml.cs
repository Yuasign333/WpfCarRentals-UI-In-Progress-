using System.Windows;
using System.Windows.Input;
namespace WpfFirst.View
{
    public partial class MaintenanceWindow : Window
    {
        private readonly string _userId;
        public MaintenanceWindow(string userId)
        {
            InitializeComponent();
            _userId = userId;
            UserLabel.Text = userId;
        }
        private void BackBtn_Click(object sender, MouseButtonEventArgs e)
        {
            new AdminDashboard(_userId).Show(); Close();
        }
    }
}