using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfUI.Views;
using static ShopLibrary.GlobalConfig;

namespace WpfUI.Forms {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure want to exit?", "Confirm", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void LoginWindow_Loaded(object sender, RoutedEventArgs e) {
            try
            {
                Init();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            UserNameText.ItemsSource = Users.Select(u => u.UserName).ToList();
            UserNameText.Focus();
        }

        private void UserNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                PasswordText.Focus();
        }

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                if (ValidateForm())
                    SubmitButton_Click(sender, e);
        }

        private bool ValidateForm() {
            string errorMessage = string.Empty;

            if (UserNameText.Text.Length == 0)
                errorMessage += "Username is empty\n";

            if (PasswordText.Password.Length == 0)
                errorMessage += "Empty password\n";

            if (errorMessage.Length > 0)
                MessageBox.Show(errorMessage);

            return errorMessage.Length == 0;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e) {
            if (ValidateForm())
                if (Connection[0].Login(UserNameText.Text, PasswordText.Password)) // Log-in Successful
                {
                    Window memo = new MemoWindow();
                    memo.Show();
                    this.Close();
                }
                else // Log-in Fail
                {
                    MessageBox.Show("Invalid username/password combination", "Login error");
                    UserNameText.Focus();
                }
        }
    }
}
