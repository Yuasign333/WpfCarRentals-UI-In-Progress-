using System.Windows;
using System.Windows.Input;
namespace WpfFirst.View
{
    public partial class BrowseCarsWindow : Window
    {
        private readonly string _userId;
        public BrowseCarsWindow(string userId)
        {
            InitializeComponent();
            _userId = userId;
            UserLabel.Text = userId;
        }
        private void BackBtn_Click(object sender, MouseButtonEventArgs e)
        {
            new CustomerDashboard(_userId).Show(); Close();
        }
    }
}