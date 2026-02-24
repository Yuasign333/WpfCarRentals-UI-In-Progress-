using System.Windows;
using System.Windows.Input;
namespace WpfFirst.View
{
    public partial class RentCarWindow : Window
    {
        private readonly string _userId;
        public RentCarWindow(string userId)
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