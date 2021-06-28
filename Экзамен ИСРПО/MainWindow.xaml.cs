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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Экзамен_ИСРПО
{

    public partial class MainWindow : Window
    {
        Database1Entities db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Database1Entities();
        }

        private void Auth_Enter(object sender, RoutedEventArgs e)
        {

            Auth auth = new Auth();
            var authorization = db.User.FirstOrDefault(ch => ch.Login == Login.Text && ch.Password == Password.Password);
            if (auth.Enter(Login.Text, Password.Password) == true)
            {
                MessageBox.Show("Вход выполнен", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                Application.Current.Shutdown();
            }
        }

    }
}
