using System;
using BespokeFusion;
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

namespace TAXONANASTASON.adminControls
{
    /// <summary>
    /// Логика взаимодействия для MyProfile.xaml
    /// </summary>
    public partial class MyProfile : UserControl
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void MyProfile_changeButton_Click(object sender, RoutedEventArgs e)
        {
            MyProfile_changeButton.IsEnabled = false;
            MyProfile_SaveButton.IsEnabled = true;

            MyFirstname.IsReadOnly = false;
            MySurname.IsReadOnly = false;                
        }

        private void MyProfile_SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MyProfile_SaveButton.IsEnabled = false;
            MyProfile_changeButton.IsEnabled = true;

            MyFirstname.IsReadOnly = true;
            MySurname.IsReadOnly = true;

            if (MyFirstname.Text != String.Empty && MySurname.Text != String.Empty)
            {
                using (Context db = new Context())
                {
                    var result = db.USER.SingleOrDefault(b => b.Id == App.admin.Id);                   
                    try
                    {
                        if (result != null)
                        {
                            result.Client.Surname = MySurname.Text;
                            result.Client.Firstname = MyFirstname.Text;
                            db.SaveChanges();
                            MaterialMessageBox.Show("Профиль изменён успешно!", "Изменение профиля");
                        }
                    }
                    catch
                    {
                        MaterialMessageBox.ShowError("Изменения не сохранены.Проверьте введенные данные!");
                    }
                }
            }
            else
            {
                MaterialMessageBox.ShowError("Поля не заполнены. Введите данные!");
            }
        }

        private void MyProf_Loaded(object sender, RoutedEventArgs e)
        {
            MySurname.Text = App.admin.Client.Surname;
            MyFirstname.Text = App.admin.Client.Firstname;
            MyPhone.Text = App.admin.Client.Phone;

            MyCardNumber.Text = App.admin.Client.Card;
            MyBalance.Text = App.admin.Client.Balance.ToString()+" бел. руб";
        }
    }
}
