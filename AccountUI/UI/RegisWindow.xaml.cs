using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AccountUI.UI
{
    /// <summary>
    /// Interaction logic for RegisWindow.xaml
    /// </summary>
    public partial class RegisWindow : Window
    {
        public RegisWindow()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Xử lý logic đăng ký ở đây
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;
            string confirmPassword = confirmPasswordBox.Password;

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Tiến hành đăng ký
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LoginTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Chuyển về trang đăng nhập
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close(); // Đóng cửa sổ hiện tại
        }
    }
}
