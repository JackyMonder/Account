using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AccountUI.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            // Xử lý đăng nhập ở đây
            MessageBox.Show($"Tên đăng nhập: {username}\nMật khẩu: {password}");
        }
        private void RegisterTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Mở cửa sổ đăng ký (hoặc bất kỳ hành động nào bạn muốn thực hiện)
            RegisWindow registerWindow = new RegisWindow();
            registerWindow.Show();
            this.Close(); // Đóng cửa sổ đăng nhập nếu cần
        }
    }
}