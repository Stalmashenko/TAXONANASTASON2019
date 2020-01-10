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
using BespokeFusion;
using System.Windows.Shapes;

namespace TAXONANASTASON.userControls
{
    /// <summary>
    /// Логика взаимодействия для ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                if (MyOldPassword.Password != String.Empty && MyNewPassword.Password != String.Empty)
                {
                    string OldPassword = MyOldPassword.Password.GetHashCode().ToString();
                    string NewPassword = MyNewPassword.Password.GetHashCode().ToString();
                    var result = db.USER.SingleOrDefault(b => b.Id == App.currentUser.Id);
                    if (result != null && result.Password == OldPassword)
                    {
                        result.Password = NewPassword;
                        db.SaveChanges();
                        MyNewPassword.Password = "";
                        MyOldPassword.Password = "";
                        MaterialMessageBox.Show("Пароль успешно изменён!", "Изменение пароля");
                    }
                    else
                    {
                        MyNewPassword.Password = "";
                        MyOldPassword.Password = "";
                        MaterialMessageBox.ShowError("Неправильно введён старый пароль!");
                    }

                }
                else
                    MaterialMessageBox.ShowError("Заполните поля!");
            }
        }
    }
}
