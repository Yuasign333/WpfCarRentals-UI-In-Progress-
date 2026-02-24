using System.Windows;
using System.Windows.Input;
namespace WpfFirst.View
{
    public partial class RevenueWindow : Window
    {
        private readonly string _userId;
        public RevenueWindow(string userId)
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