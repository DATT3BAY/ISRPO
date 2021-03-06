using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Экзамен_ИСРПО
{
    public class Auth
    {
        public bool Enter(string login, string password)
        {
            Database1Entities db = new Database1Entities();
            if (login == "" || password == "")
            {
                MessageBox.Show("Вы не заполнили все поля", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            var auth_check = db.User.FirstOrDefault(ch => ch.Login == login && ch.Password == password);
            if (auth_check == null)
            {
                MessageBox.Show("Логин или пароль введены не верно", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}
