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
using BespokeFusion;
using TAXONANASTASON.Models;

namespace TAXONANASTASON
{
    /// <summary>
    /// Логика взаимодействия для registration.xaml
    /// </summary>
    public partial class registration : Window
    {
        public registration()
        {
            InitializeComponent();
        }
        private double GetRandomBalance()
        {
            Random random = new Random();
            return random.Next(1, 999999) / 100.0;
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Validation check = new Validation();
            

            CLIENT newCLient = new CLIENT()
            {
                Surname = mySurname.Text,
                Firstname = myFirstname.Text,
                Card = myCardID.Text,
                Phone = myPhone.Text,
                Balance = GetRandomBalance(),
            };
            USER newUser = new USER()
            {
                Login = myLogin.Text,
                Client = newCLient,
                Role = "Client"           
            };
            if (myPassword.Password != string.Empty)
            {
                newUser.Password = myPassword.Password.GetHashCode().ToString();
            }
            if (check.CheckValid(newCLient) && check.CheckValid(newUser))
            {
                using (Context db = new Context())
                {
                    var someUser = db.USER.FirstOrDefault(u => u.Login == myLogin.Text);

                    if (someUser == null)
                    {
                        var phoneNumClient = db.CLIENT.FirstOrDefault(u => u.Phone == myPhone.Text);
                        var phoneNumDriver = db.DRIVER.FirstOrDefault(u => u.Phone == myPhone.Text);

                        if (phoneNumClient == null && phoneNumDriver==null)
                        {
                            db.USER.Add(newUser);
                            db.SaveChanges();
                            Autorization autorization = new Autorization();
                            Close();
                            autorization.Show();
                        }
                        else
                        {
                            MaterialMessageBox.ShowError("Введенный номер телефона уже привязан к другому профилю. Попробуйте снова!");
                        }
                    }
                    else
                    {
                        MaterialMessageBox.ShowError("Пользователь с таким логином уже существует. Попробуйте снова!");
                    }
                }
            }
        }
    }
}
